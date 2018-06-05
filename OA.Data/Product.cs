using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class Product: BaseEntity
    {
        //public int Id { get; set; } "exist in base
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public virtual ProductProfile ProductProfile { get; set; }
    }
}
