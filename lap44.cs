using System;
namespace Codelearn
{
	public class Lap44
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int answer = 0;
			for (int i = a; i <= b; i++)
			{
				// answer += i tương đương với answer = answer + i
				answer += i;
			}
			Console.WriteLine(answer);
		}
	}
	
}

