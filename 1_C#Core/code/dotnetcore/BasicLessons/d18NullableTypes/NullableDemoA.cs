using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d11NullableTypes
{
    class NullableDemoA
    {
        public static void M1()
        {
            int x = 100;
            //x = null;
            Console.WriteLine(" X = " + x );

            int? y = 200;
            Console.WriteLine("Does Y has Value " + y.HasValue );
            Console.WriteLine(" Y = " + y.GetValueOrDefault() );
            y = null;
            Console.WriteLine("Does Y has Value " + y.HasValue);
            Console.WriteLine(" Y = " + y.GetValueOrDefault());
            //Console.WriteLine("Y= " + y.Value);//Error
            if (y.HasValue)
                Console.WriteLine("Y= " + y.Value);
            else
                Console.WriteLine("Y is NULL");
        }
    }
}
