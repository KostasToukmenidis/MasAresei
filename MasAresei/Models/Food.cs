using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class Food
    {
        public int Id { get; set; }
        public int FoodCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Ingridient> IngridientsList { get; set; }
    }
}
