Imports ActiveConnection
Imports ERP_Family

Public Class AttendanceControl
    Private dbcon As DB
    Private Delegate Sub progbarNotify(max As Integer, prog As Integer, txt As String)

    Public Sub New()

    End Sub

    Private Sub AttendanceControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
