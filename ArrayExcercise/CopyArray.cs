using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class CopyArray
    {
        public void copyOfArray(int[] arr)
        {
            int[] newArray = new int[arr.Length];
            Array.Copy(arr, newArray, arr.Length);
            Console.WriteLine(string.Join(", ", newArray));
            Console.ReadLine();
           

        }
    }
}
