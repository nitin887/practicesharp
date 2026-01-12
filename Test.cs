using System;
using System.Collections.Generic;

class Test
{
	static void Main()
	{
		List<int> list = new List<int>();

		if (list.Count > 0)
			Console.WriteLine(list[0]);
		else
			Console.WriteLine("List is empty");
	}
}
