Imports ActiveConnection
Imports DevExpress.XtraGrid.Views.Grid

Public Class ApiConf
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ApiConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl1.DataSource = DB.readlocal("select ID, SP as Function, Link, Type from t_apilink")
        GridView1.BestFitColumns()
        GridControl1.UseEmbeddedNavigator = True
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            'e.Menu.Items.Add(New DXMenuItem("Sync API", New EventHandler(AddressOf DB.syncapi(""))))
            ' e.Menu.Items.Add(New DXMenuItem("Sync API", )
        End If
    End Sub
End Class