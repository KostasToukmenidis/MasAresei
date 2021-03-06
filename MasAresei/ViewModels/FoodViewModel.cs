using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Migrations;
using MasAresei.Models;

namespace MasAresei.ViewModels
{
    public class FoodViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Food Category")]
        public string CategoryName { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; } = new HashSet<Ingredient>();
    }
}
