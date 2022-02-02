using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string currentQuestion;
		int currentIndex;
		List<string> finalQuestions = new List<string>(new string[5]);
		
		for (int i = 0; i <= 4; i++){
			currentQuestion = Console.ReadLine();
			currentIndex = Int32.Parse(Console.ReadLine());
			finalQuestions[currentIndex - 1] = currentQuestion;
		}
		
		for (int i = 0; i <= 4; i++){
			Console.WriteLine(finalQuestions[i]);
		}
	}
}
