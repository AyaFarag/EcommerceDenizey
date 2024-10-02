using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public required string FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        public string? Password { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }

        [NotMapped]
        public Cart Cart { get; set; }

        public ICollection<ReplyReview> ReplyReviews { get; set; }

        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }



    }
}
