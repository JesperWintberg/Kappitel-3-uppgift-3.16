using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång ät din sång?");
            string låt = Console.ReadLine();

            float musik = float.Parse(låt);

            if (musik > 2.45 && musik < 4.20)
            {
                Console.WriteLine("Du får spela din låt");
            }

            else
            {
                Console.WriteLine("Du får tyvär inte spela din låt");
            }
        }
    }
}
