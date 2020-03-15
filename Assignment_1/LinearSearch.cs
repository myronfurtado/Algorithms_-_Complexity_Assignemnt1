using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class StepCounter
    {
        public static int Stepcounter = 0;
    }
    class LinearSearch1
    {


        public static int LinearSearch(int[] array, int r)
        { // code is used to search for r in int[] array selected by the user

            int n = array.Length;

            for (int j = 0; j < n; j++)
            {
                //Stepcounter is used to count the number of steps performed by the algorithm
                StepCounter.Stepcounter++;
                if (array[j] == r)
                {
                    return j;
                }
               
            }
            return -1;
            // if r is present in the array then return it index location
            //the rest of the code is called in Program.cs

        }


    }
}



