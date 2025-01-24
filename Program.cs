using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print out the prompt to ask for principal amount input
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            //collect the user input for principal amount
            int print = Convert.ToInt32(Console.ReadLine());


            //print out the prompt to ask for interest rate input
            Console.WriteLine("What is the interest rate? (Input 0.05 for 5%)");
            //collect the user input for interest rate
            double rate = Convert.ToDouble(Console.ReadLine());


            //print out the prompt to ask for period of lone input
            Console.WriteLine("What is the period of the loan in years?");
            //collect the user input for period of lone
            int years = Convert.ToInt32(Console.ReadLine());

            //multiplies all inputs to get the interest of the loan
            double interest = print * rate * years;

            //print out the message with interest amount
            Console.WriteLine($"Total interest of loan is: {interest}.");

            //pause screen to read output
            Console.ReadLine();
        }
    }
}
