Imports System.Web.Http.Cors
Imports System.Net
Imports System.Web.Http
<EnableCors("*", "*", "*")>
Public Class ProductController
    Inherits ApiController

    ' GET api/<controller>
    <HttpGet>
    Public Function GetValues() As IEnumerable(Of Product)
        ' Return New String() {"value1", "value2"}
        Dim repo As New ProductsRepository
        Dim list As List(Of Product) = repo.GetAllProducts()
        Return list
    End Function

    ' GET api/<controller>/5
    <HttpGet>
    Public Function GetValue(ByVal id As Integer) As Product
        '  Return "value"
        Dim repo As New ProductsRepository
        Dim prod As Product = repo.FindProductByID(id)
        Return prod
    End Function


    <HttpPost>
    Public Function PostValue(prod As Product) As IHttpActionResult
        Dim repo As New ProductsRepository
        repo.AddNewProduct(prod)
        Dim list As List(Of Product) = repo.GetAllProducts()
        Return Ok(list)
    End Function

    <HttpPut>
    Public Function PutProduct(prod As Product) As IHttpActionResult
        Dim repo As New ProductsRepository
        'repo.UpdateProducts(prod)
        Dim prodList As List(Of Product) = repo.GetAllProducts()
        Dim prd As Product = (From p In prodList
                              Where p.ProductID = prod.ProductID
                              Select p).First
        If ModelState.IsValid Then
            Console.WriteLine("Hi")
        End If
        prd.ProductName = prod.ProductName
        prd.ProductCategory = prod.ProductCategory
        prd.ProductPrice = prod.ProductPrice
        Return Ok(prodList)

    End Function

    ' DELETE api/<controller>/5
    <HttpDelete>
    Public Sub DeleteProduct(id As Integer)
        Dim repo As New ProductsRepository
        'repo.DeleteProducts(id)
    End Sub
End Class
