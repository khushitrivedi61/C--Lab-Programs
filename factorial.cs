using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial of " + num + " is " + fact);

    }
}
