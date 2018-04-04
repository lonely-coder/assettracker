using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace FAS
{
    public class ItemManager
    {

        private DataTable _dt;

        private readonly bool _item_exist = false;
        private readonly bool _success = false;

        public bool itemExist(int id) {
            return id>0;
        }
        //this gets item based on parameter passed
        public  static Item GetItem(string parameter)
        {
            Item itemObj = new Item();

            string query = "select * from items where model = @model";
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@model", parameter);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itemObj.Id = int.Parse(reader["id"].ToString());
                                itemObj.Model = reader["model"].ToString();
                                itemObj.Brand = reader["brand"].ToString();
                                itemObj.CategoryId = int.Parse(reader["category_id"].ToString());
                                itemObj.SubCategoryId = int.Parse(reader["sub_category_id"].ToString());
                                itemObj.HasSerialNumber = (reader["serialized"].ToString() == "1");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return itemObj;
        }
        /*
        *This get all items on database based on parameters passed
        *
        *return type is DataTable since its easier to populate a DataTable than List<item>
        */
        public DataTable GetAllItems(string parameter) {

            this._dt = new DataTable();

            string query = @"SELECT id as `ID`,
                                brand as `Brand`,
                                model as `Model`,
                                category_id as `Category`,
                                sub_category_id as `Sub Category`,
                                quantity_on_hand as `On Hand`
                            FROM items WHERE model LIKE @parameter";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@parameter", "%" + parameter + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        this._dt.Load(reader);
                    }
                }
            }
            return this._dt;
        }

        public bool CreateItem()
        {

            try
            {

            }
            catch (MySqlException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {

            }

            return _success;
        }

    }
}
