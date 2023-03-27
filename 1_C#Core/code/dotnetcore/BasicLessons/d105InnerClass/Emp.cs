using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4InnerClass
{
    class Emp
    {
        public int Eno=0;
        private readonly Address add;
       
        public Emp()
        {
            add = new Address(this);
        }
        public Address GetAddress()
        {
            return add;
        }
        //Inner Class
        public class Address
        {
            public String Address1;
            public String Address2;
            private readonly Emp e1;

            internal Address(Emp outerEmp)
            {
                e1 = outerEmp;
            }
            public override string ToString()
            {
            return Address1+","+Address2+" of "+e1.Eno;
            }
        }//end of Address
    }//end of Emp
}
