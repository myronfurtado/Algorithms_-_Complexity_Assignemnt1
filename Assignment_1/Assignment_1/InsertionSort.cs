using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_1
{

    public class Insertionsort
    {

        public static void InsertionSortAscending(int[] unsortedascendinglist)
        {
            int stepCounter = 0;
            int i = 1; //is the index of the element that will be mmoved back
            int j = i; //is the index of the element i am trying to swap
            int temp = 0; //temproary variable i will use to swap

            //Below code will allow me go from start to end of the list
            while (i < unsortedascendinglist.Length)
            {
                stepCounter = stepCounter + 1;
                j = i; //set the index of my current number
                //if the number to the left is bigger than the current number it will swap with it to one position backwards
                while (j > 0 && unsortedascendinglist[j - 1] > unsortedascendinglist[j])
                {
                    //the code below will swap j and j-1
                    temp = unsortedascendinglist[j]; //placing j in a temp var
                    unsortedascendinglist[j] = unsortedascendinglist[j - 1];
                    unsortedascendinglist[j - 1] = temp;
                    j--; //compares j to the next element in the array

                }
                i++; // moves onto the next element to swap it backwards into the list

            }
            Console.WriteLine($"Insertion Sort took {stepCounter} steps\n");
        }

        public static void InsertionSortDescending(int[] unsorteddescendinglist)
        {
            int stepCounter = 0;
            int i = 1; //is the index of the element that will be mmoved back
            int j = i; //is the index of the element i am trying to swap
            int temp = 0; //temproary variable i will use to swap

            //Below code will allow me go from start to end of the list
            while (i < unsorteddescendinglist.Length)
            {
                stepCounter = stepCounter + 1;
                j = i; //set the index of my current number
                //if the number to the left is bigger than the current number it will swap with it to one position backwards
                while (j > 0 && unsorteddescendinglist[j - 1] < unsorteddescendinglist[j])
                {
                    //the code below will swap j and j-1
                    temp = unsorteddescendinglist[j]; //placing j in a temp var
                    unsorteddescendinglist[j] = unsorteddescendinglist[j - 1];
                    unsorteddescendinglist[j - 1] = temp;
                    j--; //compares j to the next element in the array

                }
                i++; // moves onto the next element to swap it backwards into the list
                unsorteddescendinglist.Reverse();
            }
            Console.WriteLine($"Insertion Sort took {stepCounter} steps\n");
        }

    }
}
