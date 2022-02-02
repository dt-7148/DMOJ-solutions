using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        
        int numOperations;
        string operation;
        int studentNum;
        string curOperation;

        numOperations = Int32.Parse(Console.ReadLine());

        List<int> students = new List<int>();

        for (int i = 0; i < numOperations; i++) {
            curOperation = Console.ReadLine();

            // F E or R
            operation = curOperation.Substring(0, 1);

            // The current student the operation is being performed on
            studentNum = Int32.Parse(curOperation.Substring(curOperation.IndexOf(" ") + 1));

            if (operation.Equals("F")) {
                students.Insert(0, studentNum);
            }
            else if (operation.Equals("E")) {
                students.Add(studentNum);
            }
            else {
                students.Remove(studentNum);
            }
        }

        foreach (int num in students) {
            Console.WriteLine(num);
        }
    }
}
