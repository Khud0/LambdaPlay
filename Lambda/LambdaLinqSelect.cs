using System;
using System.Linq;

namespace Lambda
{
    class LambdaLinqSelect: ILambdaExecuter
    {
        public void Execute()
        {
            string[] words = { "Ape", "Pancake", "Parrot", "Lettuce", "Easter" };
            var firstLetters = words.Select(word => word.Substring(0, 1));
            Console.WriteLine(string.Join(".", firstLetters));
        }
    }
}
