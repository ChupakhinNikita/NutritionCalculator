using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalculator.Models
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; } // К

        public double Protein { get; set; } // Б

        public double Fat { get; set; } // Ж

        public double Carbohydrates { get; set; } // У
    }
}
