using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPage.Models
{
    public class ProductProfile : BaseEntity
    {
        public string ViderDescription { get; set; }
        public string Country { get; set; }
        public string ResponsibleLName { get; set; }
        public virtual Product Product { get; set; }
    }
}
