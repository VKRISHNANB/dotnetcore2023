using System;
using System.Collections;
class MyArray
{
  Object _x;
    public object x
    {
        get
        {
                return _x;
        }
        set
        {
                _x = value;
        }
    }
}

class MyApp
{
    public static void M1()
    {
        MyArray[] lbx=new MyArray[3] ;
        for (int i=0; i < lbx.Length;i++){
           lbx.SetValue(new MyArray(),i);
           lbx[i].x = i*10;
  /*
        lbx[0]=new MyArray();
        lbx[0].x = 10;
        lbx[1]=new MyArray();
        lbx[1].x = 20;
        lbx[2]=new MyArray();
        lbx[2].x = 30;
    */
       }
       Console.WriteLine("{0} {1} {2}", 
                           lbx[0].x, lbx[1].x, lbx[2].x);
    }
}
 
