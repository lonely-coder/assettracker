using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class ItemCreator
    {
        Connection _connection;
        Items _items;
        Receipt _receipt;
        List<Serial> _serial_list;
        ItemRepository itemRepository;
        ReceiptRepository receiptRepository;
        int _item_id = 0 ;
        int _receipt_id = 0;

        public ItemCreator(Items items, Receipt receipt)
        {
            _connection = new Connection();
            _items = items;
            _receipt = receipt;
         
        }
        public ItemCreator(Items items, Receipt receipt,List<Serial> serial_list) {
            _connection = new Connection ();
            _items = items;
            _receipt = receipt;
            _serial_list = serial_list;
        }
        private bool checkedQuantityAndProvidedSerialsIfEqual() {
            if (_items.Quantity == _serial_list.Count) {
                return true;
            }
            else {
                throw new ArgumentException(string.Format("-Please provide {0} serial number(s)", _items.Quantity - _serial_list.Count));
            }
            
        }
        private void CreateItemDetails() {
            itemRepository = new ItemRepository(_items);
            switch (itemRepository.itemExist())
            {
                case true:
                    itemRepository.UpdateItem();
                    break;
                case false:
                    itemRepository.InsertItem();
                    break;
                default:
                    //
                    break;
            }
        }
        private void CreateReceipt(int _item_id) {
            receiptRepository = new ReceiptRepository(_receipt);

            receiptRepository.InsertReceipt(_item_id);
        }
        public void CreateItem() {
            MySqlTransaction transaction=null;
            try {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (transaction = connection.BeginTransaction())
                    {
                        CreateItemDetails();
                          
                        _item_id = itemRepository.GetIdOfLastInsertedItem();

                        CreateReceipt(_item_id);

                        _receipt_id = receiptRepository.LastInsertId();
                        
                        if ((_items.HasSerial == 1) && checkedQuantityAndProvidedSerialsIfEqual()) {
                            SerialRepository serialRepository = new SerialRepository(_serial_list);
                            serialRepository.InsertSerial(_item_id,_receipt_id);
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (MySqlException ex) {
                transaction.Rollback();
                Console.WriteLine("Error occured. Rolling back changes.");
                throw new ArgumentException(ex.Message);
                
            }
            catch (Exception ex) {
                Console.WriteLine("Error occured. Rolling back changes.");
                throw new ArgumentException(ex.Message);
            }
        }
        
    }
}
