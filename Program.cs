using System;

class Program
{
    static void Main()
    {
        Console.Write("How old are you: ");
        int age;

        while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
        {
            Console.Write("Invalid input: please enter a POSITIVE number: ");
        }

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are less than 18 years old and NOT eligible to vote.");
        }
    }
}
