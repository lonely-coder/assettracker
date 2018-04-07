using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAS
{
    public class ItemModel
    {
        public int Id {get;set;}
        public int CategoryId{ get; set; }
        public int SubCategoryId{ get; set; }
        public string Model{ get; set; }
        public string Brand{ get; set; }
        public int Quantity{ get; set; }
        public int OnLoan{get;set;}
        public int HasSerial{ get; set; }
        public override string ToString()
        {
            return Model.ToString();
        }
    }
}
