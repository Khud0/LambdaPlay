using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random lambda expression tests
            List<ILambdaExecuter> executers = new List<ILambdaExecuter>()
            {
                new LambdaOneArgument(),
                new LambdaMultipleArguments(),
                new LambdaNoArguments(),
                new LambdaFindAll(),
                new LambdaLinqSelect()
            };

            foreach (ILambdaExecuter executer in executers)
            {
                executer.Execute();
            }          
        }
    }
}
