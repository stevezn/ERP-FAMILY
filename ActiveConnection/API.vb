Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class API
    Private Sub API_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.key
        TextBox4.Text = My.Settings.secret
        TextBox2.Text = My.Settings.app
    End Sub

    Sub setting()
        Try
            My.Settings.key = TextBox1.Text
            My.Settings.app = TextBox2.Text
            My.Settings.secret = TextBox4.Text
            My.Settings.Save()
            Application.Exit()
            Process.Start(Application.ExecutablePath)
        Catch ex As Exception
            log_file.storedata(Now & " -> Error on ActiveCon-API(setting): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim mess2 = CType(XtraMessageBox.Show("New API key will be generated after this app restarted, Do you want to do it now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
        If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            log_file.storedata(Now() & DB.user & " has changed the api key")
            setting()
        End If
    End Sub
End Class