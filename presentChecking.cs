using System;
					
public class Program
{
	public static void Main()
	{
		bool matching = true;
		
		int num = Int32.Parse(Console.ReadLine());
		
		int[] origNums = new int[num];
		
		for (int i = 1; i <= num; i++) {
			origNums[i - 1] = i;	
		}
		
		string input = Console.ReadLine();
		
		string[] subsInput = input.Split(' ');
		int[] intSubsInput = new int[num];
		
		for (int i = 0; i < num; i++) {
			intSubsInput[i] = Int32.Parse(subsInput[i]);
		}
		
		Array.Sort(intSubsInput);
		
		for (int i = 0; i < num; i++) {
			if (origNums[i] != intSubsInput[i]) {
				matching = false;
				break;
			}
		}
		
		if (matching) {
			Console.WriteLine("YES");	
		}
		else {
			Console.WriteLine("NO");	
		}
		
	}
}
