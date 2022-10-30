using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue___procedural
{
    class Program
    {
        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Queue test program");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Display queue");
            Console.WriteLine("2. Enqueue an integer");
            Console.WriteLine("3. Dequeue an integer");
            Console.WriteLine("4. Quit\n");
            Console.Write("What do you want to do? ");
            return Console.ReadKey().KeyChar;
        }

        static void DisplayQueue(int[] currentQueue, int F, int R)
        {
            string queueDisplay = "";

            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Displaying queue");
            Console.WriteLine("----------------");

            // Check if R has not moved from starting default position (-1)
            // meaning data has not been added
            if (R == -1)
            {
                Console.WriteLine("Queue empty.");
            }
            // Output queue values if there is data
            else
            {
                // Build queue output
                while (F < R)
                {
                    queueDisplay += currentQueue[F] + "->";
                    F++;
                }
                // Include last item in queue without final ->
                Console.WriteLine(queueDisplay += currentQueue[F]);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        static void Enqueue(ref int[] currentQueue, ref int F, ref int R)
        {

        }

        static int Dequeue(int[] currentQueue, ref int F, ref int R)
        {

        }

        static void Main()
        {
            char menuChoice;
			// Declare pointer and queue data structure
            // Set queue pointers to default empty positions

            do
            {
                menuChoice = Menu();
                if (menuChoice == '1')
                {
                    
                }
                else if (menuChoice == '2')
                {
                    
                }
                else if (menuChoice == '3')
                {

                }
                else if (menuChoice == '4')
                {
                    Console.WriteLine("Quitting...");
                }
                else
                {
                    Console.WriteLine("Error - try again");
                }
            } while (menuChoice != '4');
        }
    }
}