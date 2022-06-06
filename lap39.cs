using System;

namespace Codelearn
{
    public class lap39
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 10)
            {
                Console.WriteLine("The score is valid");
            }
            else
            {
                Console.WriteLine("The score is not valid");
            }
        }
    }
}

