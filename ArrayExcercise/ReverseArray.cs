using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class ReverseArray
    {
        public void reverseArray(int[] arr)
        {
            Console.Write("\n\tThe reverse array is : ");
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
