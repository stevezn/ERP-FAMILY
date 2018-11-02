Imports System.Data.SQLite
Imports ActiveConnection

Public Class CardV
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub CardV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Sub startv()
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand

            cmd.CommandText = "select a.id, a.memberid, b.firstname,a.fingerindex, a.data from t_finger a left join t_members b on
                                a.memberid = b.memberid where a.data = ?"
            cmd.Parameters.AddWithValue("data", TextBox1.Lines(1))
            Dim t As New DataTable
            t.Load(cmd.ExecuteReader)
            For i As Integer = 0 To t.Rows.Count - 1
                TextBox1.Text = TextBox1.Text & vbNewLine & "MemberID: " & t.Rows(i).Item("memberid") & ", ID : " & t.Rows(i).Item("id") & ", Name : " & t.Rows(i).Item("firstname")
            Next
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on Membership-FingerV(StartV) : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        startv()
    End Sub
End Class
