using System;

public class Program {
    public static void Main() {
        // gets the equation and removes the = from the end so you only have the terms
        string equation = Console.ReadLine();
        equation = equation.Substring(0, equation.Length - 1);

        // split the equation into terms - in sets of two, even number index and 0 are values and odd are operations 
        string[] terms = equation.Split(' ');

        int answer = 0;

        for (int i = 0; i < terms.Length - 3; i += 2) {
            int previousTerm;

            // make the first number either the first index number or the current answer value
            // because you will be either adding or subtracting to the previous term / sum of terms
            // if there is only the first term, you would set it to the first item
            // if it is not the first term, you would add/subtract from the sum of the previous numbers [answer]
			if (i == 0) {
				previousTerm = Int32.Parse(terms[i]);	
			}
			else {
				previousTerm = answer;	
			}
			
            int nextTerm = Int32.Parse(terms[i+2]);

            // if its plus, add the previous term with the next term
            // if its minus, subtract second term from previous term
            // previous term is num1
            switch (terms[i + 1]) {
                case "P":
                    answer = (previousTerm + nextTerm);
                    break;
                
                // this one is case "M"
                default:
                    answer = (previousTerm - nextTerm);
                    break;
            }
        }
		
		Console.WriteLine(answer);


    }
}