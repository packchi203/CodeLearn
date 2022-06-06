using System;
namespace Codelearn
{
	public class Lap55
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				Console.Write(i + " ");
			}
		}
	}
}

