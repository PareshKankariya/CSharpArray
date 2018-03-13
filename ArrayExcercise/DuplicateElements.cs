using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    class DuplicateElements
    {
        public void findDuplicateElements(int[] arr)
        {
           
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
                if (count > 1)
                {
                    Console.WriteLine("Duplicate Element {0} found {1} times.", arr[i], count);
                }
              
            }
           
            Console.ReadLine();
        }        
    }
}
