Imports System.Net
Imports ActiveConnection
Imports DevExpress.XtraEditors

Public Class Login
    Public Sub New()
        InitializeComponent()
        If DB.CheckDB = True Then
            lblCon.Text = "API READY"
        Else
            lblCon.Text = "OFFLINE"
        End If
        CheckMac()
    End Sub

    Sub CheckMac()
        If DB.execscalar("SELECT COUNT(*) from t_computer where mac = '" & AccessHandler.getMacAddress() & "' and blockaccess = 0") <> 1 Then
            Dim mess2 = CType(XtraMessageBox.Show("You are not registered on this system, please click YES to check into main system", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
            If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
                If GetMac() = 1 Then
                    Dim mess = CType(XtraMessageBox.Show("You are registered on server but it seems your data are not current, please click YES to sync the latest data", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question), String)
                    If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
                        DoSync.throwdata(DB.getlink("GetTable", "t_computer/100"), "t_computer")
                    End If
                Else
                    MsgBox("Sorry you are not allowed to access this system." & "Your mac is :" & AccessHandler.getMacAddress, MsgBoxStyle.Information)
                    Application.Exit()
                End If
            Else
                Application.Exit()
            End If
            Exit Sub
        End If
    End Sub

    Private Function GetMac()
        Dim res As String = ""
        Dim jsondata As Dictionary(Of String, Object) = DB.ApiRead(DB.getlink("GetMac", AccessHandler.getMacAddress))
        Return jsondata("count")
    End Function

    Sub init()
        log_file.cleardata()
        log_file.visittime = Date.Now
        log_file.lastvisiting = Date.Now
        log_file.storedata("User : " & DB.user & " Login with IP = " & Dns.GetHostEntry(Dns.GetHostName).AddressList(1).ToString & " and hostname = " & Dns.GetHostName & "--->  " & Date.Now & vbCrLf)
        log_file.insertlog()
        Hide()
        MainForm.ShowDialog()
    End Sub

    Sub authenticateuser()
        If DB.execscalar("SELECT COUNT(*) FROM t_user WHERE fullname = '" & txtUser.Text & "' and pass = '" & Encryptio(txtPwd.Text) & "'") = 1 Then
            Dim dt As DataTable = DB.readlocal("select a.fullname, b.name, a.id, a.locations from t_user a left join t_location b on a.locations = b.locid where fullname = '" & txtUser.Text & "' and pass = '" & Encryptio(txtPwd.Text) & "'")
            For i As Integer = 0 To dt.Rows.Count - 1
                DB.user = dt.Rows(i).Item(0)
                DB.locations = dt.Rows(i).Item(1)
                DB.id = dt.Rows(i).Item(2)
                DB.locid = dt.Rows(i).Item(3)
            Next
            init()
        Else
            MsgBox("Username and password doesn't match", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        authenticateuser()
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown, txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            authenticateuser()
        End If
    End Sub
End Class