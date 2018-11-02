Imports System.Data.SQLite
Imports ActiveConnection

Public Class AddCard
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Lookupedit()
    End Sub

    Sub Lookupedit()
        LookUpEdit1.Properties.DataSource = MemberList.getdata
        LookUpEdit1.Properties.DisplayMember = "Name"
        LookUpEdit1.Properties.ValueMember = "MemberID"
    End Sub

    Sub insertcard()
        Try
            Dim data As New Dictionary(Of String, Object)
            Dim query As String = "INSERT INTO t_finger (memberid, type, fingerindex, data, createdate, createby, remarks, void, voidby) values ('" & LookUpEdit1.EditValue & "','" & "R" & "','" & "" & "','" & RichTextBox1.Text & "','" & Now & "','" & DB.id & "','" & "" & "','" & "0" & "','" & "" & "');"
            data.Add("memid", LookUpEdit1.EditValue)
            data.Add("tipe", "R")
            data.Add("findex", "")
            data.Add("dta", RichTextBox1.Text)
            data.Add("users", DB.id)
            data.Add("rem", "")
            data.Add("src", AccessHandler.getMacAddress)
            data.Add("queries", query)
            DB.crudapi(DB.getlink("INS_Finger"), DB.jsonser.Serialize(data))
        Catch ex As Exception
            log_file.storedata(Now & " Error :" & ex.Message & "on Membership.AddCard.Insertcard")
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub insertcard1()
        Dim sqliteconstr As String = Nothing
        sqliteconstr = "Data Source=local.sqlite;Version=3;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Dim cmd As SQLiteCommand = localcon.CreateCommand
        cmd.CommandText = "INSERT INTO t_finger (memberid, type, fingerindex, data, createdate, createby, remarks, void, voidby) values (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        With cmd
            .Parameters.AddWithValue("memberid", LookUpEdit1.EditValue)
            .Parameters.AddWithValue("type", "R")
            .Parameters.AddWithValue("fingerindex", "")
            .Parameters.AddWithValue("data", RichTextBox1.Text)
            .Parameters.AddWithValue("createdate", Now)
            .Parameters.AddWithValue("createby", DB.id)
            .Parameters.AddWithValue("remarks", "")
            .Parameters.AddWithValue("void", 0)
            .Parameters.AddWithValue("voidby", "")
            .ExecuteNonQuery()
        End With
        MsgBox("New finger template saved", MsgBoxStyle.Information)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LookUpEdit1.EditValue <> "" Then
            insertcard()
        Else
            MsgBox("Please insert member and rfid number", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AccessHandler.ClearForm(Me)
    End Sub
End Class
