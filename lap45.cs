﻿using System;
namespace Codelearn
{
	public class Lap45
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int answer = 0;
			for (int i = 0; i <= n; i++)
			{
				if (i % 2 != 0)
				{
					answer += i;
				}
			}
			Console.WriteLine(answer);
		}
	}
}

