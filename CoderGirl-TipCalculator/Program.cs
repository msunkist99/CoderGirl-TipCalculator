using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // get meal subtotal from user
            Console.WriteLine("What is your meal subtotal?");
            double subTotalAmount = Convert.ToDouble(Console.ReadLine());

            // get tip percentage from user
            Console.WriteLine("What is your tip percentage?  i.e - 20 = 20%");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            string xxx = null;

            

            // calculate tip
            double tip = Math.Round( subTotalAmount * (tipPercentage / 100), 2);

            // display calculated tip amount --- using interpolation
            Console.WriteLine($"Your {tipPercentage}% tip is ${tip}.");
            //Console.WriteLine("Your {0:P0} tip is {1:C}", (tipPercentage/100), tip);

            // display calculated total of meal and tip ---- using interpolation
            Console.WriteLine($"Your bill total is ${subTotalAmount + tip}.");
            //Console.WriteLine("Your bill total is {0:C}", subTotalAmount + tip);

            Console.ReadLine();
            
        }
    }
}
