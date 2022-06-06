using System;
namespace Codelearn
{
	public class Lap53
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			for (int i = a; i <= b; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.Write(i + " ");
				}
			}
		}
	}
}

