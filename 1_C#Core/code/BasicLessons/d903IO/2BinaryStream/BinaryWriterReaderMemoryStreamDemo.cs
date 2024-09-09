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
        
       static  MemoryStream tempMemorystream = new MemoryStream();
        //Using BinaryWriter to store random byte value
        public static void WriteBytesToMemoryStreamusingBinaryWriter()
        {
            byte[] stringdata = Encoding.ASCII.GetBytes("Hello");
            byte[] bitdata = BitConverter.GetBytes(true);// converts boolen to byte
            Console.WriteLine("MemoryStream Length " + tempMemorystream.Length);
            int arrayLength = 10;
            byte[] dataArray = new byte[arrayLength];
           
            // Create random numbers and fill the dataArray
            Random r1 = new Random();
            r1.NextBytes(dataArray);
            #region checkRandomValue
            //StringBuilder str = new StringBuilder(arrayLength);
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    str.Append(dataArray[i]);
            //    str.Append(";");
            //}
            //Console.WriteLine(str);
            #endregion
            BinaryWriter binWriter = new BinaryWriter(tempMemorystream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            Console.WriteLine("Before Writting to stream " + tempMemorystream.Length);
            binWriter.Write(dataArray); 
            Console.WriteLine("Write Completed "+tempMemorystream.Length);
        }
        //Using BinaryReader
        public static void ReadBytesFromMemoryStreamBinaryReader()
        {
            if(tempMemorystream.Length==0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
           // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(tempMemorystream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)tempMemorystream.Length;
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            StringBuilder stringbuilder = new StringBuilder(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                stringbuilder.Append(verifyArray[i] );
                stringbuilder.Append(";");
            }
            Console.WriteLine(stringbuilder);
        }

        //Using BinaryWriter to store String 
        public static void WriteStringToMemoryStreamBinaryWriter()
        {
            Console.WriteLine("MemoryStream Length " + tempMemorystream.Length);
            Console.WriteLine("Enter a String ");
            String inputData = Console.ReadLine();
            byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
            BinaryWriter binWriter = new BinaryWriter(tempMemorystream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray);
            Console.WriteLine("Write Completed " + tempMemorystream.Length);
        }
        //Using BinaryReader for Storing Strings
        public static void ReadStringFromMemoryStreamBinaryReader()
        {
            if (tempMemorystream.Length == 0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
            // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(tempMemorystream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)tempMemorystream.Length;
            // tempMemorystream.Length is Long but binReader.ReadBytes(int)
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
    }
}
