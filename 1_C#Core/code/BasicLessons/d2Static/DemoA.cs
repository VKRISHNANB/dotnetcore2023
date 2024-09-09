using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d2Static
{
    class DemoA
    {
        //parameterless Method
        public static void Echo()
        {
            Console.WriteLine("DemoA Echo");
        }
      
        public static void SortNosA()
        {
            //sort the nos
            int x = 1;
            int y = 5;
            int z = 2;
            if (x < y)
            {
                if (x < z)
                {
                    Console.Write(x + " ");
                    if (z < y)
                        Console.WriteLine(z + " " + y);
                    else
                        Console.WriteLine(y + " " + z);
                }
                else
                    Console.WriteLine(z + " " + x + " " + y);
            }
            else
            {
                if (y < z)
                {
                    Console.Write(y + " ");
                    if (z < x)
                        Console.WriteLine(z + " " + x);
                    else
                        Console.WriteLine(x + " " + z);
                }
                else
                    Console.WriteLine(z + " " + y + " " + x);
            }
        }
        public static void SortNosB()
        {
            //sort the nos
            int x = 1;
            int y = 5;
            int z = 2;
            int i = 10;
            int j = 3;
            int firstNo = 0;
            int secondNo = 0;
            int thirdNo = 0;
            int fourthNo = 0;
            int fifthNo = 0;
            #region x
            if (x < y && x < z && x < i && x < j)
            {
                firstNo = x;
                #region xy
                if (y < z && y < i && y < j)
                {
                    secondNo = y;
                    if (z < i && z < j)
                    {
                        thirdNo = z;
                        if (i < j)
                        {
                            fourthNo = i; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = i;
                        }
                    }
                    else if ( i<z && i < j)
                    {
                        thirdNo = i;
                        if (z < j)
                        {
                            fourthNo = z; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = z;
                        }
                    }
                    else if (j < z && j < i)
                    {
                        thirdNo = j;
                        if (z < i)
                        {
                            fourthNo = z; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = z;
                        }
                    }
                }
                #endregion
                #region xz
                else if (z < y && z < i && z < j)
                {
                    secondNo = z;
                    if (y < i && y < j)
                    {
                        thirdNo = y;
                        if (i < j)
                        {
                            fourthNo = i; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = i;
                        }
                    }
                    else if (i < y && i < j)
                    {
                        thirdNo = i;
                        if (y < j)
                        {
                            fourthNo = y; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = y;
                        }
                    }
                }
                #endregion
                #region xi
                else if (i < y && i < z && i < j)
                {
                    secondNo = i;
                    if (y < z && y < j)
                    {
                        thirdNo = y;
                        if (z < j)
                        {
                            fourthNo = z; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = z;
                        }
                    }
                    else if (z < y && z < j)
                    {
                        thirdNo = z;
                        if (y < j)
                        {
                            fourthNo = y; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = y;
                        }
                    }
                }
                #endregion
                #region xj
                else if (j < y && j < z && j < i)
                {
                    secondNo = j;
                    if (y < z && y < i)
                    {
                        thirdNo = y;
                        if (z < i)
                        {
                            fourthNo = z; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = z;
                        }
                    }
                    else if (z < y && z < i)
                    {
                        thirdNo = z;
                        if (y < i)
                        {
                            fourthNo = y; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = y;
                        }
                    }

                }
                #endregion
            }
            #endregion
            #region y
            else if (y < x && y < z && y < i && y < j)
            {
                firstNo = y;
                #region yx
                if (x < z && x < i && x < j)
                {
                    secondNo = x;
                    if (z < i && z < j)
                    {
                        thirdNo = z;
                        if (i < j)
                        {
                            fourthNo = i; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = i;
                        }
                    }
                    else if (i < z && i < j)
                    {
                        thirdNo = i;
                        if (z < j)
                        {
                            fourthNo = z; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = z;
                        }
                    }
                    else if (j < z && j < i)
                    {
                        thirdNo = j;
                        if (z < i)
                        {
                            fourthNo = z; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = z;
                        }
                    }
                }
                #endregion
                #region yz
                else if (z < x && z < i && z < j)
                {
                    secondNo = z;
                    if (x < i && x < j)
                    {
                        thirdNo = x;
                        if (i < j)
                        {
                            fourthNo = i; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = i;
                        }
                    }
                    else if (i < x && i < x)
                    {
                        thirdNo = i;
                        if (x < j)
                        {
                            fourthNo = x; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = x;
                        }
                    }
                }
                #endregion
                #region yi
                else if (i < x && i < z && i < j)
                {
                    secondNo = i;
                    if (x < z && x < j)
                    {
                        thirdNo = x;
                        if (z < j)
                        {
                            fourthNo = z; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = z;
                        }
                    }
                    else if (z < x && z < x)
                    {
                        thirdNo = z;
                        if (x < j)
                        {
                            fourthNo = x; fifthNo = j;
                        }
                        else
                        {
                            fourthNo = j; fifthNo = x;
                        }
                    }
                }
                #endregion
                #region xj
                else if (j < y && j < z && j < i)
                {
                    secondNo = j;
                    if (y < z && y < i)
                    {
                        thirdNo = y;
                        if (z < i)
                        {
                            fourthNo = z; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = z;
                        }
                    }
                    else if (z < y && z < i)
                    {
                        thirdNo = z;
                        if (y < i)
                        {
                            fourthNo = y; fifthNo = i;
                        }
                        else
                        {
                            fourthNo = i; fifthNo = y;
                        }
                    }

                }
                #endregion
            }
            #endregion
            #region z
            else if (z < x && z < y && z < i && z < j)
            {
                firstNo = z;
            }
            #endregion
            #region i
            else if (i < x && i < y && i < z && i < j)
            {
                firstNo = i;
            }
            #endregion
            #region j
            else if (j < x && j < y && j < z && j < i)
            {
                firstNo = j;
            }
            #endregion
            Console.WriteLine(firstNo+","+ secondNo + "," + thirdNo + "," + fourthNo+ "," + fifthNo);
        }

        public static void SwapA()
        {
            int x = 123;
            int y = 65;
            int z = 0;
            Console.WriteLine("x="+x+",y="+y);
            //swap
            z = x;
            x = y;
            y = z;
            Console.WriteLine("x=" + x + ",y=" + y);
        }
        public static void SwapB()
        {
            int x = 123;
            int y = 65;
            Console.WriteLine("x=" + x + ",y=" + y);
            //swap
            //.....
            Console.WriteLine("x=" + x + ",y=" + y);

        }
        public static int DoTask()
        {
            return 0;
        }
    }
}
