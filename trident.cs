using System;

public class program {
    public static void Main() {
        int height = Int32.Parse(Console.ReadLine());
        int spaces = Int32.Parse(Console.ReadLine());
        int handleLength = Int32.Parse(Console.ReadLine());
        
        int length = 3 + (2 * spaces);
        int mid = length / 2;

        string prong = ""; 
        string hilt = "";
        string handle = "";

        
        for (int i = 0; i < 5; i++) {
            if ((i == 0) || (i == 2) || (i == 4)) {
                prong += "*";
            }
            else {
                for (int j = 0; j < spaces; j++) {
                    prong += " ";
                }
            }
        }

        for (int k = 0; k < length; k++) {
            hilt += "*";
        }

        for (int l = 0; l <= mid; l++) {
            if (l != mid) {
                handle += " ";
            }
            else {
                handle += "*";
            }
        }

        for (int m = 0; m < height; m++) {
            Console.WriteLine(prong);
        }

        Console.WriteLine(hilt);

        for (int n = 0; n < handleLength; n++) {
            Console.WriteLine(handle);
        }

    }
}
