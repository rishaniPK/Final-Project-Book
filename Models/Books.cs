using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Books
    {
        [Key] //Adding Primary key
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
