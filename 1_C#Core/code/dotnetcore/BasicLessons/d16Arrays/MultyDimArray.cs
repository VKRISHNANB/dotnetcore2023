using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicLessons.d31Arrays
{
    class MultiDimArray
    {
        protected int currentMonth;
        protected double[,] sales;
        public MultiDimArray()
        {
            currentMonth=10; 
            sales = new double[2, currentMonth];
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j=0; j < 10; j++)
                    sales[i,j] = (i * 100) + j;
            }
        }

        public  void PrintSales()
        {
            //The number of dimensions in an array
            //is called an array's rank,
            int rank = sales.Rank;
            Console.WriteLine("Rank of Sales " + rank);
            for (int k = 0; k < rank; k++)
             Console.WriteLine("Length of Sales({0}) {1}" ,k,
                                                    sales.GetLength(k));            
            Console.WriteLine("Length of Sales " + sales.Length );
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j=0; j < sales.GetLength(1); j++)
                 Console.WriteLine("[{0}][{1}]={2}", i, j, sales[i,j]);
            }
        }

    }
}
