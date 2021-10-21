using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Category")]
        public int FoodCategoryId { get; set; }

        public FoodCategory FoodCategory { get; set; }

        public List<Ingridient> Ingridients { get; set; }
    }
}
