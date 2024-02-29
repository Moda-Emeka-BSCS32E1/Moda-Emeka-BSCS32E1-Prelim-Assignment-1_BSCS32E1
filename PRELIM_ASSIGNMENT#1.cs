using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Calculate the area of a triangle
        Console.Write("Enter the base of the triangle: ");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());

        double triangleArea = 0.5 * triangleBase * triangleHeight;
        Console.WriteLine($"The area of the triangle is {triangleArea}");

        // Declare an array of 5 integers and fill it with values based on a user-defined formula
        int[] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter a number for index {i}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number * number;  // The user-defined formula is n^2
        }

        // Print the largest element in the array
        int maxElement = array.Max();
        Console.WriteLine($"The largest element in the array is {maxElement}");

        // Implement a simple for loop that iterates from 1 to 10 and prints each number along with its square root
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Number: {i}, Square root: {Math.Sqrt(i)}");
        }
    }
}
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Calculate the area of a triangle
        Console.Write("Enter the base of the triangle: ");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());

        double triangleArea = 0.5 * triangleBase * triangleHeight;
        Console.WriteLine($"The area of the triangle is {triangleArea}");

        // Declare an array of 5 integers and fill it with values based on a user-defined formula
        int[] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter a number for index {i}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number * number;  // The user-defined formula is n^2
        }

        // Print the largest element in the array
        int maxElement = array.Max();
        Console.WriteLine($"The largest element in the array is {maxElement}");

        // Implement a simple for loop that iterates from 1 to 10 and prints each number along with its square root
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Number: {i}, Square root: {Math.Sqrt(i)}");
        }
    }
}
