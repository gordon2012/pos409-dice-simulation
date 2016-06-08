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


            //TODO: Menu type system


            for (int i = 0; i < 100; i++)
            {
                int die1 = rnd.Next(6);
                int die2 = rnd.Next(6);

                //Console.WriteLine((die1 == die2 ? "DOUBLE!! " : "") + "Roll " + (i + 1) + ": " + (die1 + 1) + ", " + (die2 + 1));

                if(die1 == die2)
                {
                    tally[die1]++;
                    Console.WriteLine("DOUBLE!! Roll " + (i + 1) + ": " + (die1 + 1) + ", " + (die2 + 1));
                }
            }

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
