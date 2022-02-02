using System;
using System.Collections.Generic;

class Test {
    public static void Main() {
        Console.ReadLine();

        string problems = Console.ReadLine();

        HashSet<int> uniqueProblems = new HashSet<int>();

        string[] separatedProblems = problems.Split(" ");

        foreach (string problem in separatedProblems) {
            uniqueProblems.Add(Int32.Parse(problem));
        }

        Console.WriteLine(uniqueProblems.Count);
    }
}
