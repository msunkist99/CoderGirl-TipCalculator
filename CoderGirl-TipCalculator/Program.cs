using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your meal subtotal?");

            //string subTotal = Console.ReadLine();
            //double subTotalAmount = Convert.ToDouble(subTotal);

            double subTotalAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your tip percentage?  i.e - 20 = 20%");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            double tip = subTotalAmount * (tipPercentage / 100);

            Console.WriteLine("Your " + tipPercentage + "% tip is $" + tip);
            //Console.WriteLine("Your {0:P0} tip is {1:C}", (tipPercentage/100), tip);

            Console.WriteLine("Your bill total is $" + (subTotalAmount + tip));
            //Console.WriteLine("Your bill total is {0:C}", subTotalAmount + tip);

            Console.ReadLine();

        }
    }
}
