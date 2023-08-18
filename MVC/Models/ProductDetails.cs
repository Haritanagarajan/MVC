using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Valid Product Name")]
        [RegularExpression(@"([A-Za-z]){5,}")]
        [StringLength(10,MinimumLength = 8,ErrorMessage ="String length is less than 10 words")]
        public string Prodname { get; set; }

        [Required(ErrorMessage = "Enter the Product Price")]
        [RegularExpression(@"[0-9]{4}")]
        public double ProPrice { get; set; }

        [Required(ErrorMessage = "Enter the Product Quantity")]
        [RegularExpression(@"[0-9]")]
        public int ProInStock { get; set; }
    }
}