using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Customer
    {
        [Key] //Adding Primary key

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Phone { get; set; }

        public string Email { get; set; }

    }
}
