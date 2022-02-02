using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		int numGivenValues = Int16.Parse(Console.ReadLine());
		
		List<int> givenValues = new List<int>();
		
		for(int i = 0; i <= numGivenValues - 1; i++){
			givenValues.Add(Int32.Parse(Console.ReadLine()));
		}
		
		givenValues.Sort();
		givenValues.ForEach(Console.WriteLine);
		
	}
}
