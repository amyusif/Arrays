using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            // string[] mates = { "YUSIF", "ASANTE" };

            // Looping through an array with FOR LOOP
            /* for (int i = 0; i < mates.Length; i++)
             {
                 Console.WriteLine(mates[i]);
             }
            */





            // Create an ARRAY of ints and use loops to find the sum of all integers

            /*  int[] myNums = {2, 4, 6, 8, 10, 12 };

              int sum = 0;

              foreach (int i in myNums)
              {
                   sum += i;  
              }
              Console.WriteLine(sum);
            */




            // CREATE AN ARRAY OF NAME STRINGS AND SORT THEM IN ALPHABETICAL ORDER

            /* string[] names = { "Yusif", "Spiff", "Kwame", "Emma" };

              void SortandLoop()
             {
                 Array.Sort(names);

                 foreach (string name in names)
                 {
                     Console.WriteLine(name);
                 }
             }

             SortandLoop();
            */


            // WRITE A PROGRAM TO DISPLAY THE TRANSPOSE OF A MATRIX (2D ARRAY)

            int[,] matrix =
            {
                {2, 4, 6},
                {8, 12, 14},
                {16, 17, 18}
            };

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            // Creating a new matrix for the transpose

           /* int[,] transpose = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }


            void DisplayMat(int[,] mat)
            {
                int rows = mat.GetLength(0);
                int cols = mat.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(transpose[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            DisplayMat(transpose);

            */



            // ARRAYLIST 

            ArrayList myArrayList = new ArrayList();


            myArrayList.Add("Yusif");
            myArrayList.Add("Mensah");
            myArrayList.Add(12);


            Console.WriteLine( );











        }
    }
}
