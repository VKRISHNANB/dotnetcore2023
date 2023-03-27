using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons
{
    class WorkerWithArrays
    {
        public static void TestArraysA()
        {
            int[] nos = {1,2,3,4,5,6,7,8,9,0 };
            foreach(int x in nos)
            {
                Console.Write(x);
            }
            Console.WriteLine();
            for(int i=0;i<nos.Count();i++)
            {
                Console.Write(nos[i]);
            }
        }
        public static void TestArraysB()
        {
            char[] data = {'A' ,'B','C','D','E','F','G', 'H','I','J'};
            String[] data1 = {"Hello","Good","Bad","Ugly"};
            foreach (char c in data)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            for (int i = 0; i < data1.Count(); i++)
            {
                Console.Write(data1[i]);
            }
        }

        public static int[] Sort(int[] data)
        {
            //Bubble Sort
            bool flag = true;
            int temp;
            int numLength = data.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (data[j + 1] > data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            return data;            
        }
        public static int[] AddLength(int[] data,int extraLength)
        {
            int[] newArray = new int[data.Count()+ extraLength];
            for(int i=0;i< data.Count();i++)
            {
                newArray[i] = data[i];
            }
            return newArray;
        }
    }
}
