using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class LambdaMultipleArguments : ILambdaExecuter
    {
        public void Execute()
        {   
            Func<int, int, int, int> sumOfThree = (number1, number2, number3) => number1 + number2 + number3;
            Console.WriteLine($"Sum of 3 + 4 + 10 = {sumOfThree(3, 4, 10)}");
        }
    }
}
