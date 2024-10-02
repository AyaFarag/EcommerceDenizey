using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IQuestionRepository : IRepository<QuestionAnswer>
    {
        Task<List<QuestionAnswer>> GetAllQuestionswithAnswersByProductId(int productId);
    }
}
