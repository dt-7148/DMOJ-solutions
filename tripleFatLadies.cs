using System;

public class Program {
    public static void Main() {
        int numCases = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < numCases; i++) {
            
            int findLargerThan = Int32.Parse(Console.ReadLine());

            long correctCube = findLargerThan + 1;

            string value = Math.Pow(correctCube, 3).ToString();
			
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
