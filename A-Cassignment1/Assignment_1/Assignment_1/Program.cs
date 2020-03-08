using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_1
{
    class Program
    {
        public static List<string> arraynumber1_256;

        static void Main(string[] args)
        {
            //Read indiciduall text file and append each line into individual arrays
            string Net_1_256 = @"‎iCloud Drive\Desktop\Assignment_1\Assignment_1\Net_1_256.txt";
            //int[] Net_1= new int[] { };
            List<string> arraynunber1_256 = new List<string>();
            arraynumber1_256 = File.ReadAllLines(Net_1_256).ToList();

            foreach (string line in arraynunber1_256)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

        }
    }
}