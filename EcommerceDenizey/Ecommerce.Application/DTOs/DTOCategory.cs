using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOCategory
    {
        public string Name { get; set; }
    }

    public class DTOUpdateCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
