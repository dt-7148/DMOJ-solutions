using System;

public class Program {
    public static void Main() {
        // gets the equation and removes the = from the end so you only have the terms
        string equation = Console.ReadLine();
        equation = equation.Substring(0, equation.Length - 1);

        // split the equation into terms - in sets of two, even number index and 0 are values and odd are operations 
        string[] terms = equation.Split(' ');

        // reminder: 0 % 1 and 2 are both true, so make a cusotm conditional for it
        // 0 1 2, 2 3 4, so + 2 each time

        int answer = 0;

        for (int i = 0; i < terms.Length - 3; i += 2) {
            int num1;
			if (i == 0) {
				num1 = Int32.Parse(terms[i]);	
			}
			else {
				num1 = answer;	
			}
			
            int num2 = Int32.Parse(terms[i+2]);

            switch (terms[i + 1]) {
                case "P":
                    answer = (num1 + num2);
                    break;
                
                // this one is case "M"
                default:
                    answer = (num1 - num2);
                    break;
            }
        }
		
		Console.WriteLine(answer);


    }
}
