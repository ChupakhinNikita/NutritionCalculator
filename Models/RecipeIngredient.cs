using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Models
{
    internal class RecipeIngredient
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public double Quantity { get; set; }
    }
}
