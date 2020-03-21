using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoAppCS.Models
{
    public class OrderSearch
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        
        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; }
        
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }
        
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
    }
}