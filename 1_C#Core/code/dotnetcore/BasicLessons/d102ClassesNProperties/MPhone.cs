using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties
{
    enum Color { WHITE=1, BLACK=2, RED=3, BLUE=4, GREEN=5}
    class MPhone
    {
        //Field
        private long mNumber;
        private Color color ;
        private float cost;
        private String model = String.Empty;
        //properties
        public long MobileNo //(long value)
        {
            get
            {
                return mNumber;
            }

            set
            {
                //if (value < 9000000000 || value > 10000000000)
                //    throw new Exception("In Valid Mobile No");
                if (value < 9000000000L || value > 10000000000L)
                {
                    Console.WriteLine("In Valid Mobile No");
                    return;
                }
                mNumber = value;
            }
        }

        public Color PhoneColor
        {
            get
            {
                return color;
            }
            set
            {
                #region A
                //char[] data = value.ToUpper().ToCharArray();
                //for(int i=0;i<data.Length;i++)
                //{
                //    int ascii = (int)data[i];
                //    if (ascii<65 || ascii >90)
                //    {
                //        Console.WriteLine("ERROR!!! Invalid Color!");
                //        return;
                //    }
                //}
                #endregion
                color = value;
            }
        }

        public float Cost //(float value)
        {
            get
            {
                return cost;
            }

            set
            {
                //should be > zero. Must be Multiple of 50/- . Not mor than 100000/-
                if(value<0)
                {
                    Console.WriteLine("ERROR!!! Cost must be Greater than Zero!");
                    return;
                }
                else if((value%50)!=0)
                {
                    Console.WriteLine("ERROR!!! Cost must be Multiples of 50");
                    return;
                }
                else if(value>100000)
                {
                    Console.WriteLine("ERROR!!! Cost must be Less than 100000!");
                    return;
                }
                cost = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        //Methods
        public void MakeaCall(long calledNo)
        {
            Console.WriteLine("Calling .. "+calledNo);
        }
        public void ReceiveCall(long callingNo)
        {
            Console.WriteLine("Received call from .. " + callingNo);
        }
        public void SendMessage(long msgToNo,String msg)
        {
            Console.WriteLine(msg+"   Sending Message to .. " + msgToNo);
        }
        public void ReceiveMessage(long msgFromNo,String msg)
        {
            Console.WriteLine(msg+" Received message from .. " + msgFromNo);
        }
        public void ShowDetails()
        {
            Console.WriteLine("Mobile Number "+MobileNo);
            Console.WriteLine("Mobile Color "+Enum.GetName(typeof( Color),PhoneColor));
            Console.WriteLine("Mobile Cost "+Cost);
            Console.WriteLine("Mobile model "+Model);
        }
    }
}
