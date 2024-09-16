using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }  // 1
        public Order Order { get; set; }

        public int ProductId { get; set; }  // 1 
        public Product Product { get; set; }

        public int Quantity { get; set; } // 2

        [Required]
        public decimal UnitPrice { get; set; } //200
    }
}
