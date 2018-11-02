Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports DevExpress.XtraGrid
Imports System.Web.Script.Serialization

Public Class DB : Implements IDisposable
    Public Shared user, locations, id, locid As String
    Public mysqlconstr As String = ""
    Public mysqlcon As New MySqlConnection(mysqlconstr)
    Public Shared jsonser As New JavaScriptSerializer

    Public sqlserconstr As String = ""
    Public sqlservercon As New SqlConnection(sqlserconstr)
    Public Shared apidefault As String = "?key=" & My.Settings.key & "&secret=" & My.Settings.secret & "&app=" & My.Settings.app & "&token="

    Public Shared Function CheckDB() As Boolean
        Try
            If My.Computer.Network.Ping("117.53.45.66") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Sub crudapiget(uri As String, jsondata As String)
        Try
            Dim request As WebRequest
            request = WebRequest.Create(uri)
            Dim response As WebResponse
            Dim postData As String = jsondata.Replace(" '", Chr(34))
            Dim data As Byte() = Text.Encoding.UTF8.GetBytes(postData)
            request.Method = WebRequestMethods.Http.Get
            request.ContentType = "application/json"
            request.ContentLength = data.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
            stream.Close()
            response = request.GetResponse()
            Dim sr As New StreamReader(response.GetResponseStream())
            MsgBox(sr.ReadToEnd, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message & " : crudapiget", MsgBoxStyle.Critical)
            log_file.storedata(Now & "-> Error ActiveCon-DB(crudapi)" & ex.Message)
        End Try
    End Sub

    Public Shared Sub crudapi(uri As String, jsondata As String)
        'Try
        Dim request As WebRequest
            request = WebRequest.Create(uri)
            Dim response As WebResponse
            Dim postData As String = jsondata.Replace("'", Chr(34))
            Dim data As Byte() = Text.Encoding.UTF8.GetBytes(postData)
            request.Method = WebRequestMethods.Http.Post
            request.ContentType = "application/json"
            request.ContentLength = data.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
            stream.Close()
            response = request.GetResponse()
            Dim sr As New StreamReader(response.GetResponseStream())
            MsgBox(sr.ReadToEnd, MsgBoxStyle.Information)
        'Catch ex As Exception
        '    MsgBox(ex.Message & " : crudapi", MsgBoxStyle.Critical)
        '    log_file.storedata(Now & "-> Error ActiveCon-DB(crudapi)" & ex.Message)
        'End Try
    End Sub

    Public Shared Function readpost(uri As String, jsondata As String)
        Try
            Dim request As WebRequest
            request = WebRequest.Create(uri)
            Dim response As WebResponse
            Dim postData As String = jsondata.Replace("'", Chr(34))
            Dim data As Byte() = Text.Encoding.UTF8.GetBytes(postData)
            request.Method = WebRequestMethods.Http.Post
            request.ContentType = "application/json"
            request.ContentLength = data.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
            stream.Close()
            response = request.GetResponse()
            Dim sr As New StreamReader(response.GetResponseStream())
            Dim json As New JavaScriptSerializer
            json.MaxJsonLength = 500000000
            Dim jsondat As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(sr.ReadToEnd)
            Return jsondat
            MsgBox(sr.ReadToEnd, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            log_file.storedata(Now & "-> Error on ActiveCon-DB(readpost) " & ex.Message)
        End Try
    End Function

    Public Shared Function execscalar(query As String)
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = query
            Return cmd.ExecuteScalar
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(Execscalar): " & ex.Message)
            Return MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Shared Function readlocal(query As String)
        Try
            Dim dt As New DataTable
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = query
            dt.Load(cmd.ExecuteReader)
            Return dt
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(readlocal) : " & ex.Message)
            Return MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Public Shared Function ApiRead(txt As String)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        Dim reader As StreamReader
        Try
            request = DirectCast(WebRequest.Create(txt), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Get
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd() '.Replace("[ ", "").Replace(" ]", "")
            Dim json As New JavaScriptSerializer
            json.MaxJsonLength = 500000000
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            Return jsondata
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(ApiRead): " & ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Shared Function getlink(procedure As String, Optional p As String = Nothing) As String
        Dim sqliteconstr As String = Nothing
        sqliteconstr = "Data Source=local.sqlite;Version=3;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Dim cmd As SQLiteCommand = localcon.CreateCommand
        Try
            cmd.CommandText = "select link from t_apilink where sp = ?"
            cmd.Parameters.AddWithValue("sp", procedure)
            Dim cm As String = cmd.ExecuteScalar & apidefault & gettoken()
            Return cm.Replace("*", p)
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(getlink): " & ex.Message)
            MsgBox(ex.Message & " : getlink")
        End Try
    End Function

    Public Shared Sub readapi(procedure As String, grid As GridControl, name As String, Optional txt As String = Nothing)
        Dim dt As New DataTable
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Try
            request = DirectCast(WebRequest.Create(getlink(procedure)), HttpWebRequest)
            request = DirectCast(WebRequest.Create(txt), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Post
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd() '.Replace("[ ", "").Replace(" ]", "")
            Dim json As New JavaScriptSerializer
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            For Each s As KeyValuePair(Of String, Object) In jsondata("Data")(0)
                dt.Columns.Add(s.Key.ToUpper)
            Next
            Select Case name
                Case "Member"
                    For Each item In jsondata("Data")
                        dt.Rows.Add(item("ID"), item("MemberID"), item("FirstName"), item("DateOfBirth"),
    item("Phone"), item("Email"), item("Gender"), item("Address"), item("Religion"), item("Location"))
                    Next
            End Select
            grid.DataSource = dt
            grid.UseEmbeddedNavigator = True
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(ReadApi ) : " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Sub

    Public Shared Function gettoken()
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = "select link from t_apilink where sp = 'GetToken'"
            request = DirectCast(WebRequest.Create(cmd.ExecuteScalar & "?key=" & My.Settings.key & "&secret=" & My.Settings.secret & "&app=" & My.Settings.app), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd().Replace("[ ", "").Replace(" ]", "")
            Dim json As New JavaScriptSerializer
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            Return jsondata("data")("token")
            'For Each item In jsondata("data")
            '    res = item("token")
            'Next
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on Activecon-db(gettoken): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Function


    Public Shared Function readtable(query As String) As DataTable
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = query
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            Return dt
            log_file.storedata(Now & " User Succesfully executed local query. Statements : " & query)
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(readtable): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Public Shared Sub readlocal(query As String, grid As GridControl)
        Try
            Dim sqliteconstr As String = Nothing
            sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim cmd As SQLiteCommand = localcon.CreateCommand
            cmd.CommandText = query
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            grid.DataSource = dt
            grid.UseEmbeddedNavigator = True
            log_file.storedata(Now & " User Succesfully executed local query. Statements : " & query)
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(readlocal): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Sub syncapi(uri As String)
        Dim sqliteconstr As String = Nothing
        Dim dt As New DataTable
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim cmd As SQLiteCommand
        sqliteconstr = "Data Source = local.sqlite;Version=3;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Try
            request = DirectCast(WebRequest.Create(uri & "&token=" & gettoken()), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd().Replace("[ ", "").Replace(" ]", "")
            Dim json As New JavaScriptSerializer
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            For Each item In jsondata("data")
                cmd = localcon.CreateCommand
                cmd.CommandText = "insert into t_apilink (sp, link, type) values (?, ?, ?)"
                cmd.Parameters.AddWithValue("sp", item("phone"))
                cmd.Parameters.AddWithValue("link", item("name"))
                cmd.Parameters.AddWithValue("type", item("rfid"))
                cmd.ExecuteNonQuery()
            Next
            log_file.storedata(Now & " User succesfully syncing new apilink data")
            MsgBox("API Synced to the main server!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            log_file.storedata(Now & "-> Error on DB.syncapi " & ex.Message)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Sub

    Public Shared Sub throwdata(uri As String)
        Dim sqliteconstr As String = Nothing
        Dim dt As New DataTable
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim cmd As SQLiteCommand
        sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Try
            request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd().Replace("[ ", "").Replace(" ]", "")
            Dim json As New JavaScriptSerializer
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            For Each item In jsondata("data")
                cmd = localcon.CreateCommand
                cmd.CommandText = "insert into t_member (link, name, addr) values (?, ?, ?)"
                cmd.Parameters.AddWithValue("link", item("phone"))
                cmd.Parameters.AddWithValue("name", item("name"))
                cmd.Parameters.AddWithValue("addr", item("rfid"))
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Data Renewed Succesfully", MsgBoxStyle.Information)
            log_file.storedata(Now & " User succesfully syncing new data member")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            log_file.storedata(Now & "-> Error :" & ex.Message)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Sub

    Public Shared Sub constructDB(q As String)
        Try
            Dim sqliteconstr As String = Nothing

            Dim cmd As SQLiteCommand
            If Not File.Exists("local.sqlite") Then
                SQLiteConnection.CreateFile("local.sqlite")
            End If
            sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            cmd = localcon.CreateCommand
            cmd.CommandText = File.ReadAllText("localmembers.txt")
            cmd.ExecuteNonQuery()
            MsgBox("Members executed", MsgBoxStyle.Information)
            'log_file.storedata(Now & " User succesfully re-construct localDB")
            'If q = 1 Then
            '    If MessageBox.Show("Local DB Created Succesfully, do you want to get the newest Data to keep to this computers?", "Succesfully Created", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '        throwdata("http://api.gofamfit.com/members/getlist/?key=36188c419fa605812351e216ad0c1fa7&secret=20245&app=ffdesktop")
            '    End If
            'End If
        Catch ex As Exception
            log_file.storedata(Now & "-> Error on ActiveCon-DB(ConstructDB): " & ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Function execdb(db As Object, exec As String, action As Integer)
        'Dim dt As DataTable
        Select Case db
            Case "MySql"
                mysqlcon.Open()
                Dim query As MySqlCommand = mysqlcon.CreateCommand
                query.CommandText = exec
                If action = 1 Then
                    Return query.ExecuteNonQuery()
                ElseIf action = 2 Then
                    Return query.ExecuteScalar()
                ElseIf action = 3 Then
                    Return query.ExecuteReader
                End If
            Case "Sql Server"
                sqlservercon.Open()
                Dim query As SqlCommand = sqlservercon.CreateCommand
                query.CommandText = exec
                query.ExecuteNonQuery()
        End Select
        Return Nothing
    End Function

    Private serverType As String
    Private con As Object
    Private cmd As Object
    Private adp As Object
    Private conStr As String

    Private result As IAsyncResult

    Public host As String

    Protected disposed As Boolean = False

    Public Sub init(server As String, host As String, dataBase As String, user As String, pwd As String)
        serverType = server
        Me.host = host
        Select Case serverType
            Case "MSSQL"
                conStr = "Server=" + host + ";Database=" + dataBase + ";User=" + user + ";Pwd=" + pwd + ";MultipleActiveResultSets=True"
                con = New SqlConnection()
            Case "MySQL", "MariaDB"
                conStr = "Server=" + host + ";Database=" + dataBase + ";Uid=" + user + ";Pwd=" + pwd
                con = New MySqlConnection()
        End Select
        con.ConnectionString = conStr
    End Sub

    Public Sub init(serverType As String, conStr As String)
        Me.serverType = serverType
        Me.conStr = conStr
        Select Case serverType
            Case "MSSQL"
                con = New SqlConnection()
            Case "MySQL", "MariaDB"
                con = New MySqlConnection()
        End Select
        con.ConnectionString = conStr
    End Sub

    Public Function open() As Boolean
        Try
            con.Open()
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Sub close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Sub SQL(str As String, Optional cmdObj As Object = Nothing)
        If IsNothing(cmdObj) Then
            Select Case serverType
                Case "MSSQL"
                    cmd = New SqlCommand(str, con)
                Case "MySQL", "MariaDB"
                    cmd = New MySqlCommand(str, con)
            End Select
        Else
            If IsNothing(cmdObj.Connection) Then cmdObj.Connection = con
            cmdObj.CommandText = str
        End If
    End Sub

    Public Sub SQL(str As String, cmdType As CommandType)
        Select Case serverType
            Case "MSSQL"
                cmd = New SqlCommand(str, con)
            Case "MySQL", "MariaDB"
                cmd = New MySqlCommand(str, con)
        End Select
        cmd.CommandType = cmdType
    End Sub

    Public Function SQLReader(str As String) As Object
        Select Case serverType
            Case "MSSQL"
                Return New SqlCommand(str, con)
            Case "MySQL", "MariaDB"
                Dim tcon As New MySqlConnection
                tcon.ConnectionString = conStr
                tcon.Open()
                Return New MySqlCommand(str, tcon)
        End Select
        Return Nothing
    End Function

    Public Sub addOutputParam(name As String, size As Integer, type As Object)
        cmd.Parameters.Add(name, type, size)
        Select Case serverType
            Case "MSSQL"
                DirectCast(cmd, SqlCommand).Parameters(name).Direction = ParameterDirection.Output
            Case "MySQL", "MariaDB"
                DirectCast(cmd, MySqlCommand).Parameters(name).Direction = ParameterDirection.Output
        End Select
    End Sub

    Public Sub addParameter(name As String, val As Object)
        cmd.Parameters.AddWithValue(name, val)
    End Sub

    Public Sub addParameter(name As String, val As Object, cmdRdr As Object)
        cmdRdr.Parameters.AddWithValue(name, val)
    End Sub

    Public Sub clearParameter()
        cmd.Parameters.Clear()
    End Sub

    Public Sub clearParameter(cmdRdr As Object)
        cmdRdr.Parameters.Clear()
    End Sub

    Public Sub fillData(ByRef ds As DataSet, Optional cmdObj As Object = Nothing)
        If IsNothing(cmdObj) Then
            Select Case serverType
                Case "MSSQL"
                    adp = New SqlDataAdapter(cmd)
                Case "MySQL", "MariaDB"
                    adp = New MySqlDataAdapter(cmd)
            End Select
        Else
            Select Case serverType
                Case "MSSQL"
                    adp = New SqlDataAdapter(cmdObj)
                Case "MySQL", "MariaDB"
                    adp = New MySqlDataAdapter(cmdObj)
            End Select
        End If
        adp.Fill(ds)
        adp.Dispose()
        cmd.Dispose()
    End Sub

    Public Sub fillTable(ByRef dt As DataTable, Optional cmdObj As Object = Nothing)
        If IsNothing(cmdObj) Then
            Select Case serverType
                Case "MSSQL"
                    adp = New SqlDataAdapter(cmd)
                Case "MySQL", "MariaDB"
                    adp = New MySqlDataAdapter(cmd)
            End Select
        Else
            Select Case serverType
                Case "MSSQL"
                    adp = New SqlDataAdapter(cmdObj)
                Case "MySQL", "MariaDB"
                    adp = New MySqlDataAdapter(cmdObj)
            End Select
        End If
        adp.Fill(dt)
        adp.Dispose()
        cmd.Dispose()
    End Sub

    Public Function getData() As DataSet
        Dim ds As New DataSet
        Try
            fillData(ds)
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Return ds
    End Function

    'Public Function isReading() As Boolean
    '    If IsNothing(rdr) Then
    '        Return Not rdr.IsClosed
    '    Else
    '        Return False
    '    End If
    '    'Select Case serverType
    '    '    Case "MSSQL"
    '    '        If IsNothing(sqlRdr) Then
    '    '            Return Not sqlRdr.IsClosed
    '    '        Else
    '    '            Return False
    '    '        End If
    '    '    Case "MSSQL"
    '    '        If IsNothing(myRdr) Then
    '    '            Return Not myRdr.IsClosed
    '    '        Else
    '    '            Return False
    '    '        End If
    '    'End Select
    '    'Return False
    'End Function

    Public Function beginRead(cmdRdr As Object) As Object
        result = cmdRdr.BeginExecuteReader()
        Return cmdRdr.EndExecuteReader(result)
    End Function

    'Public Sub beginRead()
    '    result = cmd.BeginExecuteReader()
    '    rdr = cmd.EndExecuteReader(result)
    '    'Select Case serverType
    '    '    Case "MSSQL"
    '    '        'If Not IsNothing(sqlRdr) Then
    '    '        '    While Not sqlRdr.IsClosed
    '    '        '        Threading.Thread.Sleep(100)
    '    '        '    End While
    '    '        'End If

    '    '        result = sqlCmd.BeginExecuteReader
    '    '        sqlRdr = sqlCmd.EndExecuteReader(result)
    '    '    Case "MySQL", "MariaDB"
    '    '        'If Not IsNothing(myRdr) Then
    '    '        '    While Not myRdr.IsClosed
    '    '        '        Threading.Thread.Sleep(100)
    '    '        '    End While
    '    '        'End If

    '    '        result = myCmd.BeginExecuteReader
    '    '        myRdr = myCmd.EndExecuteReader(result)
    '    'End Select
    'End Sub

    Public Sub endRead(rdr As Object)
        rdr.Close()
    End Sub

    Public Function doRead(rdr As Object)
        Return rdr.Read()
    End Function

    Public Function getRow(rdr As Object) As Dictionary(Of String, Object)
        Dim row As New Dictionary(Of String, Object)
        Dim obj As Object

        For i = 0 To rdr.FieldCount - 1
            obj = rdr.GetValue(i)
            If IsDBNull(obj) Then
                obj = ""
            End If
            row.Add(rdr.GetName(i), obj)
        Next
        Return row
    End Function

    Public Sub execute()
        cmd.ExecuteNonQuery()
        If cmd.CommandType <> CommandType.StoredProcedure Then
            cmd.Dispose()
        End If
    End Sub

    Public Function scalar()
        Dim result = Nothing

        result = cmd.ExecuteScalar()
        cmd.Dispose()

        Return result
    End Function

    Public Function state() As ConnectionState
        Return con.State
    End Function

    Public Function getConnectionString() As String
        Return conStr
    End Function

    Public Function getServerType() As String
        Return serverType
    End Function

    Public Sub setOnStateChange(func)
        Select Case serverType
            Case "MSSQL"
                AddHandler DirectCast(con, SqlConnection).StateChange, func
            Case "MySQL", "MariaDB"
                AddHandler DirectCast(con, MySqlConnection).StateChange, func
        End Select
    End Sub

    Public Function getParamOutput(name As String) As Object
        Select Case serverType
            Case "MSSQL"
                Return DirectCast(cmd, SqlCommand).Parameters(name).Value
            Case "MySQL", "MariaDB"
                Return DirectCast(cmd, MySqlCommand).Parameters(name).Value
        End Select
        Return Nothing
    End Function

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not disposed Then
            If disposing Then
                ' Insert code to free managed resources.
                Try
                    adp.Dispose()
                    cmd.Dispose()
                    con.Dispose()
                Catch ex As Exception
                End Try
            End If
            ' Insert code to free unmanaged resources.
        End If
        disposed = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

End Class
