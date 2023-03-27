using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d31Arrays
{
    public class ArrayDemo
    {
        public static void M1()
        {
            int[] sample = new int[10];
	        //int a[] = new int[10];
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i*5;
            for (i = 0; i < 10; i++)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }

        public static void Average()
        {
            int[] nums = new int[10];
            int avg = 0;   int sum = 0;
            nums[0] = 99;   nums[1] = 10;
            nums[2] = 100;  nums[3] = 18;
            nums[4] = 78;   nums[5] = 23;
            nums[6] = 63;   nums[7] = 9;
            nums[8] = 87;   nums[9] = 49;
            for (int i = 0; i < 10; i++)
                sum += nums[i];
            avg = sum / nums.Count();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Sum: " + nums.Sum());
            Console.WriteLine("Average: " + nums.Average());
        }
        public static void FindMaxAndMin()
        {
            int[] data = { 32, 21, 10, 56, 87, 43, 97, 2 };

            //Find Smallest and largest no
            #region hide
            Console.WriteLine("Largest " + data.Max());
            Console.WriteLine("Smallest " + data.Min());
            #endregion
            //finding largest no
            int max = data[0];
            int min = data[0];
            int count = data.Count();
            for (int i = 1; i < count; i++)
            {
                if (data[i] > max) max = data[i];
            }
            for (int i = 1; i < count; i++)
            {
                if (data[i] < min) min = data[i];
            }
            Console.WriteLine("Largest " + max);
            Console.WriteLine("Smallest " + min);
        }

        public static void ArrayOverRun()
        {
            int[] sample = new int[10];
            int i;
            // Generate an array overrun.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;
            //IndexOutOfRangeException
        }

        public static void WorkingWithCharArray()
        {
            String s1 = "Today is a very hot day";
            char[] data = s1.ToCharArray();
            int count = data.Length;
            Console.WriteLine("Array Length " + count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
 
        public static void TwoD()
        {
            int t, i;
            int[,] table = new int[3, 4];//3 Rows - 4 Col
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    //Console.Write(table[t, i] + " ");
                }
                Console.WriteLine();
            }
        }
        /**
        * Console.WriteLine(table.GetUpperBound(0));
            Console.WriteLine(table.GetUpperBound(1));
        */
        public static void Jagged1()
        {
            // int []a[] = new int[4][4];
            // int a1[][] = new int[4][4];
            // int []a1[] = new int[4][];
            // int[][] a1 = new int[4][4];
            int[][] a1 = new int[4][];
            int[,] a = new int[4,4];
            // int a2[][] = new int[][4];        
            // int[][] a2 = new int[][4]; //Array creation must have array size or array initializer 
            int[][] a2 = new int[4][];
            int [ ] [ ] a5 = new int[4][];
        }	
        public static void ThreeD()
        {
            int[,,] m = new int[3, 3, 3];
            //int sum = 0;
            int n = 1;
            #region a
            //m[0, 0, 0] = 1; m[0, 0, 1] = 2; m[0, 0, 2] = 3;
            //m[0, 1, 0] = 4; m[0, 1, 1] = 5; m[0, 1, 2] = 6;
            //m[0, 2, 0] = 7; m[0, 2, 1] = 8; m[0, 2, 2] = 9;

            //m[1, 0, 0] = 10; m[1, 0, 1] = 11; m[1, 0, 2] = 12;
            //m[1, 1, 0] = 13; m[1, 1, 1] = 14; m[1, 1, 2] = 15;
            //m[1, 2, 0] = 16; m[1, 2, 1] = 17; m[1, 2, 2] = 18;
            
            //m[2, 0, 0] = 19; m[2, 0, 1] = 20; m[2, 0, 2] = 21;
            //m[2, 1, 0] = 22; m[2, 1, 1] = 23; m[2, 1, 2] = 24;
            //m[2, 2, 0] = 25; m[2, 2, 1] = 26; m[2, 2, 2] = 27;

            #endregion
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        m[x, y, z] = n++;
                    }
                }
            }
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        Console.Write(m[x, y, z]+ " ,");
                    }
                    Console.WriteLine();
                }
            }
            //sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
            //Console.WriteLine("Sum of first diagonal: " + sum);
        }
        public static void TestUpperBound()
        {
           // int[] NOs = { 100, 10, 20, 30, 40, 50};
           //Console.WriteLine("UpperBound "+NOs.GetUpperBound(0));
           //Console.WriteLine("LowerBound "+NOs.GetLowerBound(0));
            int[][] data = new int[2][];
            data[0] = new int[3] { 10, 20, 30 };
            data[1]=new int[2]{100,200 };
        Console.WriteLine("UpperBound 0 - " + data.GetUpperBound(0));
        Console.WriteLine("GetUpperBound data[0]-  " + data[0].GetUpperBound(0));
        Console.WriteLine("GetUpperBound data[1]-  " + data[1].GetUpperBound(0));

        }
        public static void UsingJaggedArrays()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
            // Store values in first array.
            for (i = 0; i < 4; i++)
                jagged[0][i] = i;
            // Store values in second array.
            for (i = 0; i < 3; i++)
                jagged[1][i] = i;
            // Store values in third array.
            for (i = 0; i < 5; i++)
                jagged[2][i] = i;
            // Display values in first array.
            for (i = 0; i < 4; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            // Display values in second array.
            for (i = 0; i < 3; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            // Display values in third array.
            for (i = 0; i < 5; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();
                  }
                  /* **
                    Console.WriteLine("GetUpperBound(0) " + jagged.GetUpperBound(0));
            Console.WriteLine("GetUpperBound(1) " + jagged[0].GetUpperBound(0));
            Console.WriteLine("GetUpperBound(2) " + jagged[1].GetUpperBound(0));
            Console.WriteLine("GetUpperBound(3) " + jagged[2].GetUpperBound(0));
                  */
        public static void JaggedArraysM2()
        {
            //int []i[] = {{1,2}, {1}, {}, {1,2,3}};
            //int[][] i = {{1,2}, {1}, {}, {1,2,3}};
            int[][] i =  new[] {
                                     new int[] { 1, 2 },
                                     new int[] { 1 },
                                     new int[] { },
                                     new int[] { 1, 2, 3 }
                                 };
            #region i
            Console.WriteLine("i Length " + i.Length);
            for (int x = 0; x < i.Length; x++)
            {
                for (int y = 0; y < i[x].Length; y++)
                {
                    Console.Write(" " + i[x][y]);
                }
                Console.WriteLine();
            }
            #endregion
            //int j[]= new int[2]{1, 2};
            int[] j = new int[2] { 1, 2 };
            #region j
            Console.WriteLine("j Length " + j.Length);
            for (int x = 0; x < j.Length; x++)
            {
                Console.Write(" " + j[x]);
            }
            #endregion
            int[][] k = new int[][] { 
                new int[] { 1, 2, 3 },
                 new int[] { 4, 5, 6 } 
                 };
            #region k
            Console.WriteLine("k Length " + k.Length);
            for (int x = 0; x < k.Length; x++)
            {
               for (int y = 0; y < k[x].Length; y++)
               {
                   Console.Write(" " + k[x][y]);
               }
               Console.WriteLine();
            }
            #endregion
        //int l[][] = {{1, 2}, new int[2]};
		//int[][] l = {{1, 2}, new int[2]};
         int[][] l = { new int[] { 1, 2 }, new int[2] };
        
        //int m[4] = {1, 2, 3, 4};	
        //int[4] m = {1, 2, 3, 4};	
		int[] m = { 1, 2, 3, 4 };
        }

        public static void SortingNos()
        {
            //sort the nos
            int[] nos = new int[5];
            nos[0] = 10;
            nos[1] = 1;
            nos[2] = 2;
            nos[3] = 4;
            nos[4] = 3;
            
            int temp = 0;
            int len = nos.Length;
            for(int i=0;i<len;i++)
            {
                for (int j = 0; j < (len-1); j++)
                {
                    if(nos[j]>nos[j+1])
                    {
                        temp = nos[j];
                        nos[j] = nos[j + 1];
                        nos[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i]+",");
            }
        }

        public static void SortingArrays()
        {
            int[] nos = {32,21,10,56,87,43,97,2 };
            Console.WriteLine("B4 sort ");
            int len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();
            Array.Sort(nos);
            Console.WriteLine("After sort ");

            len = nos.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(nos[i] + ",");
            }
            Console.WriteLine();

        }
       
       
        public static void AnagramUsingSort()
        {

            String s1 = "parts";
            String s2 = "strap";
            char[] data1 = s1.ToCharArray();
            char[] data2 = s2.ToCharArray();
            Console.WriteLine("B4 sort ");
            int len = data2.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(data2[i] + ",");
            }
            Console.WriteLine();
            Array.Sort(data1);
            Array.Sort(data2);
            Console.WriteLine("After sort ");

            for (int i = 0; i < len; i++)
            {
                Console.Write(data1[i] + ",");
            }
            Console.WriteLine();
            for (int i = 0; i < len; i++)
            {
                Console.Write(data2[i] + ",");
            }
        }
        public static void EmpArray()
        {
            Emp[] elist = new Emp[10];
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = new Emp(i);
                e1.Name = "Emp" + i;
                elist[i] = e1;
            }

            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.Name);
            }
        }
        
        public static int GetIndexOfMinimumDistance(int[] numbers)
        {
        /**
        * Method that finds the minimum distance
        * of two neighboring numbers in a int array.
        * Returns the index of the first number
        * of two neighboring numbers with minimum distance to
        * each others.
        */
            int index = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (Math.Abs(numbers[index] - numbers[index + 1]) >
                    Math.Abs(numbers[i] - numbers[i + 1]))
                {
                    index = i;
                }
            }

            return index;
        }
        public static void TestGetIndexOfMinimumDistance1()
        {
            int[] numbersA = { 1, 1 };
            GetIndexOfMinimumDistance(numbersA);

            int[] numbersB = { 1, 3, 2 };
            GetIndexOfMinimumDistance(numbersB);

            int[] numbersC = { 1, 3, 2, 3, 7, 9, 9, 8, 2, 2 };
            GetIndexOfMinimumDistance(numbersC);

        }
       
    }
}