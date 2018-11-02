Imports System.Data.SQLite
Imports ActiveConnection

Public Class Devices
    Private Sub Devices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddevice()
    End Sub

    Sub loaddevice()
        GridControl1.DataSource = DB.readlocal("select ID, SN as SerialNumber, ac as ActivationCode, vc as VerificationCode, Type, usethis as ActiveDevice from t_device")
        GridView1.BestFitColumns()
        GridControl1.UseEmbeddedNavigator = True
    End Sub

    Sub changeactive()
        Dim sqliteconstr As String = Nothing
        sqliteconstr = "Data Source=local.sqlite;Version=3;"
        Dim localcon As New SQLiteConnection(sqliteconstr)
        localcon.Open()
        Dim cmd As SQLiteCommand = localcon.CreateCommand
        cmd.CommandText = "update t_device set usethis = 1 where id = @id;
                           update t_device set usethis = 0 where id <> @id;"
        cmd.Parameters.AddWithValue("@id", GridView1.GetFocusedRowCellValue("id"))
        cmd.ExecuteNonQuery()
        MsgBox("Device has changed", MsgBoxStyle.Information)
        loaddevice()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Set as active", New EventHandler(AddressOf changeactive)))
        End If
    End Sub
End Class