using System;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 33 };

            for (int index = 0; index < array1.Length; index++)
            {
                Console.WriteLine(array1[index]);
            }

            int[] number = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int index1 = 1; index1 < number.Length; index1++)
            {
                if (number[index1] % 2 == 1)
                {
                    Console.WriteLine(number[index1]);
                }
            }


            for (int a = 1; a < 6; a++)
            {
                for (int b = 1; b < 6; b++)
                {
                    int c = a * b;
                    Console.WriteLine(c);
                }
            }

            string password = "qwerty";
            do
            {
                Console.Write("Please enter password: ");

            } while (password != Console.ReadLine());
            Console.WriteLine("Access denied.");
        }
    }
}