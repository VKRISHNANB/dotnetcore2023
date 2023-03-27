using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d94Generics
{
    class IndiaBizQ7
    {
        public void M1()
        {
            MyContainer<ClassA> m1 = new MyContainer<ClassA>();
            m1.obj = new ClassA();
            m1.Echo();
            // MyContainer<ClassB> m2 = new MyContainer<ClassB>();
            MyContainer<ClassC> m3 = new MyContainer<ClassC>();
            m3.obj = new ClassC();
            m3.Echo();
            //--------------------
            YourContainer<ClassA> y1= new YourContainer<ClassA>();
            y1.obj = new ClassA();
            y1.Echo();
            //YourContainer<ClassC> y2 = new YourContainer<ClassC>();
        }
    }
    public interface IService
    {
    }
    public class ClassA: IService
    {

    }
    public class ClassB
    {

    }
    public struct ClassC : IService
    {

    }
   
    public class MyContainer<T> where T : IService
    {
        public T obj;
        public void Echo()
        {
            if(null!=obj)
             Console.WriteLine(obj.GetHashCode());
        }
    }
    public class YourContainer<T> where T :class, IService
    {
        public T obj;
        public void Echo()
        {
            if (null != obj)
                Console.WriteLine(obj.GetHashCode());
        }
    }
}
