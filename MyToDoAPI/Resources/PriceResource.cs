using System.Runtime.Serialization;
using MyToDoAPI.Models;

namespace MyToDoAPI.Resources
{
    [DataContract(Name="price")]
    public class PriceResource
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        public PriceResource(Price price)
        {
            Id = price.Id;
            Value = price.Value;
        }

    }
}