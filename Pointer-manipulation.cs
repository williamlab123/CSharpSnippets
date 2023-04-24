using System;

unsafe class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        fixed (int* ptr = arr)
        {
            // Print the original array using pointer arithmetic
            Console.WriteLine("Original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(*(ptr + i) + " ");
            }
            Console.WriteLine();

            // Increment the pointer by 2 and print the next two values
            Console.WriteLine("Two values after incrementing the pointer by 2:");
            int* ptr2 = ptr + 2;
            Console.WriteLine(*ptr2); // should print 3
            Console.WriteLine(*(ptr2 + 1)); // should print 4

            // Decrement the pointer by 1 and modify the value
            Console.WriteLine("Value after decrementing the pointer by 1 and modifying the data:");
            ptr2--;
            *ptr2 = 10;
            Console.WriteLine(*ptr2); // should print 10

            // Print the modified array using pointer arithmetic
            Console.WriteLine("Modified array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(*(ptr + i) + " ");
            }
            Console.WriteLine();
        }
    }
}
