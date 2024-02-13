using System;

public class program
{

    public static void Main(string[] args)
    {

        int num1, num2, temp;


        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        temp = num1;
        num1 = num2;
        num2 = temp;


        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + num1); // Displaying the first number after swapping
        Console.Write("\nSecond Number : " + num2); // Displaying the second number after swapping

        Console.Read(); // Keeping the console window open until a key is pressed
    }
}