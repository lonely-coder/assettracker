using System;

namespace FAS
{
    public class AssetsModel 
    {
        public int Id {get; set;        }
        public string PropertyTag{get;set;}
        public int EmployeeId {get; set;}
        public Employee Employee { get; set; }
        public Items Items {get; set;}
        public Serial Serial { get; set; }
        public double Price {get; set;}
        public int Quantity {get; set;}
        public DateTime DateAcquired {get; set;}

    }
}
