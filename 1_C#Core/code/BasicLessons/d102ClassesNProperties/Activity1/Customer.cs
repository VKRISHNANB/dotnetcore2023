using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties.Activity1
{
    enum AccountType { Savings,Current }
    class Customer
    {
        public String Name;
        public long Accountnumber;
        public AccountType TypeofAccount;
        public String Address;
        public long Phonenumber;
        public String emailaddress;
    }
}
