using System;
namespace Codelearn
{
	public class Lap28
	{
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping, a = " + a + ", b = " + b);
        }

    }
}

