using System;

public class Program {
    public static void Main() {
        int numPeople = Int32.Parse(Console.ReadLine());

        string[] peopleList = new string[numPeople];
        int[] bids = new int[numPeople];

        for (int i = 0; i < numPeople; i++) {
            peopleList[i] = Console.ReadLine();
            bids[i] = Int32.Parse(Console.ReadLine());
        }

        int largestIndex = 0;
        int largest = bids[0];

        for (int i = 1; i < numPeople; i++) {
            if (bids[i] > largest) {
                largest = bids[i];
                largestIndex = i;
            }
        }

        Console.WriteLine(peopleList[largestIndex]);

    }
}