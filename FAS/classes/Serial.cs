using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
namespace FAS
{
    public class Serial 
    {

        public int Id {
            get;
            set;
        }
        public int ItemId {
            get; set;
        }
        public int ReceiptId
        {
            get; set;
        }
        public string SerialNumber
        {
            get; set;
        }
        public override string ToString()
        {
            return SerialNumber.ToString();
        }
    }
}
