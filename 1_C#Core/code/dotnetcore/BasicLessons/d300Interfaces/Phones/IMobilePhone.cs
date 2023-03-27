using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Interfaces.Phones
{
    public interface IMobilePhone 
    {
        void MakeaCall();
        void SendSMS();
        void AddContact();
    }
}
