using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasAresei.Interfaces;

namespace MasAresei.Models
{
    public class Order
    {
        public int Id { get; set; }

        [DataType(dataType:DataType.DateTime)]
        public DateTime DateTime { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }

        //public virtual ICollection<Food> OrderedFood { get; set; }
    }
}
