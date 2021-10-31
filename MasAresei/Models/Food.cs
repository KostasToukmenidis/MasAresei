﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAresei.Models
{
    public class Food
    {
        //public Food()
        //{
        //    Ingredients  = new HashSet<Ingredient>();
        //}
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Category")]
        public int FoodCategoryId { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
