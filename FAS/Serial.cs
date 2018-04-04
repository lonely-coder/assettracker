using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Serial :DB
    {

        private int _id;
        private int _item_id;
        private int _item_receipt_id;
        private string _serial_number;
        private string _parameter;
        private DataTable _dt;

        Logs log = new Logs();
        public int Id {
            get { return this._id; }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Serial ID");
                }
                
            }
        }
        public int ItemId {
            get { return this._item_id; }
            set
            {
                if (value > 0)
                {
                    this._item_id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Item ID");
                }

            }
        }
        public int ReceiptId
        {
            get { return this._item_receipt_id; }
            set
            {
                if (value > 0)
                {
                    this._item_receipt_id = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Receipt Id");
                }

            }
        }
        public string Parameter {
            get { return this._parameter; }
            set { this._parameter = value; }
        }
        public void AddSerial()
        {
            this.Query = @"INSERT INTO item_serials(
                        `item_id`,
                        `item_receipt_id`,
                        `serial_number`,
                        `date_created`) 
                        values(
                        @item_id,
                        @official_receipt_id,
                        @serial_number,
                        now())";

            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand(this.Query, this.connection);
                cmd.Parameters.AddWithValue("@item_id", this._item_id);
                cmd.Parameters.AddWithValue("@official_receipt_id", this._item_receipt_id);
                cmd.Parameters.AddWithValue("@serial_number", this._serial_number);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            
        }
        public void UpdateSerial()
        {
            this.Query = @"UPDATE item_serials SET
                        `item_id` = @item_id,
                        `item_receipt_id` = @official_receipt_id,
                        `serial_number` = @serial_number,
                        `date_updated` = NOW() WHERE id = @id";

            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand(this.Query, this.connection);
                cmd.Parameters.AddWithValue("@item_id", this._item_id);
                cmd.Parameters.AddWithValue("@official_receipt_id", this._item_receipt_id);
                cmd.Parameters.AddWithValue("@serial_number", this._serial_number);
                cmd.Parameters.AddWithValue("@id", this._id);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
           
        }

        public string SerialNumber {
            get { return this._serial_number; }
            set {
                this._serial_number = value;
            }
        }
        public DataTable SelectSerialPerItemId() {
            try {
                this.Query = $@"Select 
                        item_serials.id as `Id`,
                        item_serials.item_id as `item_id`,
                        item_serials.serial_number as `Serial Number`,
                        item_receipt.price as `Amount`
                        from assets RIGHT JOIN(item_serials INNER JOIN item_receipt ON item_serials.item_receipt_id = item_receipt.id)ON item_serials.id = assets.item_Id  WHERE item_serials.item_id = @id AND assets.serial_id IS NULL AND assets.remarks IS NULL or assets.remarks = 1";

                if (this.OpenConnection() == true)
                {
                    cmd = new MySqlCommand(this.Query, connection);
                    da = new MySqlDataAdapter(cmd);
                    _dt = new DataTable();
                    cmd.Parameters.AddWithValue("@id", this._item_id);
                    cmd.Prepare();
                    da.SelectCommand = cmd;
                    da.Fill(this._dt);
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex) {
                log.ErrorLog(ex.Message,this);
                throw new ArgumentException("Error loading Serial for this item.\nPlease contact your System Administrator.");
            }
                return this._dt;

        }

        public DataTable SelectSerial()
        {
            try
            {
                this.Query = $@"Select 
                        item_serials.serial_number as `Serial Number`,
                        from assets RIGHT JOIN(
                        item_serials INNER JOIN 
                        item_receipt 
                        ON item_serials.item_receipt_id = item_receipt.id)
                        ON item_serials.id = assets.item_Id
                        WHERE item_serials.serial_number LIKE @serial_number AND assets.serial_id IS NULL AND assets.remarks IS NULL or assets.remarks = 1";

                if (this.OpenConnection() == true)
                {
                    using (cmd = new MySqlCommand(this.Query, connection)) {
                        cmd.Parameters.AddWithValue("@serial_number",this._parameter);
                            using (var reader = cmd.ExecuteReader()) {
                                this._dt.Load(reader);
                            }
                    }
                    this.CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                log.ErrorLog(ex.Message, this);
                throw new ArgumentException("Error loading Serial for this item.\nPlease contact your System Administrator.");
            }
            return this._dt;

        }
    }
}
