using System;
using System.IO;
namespace Sample.Delegates
{
    public delegate void Notify(int intValue);
    public class B
    {
        public event Notify Callback;
        static int intCount = 0;
        public void Write(int value)
        {
            try
            {
                intCount = intCount + value;
                int i = 0;
                Delegate[] obj = this.Callback.GetInvocationList();
                while (i < obj.Length - 1)
                {
                    obj[i].DynamicInvoke(new object[] { i + intCount });
                    this.Callback = (Notify)obj[i + 1];
                    i = i + 2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }//end of method
    }//end of class
}// end of namespace
