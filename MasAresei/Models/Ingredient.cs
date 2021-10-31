using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class Ingredient
    {
        //public Ingredient()
        //{
        //    Foods = new HashSet<Food>();
        //}
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
