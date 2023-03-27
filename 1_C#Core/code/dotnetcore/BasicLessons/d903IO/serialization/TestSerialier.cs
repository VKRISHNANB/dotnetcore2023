using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

using System.Runtime.Serialization.Formatters.Binary;

namespace BasicLessons.d93IO.serialization
{
    class TestSerialier
    {
            public static void TestA()
            {
                FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

                try
                {
                    // Construct a BinaryFormatter and use it 
                    // to serialize the data to the stream.
                    BinaryFormatter formatter = new BinaryFormatter();

                    // Create an array with multiple elements refering to 
                    // the one Singleton object.
                    Singleton[] a1 = { Singleton.GetSingleton(), Singleton.GetSingleton() };

                    // This displays "True".
                    Console.WriteLine(
                        "Do both array elements refer to the same object? " +
                        (a1[0] == a1[1]));

                    // Serialize the array elements.
                    formatter.Serialize(fs, a1);

                    // Deserialize the array elements.
                    fs.Position = 0;
                    Singleton[] a2 = (Singleton[])formatter.Deserialize(fs);

                    // This displays "True".
                    Console.WriteLine("Do both array elements refer to the same object? "
                        + (a2[0] == a2[1]));

                    // This displays "True".
                    Console.WriteLine("Do all array elements refer to the same object? "
                        + (a1[0] == a2[0]));
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                   // throw;
                }
                finally
                {
                    fs.Close();
                }
            }
        }
}
