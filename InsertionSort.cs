using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.RB
{
    class InsertionSort
    {
        public void DisplayArray(int[] arr, int n)
        {
            Console.WriteLine();
            Console.WriteLine("Sorted array is: ");
            for (int i =0;i<n;i++)
            {   
               
                Console.WriteLine("Element [{0}] = {1}",i,arr[i]);
            }
        }

        public void  Insert_Sort(int[] arr,int n)
        {
            int i, j, key;
            for(i=1;i<n;i++)
            {
                key = arr[i];
                j = i - 1;

                while(j >= 0  && arr[j]> key)                              // Check insertion sort condition
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                     
                }
                arr[j + 1] = key;
            }
        }

       public static void Main(String[] args)
        {
            Console.WriteLine(" Let's perform insertion sort today!!");
            
            string length;                                              // Input length of an array.
            Console.Write("Input the length of the input array!!");
            length = Console.ReadLine();
            int Length_unsorted = Convert.ToInt32(length);

            int[] elementsUnsorted = new int[Length_unsorted];
            Console.WriteLine("Enter the elements of an unsorted input array!!");

            for(int i=0;i<Length_unsorted;i++)                          // Read elements of input array
            {
                Console.Write("Elements [{0}] :", i);
                string elements = Console.ReadLine();
                elementsUnsorted[i] = Convert.ToInt32(elements);
                Console.WriteLine();
            }

            InsertionSort object_IS = new InsertionSort();              // Object Creation

            object_IS.Insert_Sort(elementsUnsorted, Length_unsorted);
            object_IS.DisplayArray(elementsUnsorted, Length_unsorted);
            Console.Read();
       }
    }
}
