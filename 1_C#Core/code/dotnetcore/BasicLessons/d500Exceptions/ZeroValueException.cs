using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
    class ZeroValueException:ApplicationException // Exception
    {
        public ZeroValueException() : base("Value is Zero Error!!!") { }
        public ZeroValueException(String msg) : base(msg) { }
        public ZeroValueException(String msg,Exception innerex) 
            : base(msg, innerex) { }
    }
}
