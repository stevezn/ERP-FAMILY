Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.IO

Module EasyAccess
    Public Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function

    Public Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

    'Sub downloaditem()
    '    Try
    '        Dim sfilepath As String
    '        Dim buffer As Byte()
    '        Using cmd As New MySqlCommand("select attachments, extension from attachment where id = ?", SQLConnection)
    '            cmd.Parameters.AddWithValue("id", GridView1.GetFocusedRowCellValue("Id"))
    '            Dim tab As New DataTable
    '            tab.Load(cmd.ExecuteReader)
    '            For index As Integer = 0 To tab.Rows.Count - 1
    '                buffer = CType(tab.Rows(index).Item("attachments"), Byte())
    '                sfilepath = Path.GetTempFileName()
    '                File.Move(sfilepath, Path.ChangeExtension(sfilepath, tab.Rows(index).Item("extension")))
    '                sfilepath = Path.ChangeExtension(sfilepath, tab.Rows(index).Item("extension"))
    '                File.WriteAllBytes(sfilepath, buffer)
    '                Dim op As New Process
    '                op.StartInfo = New ProcessStartInfo(CType(sfilepath, String))
    '                op.Start()
    '            Next
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

End Module
