using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExcercise
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayInput arrayInputObj = new ArrayInput();

            InsertNewElementIntoArray insertElementObj = new InsertNewElementIntoArray();

            insertElementObj.insertNewElement(arrayInputObj.inputArray());


            //SeparateOddEven oddEvenObj = new SeparateOddEven();
            //oddEvenObj.oddEvenElelments(arrayInputObj.inputArray());



            //MaxMinElement maxMinObj = new MaxMinElement();
            //maxMinObj.maxMinElements(arrayInputObj.inputArray());


            //MergeAndOrder mergeAndOrderObj = new MergeAndOrder();
            //mergeAndOrderObj.mergeAndOrderArrays(arrayInputObj.inputArrayOne(), arrayInputObj.inputArrayTwo());
            
         


            //UniqueElements uniqueElemetsObj = new UniqueElements();
            //uniqueElemetsObj.uniqueElements(arrayInputObj.inputArray());

            //DuplicateElements duplicateElementObj = new DuplicateElements();
            //duplicateElementObj.findDuplicateElements(arrayInputObj.inputArray());

            //CopyArray copyArrayObj = new CopyArray();
            //copyArrayObj.copyOfArray(arrayInputObj.inputArray());
             
           // ReverseArray reverseArrayObj = new ReverseArray();
           // SumOfArray sumOfArrayObj = new SumOfArray();
           //// reverseArrayObj.reverseArray(arrayInputObj.inputArray());
           // sumOfArrayObj.arraySum(arrayInputObj.inputArray());

            //BasicArray basicArrayObj = new BasicArray();
            //basicArrayObj.arrayBasic();
        }
        
        
    }
}
