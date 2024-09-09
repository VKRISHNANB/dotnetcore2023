using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class TestBinaryFormatter
{
   public static void TestA()  {
      TestSimpleObject obj = new TestSimpleObject();
      Console.WriteLine("Before serialization");
      obj.Print();

      //Opens a file and serializes the object into it in binary format.
      Stream stream = File.Open("data.dat", FileMode.Create);     

    BinaryFormatter formatter = new BinaryFormatter();

      formatter.Serialize(stream, obj);
      stream.Close();
   
      //Empties obj.
      obj = null;
   
      //Opens file "data.xml" and deserializes the object from it.
      stream = File.Open("data.dat", FileMode.Open);
     // formatter = new SoapFormatter();

     formatter = new BinaryFormatter();

      obj = (TestSimpleObject)formatter.Deserialize(stream);
      stream.Close();

      Console.WriteLine("");
      Console.WriteLine("After deserialization the object contains: ");
      obj.Print();
   }
}


