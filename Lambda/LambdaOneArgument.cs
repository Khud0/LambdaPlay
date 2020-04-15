using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class LambdaOneArgument : ILambdaExecuter
    {
        // args => expression

        // Example:
        // number => number*number
        // number _goes to_ expression

        public void Execute()
        {   
            Func<int, int> square = number => number*number;
            Console.WriteLine($"Square of 5: {square(5)}");
        }
    }
}
