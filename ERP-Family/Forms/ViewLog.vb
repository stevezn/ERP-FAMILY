Imports ActiveConnection

Public Class ViewLog
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridControl1.DataSource = DB.readlocal("select id, uid, USERID, tgl as ExactVisitTime from t_logfile where tgl between '" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "' and '" & DateTimePicker2.Value.Date.ToString("yyyy-MM-dd") & "'")
        GridView1.BestFitColumns()
        GridControl1.UseEmbeddedNavigator = True
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dt As New DataTable
        dt = DB.readtable("SELECT activity FROM t_logfile WHERE id = " + GridView1.GetFocusedRowCellValue("id").ToString)
        For i As Integer = 0 To dt.Rows.Count - 1
            RichTextBox1.Text = ""
            RichTextBox1.Text = dt.Rows(i).Item(0).ToString
        Next
    End Sub
End Class