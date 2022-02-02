using System;

public class Program {
    public static void Main() {
        int numCases = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < numCases; i++) {
            
            int findLargerThan = Int32.Parse(Console.ReadLine());

            long correctCube = findLargerThan + 1;

            string value = Math.Pow(correctCube, 3).ToString();
			
            // the bug before was that value.length would be less than 3 in earlier cases, 
            // which would give an error of the substring 
            /*
                for example, if 1 was entered
                correctCube would be 2
                then value would be 8
                if we tried to substring with value.length - 3, we would get a negative because 
                the string has a length less than 3
                so we put this loop here to keep looping until we get at least 3 digits
                    because less than 2 digits will guarantee you can't end with 888, a three digit number
            */
			while (value.Length <= 3) {
				correctCube++;
                value = Math.Pow(correctCube, 3).ToString();
			}
			
            while (Int32.Parse(value.Substring(value.Length - 3)) != 888) {
                correctCube++;
                value = Math.Pow(correctCube, 3).ToString();

            }
			
			Console.WriteLine(correctCube);


        }
    }
}