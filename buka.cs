using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		string firstNum = Console.ReadLine();
		string currentOperator = Console.ReadLine();
		string secondNum = Console.ReadLine();
		
		List<char> numList = new List<char>();
		
		if (currentOperator == "+"){
			if(firstNum.Length >= secondNum.Length){
				for (int i = 0; i <= firstNum.Length - 1; i++){
				numList.Add(firstNum[i]);
			  }	
			} else {
				for (int i = 0; i <= secondNum.Length - 1; i++){
				numList.Add(secondNum[i]);
			}	
			}
			
			int replaceValueIndex = firstNum.Length - secondNum.Length;
			
			if(replaceValueIndex < 0){
				replaceValueIndex = secondNum.Length - firstNum.Length;	
			}
			
			if (numList[replaceValueIndex] == '1'){
				numList[replaceValueIndex] = '2';
			} else {
				numList[replaceValueIndex] = '1';	
			}
			
			numList.ForEach(Console.Write);
			
		} else {
			Console.Write('1');
			for(int i = 0; i <= ((firstNum.Length - 1) + (secondNum.Length - 1)) - 1; i++){
				Console.Write('0');
			}
		}
	}
}
