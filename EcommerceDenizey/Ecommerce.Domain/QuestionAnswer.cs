using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime date { get; set; }
        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public QuestionAnswer Answers { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }  
        public Product Product { get; set; }
    }
}
