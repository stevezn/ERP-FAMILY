Imports ActiveConnection
Imports DevExpress.XtraEditors

Public Class EmailConf

    Sub setting()
        Try
            My.Settings.mailhost = TextBox1.Text
            My.Settings.mailaddress = TextBox2.Text
            My.Settings.mailpass = TextBox3.Text
            My.Settings.sendemail = CheckBox1.Checked
            My.Settings.ssl = CheckBox2.Checked
            My.Settings.port = TextBox4.Text
            My.Settings.Save()
            Close()
        Catch ex As Exception
            log_file.storedata(Now & "-> Error : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub EmailConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.mailhost
        TextBox2.Text = My.Settings.mailaddress
        TextBox3.Text = My.Settings.mailpass
        CheckBox1.Checked = My.Settings.sendemail
        CheckBox2.Checked = My.Settings.ssl
        TextBox4.Text = My.Settings.port
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim mess2 = CType(XtraMessageBox.Show("Mail configuration will be available after restart. Do you want to restart now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
        If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            log_file.storedata(Now() & DB.user & " has changed the email configurations")
            setting()
        End If
    End Sub
End Class