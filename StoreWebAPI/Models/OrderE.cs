using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace StoreWebAPI.Models
{
    [DataContract(Name = "Order", Namespace = "")]
    public class OrderE
    {      
        public OrderE(int id, Nullable<decimal> amount, string invoiceNo, string email, string currency)
        {
            this.id = id;
            this.amount = amount;
            this.storeId = 781343;
            this.invoiceNo = invoiceNo;
            this.email = email;
            this.currency = currency;
        }

        [DataMember(Name = "Id")]
        public int id { get; set; }
        [DataMember(Name = "Amount")]
        public Nullable<decimal> amount { get; set; }
        [DataMember(Name = "StoreId")]
        public int storeId { get; set; }
        [DataMember(Name = "InvoiceNo")]
        public string invoiceNo { get; set; }
        [DataMember(Name = "Email")]
        public string email { get; set; }
        [DataMember(Name = "OrderDate")]
        public Nullable<System.DateTime> orderDate { get; set; }
        [DataMember(Name = "Currency")]
        public string currency { get; set; }

    }
}