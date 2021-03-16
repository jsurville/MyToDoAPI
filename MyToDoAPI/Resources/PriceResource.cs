using System;
using System.Runtime.Serialization;
using MyToApp.Models;

namespace MyToDoAPI.Resources
{
    [DataContract(Name="price")]
    public class PriceResource
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "value")]
        public decimal Value { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "creation_time")]
        public DateTime Creation_Time { get; set; }

        [DataMember(Name = "modification_time")]
        public DateTime Modification_Time { get; set; }

        public PriceResource(Price price)
        {
            Id = price.Id;
            Value = price.Value;
            Currency = price.Currency;            
            Creation_Time = price.Creation_Time;
            Modification_Time = price.Modification_Time;
        }
    }
}