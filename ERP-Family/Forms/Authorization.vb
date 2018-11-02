Imports System.Data.SQLite
Imports ActiveConnection
Imports DevExpress.XtraEditors

Public Class Authorization

    Sub actionmember()
        Try
            Dim sqliteconstr As String = Nothing
            Dim cmd As SQLiteCommand
            sqliteconstr = "Data Source=local.sqlite;version=3"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            cmd = localcon.CreateCommand
            cmd.CommandText = "UPDATE t_auth set addmember = ?, viewmember = ?, voidmember = ?,
                            addcard = ?, addfinger = ?, scanmember = ? WHERE userid = ?"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("addmember", If(CheckEdit1.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("viewmember", If(CheckEdit2.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("voidmember", If(CheckEdit4.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("addcard", If(CheckEdit5.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("addfinger", If(CheckEdit6.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("scanmember", If(CheckEdit7.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("userid", DB.id)
            cmd.ExecuteNonQuery()
            MsgBox("Authorization Changed", MsgBoxStyle.Information)
        Catch ex As Exception
            log_file.storedata(Now & " Error on " & ex.Message & " on Authorization.actionmember")
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub showmember()
        Dim sqlcon As String = Nothing
        Dim cmd As SQLiteCommand
        sqlcon = "Data Source=local.sqlite;Version=3"
        Dim localcon As New SQLiteConnection(sqlcon)
        localcon.Open()

    End Sub

    Sub auth()
        Dim sqliteconstr As String = Nothing
        Dim cmd As SQLiteCommand
        sqliteconstr = "Data Source=local.sqlite;Version=3"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        cmd = localcon.CreateCommand
        cmd.CommandText = "select * from t_auth where userid = ?"
        cmd.Parameters.AddWithValue("userid", DB.id)
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        For i As Integer = 0 To dt.Rows.Count - 1
            CheckEdit1.Checked = CBool(dt.Rows(i).Item("AddMember"))
            CheckEdit2.Checked = CBool(dt.Rows(i).Item("ViewMember"))
            CheckEdit3.Checked = CBool(dt.Rows(i).Item("ViewMember"))
            CheckEdit4.Checked = CBool(dt.Rows(i).Item("VoidMember"))
            CheckEdit5.Checked = CBool(dt.Rows(i).Item("AddCard"))
            CheckEdit6.Checked = CBool(dt.Rows(i).Item("AddFinger"))
            CheckEdit7.Checked = CBool(dt.Rows(i).Item("ScanMember"))
        Next
    End Sub

    Private Sub Authorization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim mess2 = CType(XtraMessageBox.Show("New Settings Will be available after restart. Do you want to restart now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
        If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            auth()
            log_file.storedata(Now() & DB.user & " has changed the other settings")
        End If
    End Sub
End Class