using System;

public class Program {
    public static void Main() {
        
        // gets m
        int rows = Int32.Parse(Console.ReadLine());


        // gets n
        int columns = Int32.Parse(Console.ReadLine());

        string[,] table = new string[rows, columns];

        for (int a = 0; a < rows; a++) {
            for (int j = 0; j < columns; j++) {
                table[a, j] = "B";
            }
        }

        // gets k
        int numChanges = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < numChanges; i++) {
            string change = Console.ReadLine();

            string[] data = change.Split(' ');
            string rowOrColumn = data[0];
            int value = Int32.Parse(data[1]) - 1;

            if (rowOrColumn == "R") {
                for (int j = 0; j < rows; j++) {
                    if (table[value, j] == "B") {
                        table[value, j] = "G";
                    }
                    else {
                        table[value, j] = "B"; 
                    }
                }
            }
            else {
                for (int j = 0; j < table.Length; j++) {
                    if (table[j, value] == "B") {
                        table[j, value] = "G";
                    }
                    else {
                        table[j, value] = "B";
                    }
                }
            }


        int numGold = 0;
        
        for (int k = 0; k < rows; k++) {
            for (int l = 0; l < columns; l++) {
                if (table[k, l] == "G") {
                    numGold++;
                }
            }
        }

        Console.WriteLine(numGold);
        int num = Console.ReadLine();

        }
    }
}