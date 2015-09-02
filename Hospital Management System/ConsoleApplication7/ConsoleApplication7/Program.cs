using System;

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double tax;
        if (money < 10000)
        {
            tax = .05 * money;
        }
        else if (money <= 100000)
        {
            tax = .08 * money;
        }
        else
        {
            tax = .1 * money;
        }

        Console.WriteLine("Tax is {0:C}", tax);
        Console.ReadKey();
    }
}