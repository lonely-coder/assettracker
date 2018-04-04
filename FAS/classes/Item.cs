using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace FAS
{

    public class Item : DB
    {
        private int _id = 0;
        private int _categoryId = 0;
        private int _subCategoryId = 0;
        private string _brand;
        private string _model;
        private int _quantity = 0;
        private bool _has_serial_number = false;
        private long _lastInsertedId;
        private DataTable _dt;
        private string _parameter;

        private bool _is_successfull = false;

        Logs log = new Logs();


        public int Id {
            get { return this._id; }
            set {
                this._id = value;
            }

        }

        public int CategoryId {
            get { return this._categoryId; }
            set {
                if (value > 0)
                {
                    this._categoryId = value;
                }
                else {
                    throw new ArgumentException("-Category is Required");
                }
            }
        }
        public int SubCategoryId
        {
            get { return this._subCategoryId; }
            set
            {
                if (value > 0)
                {
                    this._subCategoryId = value;
            }
                else
                {
                throw new ArgumentException("-Sub Category is Required");
            }
        }
        }
        public string Model {
            get { return this._model; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._model = value;
                }
                else {
                    throw new ArgumentException("-Model is Required");
                }
            }
        }
        public string Brand
        {
            get { return this._brand; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._brand = value;
                }
                else
                {
                    throw new ArgumentException("-Brand is Required");
                }
            }
        }
        public int Quantity {
            get { return this._quantity; }
            set {
                if (value > 0)
                {
                    this._quantity = value;
                }
                else {
                    throw new ArgumentException("-Quantity is Required");
                }
            }
        }
        public bool HasSerialNumber {
            get { return this._has_serial_number; }
            set
            {
                this._has_serial_number = value;
            }
        }

        public long LastInsertedId()
        {
            return this._lastInsertedId;
        }
        public string parameter
        {
            get { return this._parameter; }
            set { this._parameter = value; }
        }
        
        public DataTable SelectAllItems() {
            try {
                this.Query = $@"SELECT 
                items.id as `id`,
                items.category_id,
                items.sub_category_id,
                items.brand as `Brand`,
                items.model as `Model`,
                (SELECT COUNT(*) FROM assets WHERE item_id = items.id AND remarks IS NULL) AS `On Loan`,
                (SUM(item_receipt.quantity) - (SELECT COUNT(*)FROM assets WHERE item_id = items.id AND remarks = 3 OR item_id = items.id AND deleted = 1)) as `Total`,
                (IF(SUM(item_receipt.quantity) <= (SELECT COUNT(*) FROM assets WHERE item_id = items.id AND remarks IS NULL),'Unavailable','Available')) as `Availability`
                from item_receipt RIGHT JOIN items 
                ON items.id = item_receipt.item_id
                WHERE CONCAT(items.brand,items.model) LIKE @parameter
                GROUP BY item_receipt.item_id";

                    if (this.OpenConnection() == true)
                    {
                        cmd = new MySqlCommand(this.Query, this.connection);
                        da = new MySqlDataAdapter(cmd);
                        this._dt = new DataTable();
                        cmd.Parameters.AddWithValue("@parameter", "%" + this._parameter + "%");
                        cmd.Prepare();
                        da.SelectCommand = cmd;
                        da.Fill(this._dt);
                        this.CloseConnection();
                    }
                }
                catch (MySqlException ex) {
                    log.ErrorLog(ex.Message, this);
                    throw new ArgumentException("Error loading list of items.\nPlease contact your System Administrator");
                }
            return this._dt;
        }
        public DataTable SelectItemPerID() {
            this._dt = new DataTable();
            try
            {
                this.Query = $@"SELECT 
                items.id as `id`,
                vendors.id as `vendor_id`,
                vendors.vendor_name as `Vendor Name`,
                items.category_id as `category_id`,
                items.sub_category_id as `sub_category_id`,
                asset_category.category as `Category`,
                asset_sub_category.sub_category as `Sub Category`,
                items.brand as `Brand`,
                items.model as `Model`,
                item_receipt.id as `receipt_id`,
                item_receipt.official_receipt as `Official Receipt`,
                item_receipt.price as `Price`,
                (select SUM(item_receipt.quantity) from item_receipt where item_id = @id)  as `Total Quantity`,
                item_receipt.quantity As `Quantity`,
                item_receipt.date_purchased `Date Purchased`
                FROM 
                vendors INNER JOIN(
                asset_sub_category INNER JOIN(
                item_receipt INNER JOIN(
                items INNER JOIN asset_category
                ON items.category_id = asset_category.id)
                ON items.id = item_receipt.item_id)
                ON asset_sub_category.id = items.sub_category_id)
                ON vendors.id = item_receipt.vendor_id
                WHERE items.id = @id";

                if (this.OpenConnection() == true)
                {
                    using(cmd = new MySqlCommand(this.Query, this.connection)){
                        cmd.Parameters.AddWithValue("@id", this._id);
                        using (var reader = cmd.ExecuteReader()) {
                            this._dt.Load(reader);
                        }
                    }
                    
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading item details.\nPlease contact your System Administrator.");
            }
            return _dt;
        }
 
        public bool CreateNewItem() {

            try {
                this.Query = $@"INSERT INTO items(
                `category_id`,
                `sub_category_id`,
                `brand`,
                `model`,
                `serialized`,
                `date_created`) values(
                @category_id,
                @sub_category_id,
                @brand,
                @model,
                @serialized,
                now());";
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@category_id", this._categoryId);
                    cmd.Parameters.AddWithValue("@sub_category_id", this._subCategoryId);
                    cmd.Parameters.AddWithValue("@brand", this._brand);
                    cmd.Parameters.AddWithValue("@serialized", this._has_serial_number);
                    cmd.Parameters.AddWithValue("@model", this._model);
                    
                    this._is_successfull = (cmd.ExecuteNonQuery() > 0);
                    this._lastInsertedId = cmd.LastInsertedId;
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message,this);
                throw new ArgumentException(ex.Message);
            }
            return this._is_successfull;
        }
        public void UpdateItemDetails()
        {
            try {
                this.Query = $@"UPDATE items SET
                category_id = @category_id,
                sub_category_id = @sub_category_id,
                brand = @brand,
                model = @model,
                description = @description
                WHERE id = @id";
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@category_id", this._categoryId);
                    cmd.Parameters.AddWithValue("@sub_category_id", this._subCategoryId);
                    cmd.Parameters.AddWithValue("@brand", this._brand);
                    cmd.Parameters.AddWithValue("@model", this._model);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();

                }
            }catch(MySqlException ex)
            {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException(ex.Message);
            }
          
        }

    }
}
