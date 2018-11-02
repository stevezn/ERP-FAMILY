Public Class SearchSales
    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click, SimpleButton1.Click,
            SimpleButton2.Click, SimpleButton3.Click, SimpleButton4.Click, SimpleButton5.Click
        Dim op As New Operators
        op.ShowDialog()
    End Sub
End Class
