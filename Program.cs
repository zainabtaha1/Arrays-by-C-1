using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Dimension Array 
            double[] grades = new double[5];
            grades[0] = 92.6;
            grades[1] = 97.1;
            grades[2] = 93.05;
            grades[3] = 92;
            grades[4] = 91.9;
            grades[2] = 98.5;
            //Reading the Array Elements 
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[2]);
            Console.WriteLine(grades[3]);
            /* instead of repeating the same reading statement several times,
             * we have to use looping structure 
             */
            string[] books = new string[3];
            Console.WriteLine(" Please enter Names of books ");
            for (int i = 0; i < 3; i++)
                books[i] = Console.ReadLine();
            Console.WriteLine(" Displaying the three names of books ");
            for (int i = 0; i < books.Length; i++)
                Console.WriteLine("The book num " + i + " is ", books[i]);
            // Foreach Loop Sructure
            char[] letters = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine(" Displaying the 6 letters ");
            foreach (char val in letters)
                Console.WriteLine(val);

            // Passing Array to Method 
            int[] numbers = new int[5] { 2009, 84, 2001, 2014, 2005 };
            int max = maximum(numbers);
            Console.WriteLine(" The maximum of numbers of the array is " + max);

        }
        static int maximum(int[] numbers)
        {
            int i;
            int max = numbers[0];
            for (i = 1; i < numbers.Length; i++)
                if (numbers[i] > max)
                    max = numbers[i];
            return max;


        }


    }
}