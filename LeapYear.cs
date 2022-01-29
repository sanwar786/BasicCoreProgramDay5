using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramDay5
{
    internal class LeapYear
    {
        public static void FindLeapYear()
        {
            int Check_Year;
            Console.WriteLine("\n\n");
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            Check_Year = Convert.ToInt32(Console.ReadLine());

            if ((Check_Year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", Check_Year);
            else if ((Check_Year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", Check_Year);
            else if ((Check_Year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", Check_Year);
            else
                Console.WriteLine("{0} is not a leap year.\n", Check_Year);
        }
    }
}
