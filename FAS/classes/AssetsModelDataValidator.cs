using System;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class AssetsModelDataValidator
    {
        Connection _connection;
        AssetsModel _assetModel;
        public AssetsModelDataValidator(AssetsModel assetModel) {
            _connection = new Connection();
            _assetModel = assetModel;
        }

        private bool CheckPropertyTagIfAvailable() {
            bool property_tag_match_found  = false;

            string query = @"SELECT count(*) from assets where property_tag = @property_tag AND property_tag != '' ";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("property_tag",_assetModel.PropertyTag);
                    property_tag_match_found = (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
                }

            }
            return property_tag_match_found;
        }
        private void PropertyTagIsValid() {
            if (CheckPropertyTagIfAvailable()== true) {
                throw new ArgumentException("-Property Tag already used.");
            }
        }
        private void ItemIdIsGreaterThanZero() {
            if(_assetModel.Items.Id == 0){
                throw new ArgumentException("-Item Model is empty.");
            }
        }
        private void ItemRequiresSerial() {
            if (_assetModel.Items.HasSerial == 1 && _assetModel.Serial.Id == 0) {
                throw new ArgumentException("-This item requires serial.");
            }
        }
        private void EmployeeIdIsGreaterThanZero() {
            if(_assetModel.EmployeeId == 0 ){
                throw new ArgumentException("- Employee ID is required");
            }
        }
        private void Quantity() {
            if (_assetModel.Quantity == 0) {
                throw new ArgumentException("-Quantity must be greater than 0.");
            }
        }
        private void Price() {
            switch (_assetModel.Price == 0) {
                case true:
                    throw new ArgumentException("-Price must be greater than 0.");
                    break;
                case false:
                    DefinePriceIfValid();
                    break;
            }
            
        }
        private void DefinePriceIfValid() {
            ReceiptRepository receiptRepository = new ReceiptRepository();
            switch (_assetModel.Items.HasSerial == 1) {
                case true:
                    var list = receiptRepository.ItemPriceRange(_assetModel.Items.Id);
                    int count = 0;
                    foreach (var priceList in list)
                    {
                        if (priceList == _assetModel.Price)
                        {
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        throw new ArgumentException("-Price must match on price list.");
                    }
                    break;
                case false:
                    //var price = receiptRepository.GetPrice(_assetModel.Items.Id);
                    //if (price != _assetModel.Price) {
                       // throw new ArgumentException("-Price must match on price list.");
                    //}
                    break;
            }
            
            
        }
        public bool AssetsModelDataIsValid() {

            EmployeeIdIsGreaterThanZero();
            PropertyTagIsValid();
            ItemIdIsGreaterThanZero();
            ItemRequiresSerial();
            Quantity();
            Price();
            return true;
        }
    }
}
