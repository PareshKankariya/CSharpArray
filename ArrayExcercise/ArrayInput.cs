using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class ArrayInput
    {
        public int[] inputArray()
        {
            int arrLength;
            Console.Write("Input the number of elements to be stored in the array : ");
            arrLength = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Enter {0} element of an array : ", i + 1);
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            return input;
        }

        public int[] inputArrayOne()
        {
            int arrLength1;
            Console.Write("Input the number of elements to be stored in the first array : ");
            arrLength1 = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[arrLength1];
            for (int i = 0; i < arrLength1; i++)
            {
                Console.Write("Enter {0} element of an array : ", i + 1);
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }         
            return firstArray;            
        }

        public int[] inputArrayTwo()
        {
            int arrLength2;
            Console.Write("Input the number of elements to be stored in the second array : ");
            arrLength2 = Convert.ToInt32(Console.ReadLine());
            int[] secondArray = new int[arrLength2];
            for (int i = 0; i < arrLength2; i++)
            {
                Console.Write("Enter {0} element of an array : ", i + 1);
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return secondArray;
        }

    }
}
