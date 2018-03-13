using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class MergeAndOrder
    {
        public void mergeAndOrderArrays(int[] arr1, int[]arr2)
        {
            int[] outputArray = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, outputArray, arr1.Length);
            Array.Copy(arr2, 0, outputArray, (arr1.Length), arr2.Length);
            Console.WriteLine("Merged Array: "+ String.Join(", ", outputArray));
            Array.Sort(outputArray);
            Console.WriteLine("Sorted Array: " + String.Join(", ", sortedArray(outputArray)));            
            Console.ReadLine();
        }

        public int[] sortedArray(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            Array.Copy(arr, sortedArray, arr.Length);
            Boolean flag = true;
            while(flag == true)
            {
                flag = false;
                for (int i = 0; i < sortedArray.Length-1; i++)
                {
                    if (sortedArray[i]<sortedArray[i+1])
                    {
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[i+1];
                        sortedArray[i+1] = temp;
                        flag = true;
                    }
                }               

            }
            return sortedArray;
        }
    }
}
