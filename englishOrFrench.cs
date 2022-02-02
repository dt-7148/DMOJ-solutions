using System;
using System.Collections.Generic;		

public class Program
{
	public static void Main()
	{
		int numInputs = Int16.Parse(Console.ReadLine());
		List<string> textInputs = new List<string>();
		
		for(int i = 0; i <= numInputs - 1; i++){
			textInputs.Add(Console.ReadLine());
		}
		
		int numTs = 0;
		int numSs = 0;
		
		foreach (string currentSentance in textInputs){
			foreach (char currentLetter in currentSentance){
				switch (currentLetter){
					case 't':
						numTs++;
						break;
					case 'T':
						numTs++;
						break;
					case 's':
						numSs++;
						break;
					case 'S':
						numSs++;
						break;
				}
			}
		}
		
		if (numTs > numSs){
			Console.WriteLine("English");
		} else {
			Console.WriteLine("French");	
		}
	}
}
