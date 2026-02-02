using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, r, t, si;

            p = Convert.ToDouble(Console.ReadLine());
            r = Convert.ToDouble(Console.ReadLine());
            t = Convert.ToDouble(Console.ReadLine());

            si = (p * r * t) / 100;
            Console.WriteLine(si);

            Console.ReadLine();
        }
    }
}
