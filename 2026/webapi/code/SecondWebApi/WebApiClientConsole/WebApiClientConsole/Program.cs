// See https://aka.ms/new-console-template for more information
using WebApiClientConsole;

Console.WriteLine("API CLIENT!");
//EmployeeAPIClient.CallGetAllEmployee().Wait();
//EmployeeAPIClient.GetAllEmployeeJson().Wait();
//EmployeeAPIClient.FindEmployeeByID().Wait();
//EmployeeAPIClient.AddnewEmployee().Wait();
//EmployeeAPIClient.UpdateEmployee().Wait();
EmployeeAPIClient.DeleteEmployeeByID().Wait();

Console.ReadLine();