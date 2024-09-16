using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
