using System;

namespace the_replicator_of_dto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first array and assign values to array from user
            int[] firstArray = new int[5];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"Assign integer to array of index {i}: ");
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Create second array and copy values from first to second array
            int[] secondArray = new int[5];
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            // Print values of first array
            Console.Write("Content of firstArray: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }

            Console.Write("\n");

            // Print values of second array
            Console.Write("Content of secondArray: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
        }
    }
}
