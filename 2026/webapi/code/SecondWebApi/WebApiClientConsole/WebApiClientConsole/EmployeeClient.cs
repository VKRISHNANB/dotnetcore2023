using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json;

namespace WebApiClientConsole
{
    internal class EmployeeAPIClient
    {
        static Uri uri = new Uri("http://localhost:5000/");
        public static async Task CallGetAllEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                // HttpGet:
                HttpResponseMessage response =
                    await client.GetAsync("GetAllEmployees");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String x = await response.Content.ReadAsStringAsync();
                    await Console.Out.WriteLineAsync(x);
                }
            }
        }

        public static async Task GetAllEmployeeJson()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                List<Employee> employees = new List<Employee>();
                client.DefaultRequestHeaders
                    .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HttpGet:
                HttpResponseMessage response = await client.GetAsync("GetAllEmployees");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String json = await response.Content.ReadAsStringAsync();
                    // install Newtonsoft.Json using PackageManager
                    employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                    foreach (Employee emp in employees)
                    {
                        await Console.Out.WriteLineAsync($" {emp.EmpId}, {emp.FirstName}, {emp.LastName}");
                    }
                }
            }
        }

        public static async Task FindEmployeeByID()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                Employee emp = null;
                client.DefaultRequestHeaders
                    .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HttpGet:
                HttpResponseMessage response = await client.GetAsync("FindEmployees?id=5");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String json = await response.Content.ReadAsStringAsync();
                    // install Newtonsoft.Json using PackageManager
                    emp = JsonConvert.DeserializeObject<Employee>(json);
                    await Console.Out.WriteLineAsync($" {emp.EmpId}, {emp.FirstName}, {emp.LastName}");
                }
            }
        }
        public static async Task AddnewEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Employee employee = new Employee()
                {
                    FirstName = "William",
                    LastName = "John",
                    City = "Nyc",
                    BirthDate = new DateTime(1980, 01, 01),
                    HireDate = new DateTime(2000, 01, 01),
                    Title = "Manager"
                };
                var myContent = JsonConvert.SerializeObject(employee);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType =
                    new MediaTypeHeaderValue("application/json");
                // HttpPost:
                HttpResponseMessage response =
                    await client.PostAsync("AddNewEmployees", byteContent);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(response.StatusCode.ToString());
                }
            }
        }
        public static async Task UpdateEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Employee employee = new Employee()
                {
                    EmpId = 18,
                    FirstName = "Elton",
                    LastName = "John",
                    City = "Nyc",
                    BirthDate = new DateTime(1960, 01, 01),
                    HireDate = new DateTime(1985, 01, 01),
                    Title = "Manager"
                };
                var myContent = JsonConvert.SerializeObject(employee);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType =
                    new MediaTypeHeaderValue("application/json");
                // HttpPost:
                HttpResponseMessage response =
                    await client.PostAsync("ModifyEmployees", byteContent);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(response.StatusCode.ToString());
                }
            }
        }
        public static async Task DeleteEmployeeByID()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders
                    .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HttpGet:
                HttpResponseMessage response = await client.PostAsync("DeleteEmployees?id=10",null);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(response.StatusCode.ToString());
                }
            }
        }
    }
}
