using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramDay5
{
    internal class VowelandConsonent
    {
        public static void FindAlphabate()
        {
            char[] inputstring = new char[100];
            int i, vowels, consonants, x;

            vowels = 0;
            consonants = 0;

            // Enter the length of the string
            Console.WriteLine("Please enter the length of the string:\n");
            x = int.Parse(Console.ReadLine());

            // Enter the string
            Console.WriteLine("Enter string:\n");
            for (i = 0; i < x; i++)
            {
                inputstring[i] = Convert.ToChar(Console.Read());
            }
            // Iterating the string
            for (i = 0; inputstring[i] != '\0'; i++)
            {
                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'A' ||
                    inputstring[i] == 'i' || inputstring[i] == 'I' ||
                    inputstring[i] == 'o' || inputstring[i] == 'O' ||
                    inputstring[i] == 'e' || inputstring[i] == 'E' ||
                    inputstring[i] == 'u' || inputstring[i] == 'U')
                {
                    //Increment the vowels
                    vowels++;
                }
                else
                {
                    // Increment the consonants
                    consonants++;
                }
            }
            // Display the count of vowels and consonant
            Console.WriteLine("\ncount of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}

