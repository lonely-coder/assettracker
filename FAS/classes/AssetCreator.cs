using System;
using MySql.Data.MySqlClient;
namespace FAS
{
    class AssetCreator
    {
        Connection _connection;
        AssetsModel _assetModel;
        
        public AssetCreator(AssetsModel assetModel) {
            _connection = new Connection();
            _assetModel = assetModel;
        }
        
        public bool CreateEmployeeAsset() {
            string query = $@"INSERT into assets(
                `property_tag`,
                `employee_id`,
                `item_id`,
                `serial_id`,
                `quantity`,
                `asset_price`,
                `date_acquired`,
                `date_created`)values(
                @property_tag,
                @employee_id,
                @item_id,
                @serial_id,
                @quantity,
                @price,
                @date_acquired,
                now())";
            try
            {
                using (var cmd = new MySqlCommand(query, _connection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@property_tag", _assetModel.PropertyTag);
                    cmd.Parameters.AddWithValue("@employee_id", _assetModel.EmployeeId);
                    cmd.Parameters.AddWithValue("@item_id", _assetModel.Items.Id);
                    if (_assetModel.Serial.Id == 0)
                    {
                        cmd.Parameters.AddWithValue("@serial_id", null);
                    }
                    else {
                        cmd.Parameters.AddWithValue("@serial_id", _assetModel.Serial.Id);
                    }
                    cmd.Parameters.AddWithValue("@price",_assetModel.Price);
                    cmd.Parameters.AddWithValue("@quantity", _assetModel.Quantity);
                    cmd.Parameters.AddWithValue("@date_acquired", _assetModel.DateAcquired);
                    return (cmd.ExecuteNonQuery() > 0);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
        }
            
    }
}
