using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramDay5
{
    internal class FlipCoin
    {
        //initialize variable in declarations
        int result;
        Random randomNumber; // random number generator
        const int NUMBER_OF_SIDES = 2; // constant number of card
        string[] coinfaces = { "Head", "Tails" };

        public static void CoinTossCalculate()
        {
            int coinHead = 0;
            int coinTail = 0;
            Random randomNumbers = new Random();

            // prompt user for input to toss coin or not
            Console.WriteLine("Toss Coin? (1 = yes, 2 = no): ");
            int result = Convert.ToInt32(Console.ReadLine());

            //if ... else nested in While
            while (result == 1) // if result 1,
            {
                int second = randomNumbers.Next(NUMBER_OF_SIDES);
                if (second == 1)
                {
                    Console.WriteLine("Head it is!\n");
                    coinHead += 1;
                    Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                    Console.WriteLine("Tails\ttotal count: {0}", coinTail);
                }
                else
                {
                    Console.WriteLine("Tails it is!\n");
                    coinTail += 1;
                    Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                    Console.WriteLine("Tails\ttotal count: {0}", coinTail);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Toss Coin? (1 = Yes, 2 = No): ");
                result = Convert.ToInt32(Console.ReadLine());
            }

            // result is not 1, so
            Console.WriteLine("Game Over!");
 
        }
    }
}
