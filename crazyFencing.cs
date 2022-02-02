using System;

public class Program {
    public static void Main() {
        // This is n
        Console.ReadLine();

        // each value separated by spaces
        string sides = Console.ReadLine();
        string bases = Console.ReadLine();

        string[] sidesArray = sides.Split(' ');
        string[] basesArray = bases.Split(' ');

        double sum = 0;

		for (int i = 0; i < sidesArray.Length - 1; i++) {
			double a = Double.Parse(sidesArray[i]);
            double b = Double.Parse(sidesArray[i + 1]);

            double baseVal = Double.Parse(basesArray[i]);

            double final = ((a+b) / 2) * baseVal;

            sum += final;
		}

        Console.WriteLine(sum);

    }
}
