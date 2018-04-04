using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAS.classes
{
    class ItemAvailabilityChecker
    {
        private Connection _connection;
        public ItemAvailabilityChecker() {
            _connection = new Connection();
        }
        public bool ItemIsAvailable(int item_id) {

            string query = "SELECT quantity_on_hand from items where id = @id";
            try {
                return true;
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.ToString());
            }
        }
    }
}
