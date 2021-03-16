using System;
using System.ComponentModel.DataAnnotations;

namespace MyToApp.Models
{
    public class Price
    {
        [Required]
        public int Id { get; set; }

        public decimal Value { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public DateTime Creation_Time { get; set; }

        [Required]
        public DateTime Modification_Time { get; set; }
    }
}
