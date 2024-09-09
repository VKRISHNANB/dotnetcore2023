using System;
using System.Collections.Generic;
using System.Text;

namespace SpatialDataSample
{
    class SpatialDataSample
    {
        static void M1()
        {
            Random lng = new Random();
            Random lat = new Random();
            Random alt = new Random();

            int[][,,] loc=new int[10][,,];
            for (int i = 0; i < 10; i++)
            {
                loc[i] = new int[1, 1, 3];
                loc[i][0, 0, 0] = lng.Next(0, 180);
                loc[i][0, 0, 1] = lat.Next(0, 90);
                loc[i][0, 0, 2] = alt.Next(0, 8000);
            }
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console .Write( loc[i][0, 0, j]+ " ");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
