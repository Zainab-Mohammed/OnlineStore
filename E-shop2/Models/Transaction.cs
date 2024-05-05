using E_shop2.Models;
using System.ComponentModel.DataAnnotations;
namespace E_shop2.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
