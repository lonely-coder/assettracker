using System;

namespace FAS
{
    public class SubCategory 
    {
        private int _id;
        private int _category_id;
        private string _sub_category_name;

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
                    throw new ArgumentException("Invalid Sub Category ID");
                }
            }
        }
        public int CategoryId {
            get
            {
                return this._category_id;
            }
            set {
                this._category_id = value;
            }
        }
        public string SubCategoryName {
            get {
                return this._sub_category_name;
            }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._sub_category_name = value;
                }
                else {
                    throw new ArgumentException("Invalid Sub Category Name");
                }
                
            }
        }
    }
}