using System;
namespace Codelearn
{
	public class Lap48
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					Console.Write(i + " ");
				}
			}
		}
	}
	
}

