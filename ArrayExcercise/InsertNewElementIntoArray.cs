using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class InsertNewElementIntoArray
    {
        public void insertNewElement(int[] arr)
        {
            int[] inputArray = new int[arr.Length];
            int size = inputArray.Length;
            Array.Copy(arr, inputArray, size);
            Console.Write("Original Array : ");
            Console.Write(String.Join(", ", inputArray));
            int inputNum, inputLoc;
            Console.Write("\nEnter new number that needs to be added : ");
            inputNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the location to add new number : ");
            inputLoc = Convert.ToInt32(Console.ReadLine());
            if (inputLoc > size+1)
            {
                Console.WriteLine("Out of bound");
                Console.ReadLine();
            }
            else
            {
                Array.Resize(ref inputArray, inputArray.Length + 1);
                Console.WriteLine("new Input Array length {0}", inputArray.Length);
                for (int i = (inputArray.Length - 1); i >= inputLoc; i--)
                {
                    inputArray[i] = inputArray[i - 1];
                }
                inputArray[inputLoc - 1] = inputNum;
                Console.Write("\nNew Array : ");
                Console.Write(String.Join(", ", inputArray));

                Array.Sort(inputArray);
                Console.Write("\nSorted Array : ");
                foreach (int i in inputArray)
                {
                    Console.Write(i + " ");
                }

                Console.ReadLine();
            }
            
        }
    }
}
