using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons 
{
    class MobilePhone
    {
        private long mnumber;
        private string color = string.Empty;
        private string model = string.Empty;
        public long MobileNumber
        {
            get{   return mnumber;  }
            set
            {
                if (value < 90000 || value >= 100000)
                {
                    Console.WriteLine("invalid mobile number");
                    return;
                }
                mnumber = value;
            }
        }
    }
    public class TestMobilehone
    {
        public static void TestA()
        {
            MobilePhone obj = new MobilePhone();
            obj.MobileNumber = 9000000000;
            Console.WriteLine("mnumber is" + obj.MobileNumber);
        }

    }
}
