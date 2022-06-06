using System;
namespace Codelearn
{
	public class Lap25
	{
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a % b = " + (a - b * (a / b)));
        }
    }
}

