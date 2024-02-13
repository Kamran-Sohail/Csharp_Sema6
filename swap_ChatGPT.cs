using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, temp;

        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

        // Swapping logic using a temporary variable
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        Console.Read();
    }
}