// Dice Simulation
// Gordon Doskas
// POS/409
// June 13, 2016
// Carole Mckinney

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos409_dice_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tally = {0,0,0,0,0,0};

            Console.WriteLine("Welcome to the Dice Simulation Program");
            Console.WriteLine("======================================");
            Console.WriteLine("This program simulates the roll of two six sided dice one hundred times,");
            Console.WriteLine("displaying the roll, indicating whether it was a double, and displays the");
            Console.WriteLine("tally at the end." + Environment.NewLine);

            Console.WriteLine("Press the Enter key to begin.");
            Console.ReadLine();

            // Dice roll simulation loop
            //
            for (int i = 0; i < 100; i++)
            {
                int die1 = rnd.Next(6);
                int die2 = rnd.Next(6);

                // Check for doubles
                //
                if(die1 == die2)
                {
                    tally[die1]++;
                    Console.Write("DOUBLE!! ");
                }
                Console.WriteLine("Roll " + (i + 1) + ": " + (die1 + 1) + ", " + (die2 + 1));
            }

            // Display tally
            //
            Console.WriteLine(Environment.NewLine + "Tally" + Environment.NewLine + "================");
            for (int i = 0; i < tally.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + tally[i]);
            }

            // Hold the window open during Debug
            //
            Console.ReadLine();
        }
    }
}
