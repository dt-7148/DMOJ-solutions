using System;
					
public class Program {
	public static void Main() {
		string a = Console.ReadLine();
        string b = Console.ReadLine();

        string sortedA = removeSpaces(sortString(a));
        string sortedB = removeSpaces(sortString(b));

        if (sortedA.Equals(sortedB)) {
            Console.WriteLine("Is an anagram.");
        }
        else {
            Console.WriteLine("Is not an anagram.");
        }
	}
	
	private static string sortString(string input) {
		char[] inputArray = input.ToCharArray();
        Array.Sort(inputArray);
        return new string(inputArray);
	}

    private static string removeSpaces(string input) {
        string noSpaces = "";

        foreach (char cur in input) {
            if (cur != ' ') {
                noSpaces += cur;
            }
        }

        return noSpaces;

    }
}
