using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLearning
{
    public class Sort
    {
        public static void Swap(int[] arr, int indexToBeReplcaed, int indexReplacer)
        {
            var toBeReplcaed = arr[indexToBeReplcaed];
            arr[indexToBeReplcaed] = arr[indexReplacer];
            arr[indexReplacer] = toBeReplcaed;
        }

        public static int FindIndexOfTheMin(int[] arr, int startIndex)
        {
            //assume that first element is the min
            int min = arr[startIndex];
            int minIndex = startIndex;

            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        

        public static void SelectionSort(int[] arr)
        {
            //1-Create separator between ordered items and others, initial value 0 : use int variable
            //2-Find the min in right part : create function that search in an array from startIndex to the end to the array
            //3-Put it in the left side on the index of separator, and put the replaced value in it's index : swapfunction
            //4-Repeat until seaparor reach the end of the array : for loop.

            for (int i = 0; i < arr.Length; i++)
            {
                int seaparator = i;
                var minIndex = FindIndexOfTheMin(arr, seaparator);
                Swap(arr, seaparator, minIndex);
            }
        }

        public static void InsertionSort(int[] arr)
        {
           
            for (int i = 1; i < arr.Length-1; i++)
            {
                var lastOrderedItemIndex = i;
                var keyIndex = i + 1;
               
                //Compare last element from the ordered part with the first element in the unordered part
                if(arr[lastOrderedItemIndex] > arr[keyIndex])
                {
                    Swap(arr , lastOrderedItemIndex, keyIndex);
                }

                //re Order the orderedPart
                for (int j = 0; j < lastOrderedItemIndex-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        Swap(arr , j , j+1);
                    }
                }
            }

        }

        public static void BubbleSort(int[] arr)
        {
            //create flag to check if any swapping operation has executed
            bool swapped = false;

            //keep ordering untill no swapping is done
            while(true)
            {
                swapped = false;

                for (int i = 0; i < arr.Length-1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        Swap(arr, i, i +1);
                        swapped = true;
                    }
                }

                //If nothing swapped then the list is fully ordered, and stop checking
                if (!swapped)
                    break;
            }
        }




    }
}
