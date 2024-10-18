Imports Oracle.ManagedDataAccess.Client
Public Class ProductsRepository

    Public Function AddNewProduct(prod As Product) As Integer
        prodList.Add(prod)
        'Dim insertQuery As String =
        '    "Insert into Product values (:product_id, :product_name, :product_category, :product_price)"
        'Dim cn As OracleConnection = Nothing
        'Dim insertProductCommand As OracleCommand = Nothing
        'Dim result As Integer
        'Try
        '    cn = OracleDataAcessHelper.GetConnection
        '    insertProductCommand = cn.CreateCommand
        '    insertProductCommand.CommandText = insertQuery
        '    Dim idparam As New OracleParameter("product_id", OracleDbType.Int32)
        '    Dim nameparam As New OracleParameter("product_name", OracleDbType.Varchar2)
        '    Dim categoryparam As New OracleParameter("product_category", OracleDbType.Varchar2)
        '    Dim priceparam As New OracleParameter("product_price", OracleDbType.Int32)
        '    insertProductCommand.Parameters.Add(idparam).Value = prod.ProductID
        '    insertProductCommand.Parameters.Add(nameparam).Value = prod.ProductName
        '    insertProductCommand.Parameters.Add(categoryparam).Value = prod.ProductCategory
        '    insertProductCommand.Parameters.Add(priceparam).Value = prod.ProductPrice

        '    result = insertProductCommand.ExecuteNonQuery
        'Finally
        '    If cn.State = ConnectionState.Open Then
        '        cn.Close()
        '    End If
        'End Try
        'Return result
    End Function
    Public Shared prodList As New List(Of Product)
    Private Sub AddProducts()
        For index As Integer = 1 To 10
            Dim prd As New Product With
            {
            .ProductID = index,
            .ProductName = "Product " & index,
            .ProductCategory = "Cat " & index,
            .ProductPrice = index * 100
            }
            prodList.Add(prd)
        Next
    End Sub
    Public Function GetAllProducts() As List(Of Product)
        'Dim selectQuery As String =
        '    "Select * from Product"
        'Dim cn As OracleConnection = Nothing
        'Dim selectAllCommand As OracleCommand = Nothing
        'Dim result As OracleDataReader = Nothing
        If prodList.Count = 0 Then
            AddProducts()
        End If


        'Try
        '    cn = OracleDataAcessHelper.GetConnection
        '    selectAllCommand = cn.CreateCommand
        '    selectAllCommand.CommandText = selectQuery
        '    result = selectAllCommand.ExecuteReader
        '    While result.Read
        '        Dim prod As New Product
        '        prod.ProductID = result(0)
        '        prod.ProductName = result(1)
        '        prod.ProductCategory = result(2)
        '        prod.ProductPrice = result(3)
        '        prodList.Add(prod)
        '    End While
        'Finally
        '    If cn.State = ConnectionState.Open Then
        '        cn.Close()
        '    End If
        'End Try
        Return prodList
    End Function

    Public Function FindProductByID(prodID As Integer) As Product
        'Dim selectProdIDQuery As String =
        '    "Select * from Product Where product_id=:id"
        'Dim cn As OracleConnection = Nothing
        'Dim selectProdIDCommand As OracleCommand = Nothing
        'Dim prodReader As OracleDataReader = Nothing
        Dim prod As Product = (From prd In prodList
                               Where prd.ProductID = prodID
                               Select prd).First
        'Try
        '    cn = OracleDataAcessHelper.GetConnection
        '    selectProdIDCommand = cn.CreateCommand
        '    selectProdIDCommand.CommandText = selectProdIDQuery
        '    Dim idparam As New OracleParameter("id", OracleDbType.Int32)
        '    selectProdIDCommand.Parameters.Add(idparam).Value = prodID
        '    prodReader = selectProdIDCommand.ExecuteReader
        '    If prodReader.Read Then
        '        prod = New Product
        '        prod.ProductID = prodID
        '        prod.ProductName = prodReader(1)
        '        prod.ProductCategory = prodReader(2)
        '        prod.ProductPrice = prodReader(3)
        '    End If
        'Finally
        '    If cn.State = ConnectionState.Open Then
        '        cn.Close()
        '    End If
        'End Try
        Return prod
    End Function

    Public Function UpdateProducts(prod As Product) As Integer
        Dim updateQuery As String =
            "Update Product set product_name=:name, product_category=:category, product_price=:price where product_id=:id"
        Dim cn As OracleConnection = Nothing
        Dim updateProductsCommand As OracleCommand = Nothing
        Dim result As Integer
        Try
            cn = OracleDataAcessHelper.GetConnection
            updateProductsCommand = cn.CreateCommand
            updateProductsCommand.CommandText = updateQuery
            Dim idparam As New OracleParameter("product_id", OracleDbType.Int32)
            Dim nameparam As New OracleParameter("product_name", OracleDbType.Varchar2)
            Dim categoryparam As New OracleParameter("product_category", OracleDbType.Varchar2)
            Dim priceparam As New OracleParameter("product_price", OracleDbType.Int32)
            updateProductsCommand.Parameters.Add(nameparam).Value = prod.ProductName
            updateProductsCommand.Parameters.Add(categoryparam).Value = prod.ProductCategory
            updateProductsCommand.Parameters.Add(priceparam).Value = prod.ProductPrice
            updateProductsCommand.Parameters.Add(idparam).Value = prod.ProductID

            result = updateProductsCommand.ExecuteNonQuery
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return result
    End Function

    Public Function DeleteProducts(prodID As Integer) As Integer
        Dim deleteQuery As String =
            "Delete from Product where product_id=:id"
        Dim cn As OracleConnection = Nothing
        Dim deleteProductsCommand As OracleCommand = Nothing
        Dim result As Integer
        Try
            cn = OracleDataAcessHelper.GetConnection
            deleteProductsCommand = cn.CreateCommand
            deleteProductsCommand.CommandText = deleteQuery
            Dim idparam As New OracleParameter("product_id", OracleDbType.Int32)
            deleteProductsCommand.Parameters.Add(idparam).Value = prodID
            result = deleteProductsCommand.ExecuteNonQuery
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        Return result
    End Function
End Class
