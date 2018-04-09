using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Category 
    {
        private int _id;
        private string _category;
        public int ID {
            get {
                return this._id;
            }
            set {
                if (value > 0)
                {
                    this._id = value;
                }
                else {
                    throw new ArgumentException("Invalid Category ID");
                }
            }
        }
        public string CategoryName {
            get
            {
                return this._category;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._category = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Category");
                }
            }
        }
    }
}
