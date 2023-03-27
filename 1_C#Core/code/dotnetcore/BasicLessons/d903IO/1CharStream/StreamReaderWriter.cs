using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BasicLessons
{ 
    class StreamReaderWriter
    {
        //static MemoryStream tempMemorystream = new MemoryStream();
        //public static void UsingStreamWriterandStreamReader()
        //{
        //    byte[] storage = new byte[255];
        //    // Create a memory-based stream.
        //    MemoryStream tempmemorystream = new MemoryStream(storage);
        //    // Wrap tempmemorystream in a reader and a writer.
        //    StreamWriter streamwriter = new StreamWriter(tempmemorystream);
        //    // Write to storage, through streamwriter.
        //    for (int i = 0; i < 10; i++)
        //        streamwriter.WriteLine(" Hello" + i);
        //    // Put a period at the end.
        //    streamwriter.WriteLine(".");
        //    streamwriter.Flush();
        //    Console.WriteLine("Reading from storage directly: ");
        //    StreamReader streamreader = new StreamReader(tempmemorystream);
        //    Console.WriteLine("\nReading through streamreader: ");
        //    // Read from tempmemorystream using the stream reader.
        //    tempmemorystream.Seek(0, SeekOrigin.Begin); // reset file pointer
        //    //streamreader.Read();
        //    string stringdata = streamreader.ReadLine();
        //    while (stringdata != null)
        //    {
        //        stringdata = streamreader.ReadLine();
        //        if (stringdata.CompareTo(".") == 0) break;
        //        Console.WriteLine(stringdata);
        //    }

        //    // Display contents of storage directly.
        //    foreach (char ch in storage)
        //    {
        //        if (ch == '.') break;
        //        Console.Write(ch);
        //    }
        //}

        // Create a memory-based stream.
        static byte[] storage = new byte[255];
        static MemoryStream tempmemorystream = new MemoryStream(storage);
        public static void MemStreamWriter()
        {
            // Wrap tempmemorystream in a reader and a writer.
            StreamWriter streamwriter = null;
            // Write to storage, through streamwriter.
            String str = String.Empty;
            try
            {
                Console.WriteLine("Enter a Sentence:");
                str = Console.ReadLine();
                streamwriter = new StreamWriter(tempmemorystream);
                streamwriter.WriteLine(str);
                // Put a period at the end.
                streamwriter.WriteLine(".");
                streamwriter.Flush();
                Console.WriteLine("tempmemorystream.Length " + tempmemorystream.Length);
                Console.WriteLine("tempmemorystream.Capacity " + tempmemorystream.Capacity);
                Console.WriteLine("tempmemorystream.Postion " + tempmemorystream.Position);
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR!!! " + err.Message);
            }
            finally
            {
                //streamwriter.Close();
            }
        }
        public static void MemStreamReader()
        {
            Console.WriteLine("memstrm.Postion " + tempmemorystream.Position);
            StreamReader memrdr = new StreamReader(tempmemorystream);
            try
            {
                Console.WriteLine("\nReading through memrdr: ");
                // Read from tempmemorystream using the stream reader.
                tempmemorystream.Seek(0, SeekOrigin.Begin); // reset file pointer
                Console.WriteLine("tempmemorystream.Postion After seek " + tempmemorystream.Position);
                string str = memrdr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    //if (str.CompareTo(".") == 0) break;
                    str = memrdr.ReadLine();
                }
            }
            finally
            {
                memrdr.Close();
            }
        }
    }
}

/*
 * 
 * //Console.WriteLine("Reading from storage directly: ");
            //Console.WriteLine("memstrm.Postion " + memstrm.Position);
            //// Display contents of storage directly.
            //byte[] storage = new byte[255];
            //storage = memstrm.ToArray();
            //foreach (char ch in storage)
            //{
            //    if (ch == '.') break;
            //    Console.Write(ch);
            //}
 * 
 * */
