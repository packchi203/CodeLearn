using System;

namespace Codelearn
{
    public class lap58
    {
		static void Main(string[] args)
		{
			int[] a = new int[10];

			for (int i = 0; i < 10; i++)
			{
				a[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < 10; i++)
			{
				Console.Write(a[i] + " ");
			}
		}
	}
}

