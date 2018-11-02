Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Public Class DoSync

    Public Shared Function syncdata(uri As String)
        Try
            Dim datajson As New Dictionary(Of String, Object)
            Dim cmd As SQLiteCommand
            Dim sqliteconstr As String = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Get
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd()
            Dim json As New JavaScriptSerializer
            json.MaxJsonLength = 500000000
            Dim jsondat As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            If jsondat("status") = "false" Then
                Exit Function
            End If
            For Each item In jsondat("data")
                Try
                    cmd = localcon.CreateCommand
                    cmd.CommandText = item("query").ToString.Replace("\r\n", "")
                    cmd.ExecuteNonQuery()
                    datajson.Add("id", item("id"))
                    DB.ApiRead(DB.getlink("DeleteQuery", item("id")))
                    Return "Query executed"
                Catch ex As Exception
                    ' Continue For
                    Return ex.Message
                    log_file.storedata(Now & "-> Error : ActiveCon-DOSync-syncdata , error message :" & ex.Message)
                End Try
            Next
            MsgBox("Synced Succesfully", MsgBoxStyle.Information)
        Catch ex As Exception
            Return ex.Message
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            log_file.storedata(Now & "-> Error on ActiveCon-DB(readpost) " & ex.Message)
        End Try
    End Function

    Public Shared Sub throwdata(uri As String, table As String)
        Dim sqliteconstr As String = Nothing
        Dim dt As New DataTable
        Dim cmd As SQLiteCommand
        sqliteconstr = "Data Source=local.sqlite;Version=3;New=False;Compress=True;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
            request.Method = WebRequestMethods.Http.Get
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd()
            Dim json As New JavaScriptSerializer
            json.MaxJsonLength = 500000000
            Dim jsondat As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(rawresp)
            cmd = localcon.CreateCommand
            cmd.CommandText = "DELETE FROM " & table
            cmd.ExecuteNonQuery()
            For Each item In jsondat("data")
                Select Case table
                    Case "t_apilink"
                        cmd.CommandText = "INSERT INTO t_apilink (sp, link, type) VALUES (?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("sp", item("sp"))
                        cmd.Parameters.AddWithValue("link", item("link"))
                        cmd.Parameters.AddWithValue("type", item("type"))
                        cmd.ExecuteNonQuery()
                    Case "t_attachment"
                        cmd.CommandText = "INSERT INTO t_attachment (memberid, attach, extension, type, filename, isvoid) VALUES (?,?,?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("memberid", item("memberid"))
                        cmd.Parameters.AddWithValue("attach", item("attach"))
                        cmd.Parameters.AddWithValue("extension", item("extension"))
                        cmd.Parameters.AddWithValue("type", item("type"))
                        cmd.Parameters.AddWithValue("filename", item("filename"))
                        cmd.Parameters.AddWithValue("isvoid", item("isvoid"))
                        cmd.ExecuteNonQuery()
                    Case "t_computer"
                        cmd.CommandText = "INSERT INTO t_computer (ip, mac, hostname, lastactive, lastuser, blockaccess, createdate, remarks) VALUES (?,?,?,?,?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("ip", item("ip"))
                        cmd.Parameters.AddWithValue("mac", item("mac"))
                        cmd.Parameters.AddWithValue("hostname", item("hostname"))
                        cmd.Parameters.AddWithValue("lastactive", item("lastactive"))
                        cmd.Parameters.AddWithValue("lastuser", item("lastuser"))
                        cmd.Parameters.AddWithValue("blockaccess", item("blockaccess"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("remarks", item("remarks"))
                        cmd.ExecuteNonQuery()
                    Case "t_device"
                        cmd.CommandText = "INSERT INTO t_device (sn, vn, ac, type) VALUES (?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("sn", item("sn"))
                        cmd.Parameters.AddWithValue("vn", item("vn"))
                        cmd.Parameters.AddWithValue("ac", item("ac"))
                        cmd.Parameters.AddWithValue("type", item("type"))
                        cmd.ExecuteNonQuery()
                    Case "t_finger"
                        cmd.CommandText = "INSERT INTO t_finger (memberid, type, fingerindex, data, createdate, createby, remarks, void, voidby) VALUES (?,?,?,?,?,?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("memberid", item("memberid"))
                        cmd.Parameters.AddWithValue("type", item("type"))
                        cmd.Parameters.AddWithValue("fingerindex", item("fingerindex"))
                        cmd.Parameters.AddWithValue("data", item("data"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("remarks", item("remarks"))
                        cmd.Parameters.AddWithValue("void", item("void"))
                        cmd.Parameters.AddWithValue("voidby", item("voidby"))
                        cmd.ExecuteNonQuery()
                    Case "t_location"
                        cmd.CommandText = "INSERT INTO t_location (locid, name, createby, createdate, isvoid, voidby) VALUES (?,?,?,?,?,?)"
                        cmd.Parameters.AddWithValue("locid", item("locid"))
                        cmd.Parameters.AddWithValue("name", item("name"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("isvoid", item("isvoid"))
                        cmd.Parameters.AddWithValue("voidby", item("voidby"))
                        cmd.ExecuteNonQuery()
                    Case "t_logfile"
                        cmd.CommandText = "INSERT INTO t_logfile (uid, tgl, userid, activity, ishide) VALUES (?,?,?,?,?)"
                        cmd.Parameters.AddWithValue("uid", item("uid"))
                        cmd.Parameters.AddWithValue("tgl", item("tgl"))
                        cmd.Parameters.AddWithValue("userid", item("userid"))
                        cmd.Parameters.AddWithValue("activity", item("activity"))
                        cmd.Parameters.AddWithValue("ishide", item("ishide"))
                        cmd.ExecuteNonQuery()
                    Case "t_marketing"
                        cmd.CommandText = "INSERT INTO t_marketing (salesid, name, createdate, createby, void) VALUES (?,?,?,?,?)"
                        cmd.Parameters.AddWithValue("salesid", item("salesid"))
                        cmd.Parameters.AddWithValue("name", item("name"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("void", item("void"))
                        cmd.ExecuteNonQuery()
                    Case "t_members"
                        cmd.CommandText = "insert into t_members (memberid, firstname, lastname, dob, city, phone, email, gender,
                                            idtype, noid, address1, address2, address3, religion, location, remarks, createby, createdate,
                                            isvoid, blacklist, occupation, bloodtype, weight, height) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                        cmd.Parameters.AddWithValue("memberid", item("memberid"))
                        cmd.Parameters.AddWithValue("firstname", item("firstname"))
                        cmd.Parameters.AddWithValue("lastname", item("lastname"))
                        cmd.Parameters.AddWithValue("dob", item("dob"))
                        cmd.Parameters.AddWithValue("city", item("city"))
                        cmd.Parameters.AddWithValue("phone", item("phone"))
                        cmd.Parameters.AddWithValue("email", item("email"))
                        cmd.Parameters.AddWithValue("gender", item("gender"))
                        cmd.Parameters.AddWithValue("idtype", item("idtype"))
                        cmd.Parameters.AddWithValue("noid", item("noid"))
                        cmd.Parameters.AddWithValue("address1", item("address1"))
                        cmd.Parameters.AddWithValue("address2", item("address2"))
                        cmd.Parameters.AddWithValue("address3", item("address3"))
                        cmd.Parameters.AddWithValue("religion", item("religion"))
                        cmd.Parameters.AddWithValue("location", item("location"))
                        cmd.Parameters.AddWithValue("remarks", item("remarks"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("isvoid", item("isvoid"))
                        cmd.Parameters.AddWithValue("blacklist", item("blacklist"))
                        cmd.Parameters.AddWithValue("occupation", item("occupation"))
                        cmd.Parameters.AddWithValue("bloodtype", item("bloodtype"))
                        cmd.Parameters.AddWithValue("weight", item("weight"))
                        cmd.Parameters.AddWithValue("height", item("height"))
                        cmd.ExecuteNonQuery()
                    Case "t_package"
                        cmd.CommandText = "INSERT INTO t_package (packageid, name, price, months, expdate, free, session, startdate, enddate,
                                            createby, createdate, modifiedby, modifieddate, category,remarks, isenable)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("packageid", item("packageid"))
                        cmd.Parameters.AddWithValue("name", item("name"))
                        cmd.Parameters.AddWithValue("price", item("price"))
                        cmd.Parameters.AddWithValue("months", item("months"))
                        cmd.Parameters.AddWithValue("expdate", item("expdate"))
                        cmd.Parameters.AddWithValue("free", item("free"))
                        cmd.Parameters.AddWithValue("session", item("session"))
                        cmd.Parameters.AddWithValue("startdate", item("startdate"))
                        cmd.Parameters.AddWithValue("enddate", item("enddate"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("modifiedby", item("modifiedby"))
                        cmd.Parameters.AddWithValue("modifieddate", item("modifieddate"))
                        cmd.Parameters.AddWithValue("category", item("category"))
                        cmd.Parameters.AddWithValue("remarks", item("remarks"))
                        cmd.Parameters.AddWithValue("isenable", item("isenable"))
                        cmd.ExecuteNonQuery()
                    Case "t_packagelist"
                        cmd.CommandText = "INSERT INTO t_packagelist(pckgid, itemname, memberid, name, purchasedate, regdate, exp, 
                                            extend, pic, price, ptdate, ptexp, ptt, ptrun, pt, type, createby, createdate, modby,
                                            moddate, isvalid) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("pckgid", item("pckgid"))
                        cmd.Parameters.AddWithValue("itemname", item("itemname"))
                        cmd.Parameters.AddWithValue("memberid", item("memberid"))
                        cmd.Parameters.AddWithValue("name", item("name"))
                        cmd.Parameters.AddWithValue("purchasedate", item("purchasedate"))
                        cmd.Parameters.AddWithValue("regdate", item("regdate"))
                        cmd.Parameters.AddWithValue("exp", item("exp"))
                        cmd.Parameters.AddWithValue("extend", item("extend"))
                        cmd.Parameters.AddWithValue("pic", item("pic"))
                        cmd.Parameters.AddWithValue("price", item("price"))
                        cmd.Parameters.AddWithValue("ptdate", item("ptdate"))
                        cmd.Parameters.AddWithValue("ptexp", item("ptexp"))
                        cmd.Parameters.AddWithValue("ptt", item("ptt"))
                        cmd.Parameters.AddWithValue("type", item("type"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("modby", item("mod"))
                        cmd.Parameters.AddWithValue("moddate", item("moddate"))
                        cmd.Parameters.AddWithValue("isvalid", item("isvalid"))
                        cmd.ExecuteNonQuery()
                    Case "t_user"
                        cmd.CommandText = "INSERT INTO t_user (userid, fullname, roles, email, pass, createdate, createby, locations, isenable, rfid)
                                            VALUES (?,?,?,?,?,?,?,?,?,?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("userid", item("userid"))
                        cmd.Parameters.AddWithValue("fullname", item("fullname"))
                        cmd.Parameters.AddWithValue("roles", item("roles"))
                        cmd.Parameters.AddWithValue("email", item("email"))
                        cmd.Parameters.AddWithValue("pass", item("pass"))
                        cmd.Parameters.AddWithValue("createdate", item("createdate"))
                        cmd.Parameters.AddWithValue("createby", item("createby"))
                        cmd.Parameters.AddWithValue("locations", item("locations"))
                        cmd.Parameters.AddWithValue("isenable", item("isenable"))
                        cmd.Parameters.AddWithValue("rfid", item("rfid"))
                        cmd.ExecuteNonQuery()
                    Case "t_auth"
                        cmd.CommandText = "INSERT INTO t_auth (userid, roles, addmember, addcard, addfinger, voidmember, viewmember, scanmember)
                                            VALUES (?,?,?,?,?,?,?,?)"
                        cmd.Parameters.AddWithValue("userid", item("userid"))
                        cmd.Parameters.AddWithValue("roles", item("roles"))
                        cmd.Parameters.AddWithValue("addmember", item("addmember"))
                        cmd.Parameters.AddWithValue("addcard", item("addcard"))
                        cmd.Parameters.AddWithValue("addfinger", item("addfinger"))
                        cmd.Parameters.AddWithValue("voidmember", item("voidmember"))
                        cmd.Parameters.AddWithValue("viewmember", item("viewmember"))
                        cmd.Parameters.AddWithValue("scanmember", item("scanmember"))
                        cmd.ExecuteNonQuery()
                End Select
            Next
            MsgBox("Data Renewed Succesfully", MsgBoxStyle.Information)
            log_file.storedata(Now & " User succesfully syncing new data member")
        Catch ex As Exception
            MsgBox(ex.Message & " sync", MsgBoxStyle.Information)
            log_file.storedata(Now & "-> Error :" & ex.Message)
        Finally
            'If Not response Is Nothing Then response.Close()
        End Try
    End Sub
End Class