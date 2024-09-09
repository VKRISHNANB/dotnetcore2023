using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamsSamples
{
    public partial class DemoB 
    {
        
       static  MemoryStream memoryStream = new MemoryStream();
        //Using BinaryWriter to store random byte value
        public static void WriteBytesToMemoryStream()
        {
            Console.WriteLine("MemoryStream Length " + memoryStream.Length);
            int arrayLength = 10;
            byte[] dataArray = new byte[arrayLength];
           
            // Create random numbers and fill the dataArray
            Random r1 = new Random();
            r1.NextBytes(dataArray);
            StringBuilder str = new StringBuilder(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                str.Append(dataArray[i]);
                str.Append(";");
            }
            Console.WriteLine(str);

            //bool flag = true;
            //byte[] data = BitConverter.GetBytes(flag);
            BinaryWriter binWriter = new BinaryWriter(memoryStream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray); 
            Console.WriteLine("Write Completed "+memoryStream.Length);
        }
        //Using BinaryReader
        public static void ReadBytesFromMemoryStream()
        {
            if(memoryStream.Length==0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
           // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(memoryStream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)memoryStream.Length;
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            StringBuilder str = new StringBuilder(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                str.Append(verifyArray[i] );
                str.Append(";");
            }
            Console.WriteLine(str);
        }

        //Using BinaryWriter to store String 
        public static void WriteStringToMemoryStream()
        {
            Console.WriteLine("MemoryStream Length " + memoryStream.Length);
            Console.WriteLine("Enter a String ");
            String inputData = Console.ReadLine();
            if(inputData==null)
            {
                System.Console.WriteLine("INPUT IS EMPTY");
                return;
            }
            byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
            BinaryWriter binWriter = new BinaryWriter(memoryStream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray);
            Console.WriteLine("Write Completed " + memoryStream.Length);
        }
        //Using BinaryReader for Storing Strings
        public static void ReadStringFromMemoryStream()
        {
            if (memoryStream.Length == 0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
            // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(memoryStream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)memoryStream.Length;
            // memoryStream.Length is Long but binReader.ReadBytes(int)
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            String stringOutput = Encoding.ASCII.GetString(verifyArray);
            Console.WriteLine(stringOutput);

            //StringBuilder sb = new StringBuilder(arrayLength);
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    sb.Append((char)verifyArray[i]);
            //}
            //Console.WriteLine(sb);

        }

        public static void UsingStreamWriterandStreamReader()
        {
            byte[] storage = new byte[255];
            // Create a memory-based stream.
            MemoryStream memoryStream = new MemoryStream(storage);
            // Wrap memoryStream in a reader and a writer.
            StreamWriter memwtr = new StreamWriter(memoryStream);
            // Write to storage, through memwtr.
            for (int i = 0; i < 10; i++)
                memwtr.WriteLine("Hello"+i);
            // Put a period at the end.
            memwtr.WriteLine(".");
            memwtr.Flush();
            Console.WriteLine("Reading from storage directly: ");
            // Display contents of storage directly.
            foreach (char ch in storage)
            {
                if (ch == '.') break;
                Console.Write(ch);
            }
            StreamReader memrdr = new StreamReader(memoryStream);
            Console.WriteLine("\nReading through memrdr: ");
            // Read from memoryStream using the stream reader.
            memoryStream.Seek(0, SeekOrigin.Begin); // reset file pointer
            string str = memrdr.ReadLine();
            while (str != null)
            {
                str = memrdr.ReadLine();
                if (str.CompareTo(".") == 0) break;
                Console.WriteLine(str);
            }
        }
        // Create a memory-based stream.
        // static byte[] storage = new byte[255];
        // static MemoryStream memoryStream = new MemoryStream(storage);
        public static void MemStreamWriter()
        {
            // Wrap memoryStream in a reader and a writer.
            StreamWriter? memwtr = null;
            // Write to storage, through memwtr.
            String? str = String.Empty;
            try {
                Console.WriteLine("Enter a Sentence:");
                str = Console.ReadLine();
                memwtr = new StreamWriter(memoryStream);
                memwtr.WriteLine(str);
                // Put a period at the end.
                memwtr.WriteLine(".");
                memwtr.Flush();
                Console.WriteLine("memoryStream.Length " + memoryStream.Length);
                Console.WriteLine("memoryStream.Capacity " + memoryStream.Capacity);
                Console.WriteLine("memoryStream.Postion " + memoryStream.Position);
            }
            catch(Exception err)
            {
                Console.WriteLine("ERROR!!! "+err.Message);
            }
            finally {
               //memwtr.Close();
            }
        }
        public static void MemStreamReader()
        {
            //Console.WriteLine("Reading from storage directly: ");
            //Console.WriteLine("memoryStream.Postion " + memoryStream.Position);
            //// Display contents of storage directly.
            //byte[] storage = new byte[255];
            //storage = memoryStream.ToArray();
            //foreach (char ch in storage)
            //{
            //    if (ch == '.') break;
            //    Console.Write(ch);
            //}
            Console.WriteLine("memoryStream.Postion " + memoryStream.Position);
            StreamReader memrdr = new StreamReader(memoryStream);
            try
            {
                Console.WriteLine("\nReading through memrdr: ");
                // Read from memoryStream using the stream reader.
                memoryStream.Seek(0, SeekOrigin.Begin); // reset file pointer
                Console.WriteLine("memoryStream.Postion After seek " + memoryStream.Position);

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
