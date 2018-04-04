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

        public ItemCreator(Connection connection,Items items,Receipt receipt,List<Serial> serial_list) {
            _connection = connection;
            _items = items;
            _receipt = receipt;
            _serial_list = serial_list;
        }

        private bool ItemExist() => _items.Id > 0; 
        public void CreateItem() {
            MySqlTransaction transaction=null;
            try {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (transaction = connection.BeginTransaction())
                    {
                        ItemRepository itemRepository = new ItemRepository(this._connection, this._items);
                        switch (ItemExist()) {
                            case true:
                                Console.WriteLine("Item exist.");
                                itemRepository.UpdateItem();
                                Console.WriteLine("Item Quantity Updated.");
                                break;
                            case false:
                                Console.WriteLine("New Item.");
                                itemRepository.InsertItem();
                                Console.WriteLine("Item Details Created.");
                                break;
                            default:
                                break;
                        }    
                        this._receipt.ItemId = itemRepository.LastInsertID;
                        
                        ReceiptRepository receiptRepository = new ReceiptRepository(this._connection, this._receipt);
                        receiptRepository.InsertReceipt();
                        Console.WriteLine("Item receipts saved");
                        if (_items.HasSerial == 1) {
                            SerialRepository serialRepository = new SerialRepository(this._connection, _serial_list);
                            serialRepository.InsertSerial();
                            Console.WriteLine("Serial Numbers saved.");
                        }
                        Console.WriteLine("Commit to DB");
                        transaction.Commit();
                    }
                }
            }
            catch (MySqlException ex) {
                transaction.Rollback();
                throw new ArgumentException(ex.ToString());
                
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Source);
            }
        }
    }
}
