using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Models
{
    internal class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<RecipeIngredient> Ingredients { get; set; } = new();
    }
}
