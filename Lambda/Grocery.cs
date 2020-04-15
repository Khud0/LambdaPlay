using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class Grocery
    {
        public List<Vegetable> AllVegetables
        {
            get 
            {
                return new List<Vegetable>
                {
                    new Vegetable() { Name = "Cucumber", Color = "Green", Price = 1 },
                    new Vegetable() { Name = "PurpleVegetable", Color = "Purple", Price = 100 },
                    new Vegetable("Eggplant", "Purple", 4),
                    new Vegetable(color: "Purple"),
                    new Vegetable()
                };
            }
        }
    }
}
