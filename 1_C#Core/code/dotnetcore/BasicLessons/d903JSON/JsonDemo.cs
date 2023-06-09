using System.Text;
using System.Text.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLessons
{
    public class MyModel
{
    public string MyString { get; set; }
    public int MyInt { get; set; }
    public bool MyBoolean { get; set; }
    public decimal MyDecimal { get; set; }
    public DateTime MyDateTime1 { get; set; }
    public DateTime MyDateTime2 { get; set; }
    public List<string> MyStringList { get; set; }
    public Dictionary<string, Person> MyDictionary { get; set; }
    public MyModel MyAnotherModel { get; set; }
}
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}
    public class JsonDemo
    {
        // MyModelJson();
     
        public static void MyModelJson()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            string filename1=@"C:\temp\mymodel.json";

            var jsonString = File.ReadAllText(filename1);
            var jsonModel = JsonSerializer.Deserialize<MyModel>(jsonString, options);
            var modelJson = JsonSerializer.Serialize(jsonModel, options);
            Console.WriteLine(jsonModel);
        }
    }
}
