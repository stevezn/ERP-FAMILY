Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class OtherSettings
    Private Sub OtherSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit1.Text = My.Settings.host
        TextEdit2.Text = My.Settings.username
        TextEdit3.Text = My.Settings.password
        TextEdit4.Text = My.Settings.destination
        TextEdit5.Text = My.Settings.timeout
        TextEdit7.Text = My.Settings.source
        CheckBox11.Checked = My.Settings.showui
        CheckBox12.Checked = My.Settings.overwrite
    End Sub

    Sub settings()
        Try
            My.Settings.host = TextEdit1.Text
            My.Settings.username = TextEdit2.Text
            My.Settings.password = TextEdit3.Text
            My.Settings.destination = TextEdit4.Text
            My.Settings.timeout = TextEdit5.Text
            My.Settings.source = TextEdit7.Text
            My.Settings.showui = CheckBox11.Checked
            My.Settings.overwrite = CheckBox12.Checked
            My.Settings.Save()
            Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            log_file.storedata(Now & "-> Error " & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim mess2 = CType(XtraMessageBox.Show("New Settings Will be available after restart. Do you want to restart now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
        If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            log_file.storedata(Now() & DB.user & " has changed the other settings")
            settings()
        End If
    End Sub
End Class