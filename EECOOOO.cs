using System;

class ECOOAcronym {
    public static void Main() {
        // T, the number of test cases
        int numCases = Int32.Parse(Console.ReadLine());

        // Wills store all of the acronyms
        string[] acronyms = new string[numCases];

        // Adds the acronyms to the array
        for (int i = 0; i < numCases; i++) {
            acronyms[i] = Console.ReadLine();
        }

        // Goes through each acronym
        foreach (string acronym in acronyms) {

            int oCounter = 1;

            // This will go through each character in each acronym
            foreach (char a in acronym) {
                if (a == 'E') {
                    Console.Write("Educational ");
                } 
                else if (a == 'C') {
                    Console.Write("Computing ");
                }
                else if (a == 'O' && oCounter == 1) {
                    oCounter = 2;
                }
                else {
                    Console.Write("Organization of Ontario ");
                    oCounter = 1;
                }
            }
            Console.WriteLine("");
        }
    }
}
