/*This code shows you how to use pointers in C# to manipulate the memory directly.
We first define an array of integers, and then use the fixed keyword to pin it in memory, 
which means that the garbage collector won't move it around while the program is running.
We then take a pointer to the array and use pointer arithmetic to iterate over it, print
its contents, and modify its values by incrementing and decrementing the pointer. Note that 
this code requires the /unsafe compiler flag to be enabled, since it uses unsafe code and pointer 
manipulation. Overall, this code demonstrates some of the low-level capabilities of C# and is a 
great example of how to work with pointers in the language. 
To run this code, you need to add this to your .csproj file, in   </PropertyGroup>: 

<AllowUnsafeBlocks>true</AllowUnsafeBlocks>

*/
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
