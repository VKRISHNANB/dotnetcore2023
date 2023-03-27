using System;
using System.Collections;
class MyListBox
{
    protected ArrayList data = new ArrayList();
    public object this[int idx]
    {
        get
        {
            if (idx > -1 && idx < data.Count)
            {
                return (data[idx]);
            }
            else
            {
                return null;
            }
        }
        set
        {
            if (idx > -1 && idx < data.Count)
            {
                data[idx] = value;
            }
            else if (idx == data.Count)
            {
                data.Add(value);
            }
        }
    }
}

class Indexers1App
{
    public static void M1()
    {
        MyListBox lbx = new MyListBox();
        lbx[0] = "foo";
        lbx[1] = "bar";
        lbx[2] = "baz";
        Console.WriteLine("{0} {1} {2}", 
                           lbx[0], lbx[1], lbx[2]);
    }
}
 
