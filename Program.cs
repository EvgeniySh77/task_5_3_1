using System;

namespace task_5_3_1
{
    class Program
    {
        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 27;           
        }
        static void Main()
        {
            int[] arr = new int[] {1, 2, 3};
            
            Console.WriteLine(arr[0]);

            BigDataOperation(in arr);
            
            Console.WriteLine(arr[0]);

            Console.ReadKey();
        }       
    }
}
