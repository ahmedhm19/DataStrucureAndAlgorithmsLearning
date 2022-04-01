using System;
using System.Collections;
using System.Collections.Generic;

namespace DSLearning
{
    internal class Program
    {

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("**********************");
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
        }
      
        static void Main(string[] args)
        {
            var arr = new int[] { 10, 9, 13, 14,10, 8, 72, 11, 15,77 };

            Sort.BubbleSort( arr);

            PrintArray(arr);

        }
    }
}
