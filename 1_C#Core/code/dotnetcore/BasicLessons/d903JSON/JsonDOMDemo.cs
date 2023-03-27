using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace BasicLessons
{
    public class JsonDOMDemo
    {
        public static void ParseJson()
        {
            String jsonString =
                @"{  ""ClassName"": ""Science"", ""TeacherName"": ""Jane"",  ""Semester"": ""2019-01-01"",  ""Students"": [    {      ""Name"": ""John"",      ""Grade"": 94.3    },    {      ""Name"": ""James"",      ""Grade"": 81.0    },    {      ""Name"": ""Julia"",      ""Grade"": 91.9    },    {      ""Name"": ""Jessica"",      ""Grade"": 72.4    },    {      ""Name"": ""Johnathan""    }  ],  ""Final"": true}";
            // System.Console.WriteLine(jsonString);
            double sum = 0;
            int count = 0;

#region a
            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                JsonElement root = document.RootElement;
                foreach (var node in root.EnumerateObject())
                {
                    System.Console.WriteLine(node.ToString());
                }
            }
#endregion a
           #region  b
            // using (JsonDocument document = JsonDocument.Parse(jsonString))
            // {
            //     JsonElement root = document.RootElement;
            //     JsonElement classElement = root.GetProperty("ClassName");
            //     System.Console.WriteLine("ClassName:"+classElement.GetString());
            //     JsonElement teacherElement = root.GetProperty("TeacherName");
            //     System.Console.WriteLine("TeacherName:"+teacherElement.GetString());
            //     JsonElement semesterElement = root.GetProperty("Semester");
            //     System.Console.WriteLine("Semester:"+semesterElement.GetString());
            //     JsonElement studentsElement = root.GetProperty("Students");
            //     foreach (JsonElement student in studentsElement.EnumerateArray())
            //     {
            //         System.Console.Write($"\t { student.GetProperty("Name").GetString()}");
            //         if (student.TryGetProperty("Grade", out JsonElement gradeElement))
            //         {
            //             sum += gradeElement.GetDouble();
            //             System.Console.WriteLine($", {student.GetProperty("Grade").GetDouble()}");
            //         }
            //         else
            //         {
            //             sum += 0;
            //         }
            //         count++;
            //     }
            // }
            //  System.Console.WriteLine();
            // double average = sum / count;
            // Console.WriteLine($"Average grade : {average}");
            #endregion b
        }

        public static void ParseJson(string fileName)
        {
            String jsonString = File.ReadAllText(fileName);
              using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                JsonElement root = document.RootElement;
               
                foreach (var node in root.EnumerateArray())
                {
                    System.Console.WriteLine(node.ToString());
                }
            }
        }
    }
}
