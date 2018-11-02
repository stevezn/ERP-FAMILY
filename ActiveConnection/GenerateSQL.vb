Imports System.Text
Imports MySql.Data.MySqlClient

Public Class GenerateSQL

    Public Shared Function BuildAllFieldsSql(dt As DataTable)
        Dim sql As String = ""
        For Each column As DataColumn In dt.Columns
            If sql.Length > 0 Then
                sql += ","
            End If
            sql += column.ColumnName
        Next
        Return sql
    End Function

    Public Shared Function BuildInsertSQL(dt As DataTable, value As String)
        Dim sql As New StringBuilder("INSERT INTO " + dt.TableName + " (")
        Dim values As New StringBuilder("VALUES (")
        Dim bFirst As Boolean = True
        Dim bIdentity As Boolean = False
        Dim identitytype As String = Nothing
        For Each column As DataColumn In dt.Columns
            If column.AutoIncrement Then
                bIdentity = True
                Select Case column.DataType.Name
                    Case "Int16"
                        identitytype = "smallint"
                    Case "SByte"
                        identitytype = "tinyint"
                    Case "Int64"
                        identitytype = "bigint"
                    Case "Decimal"
                        identitytype = "decimal"
                End Select
            Else
                If bFirst Then
                    bFirst = False
                Else
                    sql.Append(", ")
                End If
                sql.Append(column.ColumnName)
            End If
        Next
        Dim words As String() = value.Split(New Char() {"|"c})
        For Each word In words
            values.Append(word + ",")
        Next
        sql.Append(") ")
        sql.Append(values.ToString())
        Return sql.ToString.Remove(sql.Length - 1) + ")"
    End Function

    Public Shared Sub InsertParameter(command As MySqlCommand, parameterName As String, sourceColumn As String, value As Object)
        Dim parameter As MySqlParameter = New MySqlParameter(parameterName, value)
        parameter.Direction = ParameterDirection.Input
        parameter.ParameterName = parameterName
        parameter.SourceColumn = sourceColumn
        parameter.SourceVersion = DataRowVersion.Current
    End Sub

    Public Shared Function CreateInsertCommand(row As DataRow) As MySqlCommand
        Dim table As DataTable = row.Table
        Dim sql = BuildInsertSQL(table, "")
        Dim command As MySqlCommand = New MySqlCommand(sql)
        command.CommandType = CommandType.Text
        For Each column As DataColumn In table.Columns
            If column.AutoIncrement = False Then
                Dim parameterName As String = "@" + column.ColumnName
                InsertParameter(command, parameterName, column.ColumnName, row(column.ColumnName))
            End If
        Next
        Return command
    End Function

    Public Shared Function InsertDataRow(row As DataRow, connectionString As String) As Object
        Dim command As MySqlCommand = CreateInsertCommand(row)
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)
        With connection
            command.Connection = connection
            command.CommandType = CommandType.Text
            connection.Open()
            Return command.ExecuteScalar
        End With
    End Function
End Class