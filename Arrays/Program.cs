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


            string[] mates = new string[5];
            mates[0] = "Yusif";
            mates[1] = "Adofo";


            for (int i = 0; i < mates.Length; i++)
            {
                Console.WriteLine(mates[i]);
            }
        }
    }
}
