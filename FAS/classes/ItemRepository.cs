using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace FAS
{
    public class ItemRepository
    { 
        private int _last_insert_id = 0;
        Connection _connection;
        Items _items;

        public ItemRepository()
        {
            this._connection = new Connection();
        }
        public ItemRepository(Items items) {
            this._connection = new Connection();
            this._items = items;
        }

        public int LastInsertId() {
            return _last_insert_id;
        }
        public bool itemExist() {
            return _items.Id > 0;
        }
        public int GetIdOfLastInsertedItem() {
            if (_items.Id == 0) {
                _items.Id = LastInsertId();
            }
            return _items.Id;
        }
        public Items GetItemById(int item_id) {
            Items items = new Items();

            string query = "select * from items where id = @id LIMIT 1";
            try
            {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", item_id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Id = int.Parse(reader["id"].ToString());
                                items.Model = reader["model"].ToString();
                                items.Brand = reader["brand"].ToString();
                                items.CategoryId = int.Parse(reader["category_id"].ToString());
                                items.SubCategoryId = int.Parse(reader["sub_category_id"].ToString());
                                items.HasSerial = int.Parse(reader["serialized"].ToString());
                                items.Quantity = int.Parse(reader["quantity_on_hand"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return items;

        }
        //this gets item based on parameter passed
        public Items GetItem(string parameter)
        {
            Items items = new Items();

            string query = "select * from items where model = @model";
            try
            {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@model", parameter);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Id = int.Parse(reader["id"].ToString());
                                items.Model = reader["model"].ToString();
                                items.Brand = reader["brand"].ToString();
                                items.CategoryId = int.Parse(reader["category_id"].ToString());
                                items.SubCategoryId = int.Parse(reader["sub_category_id"].ToString());
                                items.HasSerial = int.Parse(reader["serialized"].ToString());
                                items.Quantity = int.Parse(reader["quantity_on_hand"].ToString());
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return items;
        }
        public bool ItemIsAvailable(int item_id)
        {
            string query = @"SELECT count(*) FROM item_serials WHERE item_id = @id AND used = 0 AND deleted = 0";

            using (var connection = _connection.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", item_id);
                    return (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
                }
            }
        }
        public List<Items> GetAllItems(string parameter) {

            List<Items> itemList = new List<Items>();

            string query = @"SELECT id as `ID`,
                                brand as `Brand`,
                                model as `Model`,
                                category_id as `Category`,
                                sub_category_id as `Sub Category`,
                                quantity_on_hand as `On Hand`,
                                serialized 
                            FROM items WHERE model LIKE @parameter";

            using (MySqlConnection connection = this._connection.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@parameter", "%" + parameter + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            itemList.Add(new Items() {
                                Id = int.Parse(reader["ID"].ToString()),
                                Brand = reader["Brand"].ToString(),
                                Model = reader["Model"].ToString(),
                                CategoryId = int.Parse(reader["Category"].ToString()),
                                SubCategoryId = int.Parse(reader["Sub Category"].ToString()),
                                Quantity = int.Parse(reader["On Hand"].ToString()),
                                HasSerial = int.Parse(reader["serialized"].ToString())
                        });
                        }
                    }
                }
            }
            return itemList;
        }

        public void InsertItem()
        {
            string query = $@"INSERT INTO items(
                `category_id`,
                `sub_category_id`,
                `brand`,
                `model`,
                `serialized`,
                `quantity_on_hand`,
                `date_created`) values(
                @category_id,
                @sub_category_id,
                @brand,
                @model,
                @serialized,
                @quantity,
                now());";
            try
            {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@category_id", _items.CategoryId);
                        cmd.Parameters.AddWithValue("@sub_category_id", _items.SubCategoryId);
                        cmd.Parameters.AddWithValue("@brand", _items.Brand);
                        cmd.Parameters.AddWithValue("@model", _items.Model);
                        cmd.Parameters.AddWithValue("@serialized", _items.HasSerial);
                        cmd.Parameters.AddWithValue("@quantity", _items.Quantity);
                        cmd.ExecuteNonQuery();
                        this._last_insert_id = int.Parse(cmd.LastInsertedId.ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void UpdateItem()
        {

            string query = $@"UPDATE items SET
                category_id = @category_id,
                sub_category_id = @sub_category_id,
                brand = @brand,
                model = @model,
                quantity_on_hand = quantity_on_hand + @quantity
                WHERE id = @id";
            try
            {
                using (MySqlConnection connection = this._connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", _items.Id);
                        cmd.Parameters.AddWithValue("@category_id", _items.CategoryId);
                        cmd.Parameters.AddWithValue("@sub_category_id", _items.SubCategoryId);
                        cmd.Parameters.AddWithValue("@brand", _items.Brand);
                        cmd.Parameters.AddWithValue("@model", _items.Model);
                        cmd.Parameters.AddWithValue("@serialized", _items.HasSerial);
                        cmd.Parameters.AddWithValue("@quantity", _items.Quantity);
                        cmd.ExecuteNonQuery();
                        _last_insert_id = int.Parse(cmd.LastInsertedId.ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
        }
        public void UpdateOnLoanQuantity(int item_id,int quantity) {

            string query = "UPDATE items set quantity_on_hand = quantity_on_hand - @quantity where id = @id";

            using (var connection = _connection.GetConnection()) {
                using (var cmd = new MySqlCommand(query,connection)) {
                    cmd.Parameters.AddWithValue("@quantity",quantity);
                    cmd.Parameters.AddWithValue("@id", item_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
