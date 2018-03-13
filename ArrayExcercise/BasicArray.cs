using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class BasicArray
    {
        public void arrayBasic()
        {
            int arrLength;
            Console.Write("Input the number of elements to be stored in the array : ");
            arrLength = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Enter {0} element of an array : ", i+1);
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\tThe input array is : ");
            for (int j = 0; j < arrLength; j++)
            {
                Console.Write(input[j]+" ");
            }
            Console.Write("\n\tThe reverse array is : ");
            for (int j = input.Length-1; j >= 0; j-- )
            {
                Console.Write(input[j]+" "); 
            }

            Console.ReadLine();
        
        }
    }
}
