using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d94Generics
{
    public class Company<T>
    {
        public T[] Data;
        public void Init(int noOfItems)
        {
            Data = new T[noOfItems];
        }  
        public void DisplayTypeInfo()
        {
          if(Data==null) 
           Console.WriteLine("Data is Null");
          else 
           Console.WriteLine("Type "+Data.GetType().FullName);
        }
        public void ShowContent()
        {
            int count = 0;
            while(Data[count]!=null)
            {
                Console.WriteLine(Data[count]);
                count++;
                if (count == Data.Length) break;
            }
        }
        public int Add(T v1,T v2)
        {
            return v1.GetHashCode() + v2.GetHashCode();
        }
    }
}
