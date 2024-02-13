using System;

public class Exercise5
{
    
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        temp = number1;
        number1 = number2;
        number2 = temp;

        
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + number1); // Displaying the first number after swapping
        Console.Write("\nSecond Number : " + number2); // Displaying the second number after swapping

        Console.Read(); // Keeping the console window open until a key is pressed
    }
}
