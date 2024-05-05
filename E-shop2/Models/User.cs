using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_shop2.Models;
using Microsoft.AspNetCore.Identity;


namespace E_shop2.Models
{
    public enum Gender
    {
        Female, Male
    }
    public class User:IdentityUser
    {

        [Required, StringLength(14)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "National ID Not Valid")]
        public String NationalID { get; set; } = "";

        [Required, StringLength(20, MinimumLength = 3, ErrorMessage = "First Name can't be less than 3 and longer than 20  characters")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; } = "";

        [Required, StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name can't be less than 3 and longer than 20 characters")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; } = "";

        [StringLength(100, MinimumLength = 4, ErrorMessage = "Add True Address can't be less than 4 longer than 100 characters")]
        public string Address { get; set; } = "";
        [Required]
        public Gender Gender { get; set; } 

        [CreditCard]
        public string CreditCardNumber { get; set; } = "";



        public ICollection<Order> Orders { get; set; }
        public virtual Cart Carts { get; set; }


    }
}
