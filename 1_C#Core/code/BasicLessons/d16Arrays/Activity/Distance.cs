using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void MainE(string[] args)
        {
            int[] arr ={10,12,20,2,5,65,9,81,56,7 };
            int i, j, min;
            int[] s= new int[10];
            Console.WriteLine(" the Numbers are: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (i = 0, j = 1; j < arr.Length; i++,j++)
            {
                if (arr[i] > arr[j])
                {
                    s [i]= arr[i] - arr[j];
                    Console.WriteLine("the Distance between {0} and {1}: ", arr[i], arr[j]);
                    Console.WriteLine(s[i]);
                }
                else
                {
                    s [i]= arr[j] - arr[i];
                    Console.WriteLine("the Distance between {0} and {1}: ",arr[i], arr[j]);
                    Console.WriteLine(s[i]);
                }
            }
            min = s[0];
            for (i = 0; i < s.Length-1; i++)
            {
                if (s[i] <=min)
                {
                    min = s[i];
                }
            }
            Console.WriteLine("Min distance is " + min);
            Console.ReadLine();
        }
    }
}
