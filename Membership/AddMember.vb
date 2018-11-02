Imports DevExpress.XtraEditors.Camera
Imports ActiveConnection
Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class AddMember
    Public Sub New()
        InitializeComponent()
        'If DB.CheckDB = True Then
        '    DB.readapi("GetMemberList", GridControl1)
        'Else
        '    DB.readlocal("select * from t_member", GridControl1)
        'End If
    End Sub

    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim d As New TakePictureDialog
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureEdit1.Image = d.Image
        End If
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim d As New TakePictureDialog
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureEdit2.Image = d.Image
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AccessHandler.ClearForm(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Please fill all the blank fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim nextnum As String = AccessHandler.NextNum("M", "CKA", "Member")
        Dim data As New Dictionary(Of String, Object)
        Dim q As String = nextnum & "|"
        q += TextBox2.Text & "|"
        q += TextBox3.Text & "|"
        q += DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "|"
        q += TextBox7.Text & "|"
        q += TextBox9.Text & "|"
        q += TextBox8.Text & "|"
        q += ComboBox1.Text & "|"
        q += ComboBox3.Text & "|"
        q += TextBox11.Text & "|"
        q += TextBox4.Text & "|"
        q += TextBox6.Text & "|"
        q += TextBox5.Text & "|"
        q += ComboBox2.Text & "|"
        q += DB.locid & "|"
        q += RichTextBox2.Text & "|"
        q += DB.id & "|"
        q += Now & "|"
        q += "0|0|"
        q += TextBox10.Text & "|"
        q += ComboBox6.Text & "|"
        q += TextBox14.Text & "|"
        q += TextBox13.Text
        MsgBox(q)

        Dim sqliteconstr As String = Nothing
        Dim cmd As SQLiteCommand
        sqliteconstr = "Data Source=local.sqlite;Version=3"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        cmd = localcon.CreateCommand
        cmd.CommandText = "select * from t_members"
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)
        Dim txt As String = GenerateSQL.BuildInsertSQL(dt, q)
        MsgBox(txt)

        Dim query As String = "INSERT INTO t_members (memberid, firstname, lastname, dob, city, gender, address1, address2,address3, phone, email, location, createby, createdate, occupation, weight, height, bloodtype, isvoid, blacklist) VALUES ('" & nextnum & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "','" & TextBox7.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & DB.locid & "','" & DB.id & "','" & Now & "','" & TextBox10.Text & "','" & TextBox14.Text & "','" & TextBox13.Text & "','" & ComboBox6.Text & "','" & "0" & "','" & "0" & "');INSERT INTO t_attachment (memberid, attach, extension, type, filename, isvoid) VALUES ('" & nextnum & "','" & AccessHandler.ImageToBase64(PictureEdit1.Image, Drawing.Imaging.ImageFormat.Jpeg) & "','" & ".jpg" & "','" & "Profile Pic" & "','" & "noname" & "','" & "0" & "');INSERT INTO t_attachment (memberid, attach, extension, type, filename, isvoid) VALUES ('" & nextnum & "','" & AccessHandler.ImageToBase64(PictureEdit2.Image, Drawing.Imaging.ImageFormat.Jpeg) & "','" & ".jpg" & "','" & "ID Card" & "','" & "noname" & "','" & "0" & "');"
        data.Add("fmemberid", nextnum)
        data.Add("fname", TextBox2.Text)
        data.Add("lname", TextBox3.Text)
        data.Add("fdob", DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"))
        data.Add("fcity", TextBox7.Text)
        data.Add("fgender", ComboBox1.Text)
        data.Add("faddr1", TextBox4.Text)
        data.Add("faddr2", TextBox6.Text)
        data.Add("faddr3", TextBox5.Text)
        data.Add("fphone", TextBox9.Text)
        data.Add("femail", TextBox8.Text)
        data.Add("flocation", DB.locid)
        data.Add("fcreateby", DB.id)
        data.Add("fattachpic", AccessHandler.ImageToBase64(PictureEdit1.Image, Drawing.Imaging.ImageFormat.Jpeg))
        data.Add("fattachid", AccessHandler.ImageToBase64(PictureEdit2.Image, Drawing.Imaging.ImageFormat.Jpeg))
        data.Add("fext", ".jpg")
        data.Add("occu", TextBox10.Text)
        data.Add("weights", TextBox14.Text)
        data.Add("heights", TextBox13.Text)
        data.Add("blood", ComboBox6.Text)
        data.Add("queries", query)
        data.Add("src", AccessHandler.getMacAddress)
        DB.crudapi(DB.getlink("INS_Member"), DB.jsonser.Serialize(data))
    End Sub
End Class