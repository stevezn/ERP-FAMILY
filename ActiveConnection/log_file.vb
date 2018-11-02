Imports System.Data.SQLite
Imports System.IO
Public Class log_file
    Public Shared username, duration, uid As String
    Public Shared visittime, lastvisiting As Date

    Public Shared Sub ended()
        Dim duration As TimeSpan = Now - visittime
        storedata("Ended Time : " & Date.Now & vbCrLf & "Duration = " & duration.TotalMinutes & " Minutes" & vbCrLf & vbTab & vbTab & vbTab & vbTab & "--Log Off Application--")
        updatelog()
    End Sub

    Public Shared Sub storedata(writehere As String)
        'If Not File.Exists("logfile.txt") Then
        '    File.Create("logfile.txt")
        'End If
        Dim txt As StreamWriter
        txt = My.Computer.FileSystem.OpenTextFileWriter("logfile.txt", True)
        txt.WriteLine(writehere)
        txt.Close()
    End Sub

    Public Shared Sub cleardata()
        Dim Path As String = "logfile.txt"
        File.WriteAllText(Path, String.Empty)
    End Sub

    Public Shared Sub insertlog()
        Dim sqliteconstr As String = Nothing
        sqliteconstr = "Data Source=local.sqlite;Version=3;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Dim cmd As SQLiteCommand = localcon.CreateCommand
        cmd.CommandText = "insert into t_logfile (uid, tgl, userid, activity) values (?, ?, ?, ?)"
        uid = DB.user + Now + DB.id
        With cmd
            .Parameters.AddWithValue("uid", uid)
            .Parameters.AddWithValue("tgl", Now)
            .Parameters.AddWithValue("userid", DB.id)
            .Parameters.AddWithValue("activity", File.ReadAllText("logfile.txt"))
            .ExecuteNonQuery()
        End With
    End Sub

    Public Shared Sub updatelog()
        Try
            Dim data As New Dictionary(Of String, Object)
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = "select max(id) from t_logfile"
            Dim id As String = CStr(cmd.ExecuteScalar)
            cmd.CommandText = "update t_logfile set activity = @activity where uid = @id"
            With cmd
                .Parameters.AddWithValue("@id", uid)
                .Parameters.AddWithValue("@activity", File.ReadAllText("logfile.txt"))
                .ExecuteNonQuery()
            End With
            Dim query As String = "INSERT INTO t_logfile (uid, tgl, userid, activity, ishide) VALUES ('" & uid & "','" & Now & "','" & DB.id & "','" & File.ReadAllText("logfile.txt") & "','" & "Y" & "');"
            data.Add("userid", uid)
            data.Add("tanggal", Now.ToString("yyyy-MM-dd"))
            data.Add("users", DB.id)
            data.Add("act", File.ReadAllText("logfile.txt"))
            data.Add("src", AccessHandler.getMacAddress)
            data.Add("queries", query)
            Dim s As String = DB.jsonser.Serialize(data)
            DB.crudapi(DB.getlink("INS_LOG"), DB.jsonser.Serialize(data))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub
End Class