using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class LambdaFindAll : ILambdaExecuter
    {
        public void Execute()
        {
            List<Vegetable> vegetables = new Grocery().AllVegetables;
            List<Vegetable> purplePlants = vegetables.FindAll(vegetable => vegetable.Color == "Purple");

            foreach (Vegetable purplePlant in purplePlants)
            {
                Console.WriteLine($"Purple plant: {purplePlant.Name}");
            }
        }
    }
}
