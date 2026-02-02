using System;

namespace ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char op;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
                Console.WriteLine(a + b);
            else if (op == '-')
                Console.WriteLine(a - b);
            else if (op == '*')
                Console.WriteLine(a * b);
            else if (op == '/')
                Console.WriteLine(a / b);

            Console.ReadLine();
        }
    }
}
