using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class LambdaNoArguments : ILambdaExecuter
    {
        public void Execute()
        {
            Action writeLine = () => 
            {
                Console.WriteLine("Magic WriteLine");
                Console.WriteLine("Magic WriteLine 2");
            };
            writeLine += () => Console.WriteLine("Magic WriteLine 3");
            writeLine();
        }
    }
}
