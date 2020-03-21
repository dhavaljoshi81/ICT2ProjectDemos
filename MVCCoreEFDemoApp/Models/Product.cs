using System;
using System.Collections.Generic;

namespace MVCCoreEFDemoApp.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
