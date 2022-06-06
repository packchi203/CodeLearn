using System;
namespace Codelearn
{
	public class Lap33
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			if (n == 0)
			{
				Console.WriteLine("n is equal to 0");
			}
			else if (n < 0)
			{
				Console.WriteLine("n is a negative number");
			}
			else
			{
				Console.WriteLine("n is a positive number");
			}
		}
	}
}

