using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6
{
    // A class with private constructors can not be inherited
    public class ClassX
    {
        private ClassX() { }
    }
    //public class ClassY : ClassX
    //{

    //}

    // A SEALED class can not be inherited
    public sealed class ClassR
    {
        public ClassR() { }
    }
    //public class ClassT : ClassR
    //{}

    // A STATIC class can not be inherited
    public static class ClassV
    {
       // public ClassV() { }
    }
    //public  class ClassW: ClassV
    //{    }
}
