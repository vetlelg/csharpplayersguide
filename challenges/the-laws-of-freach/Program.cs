using System;

namespace the_laws_of_freach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterate array and add each value to total
            // If value is less than currentMinimum, assign value to currentMinimum
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = int.MaxValue; // Start higher than anything in the array.
            int total = 0;
            foreach (int i in array)
            {
                total += i;
                if (i < currentMinimum)
                    currentMinimum = i;
            }

            // Calculate average and print both minimum and average values
            float average = (float)total / array.Length;
            Console.WriteLine(currentMinimum);
            Console.WriteLine(average);
        }
    }
}
