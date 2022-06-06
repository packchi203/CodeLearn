using System;
namespace Codelearn
{
	public class Lap51
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int answer = 0;
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					answer++;
				}
			}
			Console.Write(answer);
		}
	}
}

