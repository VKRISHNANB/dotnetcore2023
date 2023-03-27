using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDiffE
{
    class Program
    {
        static void MainF(string[] args)
        {
            //int[] array = new int[] { 1, 32, 13, 4, 9, };
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            Console.WriteLine("The randomly generated array is:");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            int[] diff_array = new int[array.Length - 1];
            int min = int.MaxValue;
            int index=0;
           // diff_array[0] = Math.Abs(array[1] - array[0]);
            for (int i = 0; i < array.Length - 1; i++)
            {
                diff_array[i] = Math.Abs(array[i] - array[i + 1]);
            }
            for (int i = 0; i < diff_array.Length - 1; i++)
            {
                if (min > diff_array[i])
                {
                    min = diff_array[i];
                    index = i;
                }
            }
            Console.WriteLine("Elements " + array[index] + "(Element :" + index + ") & " + array[index + 1] + "(Element :" + (index+1) + ") are having the minimum difference.");
            Console.WriteLine("And the Difference is :" + diff_array[index]);
            Console.ReadLine();
        }
    }
}
