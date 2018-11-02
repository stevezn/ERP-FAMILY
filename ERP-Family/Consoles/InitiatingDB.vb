Imports ActiveConnection
Imports System.Data.SQLite


Module InitiatingDB
    Dim ip, networktype, username, password, port As String

    'Sub initiatedb()
    '    DB.constructDB()
    '    DB.localcon.Open()
    '    Dim query As SQLiteCommand = DB.localcon.CreateCommand
    '    query.CommandText = "select * from connections where active = 1"
    '    Dim tab As New DataTable
    '    tab.Load(query.ExecuteReader)
    '    For i As Integer = 0 To tab.Rows.Count - 1
    '        ip = tab.Rows(i).Item("ip").ToString
    '        username = tab.Rows(i).Item("username").ToString
    '        password = tab.Rows(i).Item("password").ToString
    '        port = tab.Rows(i).Item("port").ToString
    '        networktype = tab.Rows(i).Item("networktype").ToString
    '    Next
    'End Sub
End Module