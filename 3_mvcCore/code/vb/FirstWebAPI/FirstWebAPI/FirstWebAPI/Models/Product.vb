Imports System.Runtime.Serialization
<DataContract>
Public Class Product
    Private id As Integer
    Private name As String
    Private category As String
    Private price As Integer

    <DataMember>
    Public Property ProductID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    <DataMember>
    Public Property ProductName() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    <DataMember>
    Public Property ProductCategory() As String
        Get
            Return category
        End Get
        Set(ByVal value As String)
            category = value
        End Set
    End Property

    <DataMember>
    Public Property ProductPrice() As Integer
        Get
            Return price
        End Get
        Set(ByVal value As Integer)
            price = value
        End Set
    End Property
End Class
