using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace StoreWebAPI.Models
{
    [DataContract]
    public class OrderE
    {      
        public OrderE(int id, Nullable<decimal> amount, string invoiceNo, string email)
        {
            this.id = id;
            this.amount = amount;
            this.storeId = 1234;
            this.invoiceNo = invoiceNo;
            this.email = email;
        }

        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<decimal> amount { get; set; }
        [DataMember]
        public int storeId { get; set; }
        [DataMember]
        public string invoiceNo { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public Nullable<System.DateTime> OrderDate { get; set; }
    }
}