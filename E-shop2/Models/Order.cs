﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using E_shop2.Models;
namespace E_shop2.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        // [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Required, StringLength(11, ErrorMessage = "Phone Number Must be 11 Digit")]
        public string Phone { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Add True Address can't be less than 4 longer than 100 characters")]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Price should contain numbers only")]
        public decimal TotalPrice { get; set; }


        public int UserID { get; set; }
        public virtual Payment Payments { get; set; }
        public virtual User Users { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
