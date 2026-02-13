using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        float num2 = 5.5f;

        float automaticConversion = num1;

        int forcedConversion = (int)num2;

        Console.WriteLine("Integer value: " + num1);
        Console.WriteLine("Float value: " + num2);
        Console.WriteLine("After automatic conversion (int to float): " + automaticConversion);
        Console.WriteLine("After forced conversion (float to int): " + forcedConversion);
    }
}
