using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class SumOfArray
    {
        public void arraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("\nSum of array is : {0}", sum);
            Console.ReadLine();
        }
        
    }
}
