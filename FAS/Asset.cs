using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FAS
{
    class Asset :DB
    {
        private int _id;
        private string _property_tag;
        private int _employee_id;
        private int _transfer_to_id;
        private int _item_id;
        private int _serial_id=0;
        private int _item_condition;
        private int _remarks;
        private double _asset_price;
        private DateTime _date_acquired;
        private string _parameter;
        //private DataTable _assets;
        DataTable dt ;

        Logs log = new Logs();

        public int Id {
            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentNullException("Invalid Asset Id");
                }
            }
        }
        public string PropertyTag {
            get { return this._property_tag; }
            set { this._property_tag = value; }
        }
        public int EmployeeId {
            get { return this._employee_id; }
            set {
                if (value > 0)
                {
                    this._employee_id = value;
                }
                else {
                    throw new ArgumentException("Invalid Employee Id");
                }
            }
        }
        public int TransferTo
        {
            get { return this._transfer_to_id; }
            set
            {
                if (value > 0)
                {
                    this._transfer_to_id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Employee Id");
                }
            }
        }
        public int ItemId {
            get {
                return this._item_id;
            }
            set
            {
                if (value > 0)
                {
                    this._item_id = value;
                }
                else {
                    throw new ArgumentException("Invalid Item Id");
                }

            }
            
        }
        public int ItemCondition{
            get { return this._item_condition; }
            set {
                if (value > 0)
                {
                    this._item_condition = value;
                }
                else {
                    throw new ArgumentException("Item Condition is Required");
                }
            }
        }
        public int Remarks {
            get { return this._remarks; }
            set {
                if (value > 0)
                {
                    this._remarks = value;
                }
                else {
                    throw new ArgumentException("Please select a valid reason");
                }
                }
        }
        public int SerialId {
            get { return this._serial_id; }
            set {
      
                
                    this._serial_id = value;
      
            }
        }
        public double ItemPrice {
            get { return this._asset_price; }
            set { this._asset_price = value; }
        }
        public DateTime DateAcquired {
            get { return this._date_acquired; }
            set { this._date_acquired = value; }
        }


        public string parameter {
            get { return this._parameter; }
            set { this._parameter = value; }
        }
        public bool Exist() {
            if (string.IsNullOrWhiteSpace(this._property_tag)) {
                return false;
            }
            try
            {
                this.Query = $"SELECT property_tag FROM assets WHERE property_tag LIKE @property_tag AND property_tag IS NULL";

                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.Parameters.AddWithValue("@property_tag", "%" + this._property_tag + "%");
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {

                log = new Logs();
                log.ErrorLog(ex.Message.ToString(), this);

                throw new ArgumentException("An Error Occured while Verifying Property Tag.\n Please Contact Your System Administrator");
                
            }
            
            return (dt.Rows.Count > 0);

        }
        
        public DataTable SelectAllEmployeeAssets() {
            try
            {
                this.Query = $@"SELECT employees.id as `Id`,
                employees.department_id as `dept_id`,
                employees.position_id as `pos_id`,
                employees.employee_id as `Employee ID`,
                CONCAT(employees.first_name,' ',employees.last_name) as `Name`,
                COUNT(assets.id) as `Number of Assets` 
                FROM employees RIGHT JOIN 
                assets ON employees.id = assets.employee_id 
                WHERE CONCAT(assets.property_tag,employees.employee_id,employees.first_name,employees.first_name) LIKE
                @parameter
                AND assets.remarks IS NULL
                GROUP BY employees.id";


                if (this.OpenConnection() == true)
                {
                    this.cmd = new MySqlCommand(this.Query, this.connection);
                    this.da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.Parameters.AddWithValue("@parameter", "%" + this._parameter + "%");
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message,this);

                throw new ArgumentException("An error occured while loading list of assets. \nPlease contact your system administrator");
            }
            return dt;
        }
        public DataTable SelectAssetsPerEmployee()
        {
            try
            {
                this.Query = $@"SELECT 
                assets.id as `pkAccountability`,
                assets.employee_id as   `pkEmployeeId`,
                IFNULL(assets.property_tag,'N/A') as `Property Tag`,
                CONCAT(employees.first_name,' ',employees.last_name) as `Name`,
                employees.employee_id as `Employee Id`,
                departments.department_name as `Department`,
                positions.position_name as `Position`,
                items.model as `Model`,
                items.description as `Description`,
                IFNULL(item_serials.serial_number,'N/A') as `Serial Number`,
                assets.asset_price as `Amount`                
                FROM item_serials RIGHT JOIN(items LEFT JOIN(positions INNER JOIN(
                departments INNER JOIN(
                employees RIGHT JOIN assets 
                ON employees.id = assets.employee_id) 
                ON departments.id = employees.department_id)
                ON positions.id = employees.position_id)
                ON items.id = assets.item_id)
                ON item_serials.id = assets.serial_id
                WHERE assets.employee_id = @id
                AND assets.remarks IS NULL";

                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.Parameters.AddWithValue("@id", this._employee_id);
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("An error occured while loading Employee Assets.\nPlease Contact your system Administrator");
            }
            return dt;
        }
        public void CreateAsset() {

            try
            {
                this.Query = $@"INSERT into assets(
                `property_tag`,
                `employee_id`,
                `item_id`,
                `serial_id`,
                `asset_price`,
                `date_acquired`,
                `item_condition`,
                `date_created`)values(
                @property_tag,
                @employee_id,
                @item_id,
                @serial_id,
                @asset_price,
                @date_acquired,
                @item_condition,
                now())";
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@property_tag", this._property_tag);
                    cmd.Parameters.AddWithValue("@employee_id", this._employee_id);
                    cmd.Parameters.AddWithValue("@item_id", this._item_id);
                    if (this._serial_id > 0)
                    {
                        cmd.Parameters.AddWithValue("@serial_id", this._serial_id);
                    }
                    else {
                        cmd.Parameters.AddWithValue("@serial_id", null);
                    }
                    cmd.Parameters.AddWithValue("@asset_price", this._asset_price);
                    cmd.Parameters.AddWithValue("@date_acquired", this._date_acquired);
                    cmd.Parameters.AddWithValue("@item_condition", this._item_condition);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error saving employee assets. \nPlease contact your System Administrator");
            }
            
        }
        public DataTable SelectAssetPerId()
        {
            try
            {
                this.Query = $@"SELECT 
                assets.id as `pkAccountability`,
                assets.employee_id as   `pkEmployeeId`,
                assets.property_tag as `Property Tag`,
                CONCAT(employees.first_name,' ',employees.last_name) as `Name`,
                employees.employee_id as `Employee Id`,
                departments.department_name as `Department`,
                positions.position_name as `Position`,
                items.id as `item_id`,
                items.model as `Model`,
                items.description as `Description`,
                assets.asset_price as `Amount`,
                assets.date_acquired as `Date Acquired`,
                IFNULL(assets.serial_id,0) as `serial_id`,
                IFNULL(item_serials.serial_number,'N/A') as `Serial Number`,
                item_condition.id as `state`
                FROM item_condition RIGHT JOIN(item_serials RIGHT JOIN(items left JOIN (
                positions INNER JOIN(
                departments INNER JOIN(employees RIGHT JOIN assets 
                ON employees.id = assets.employee_id) 
                ON departments.id = employees.department_id)
                ON positions.id = employees.position_id)
                ON items.id = assets.item_id)
                ON assets.serial_id = item_serials.id)
                ON item_condition.id = assets.item_condition
                where assets.id = @id AND assets.remarks IS NULL";

                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.Prepare();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log = new Logs();
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("An error occured while loading necessary data.\n Please contact your System Administrator.");
            }
            return dt;
        }
        public void UpdateAsset() {

            try
            {
                this.Query = $@"UPDATE assets set
                    `property_tag` = @property_tag,
                    `employee_id` = @employee_id,
                    `item_id` = @item_id,
                    `serial_id` = @serial_id,
                    `asset_price` =@asset_price,
                    `date_acquired` = @date_acquired,
                    `item_condition` = @item_condition WHERE id = @id"
                    ;
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@property_tag", this._property_tag);
                    cmd.Parameters.AddWithValue("@employee_id", this._employee_id);
                    cmd.Parameters.AddWithValue("@item_id", this._item_id);
                    if (this._serial_id > 0)
                    {
                        cmd.Parameters.AddWithValue("@serial_id", this._serial_id);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@serial_id", null);
                    }
                    cmd.Parameters.AddWithValue("@asset_price", this._asset_price);
                    cmd.Parameters.AddWithValue("@item_condition", this._item_condition);
                    cmd.Parameters.AddWithValue("@date_acquired", this._date_acquired);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("An error occured while updating employee assets.\nPlease Contact your System Administrator");
            }
            
        }
        public void TransferAssets() {

            try
            {
                this.Query = $@"UPDATE assets set
                    `previous_employee_id`= `employee_id`,
                    `employee_id` = @new_employee_id
                    WHERE `employee_id` = @employee_id"
                    ;
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@employee_id", this._employee_id);
                    //cmd.Parameters.AddWithValue("@previous_employee_id", this._employee_id);
                    cmd.Parameters.AddWithValue("@new_employee_id", this._transfer_to_id);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex) {
                log.ErrorLog(ex.Message,this);
                throw new ArgumentException("An error occured while transferring assets.\nPlease Contact your System Administrator");
            }
            
        }
        public void TransferSelectedAsset() {
            try {
                this.Query = @"UPDATE assets set `previous_employee_id` = `employee_id`,`employee_id` = @employee_id WHERE `id` = @asset_id";

                if (this.OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@employee_id", this._employee_id);
                    cmd.Parameters.AddWithValue("@asset_id", this._id);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }catch(MySqlException ex){
                log.ErrorLog(ex.Message,this);
                throw new ArgumentException("An error occured while transferring assets.\nPlease Contact your System Administrator");
            }
        }
        public void DeleteAsset() {

            try
            {
                this.Query = "UPDATE assets SET `remarks` = @remarks WHERE `id` = @id";
                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    cmd.Parameters.AddWithValue("@remarks", this._remarks);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message,this);
                throw new ArgumentException("An error occured while deleting employee assets.\nPlease Contact your System Administrator.");
            }
        }
        public DataTable SelectScrappedAssets() {

            try {
                this.Query = @"SELECT assets.id as `asset_id`,
                            IF(assets.property_tag IS NULL,'N/A',assets.property_tag) as `Property Tag`,
                            items.id as `item_id`,
                            items.brand as `Brand`,
                            items.model as `Model`,
                            item_serials.item_receipt_id as `receipt_id`,
                            item_serials.id as `serial_id`,
                            IF(item_serials.serial_number IS NULL,'N/A',item_serials.serial_number) as `Serial Number` 
                            from 
                            items INNER JOIN(item_serials right join assets ON item_serials.id = assets.id)
                            ON items.id = assets.item_id
                            WHERE remarks = 2 AND deleted IS NULL";

                //assets right JOIN(items LEFT JOIN item_serials on items.id = item_serials.item_id)
                //            ON assets.item_id = items.id
                if (OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query, this.connection);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    //cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.Prepare();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    this.CloseConnection();
                }
            }
            catch (Exception ex) {
                log.ErrorLog(ex.Message, this);
                
                throw new ArgumentException("An error occured while deleting records.\nPlease contact your System Administrator.");
            }
            return dt;
        }
        public void DeleteScrappedAssets(List<int> asset_id) {
            List<int> _asset_id = asset_id;
            this.Query = "UPDATE assets set deleted = 1 where id = @id";
            try {
                if (OpenConnection() == true) {
                    cmd = new MySqlCommand(this.Query,this.connection);
                    for (int i = 0; i < _asset_id.Count; i++) {
                        cmd.Parameters.AddWithValue("@id", _asset_id[i]);
                        cmd.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (Exception ex) {
                throw new ArgumentException("An error occured while deletinf records.\nPlease contact your System Administrator");
            }
        }

    }
}
