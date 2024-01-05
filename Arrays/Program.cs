using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing an array
            // Method 1

            // string[] names = new string[5];
            // names[0] = "yusif";


            // Method 2

            string[] mates = { "YUSIF", "ASANTE" };

            // Looping through an array with FOR LOOP
            for (int i = 0; i < mates.Length; i++)
            {
                Console.WriteLine(mates[i]);
            }
        }
    }
}
