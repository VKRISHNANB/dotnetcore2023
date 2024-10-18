Imports Oracle.ManagedDataAccess.Client
Public Class EmployeeRepository
    Public Function AddNewEmployee(emp As Employee) As Integer
        Dim insertQuery As String =
            "Insert into Employee values (:id, :name, :salary, :city)"
        Dim cn As OracleConnection = Nothing
        Dim insertEmployeecommand As OracleCommand = Nothing
        Dim result As Integer
        Try
            cn = OracleDataAcessHelper.GetConnection
            insertEmployeecommand = cn.CreateCommand
            insertEmployeecommand.CommandText = insertQuery
            Dim idparam As New OracleParameter("id", OracleDbType.Int32)
            Dim nameparam As New OracleParameter("name", OracleDbType.Varchar2)
            Dim cityparam As New OracleParameter("city", OracleDbType.Varchar2)
            Dim salaryparam As New OracleParameter("salary", OracleDbType.Long)
            insertEmployeecommand.Parameters.Add(idparam).Value = emp.EmployeeNo
            insertEmployeecommand.Parameters.Add(nameparam).Value = emp.EmployeeName
            insertEmployeecommand.Parameters.Add(salaryparam).Value = emp.EmployeeSalary
            insertEmployeecommand.Parameters.Add(cityparam).Value = emp.EmployeeCity

            result = insertEmployeecommand.ExecuteNonQuery
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return result
    End Function
    Public Function GetAllEmployee() As List(Of Employee)
        Dim selectQuery As String =
              "select * from Employee"
        Dim cn As OracleConnection = Nothing
        Dim selectallcommand As OracleCommand = Nothing
        Dim result As OracleDataReader = Nothing
        Dim empList As New List(Of Employee)
        Try
            cn = OracleDataAcessHelper.GetConnection
            selectallcommand = cn.CreateCommand
            selectallcommand.CommandText = selectQuery
            result = selectallcommand.ExecuteReader
            While result.Read
                Dim emp As New Employee
                emp.EmployeeNo = result(0)
                emp.EmployeeName = result(1)
                emp.EmployeeSalary = result(2)
                emp.EmployeeCity = result(3)

                empList.Add(emp)
            End While
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return empList
    End Function
    Public Function FindEmployeeByID(empid As Integer) As Employee
        Dim selectEmpQuery As String =
            "Select * from Employee where id=:id"
        Dim cn As OracleConnection = Nothing
        Dim selectEmployeecommand As OracleCommand = Nothing
        Dim empReader As OracleDataReader = Nothing
        Dim emp As Employee = Nothing
        Try
            cn = OracleDataAcessHelper.GetConnection
            selectEmployeecommand = cn.CreateCommand
            selectEmployeecommand.CommandText = selectEmpQuery
            Dim idparam As New OracleParameter("id", OracleDbType.Int32)
            selectEmployeecommand.Parameters.Add(idparam).Value = empid
            empReader = selectEmployeecommand.ExecuteReader
            If empReader.Read Then
                emp = New Employee
                emp.EmployeeNo = empid
                emp.EmployeeName = empReader(1)
                emp.EmployeeSalary = empReader(2)
                emp.EmployeeCity = empReader(3)
            End If
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return emp
    End Function
    Public Function UpdateEmployee(emp As Employee) As Integer
        Dim updateQuery As String =
            "Update Employee set name=:name, salary=:salary, city=:city where id=:id"
        Dim cn As OracleConnection = Nothing
        Dim updateEmployeecommand As OracleCommand = Nothing
        Dim result As Integer
        Try
            cn = OracleDataAcessHelper.GetConnection
            updateEmployeecommand = cn.CreateCommand
            updateEmployeecommand.CommandText = updateQuery
            Dim idparam As New OracleParameter("id", OracleDbType.Int32)
            Dim nameparam As New OracleParameter("name", OracleDbType.Varchar2)
            Dim cityparam As New OracleParameter("city", OracleDbType.Varchar2)
            Dim salaryparam As New OracleParameter("salary", OracleDbType.Long)
            updateEmployeecommand.Parameters.Add(nameparam).Value = emp.EmployeeName
            updateEmployeecommand.Parameters.Add(salaryparam).Value = emp.EmployeeSalary
            updateEmployeecommand.Parameters.Add(cityparam).Value = emp.EmployeeCity
            updateEmployeecommand.Parameters.Add(idparam).Value = emp.EmployeeNo

            result = updateEmployeecommand.ExecuteNonQuery
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return result
    End Function

    Public Function DeleteEmployee(empid As Integer) As Integer
        Dim deleteQuery As String =
            "Delete from Employee where id=:id"
        Dim cn As OracleConnection = Nothing
        Dim deleteEmployeecommand As OracleCommand = Nothing
        Dim result As Integer
        Try
            cn = OracleDataAcessHelper.GetConnection
            deleteEmployeecommand = cn.CreateCommand
            deleteEmployeecommand.CommandText = deleteQuery
            Dim idparam As New OracleParameter("id", OracleDbType.Int32)
            deleteEmployeecommand.Parameters.Add(idparam).Value = empid
            result = deleteEmployeecommand.ExecuteNonQuery
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return result
    End Function


End Class
