using System;
using System.Collections.Generic;				

public class Program
{
	public static void Main()
	{
		List<int> data = new List<int>();
		
		int numItems = Int32.Parse(Console.ReadLine());
		
		for (int i = 0; i < numItems; i++) {
			data.Add(Int32.Parse(Console.ReadLine()));
		}
		
		data.Sort();
		
		foreach (int element in data) {
			Console.WriteLine(element);
		}
	}
	
}
