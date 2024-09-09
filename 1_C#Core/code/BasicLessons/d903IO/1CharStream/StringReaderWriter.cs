using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BasicLessons
{
    class StringReaderWriter
    {
        static StringBuilder stringToWriteRead = new StringBuilder();
       
        public static void WriteCharacters()
        {
            string textReaderText = "Tom and Jerry is an American animated media franchise and series of comedy short films created in 1940 by William Hanna and Joseph Barbera. Best known for its 161 theatrical short films by Metro-Goldwyn-Mayer, the series centers on the rivalry between the titular characters of a cat named Tom and a mouse named Jerry. Many shorts also feature several recurring characters.";
            StringWriter strWriter = new StringWriter(stringToWriteRead);
            try
            {
                //Write to StringBuilder
                strWriter.WriteLine(textReaderText);
                Console.WriteLine("Thank You");
                Console.WriteLine("Information Saved!");
                Console.WriteLine();
            }
            finally
            {
                //Close the stream
                strWriter.Flush();
                strWriter.Close();
            }
           
         

           
        }

        public static void ReadCharacters()
        {
            using (StringReader reader = new StringReader(stringToWriteRead.ToString()))
            {
                string readText = reader.ReadToEnd();
                Console.WriteLine(readText);
            }
        }

        public static void PeekAndReadCharacters()
        {
            string textReaderText = "Tom and Jerry is an American animated media franchise and series of comedy short films created in 1940 by William Hanna and Joseph Barbera. Best known for its 161 theatrical short films by Metro-Goldwyn-Mayer, the series centers on the rivalry between the titular characters of a cat named Tom and a mouse named Jerry. Many shorts also feature several recurring characters.";

            Console.WriteLine("Original text:\n\n{0}", textReaderText);

            StringReader strReader = new StringReader(textReaderText);
            //Peek to see if the next character exists
            try
            {
                while (strReader.Peek() > -1)
                {
                    //Read a line from the string and display it on the
                    //console
                    Console.WriteLine(strReader.ReadLine());
                }

                Console.WriteLine("Data Read Complete!");
            }
            finally
            {
                //Close the stringReader
                strReader.Close();
            }

        }
    }
}
