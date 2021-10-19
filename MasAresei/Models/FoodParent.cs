using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class FoodParent
    {
        public int Quantity { get; set; } = 1;
        public string Name { get; set; }
        public Decimal Price { get; set; } = 0m;
    }
}
