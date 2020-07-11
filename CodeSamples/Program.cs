using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSamples
{
    class Program
    {
        /*
         *  This little snippet recreates a lab task I did in the first term in the first year of my CS degree way back in 2003.
         *  
         *  Asked during a lab session to take a string and output the number of letters present in a string. People were 
         *  frantically typing if statements to check for each letter of the alphabet, both upper and lower case. I sat there 
         *  with only one thought going over and over in my head: ‘too many ifs’. Nothing happened.  I sat there staring at 
         *  the screen with a rising sense of panic, but unable to bring myself to frantically pound out if statements. Finally 
         *  about half an hour into the 45 minute lab session, I reasoned the Java language was written by a human, as was the 
         *  memory location of the alphabet, and most likely the letters would be stored in order.  Therefore, a for loop using 
         *  a char instead of an int as an index would work.
         *  
         *  Here it is for posterity!
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word then hit enter to find out how many of each letter in that word.");
            string input = Console.ReadLine();

            // My favourite for loop :-*
            for (char i = 'A'; i <= 'z'; i++)
            {
                if (input.Contains(i)) 
                {
                    int count = input.Count(c => c == i); // I certainly didn't have Linq in Java back in 2003!!
                    Console.WriteLine("Character " + i + " is in the string " + count + " times.");
                }                    
            }
        }
    }
}
