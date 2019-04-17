using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  Created By Keith Mitchell
 *  Date 04 April 2019
 *  
 *  Problem - Find PI to the Nth Digit, Within a set limit
 *  
 *  Solution - Determine Value of PI
 *             Get Input from user for amount of digits to display
 *             Validate their input
 *             Display appropriate Value
 */






namespace PIToTheNth
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            string value;

            //Get user input to determine decimals to display, ensure data is valid before proceeding.
            do
            {
                Console.WriteLine("Find Pi to the Nth Digit");
                Console.WriteLine("Enter Value for how many decimals to display - Limit is 14");
                value = Console.ReadLine();
            } while (IsDigitsOnly(value) == false);

            //if the string value is greater than limit, set it to round to 14.
            //Otherwise convert string value to integer as normal

            if (Convert.ToInt16(value) >= 15)
            {
                Console.WriteLine(Math.Round(Pi, 14));
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine(Math.Round(Pi, Convert.ToInt16(value)));
                Console.ReadKey(true);
            }

        }
        //Check to see if user entered a number
        public static bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
