using System;

public class program
{

    public static void Main(string[] args)
    {

        int number1, number2, temp;


        Console.Write("\nInput the First Number : ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("\nInput the Second Number : ");
        number2 = int.Parse(Console.ReadLine());

        temp = number1;
        number1 = number2;
        number2 = temp;


        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + number1); // Displaying the first number after swapping
        Console.Write("\nSecond Number : " + number2); // Displaying the second number after swapping

        Console.Read(); // Keeping the console window open until a key is pressed
    }
}
