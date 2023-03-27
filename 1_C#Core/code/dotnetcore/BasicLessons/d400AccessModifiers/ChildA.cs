using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d71AccessModifiers
{
    public class ChildA: DemoA
    {
        public void ExecuteTasks()
        {
            Console.WriteLine("===========From Child Class==============");
            this.DotaskA();// public
            //this.DotaskB(); // private
            this.DotaskC(); // internal
            this.DotaskD(); // protected
            this.DotaskE(); // internal protected
        }
    }
}
