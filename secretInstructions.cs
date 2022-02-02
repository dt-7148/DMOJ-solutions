using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        List<string> instructions = new List<string>();

        while (true) {
            string input = Console.ReadLine();

            if (input == "99999") {
                break;
            }
            else {
                instructions.Add(input);
            }
        }

		// arbitrary value
        int previousOperation = 42;

        foreach (string step in instructions) {
            // the step[index] values have to undergo ToString() because it is a char, and Parse does not support char conversion to int [rpob because char is already an ascii value int]
            int sum = Int32.Parse(step[0].ToString()) + Int32.Parse(step[1].ToString());

            // the last three digits, you could probably just have this as a string and remove the parse
            int trailingNums = Int32.Parse(step.Substring(2));

            if (sum == 0) {
                switch (previousOperation) {
                    case 0:
                        Console.WriteLine("right " + trailingNums);
                        break;
                    case 1:
                        Console.WriteLine("left " + trailingNums);
                        break;
                }
            }
            else if (sum % 2 == 0) {
                Console.WriteLine("right " + trailingNums);
                previousOperation = 0;
            }
            else {
                Console.WriteLine("left " + trailingNums);
                previousOperation = 1;
            }
        }

    }
}