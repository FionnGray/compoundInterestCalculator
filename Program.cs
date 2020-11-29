using System;

namespace compoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {   //Prompt the user for initial variables
            Console.WriteLine("What's your starting amount?");
            double presentValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What's your expected annual interest? (Please leave out the % sign)");
            double annualReturn = (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("How much will you be contributing per month? (If you want be contributing anything, please input 0.)");
            double monthlyContr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("For how many years will you accrue interest?");
            int periodMonths = Convert.ToInt32(Console.ReadLine());


            //Calculations
            double v = (annualReturn / 12);
            double futureValue = (presentValue * (Math.Pow(1 + v, periodMonths * 10))) + monthlyContr * (Math.Pow(1 + v, (periodMonths * 10) - 1) / v * (annualReturn + v));
            Console.WriteLine(futureValue);

        }
    }
}
