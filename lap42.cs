using System;
namespace Codelearn
{
	public class Lap42
	{
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}

