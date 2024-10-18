Imports System.ComponentModel.DataAnnotations

Public Class Employee
    Private id As String
    Private city As String
    Private salary As Integer
    Private name As String
    <Key>
    Public Property EmployeeNo() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    <StringLength(15, ErrorMessage:="Name Length must be between 3 and 15", MinimumLength:=3)>
    <Required>
    Public Property EmployeeName() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    <StringLength(15, ErrorMessage:="City Length must be between 3 and 15", MinimumLength:=3)>
    Public Property EmployeeCity() As String
        Get
            Return city
        End Get
        Set(ByVal value As String)
            city = value
        End Set
    End Property
    <Required>
    <Range(20000, 10000, ErrorMessage:="Salary must be between 20000 and 100000")>
    Public Property EmployeeSalary() As Integer
        Get
            Return salary
        End Get
        Set(ByVal value As Integer)
            salary = value
        End Set
    End Property
End Class
