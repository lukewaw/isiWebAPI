//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Order
    {
        [DataMember]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string InvoiceNo { get; set; }
        [DataMember]
        public Nullable<decimal> Amount { get; set; }
        public bool Unpaid { get; set; }


    }
}