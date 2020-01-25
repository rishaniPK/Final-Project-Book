using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Review
    {

        [Key] //Adding Primary key
        public int ReviewID { get; set; }
        public Customer Customers { get; set; }
        public Books Books { get; set; }
        public String Reviews { get; set; }

        public Decimal Rate { get; set; }

    }
}
