Imports System.Data.SQLite
Imports ActiveConnection

Public Class CFV
    Dim myDB As SQLiteConnection
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim EmpID As String
    Dim FpIndex As Byte

    Sub startv()
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            FpVer = New FlexCodeSDK.FinFPVer
            cmd.CommandText = "select sn, ac, vc from t_device where type = 'Finger' and usethis = 1"
            Dim tb As New DataTable
            tb.Load(cmd.ExecuteReader)
            For k As Integer = 0 To tb.Rows.Count - 1
                FpVer.AddDeviceInfo(tb.Rows(k).Item("sn"), tb.Rows(k).Item("vc"), tb.Rows(k).Item("ac"))
                LabelControl3.Text = tb.Rows(k).Item("sn")
            Next
            cmd.CommandText = "select id, memberid, fingerindex, data from t_finger where void = 0 and type = 'F'"
            Dim t As New DataTable
            t.Load(cmd.ExecuteReader)
            For i As Integer = 0 To t.Rows.Count - 1
                FpVer.FPLoad(t.Rows(i).Item("memberid"), t.Rows(i).Item("fingerindex"), t.Rows(i).Item("data"), "Family" & t.Rows(i).Item("memberid"))
            Next
            FpVer.FPVerificationStart()
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on Membership-FingerV(StartV) : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FpVer_FPVerificationID(ByVal ID As String, ByVal FingerNr As FlexCodeSDK.FingerNumber) Handles FpVer.FPVerificationID
        EmpID = ID
        FpIndex = FingerNr
    End Sub

    Private Sub FpVer_FPVerificationStatus(ByVal Status As FlexCodeSDK.VerificationStatus) Handles FpVer.FPVerificationStatus
        If Status = FlexCodeSDK.VerificationStatus.v_OK Then
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = "select a.id, a.memberid, b.firstname,a.fingerindex, a.data from t_finger a left join t_members b on
                                a.memberid = b.memberid where a.memberid = ?"
            cmd.Parameters.AddWithValue("memberid", EmpID)
            Dim t As New DataTable
            t.Load(cmd.ExecuteReader)
            For i As Integer = 0 To t.Rows.Count - 1
                TextBox1.Text = TextBox1.Text & vbNewLine & "MemberID: " & EmpID & ", ID : " & t.Rows(i).Item("id") & ", Finger Index : " & Str(FpIndex)
                EmpID = ""
            Next
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "Not recognized!")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "Finger touch")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerificationFailed Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "Verification failed")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_ActivationIncorrect Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "Incorrect activation number of devices")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NoDevice Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "No device connected")
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_FPListFull Then
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "FPListFull")
        Else
            TextBox1.AppendText(TextBox1.Text & vbNewLine & "Result Status : " & Str(Status))
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        startv()
    End Sub

    Private Sub CFV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startv()
    End Sub
End Class
