using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class DeleteElementFromArray
    {
        public void deleteElement(int[] arr)
        {
            int[] inputArray = new int[arr.Length];
            int size = inputArray.Length;
            int deleteLoc;
            Array.Copy(arr, inputArray, size);
            Console.Write("Original Array : ");
            foreach (int i in inputArray)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nEnter the element that needs to be deleted : ");
            deleteLoc = Convert.ToInt32(Console.ReadLine());

            if (deleteLoc > size + 1)
            {
                Console.WriteLine("Out of bound");
                Console.ReadLine();
            }
            else
            {
                for (int i = deleteLoc; i < size; i++)
                {
                    inputArray[i - 1] = inputArray[i];
                }
                Array.Resize(ref inputArray, size - 1);
                Console.WriteLine("New Array is : ");
                foreach (int i in inputArray)
                {
                    Console.WriteLine(i + " ");
                }
                Console.ReadLine();
            }

        }

    }
}
