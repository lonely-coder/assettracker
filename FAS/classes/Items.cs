using System;
namespace FAS
{
    public class Items
    {      
        private int _id = 0;
        private int _category_id = 0;
        private int _sub_category_id = 0;
        private string _model;
        private string _brand;
        private int _has_serial = 0;

        public Items() {

        }
        public int Id
        {
            get { return this._id; }
            set
            {
                this._id = value;
            }
        }
        public int CategoryId
        {
            get { return this._category_id; }
            set
            {
                if (value > 0)
                {
                    this._category_id = value;
                }
                else {
                    throw new ArgumentException("-Category is Required");
                }
            }
        }
        public int SubCategoryId
        {
            get { return this._sub_category_id; }
            set
            {
                if (value > 0)
                {
                    this._sub_category_id = value;
                }
                else
                {
                    throw new ArgumentException("-Sub Category is Required");
                }
            }
        }
        public string Model
        {
            get { return this._model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._model = value;
                }
                else {
                    throw new ArgumentException("-Model is Required");
                }
            }
        }
        public string Brand
        {
            get { return this._brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this._brand = value;
                }
                else
                {
                    throw new ArgumentException("-Brand is Required");
                }
            }
        }
        public int Quantity
        {
            get;set;
        }
        public int HasSerial {
            get { return this._has_serial; }
            set {  this._has_serial = value; }
        }
        public override string ToString()
        {
            return _model.ToString();
        }

    }
}
