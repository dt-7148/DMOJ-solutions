using System;

public class Program {
    public static void Main() {
        int n = Int32.Parse(Console.ReadLine());

        char[] answers = new char[n];
        char[] correct = new char[n];

        int correctAnswers = 0;

        for (int i = 0; i < n; i++) {
            answers[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++) {
            correct[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++) {
            if (answers[i] == correct[i]) {
                correctAnswers++;
            }
        }

        Console.WriteLine(correctAnswers);
    }
}
