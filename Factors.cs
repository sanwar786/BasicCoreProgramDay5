using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramDay5
{
    internal class Factors
    {
        static bool IsPrime(long i)
        {
            for (long n = 2; n < i; n++)
            {
                if (i % n == 0)
                    return false;
            }
            return true;
        }

        public static void FindPrimeFactors()
        {
            long number = 600851475143;
            for (long i = 3; i <= number; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
