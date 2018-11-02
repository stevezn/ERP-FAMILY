Imports System.Data.SQLite
Imports ActiveConnection
Imports DevExpress.XtraEditors.Controls

Public Class AddFinger
    Public Sub New()
        InitializeComponent()
        Lookupedit()
    End Sub

    Dim WithEvents FpReg As FlexCodeSDK.FinFPReg
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim Template As String
    Dim EmpID As String
    Dim FpIndex As Byte
    Dim ItIsUniqueTemplate As Boolean

    Sub Lookupedit()
        LookUpEdit1.Properties.DataSource = MemberList.getdata
        LookUpEdit1.Properties.DisplayMember = "Name"
        LookUpEdit1.Properties.ValueMember = "MemberID"
        'LookUpEdit1.Properties.PopulateColumns()
        'LookUpEdit1.Properties.Columns[3].Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            SimpleButton1.Enabled = False
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            FpReg = New FlexCodeSDK.FinFPReg
            cmd.CommandText = "select sn, ac, vc from t_device where type = 'Finger' and usethis = 1"
            Dim tb As New DataTable
            tb.Load(cmd.ExecuteReader)
            For k As Integer = 0 To tb.Rows.Count - 1
                FpReg.AddDeviceInfo(tb.Rows(k).Item("sn"), tb.Rows(k).Item("vc"), tb.Rows(k).Item("ac"))
            Next
            FpReg.FPRegistrationStart("Family" & LookUpEdit1.EditValue)
            ItIsUniqueTemplate = False
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on Membership-AddFinger(simplebutton1): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub FpReg_FPRegistrationStatus(ByVal Status As FlexCodeSDK.RegistrationStatus) Handles FpReg.FPRegistrationStatus
        If Status = FlexCodeSDK.RegistrationStatus.r_OK Then
            SimpleButton2.Enabled = True
        End If
    End Sub

    Private Sub FpReg_FPRegistrationTemplate(ByVal FPTemplate As String) Handles FpReg.FPRegistrationTemplate
        Template = FPTemplate
    End Sub

    Private Sub FpReg_FPSamplesNeeded(ByVal Samples As Short) Handles FpReg.FPSamplesNeeded
        Label1.Text = Str(Samples) & " Times"
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
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
            Next
            'Dim js As String = "{'data': '" & Template & "'}"
            'Dim jsondata As Dictionary(Of String, Object) = DB.ApiRead(DB.getlink("GetFinger"))
            'For Each item In jsondata("data")
            '    FpVer.FPLoad(item("memberid"), item("fingerindex"), item("data"), "Family" & item("memberid"))
            'Next
            cmd.CommandText = "select id, memberid, fingerindex, data from t_finger where void = 0 and type = 'F'"
            Dim t As New DataTable
            t.Load(cmd.ExecuteReader)
            For i As Integer = 0 To t.Rows.Count - 1
                FpVer.FPLoad(t.Rows(i).Item("memberid"), t.Rows(i).Item("fingerindex"), t.Rows(i).Item("data"), "Family" & t.Rows(i).Item("memberid"))
            Next
            FpVer.FPVerificationStart()
            SimpleButton2.Enabled = False
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on Membership-Addfinger(simplebutton2) : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FpVer_FPVerificationID(ByVal ID As String, ByVal FingerNr As FlexCodeSDK.FingerNumber) Handles FpVer.FPVerificationID
        EmpID = ID
        FpIndex = FingerNr
    End Sub

    Private Sub FpVer_FPVerificationStatus(ByVal Status As FlexCodeSDK.VerificationStatus) Handles FpVer.FPVerificationStatus
        FpVer.FPVerificationStop()
        If Status = FlexCodeSDK.VerificationStatus.v_OK Then
            TextBox6.Text = TextBox6.Text & "This finger already registered as ID: " & EmpID & " and Finger Index: " & Str(FpIndex) & vbNewLine & "Please register other finger"
            'TextBox1.Text = ""
            'TextBox2.Text = ""
            SimpleButton1.Enabled = True
            'Button3.Enabled = False
            Label9.Text = "Samples Needed :"
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Or Status = FlexCodeSDK.VerificationStatus.v_FPListEmpty Then
            TextBox6.Text = TextBox6.Text & "Your finger is unique! Now you can save the template to database."
            ItIsUniqueTemplate = True
            'Button3.Enabled = True
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            TextBox6.Text = TextBox6.Text & vbNewLine & "Finger touch"
        ElseIf Status =
            MsgBox(Status) Then
        End If
    End Sub

    Sub insertcard()
        Try
            Dim data As New Dictionary(Of String, Object)
            Dim query As String = "INSERT INTO t_finger (memberid, type, fingerindex, data, createdate, createby, remarks, void, voidby) values ('" & LookUpEdit1.EditValue & "','" & "F" & "','" & Str(ComboBox1.SelectedIndex) + 1 & "','" & Template & "','" & Now & "','" & DB.id & "','" & "" & "','" & "0" & "','" & "" & "');"
            data.Add("memid", LookUpEdit1.EditValue)
            data.Add("tipe", "F")
            data.Add("findex", Str(ComboBox1.SelectedIndex) + 1)
            data.Add("dta", Template)
            data.Add("users", DB.id)
            data.Add("rem", "")
            data.Add("src", AccessHandler.getMacAddress)
            data.Add("queries", query)
            DB.crudapi(DB.getlink("INS_Finger"), DB.jsonser.Serialize(data))
            MsgBox("New finger template saved", MsgBoxStyle.Information)
        Catch ex As Exception
            log_file.storedata(Now & " Error :" & ex.Message & "on Membership.AddFinger.Insertcard")
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If ItIsUniqueTemplate Then
            insertcard()
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = False
            Label9.Text = "Samples Needed :"
            'Dim js As String = "{'memid' : '" & TextBox2.Text & "',
            '                    'tipe' : '" & "F" & "',
            '                    'findex' : '" & Str(ComboBox1.SelectedIndex) + 1 & "',
            '                    'dta'	: '" & Template & "',
            '                    'users'	: '" & DB.id & "',                          
            '                    'rem'	: '" & "no data" & "'}"
            'DB.crudapi(DB.getlink("INS_Finger"), js)
        Else
            MsgBox("No unique template found, please make sure the fingers is already verified to be unique indexs", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        'TextBox2.Text = LookUpEdit1.EditValue
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
End Class