Public Class SearchMember
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click, SimpleButton2.Click, SimpleButton3.Click,
            SimpleButton4.Click, SimpleButton5.Click
        Dim op As New Operators
        op.ShowDialog()
    End Sub
End Class
