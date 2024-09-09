using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties.Activity1
{
    class Bank
    {
        public String Name=String.Empty;
        public String HOAddress=String.Empty;
        Branch[] BranchList=null;
        public void SetBranches(Branch[] blist)
        {
            BranchList=blist;
            foreach(Branch b in BranchList )
                Console.WriteLine(b.BranchId+" "+b.Location);
        }
    }
}
