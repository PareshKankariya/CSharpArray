using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class MaxMinElement
    {
        public void maxMinElements(int[] arr)
        {
            //Boolean flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp;
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
             }
            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine("Max element : {0}", arr[arr.Length - 1]);
            Console.WriteLine("Min element : {0}", arr[0]);
            Console.ReadLine();
        }
    }
}
