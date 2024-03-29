using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlan
{
    public class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public static decimal Quantity { get; set; }

        public Food(string name, decimal price, int calories)
        {
            Name = name;
            Price = SetPrice(price);
            Calories = calories;
        }

        private decimal SetPrice(decimal price)
        {
            return price * Quantity;
        }

        public override string ToString()
        {

            return $"{Name} | Price: {Price} | Calories: {Calories}";

        }

    }
}
