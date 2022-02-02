using System;

class AlpacaShapes {
    public static void Main() {
        // Gets the two numbers as input
        string input = Console.ReadLine();

        // Separates the two numbers
        // nums[0] is S, nums[1] is R
        string[] nums = input.Split(' ');
        
        double side = Double.Parse(nums[0]);
        double radius = Double.Parse(nums[1]);
    
        double areaSquare = Math.Pow(side, 2);
        double areaCircle = 3.14 * Math.Pow(radius, 2);

        if (areaSquare > areaCircle) {
            Console.WriteLine("SQUARE");
        }
        else {
            Console.WriteLine("CIRCLE");
        }
    }
}
