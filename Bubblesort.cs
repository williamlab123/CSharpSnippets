
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


      
        Console.WriteLine("Array desordenado:");
        PrintArray(arr);

        BubbleSort(arr);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(arr);
    

   
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
    }

     static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }


    //Bubblesort to ordenate an array
    

