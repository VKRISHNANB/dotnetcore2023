using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasicLessons
{
    public class BufferedStreamDemo
    {
        static MemoryStream memoryStream = new MemoryStream();

        public static void WritingToStreamUSingBufferedStream()
        {
            String data = "Hello How are you";
            byte[] encodedstringdata = Encoding.ASCII.GetBytes(data);
            int arrayLength = encodedstringdata.Length;
            // Use BufferedStream to buffer writes to a MemoryStream.
            BufferedStream stream = new BufferedStream(memoryStream);
            stream.Write(encodedstringdata, 0, arrayLength);
            stream.Flush();
            Console.WriteLine("BUFFEREDSTREAM " + memoryStream.Length);
        }

        public static void ReadingFromStreamUSingBufferedStream()
        {
            String data = String.Empty;
            int arrayLength = (int)memoryStream.Length;
            byte[] encodedstringdata = new byte[arrayLength];
            StringBuilder stringbuilder = null;
            using (BufferedStream stream = new BufferedStream(memoryStream))
            {
                // memoryStream.Position = 0;
                stream.Position = 0;
                stream.Read(encodedstringdata, 0, arrayLength);
                stringbuilder = new StringBuilder(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    stringbuilder.Append((char)encodedstringdata[i]);
                }
            }
            Console.WriteLine("OUTPUT " + stringbuilder.ToString());
        }
    }
}
