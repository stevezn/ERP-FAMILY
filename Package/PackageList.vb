Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports ActiveConnection

Public Class PackageList

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Shared Function GetData() As BindingList(Of Package)
        Dim result As New BindingList(Of Package)
        Dim jsondata As Dictionary(Of String, Object) = DB.ApiRead(DB.getlink("GetPackageList"))
        For Each item In jsondata("data")
            result.Add(New Package() With {.ID = item("ID"), .PackageID = item("packageid"), .Name = item("name"),
                       .Price = item("price"), .Months = item("months"), .ExpDate = item("expdate"),
                       .Free = item("free"), .Session = item("session"), .StartDate = item("startdate"),
                       .EndDate = item("enddate")})
        Next
        Return result
    End Function

    Public Class Package
        <Key, Display(AutoGenerateField:=False)>
        Public Property ID() As Integer
        <Required>
        Public Property PackageID() As String
        Public Property Name() As String
        Public Property Price() As String
        Public Property Months() As Date
        <Display(Name:="Expire Date")>
        Public Property ExpDate() As String
        Public Property Free() As String
        Public Property Session() As String
        Public Property StartDate() As Date
        Public Property EndDate() As Date
        Public Property Religion() As String
        Public Property CreatedBy() As String
        Public Property Location() As String
    End Class

    Private Sub PackageList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
