Imports System.Web.Http.Cors
Imports System.Net
Imports System.Web.Http
<EnableCors("*", "*", "*")>
Public Class EmployeeController
    Inherits ApiController
    Public Function GetValues() As IEnumerable(Of Employee)
        'Return New String() {"value1", "value2"}
        Dim repo As New EmployeeRepository
        Dim list As List(Of Employee) = repo.GetAllEmployee()
        Return list
    End Function
    ' GET api/<controller>
    Public Function GetValue(ByVal id As Integer) As Employee
        ' Return "value"
        Dim repo As New EmployeeRepository
        Dim emp As Employee = repo.FindEmployeeByID(id)
        Return emp
    End Function
    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal emp As Employee)
        Dim repo As New EmployeeRepository
        repo.AddNewEmployee(emp)
    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(<FromBody()> ByVal emp As Employee)
        Dim repo As New EmployeeRepository
        repo.UpdateEmployee(emp)
    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)
        Dim repo As New EmployeeRepository
        repo.DeleteEmployee(id)
    End Sub
End Class
