using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompts users the candidates
            Console.WriteLine("Input the name of cadidate 1:");
            Console.WriteLine("Donald Trump");
            Console.WriteLine("Input the name of candidate 2:");
            Console.WriteLine("Kamala Harris");

            double trumpvotes = 0; // starts their votes at 0
            double kamalavotes = 0; // starts their votes at 0
            // prompts users the line on who to vote for
            Console.WriteLine("Who do you want to vote for? (1 for Trump, 2 for kamala, 0 for exit)");
            // makes their input a variable
            int input = Convert.ToInt32(Console.ReadLine());
            trumpvotes = Convert.ToInt32(Console.ReadLine());
            kamalavotes = Convert.ToInt32(Console.ReadLine());
            // starts the loop for the voting
            while (input > 0)
            {
                if (input == 1)
                {
                   trumpvotes++; // adds to trumps count
                }
                if (input == 2)
                {
                    kamalavotes++; // adds to kamalas count
                }
                if (input == 0)
                {
                    break; // breaks the loop if they enter a 0
                }
            }

            Console.WriteLine("Final Result: "); // prompts user the results
            Console.WriteLine(trumpvotes); // prints trumps votes
            Console.WriteLine(kamalavotes); // prints kamalas votes
            Console.ReadKey();
        }
    }
}
