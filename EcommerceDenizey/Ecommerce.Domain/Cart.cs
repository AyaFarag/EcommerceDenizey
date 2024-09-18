﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Cart
    {
        public int Id { get; set; }

        public int UserId { get; set; } 
        public User User { get; set; }
        public double Total { get ; set; }

       public ICollection<CartItem> CartItems { get; set; }
    }
}
