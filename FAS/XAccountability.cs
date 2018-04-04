using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace FAS
{
    class Accountability :DB
    {

        private int _id;
        private int _employee_id;
        private string _property_tag;
        private string _model;
        private string _description;
        private string _amount;
        private int _quantity;
        private int _vendor_id;
        private int _remarks;
        private string _serial_number;
        private DateTime _date_purchased;
        private DateTime _warranty_period;
        private DateTime _date_acquired;
        private int _user_id;
        private int _status_id;
        private int _test_date_purchased;
        private int _test_date_of_warranty;
        private int _from_employee_id;
        private DataTable _accountabilityDT;
        private DataTable _accountabilityPerIdDT;
        private DataTable _floatingItems;
        private string sqlAccountability = $@"SELECT 
                assets.id as `pkAccountability`,
                assets.employee_id as   `pkEmployeeId`,
                assets.property_tag as `Property Tag`,
                CONCAT(employees.first_name,' ',employees.last_name) as `Name`,
                employees.employee_id as `Employee Id`,
                departments.department_name as `Department`,
                positions.position_name as `Position`,
                assets.model as `Model`,
                item_condition.id as `Item Condition ID`,
                item_condition.state as `Item Status`
                FROM item_condition INNER JOIN(positions INNER JOIN(departments INNER JOIN(employees RIGHT JOIN(assets LEFT JOIN vendors
                ON assets.vendor_id = vendors.id)
                ON employees.id = assets.employee_id) 
                ON departments.id = employees.department_id)
                ON positions.id = employees.position_id)
                ON assets.item_condition = item_condition.id";

        private string sqlAccountability2 = @"SELECT 
                departments.department_name as `Department`,
                employees.id as `Employee Id`,
                departments.id as `deptId`,
                positions.id as `posId`,
                employees.employee_id as `Company ID`,
                concat(employees.first_name,' ',employees.last_name) as `Name`,
                COUNT(assets.employee_id) as `# of Assigned Items`
                from positions INNER JOIN(departments RIGHT JOIN(employees RIGHT JOIN
                assets ON employees.id = assets.employee_id)
                ON departments.id = employees.department_id)
                ON employees.position_id= positions.id
                ";

        public int ID
        {
            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Asset  ID");
                }
            }
        }

        public int EmployeeId
        {
            get { return this._employee_id; }
            set {
                if (value > 0)
                {
                    this._employee_id = value;
                }
                else
                {
                    throw new ArgumentException("You have not selected an Employee");
                }
               }
        }
        public int ToEmployeeId {
            get { return this._from_employee_id; }
            set
            {
                if (value > 0)
                {
                    this._from_employee_id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Employee ID");
                }
            }
        }
        public string PropertyTag
        {
            get { return this._property_tag; }
            set {
                
                    this._property_tag = value;
                
                }
        }
        public string Model
        {
            get { return this._model; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._model = value;
                }
                else {
                    throw new ArgumentException("Model is Required");
                }
            }
        }
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        public string SerialNumber
        {
            get { return this._serial_number; }
            set { this._serial_number = value; }
        }
        public string Amount
        {
            get { return this._amount; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._amount = value;
                }
                else {
                    throw new ArgumentException("Amount is Required");
                }
                 }
        }
        public int Quantity
        {
            get { return this._quantity; }
            set {
                if (value > 0)
                {
                    this._quantity = value;
                }
                else {
                    throw new ArgumentException("Quantity is Required");
                }
               }
        }
        public int Vendor {
            get { return this._vendor_id; }
            set {
                if (value > 0)
                {
                    this._vendor_id = value;
                }
                else {
                    throw new ArgumentException("Vendor is Required");
                }
            }
        }
        public DateTime DatePurchased
        {
            get { return this._date_purchased; }
            set
            {
                    this._date_purchased = value;   
            }
        }
        public DateTime WarrantyPeriod
        {
            get { return this._warranty_period; }
            set
            {
                    this._warranty_period = value;
                
            }
        }
        public DateTime DateAcquired
        {
            get { return this._date_acquired; }
            set
            {
                this._date_acquired = value;

            }
        }
        public int UserId {
            get { return this._user_id; }
            set {
                if (value > 0)
                {
                    this._user_id = value;
                }
                else {
                    throw new ArgumentException("User Id is Empty");
                }
                }
        }
        public int ItemCondition
        {
            get { return this._status_id; }
            set
            {
                if (value > 0)
                {
                    this._status_id = value;
                }
                else
                {
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
                
            }
        }
        
        

        public void CreateAccountability() {

            try {

                this.Query = @"INSERT into assets (
                                `id`,
                                `employee_id`,
                                `property_tag`,
                                `model`,
                                `description`,
                                `serial_numbers`,
                                `amount`,
                                `quantity`,
                                `vendor_id`,
                                `date_purchased`,
                                `warranty_period`,
                                `date_acquired`,
                                `user_id`,
                                `item_condition`,
                                `date_created`)
                                values(null,
                                @employeeId,
                                @propertyTag,
                                @model,
                                @description,
                                @serialNumber,  
                                @amount,
                                @quantity,
                                @vendor,
                                @datePurchased,
                                @warrantyDate,
                                @dateAcquired,
                                @userId,
                                @itemCondition,
                                NOW())";

                if (this.OpenConnection() == true) {
                    MySqlCommand cmd = new MySqlCommand(this.Query,this.connection);

                    cmd.Parameters.AddWithValue("@employeeId", this.EmployeeId);
                    cmd.Parameters.AddWithValue("@propertyTag", this.PropertyTag);
                    cmd.Parameters.AddWithValue("@model", this.Model);
                    cmd.Parameters.AddWithValue("@description", this.Description);
                    cmd.Parameters.AddWithValue("@serialNumber", this.SerialNumber);
                    cmd.Parameters.AddWithValue("@amount", double.Parse(this.Amount));
                    cmd.Parameters.AddWithValue("@quantity", this.Quantity);
                    cmd.Parameters.AddWithValue("@vendor", this.Vendor);
                    cmd.Parameters.AddWithValue("@datePurchased", this.DatePurchased);
                    cmd.Parameters.AddWithValue("@warrantyDate", this.WarrantyPeriod);
                    cmd.Parameters.AddWithValue("@dateAcquired", this.DateAcquired);
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    cmd.Parameters.AddWithValue("@itemCondition", this.ItemCondition);
                    
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }

            } catch (Exception ex) {
                throw new ArgumentException(ex.ToString());
            }

        }
        public DataTable ReadAccountability() {

            try {
                this.Query = this.sqlAccountability2 + " WHERE assets.remarks IS NULL  AND assets.item_condition = 1 GROUP BY employees.id";

                this._accountabilityDT = this.Select();
                return this._accountabilityDT;
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }

            
        }
        public DataTable ReadAccountabilityPerId() {
            try {
                this.Query = this.sqlAccountability+ $" where assets.id = {this._id}";
                return this._accountabilityPerIdDT= this.Select();
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }
        }
        public DataTable SelectAccountability() {

            try {
                this.Query = this.sqlAccountability +$" WHERE assets.employee_id = {this._employee_id} AND assets.remarks IS NULL AND assets.item_condition = 1";

                return this._accountabilityPerIdDT = this.Select();
            } catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }
        }
        public DataTable FloatingItems() {
            try {
                this.Query = this.sqlAccountability + $" WHERE assets.remarks IS NOT NULL AND assets.item_condition < 3";

                return this._floatingItems = this.Select();
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }
        }
        public void UpdateAccountability() {
            try {
                this.Query = @"UPDATE assets SET 
                        `employee_id` = @employeeId,
                        `property_tag` = @propertyTag,
                        `model` = @model,
                        `description` = @description,
                        `serial_numbers` = @serialNumber,
                        `amount` = @amount,
                        `quantity` = @quantity,
                        `vendor_id` = @vendor,
                        `date_purchased` = @datePurchased,
                        `warranty_period` = @warrantyDate,
                        `date_acquired` = @dateAcquired,
                        `user_id` = @userId,
                        `item_condition` = @ItemCondition,
                        `date_updated` = now()
                        where id = @id
                        ";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(this.Query, this.connection);

                    cmd.Parameters.AddWithValue("@employeeId", this.EmployeeId);
                    cmd.Parameters.AddWithValue("@propertyTag", this.PropertyTag);
                    cmd.Parameters.AddWithValue("@model", this.Model);
                    cmd.Parameters.AddWithValue("@description", this.Description);
                    cmd.Parameters.AddWithValue("@serialNumber", this.SerialNumber);
                    cmd.Parameters.AddWithValue("@amount", this.Amount);
                    cmd.Parameters.AddWithValue("@quantity", this.Quantity);
                    cmd.Parameters.AddWithValue("@vendor", this.Vendor);
                    cmd.Parameters.AddWithValue("@datePurchased", this.DatePurchased);
                    cmd.Parameters.AddWithValue("@warrantyDate", this.WarrantyPeriod);
                    cmd.Parameters.AddWithValue("@dateAcquired", this.DateAcquired);
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    cmd.Parameters.AddWithValue("@itemCondition", this.ItemCondition);
                    cmd.Parameters.AddWithValue("@id", this.ID);
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }

            }
            catch (Exception ex) {
                throw new ArgumentException(ex.ToString());
            }

        }
        public void TransferEmployeeAccountability() {
            this.Query = $@"UPDATE assets set employee_id = @to_employee_id,date_updated = now() 
                        where employee_id = @from_employee_id";
            if (this.OpenConnection() == true) {
                MySqlCommand cmd = new MySqlCommand(this.Query, this.connection);

                cmd.Parameters.AddWithValue("@from_employee_id", this.EmployeeId);
                cmd.Parameters.AddWithValue("@to_employee_id", this.ToEmployeeId);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }
        }
        public void ReAssignItem()
        {
            this.Query = @"UPDATE assets set employee_id = @employee_id,remarks = @remarks,date_updated = now() 
                        where id = @id";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(this.Query, this.connection);

                cmd.Parameters.AddWithValue("@id", this.ID);
                cmd.Parameters.AddWithValue("@employee_id", this.EmployeeId);
                cmd.Parameters.AddWithValue("@remarks", null);
                cmd.ExecuteNonQuery();
                this.CloseConnection();

            }
        }
        public void DropAccountability() {
            this.Query = $@"UPDATE assets SET remarks = 1 
                    WHERE id = @id";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(this.Query, this.connection);

                cmd.Parameters.AddWithValue("@id", this.ID);
                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }
        public void ValidateDateTime()
        {

            this._test_date_of_warranty = DateTime.Compare(this._date_purchased, this._warranty_period);
            this._test_date_purchased = DateTime.Compare(this._date_purchased, this._date_acquired);
            if (this._test_date_of_warranty > 0)
            {
                throw new ArgumentException("Warranty Date is earlier than Date of Purchased");
            }
            else if(this._test_date_purchased > 0){
                throw new ArgumentException("Date acquired is earlier than Date of Purchased");
            }

        }
        public DataTable TotalAssets() {
            this.Query = "SELECT sum(assets.amount) from assets WHERE remarks IS NULL";

            DataTable Total = this.Select();

            return Total;
        }
    }
}
