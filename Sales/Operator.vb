Imports System.ComponentModel

Public Class Operators
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        GridControl1.DataSource = getdata()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function getdata() As BindingList(Of op)
        Dim result As New BindingList(Of op)
        result.Add(New op() With {.Operand = "=", .Description = "Equals to"})
        result.Add(New op() With {.Operand = "<>", .Description = "Not equals to"})
        'result.Add(New op() With {.Operand = "=", .Description = "Equals to"})
        Return result
    End Function

    Public Class op
        Public Property Operand As String
        Public Property Description As String
    End Class

    Private Sub Operators_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class