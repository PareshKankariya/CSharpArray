using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class SeparateOddEven
    {
        public void oddEvenElelments(int[] arr)
        {
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList.Add(arr[i]);
                }
                else
                {
                    oddList.Add(arr[i]);
                }
            }
            Console.Write("Even numbers are : ");
            Console.Write(String.Join(", ", evenList));
            Console.Write("\nOdd numbers are : ");
            Console.Write(String.Join(", ", oddList));
            
            Console.ReadLine();
        }
    }
}
