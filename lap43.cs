using System;
namespace Codelearn
{
	public class Lap43
	{
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= -n; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}

