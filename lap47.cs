using System;
namespace Codelearn
{
	public class Lap47
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int answer = 1;
			for (int i = 1; i <= n; i++)
			{
				// answer *= i tương đương với answer = answer * i;
				answer *= i;
			}
			Console.Write(answer);
		}
	}
}

