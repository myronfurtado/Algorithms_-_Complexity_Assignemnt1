using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_1
{
    public class BubbleSort
    {

        //public static int totalSteps = 0;
        public int i = 0;

        //public int stepCounter = 0;

        public static void BubbleAscendingSort(int[] unsortedAscendingsort)
        {
            int stepCounter = 0;// counts the number steps  the sort algorithhm takes
            int temp;
            //When looping we deal with 1 less than the lenght of the array the current number with the one next to it
            //It is unnecessary to go to the last number as it will be the last one

            for (int i = 0; i < unsortedAscendingsort.Length - 1; i++)
            {
                //I soved 'i' from the right side
                //'i' should not be added to the last element as it has already been moved to the sopt on its right
                for (int j = 0; j < unsortedAscendingsort.Length - (1 + i); j++)
                {
                    stepCounter = stepCounter + 1;

                    if (unsortedAscendingsort[j] > unsortedAscendingsort[j + 1])
                    {
                        stepCounter = stepCounter + 1;
                        //if the current number is greater than the one to the right they will swap location
                        temp = unsortedAscendingsort[j + 1];
                        unsortedAscendingsort[j + 1] = unsortedAscendingsort[j];
                        unsortedAscendingsort[j] = temp;

                    }

                }

            }
            Console.WriteLine($"The Bubble Sort took {stepCounter} steps\n");
        }


        //code for the descending sort display
        public static void BubbleDescendingSort(int[] unsorteddescendingsort)
        {
            int stepCounter = 0;
            int temp;
            //When looping we deal with 1 less than the lenght of the array the current number with the one next to it
            //It is unnecessary to go to the last number as it will be the last one

            for (int i = unsorteddescendingsort.Length; i > 0; i--)

            {
                //solved 'i' from the right side
                //'i' should not be added to the last element as it has already been moved to the sopt on its right
                for (int j = unsorteddescendingsort.Length - 1; j >= 0; j--)
                {
                    //when J is not equal to zero it will check the nu,ber to the right and move the bigger number to the right
                    if (j != 0)
                    {
                        if (unsorteddescendingsort[j - 1] < unsorteddescendingsort[j])
                        {
                            stepCounter = stepCounter + 1;
                            //if the current number is smaller than the one to the right they will swap location
                            temp = unsorteddescendingsort[j];
                            unsorteddescendingsort[j] = unsorteddescendingsort[j - 1];
                            unsorteddescendingsort[j - 1] = temp;
                        }

                    }
                }


            }
            Console.WriteLine($"Bubble Sort took {stepCounter} steps\n");
        }

    }
}
