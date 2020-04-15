using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class Vegetable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Vegetable(string name = "Default Vegetable",
                         string color = "Default Color",
                         int price = -1)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
