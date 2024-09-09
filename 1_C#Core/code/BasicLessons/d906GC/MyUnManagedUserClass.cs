using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCSample
{
    class MyUnManagedUserClass
    {
        Object obj=null;
        Object unmanagedObject=null;
        public void Display()
        {
            Console.WriteLine(obj==null);
            Console.WriteLine(unmanagedObject==null);
        }
    }
}
