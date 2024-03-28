using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlan
{
    public class Meal
    {
        public Food Meat { get; }
        public Food Cereal { get; }
        public Food Vegetable { get; }
        public Food Dairy { get; }


        public Meal(Food meat, Food cereal, Food vegetable, Food dairy)
        {
            Meat = meat;
            Cereal = cereal;
            Vegetable = vegetable;
            Dairy = dairy;
        }

        public decimal CalculatePrice()
        {

            return Meat.Price + Cereal.Price + Dairy.Price + Vegetable.Price;
        }

        public int CalculateCalories()
        {
            return Meat.Calories + Cereal.Calories + Dairy.Calories + Vegetable.Calories;
        }
    }
}
