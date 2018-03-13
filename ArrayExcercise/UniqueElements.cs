using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class UniqueElements
    {
        public void uniqueElements(int[] arr)
        {
            Console.Write("Unique Element : ");
          
            for (int i = 0; i < arr.Length; i++)
            {
               int count = 0;
                int element = arr[i];

                for (int j = 0; j < arr.Length; j++)
                {
                    if (element == arr[j])
                    {
                        count++;                        
                    }

                   }
                if (count == 1)
                {
                    Console.Write(arr[i] + " ");
                }
                if (count > 1)
                {
                    Console.Write("No unique element. ");
                    break;
                }

            }
            Console.ReadLine();

            }
        }
    }

