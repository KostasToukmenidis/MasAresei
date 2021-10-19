using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Food> FoodsList { get; set; }
    }
}
