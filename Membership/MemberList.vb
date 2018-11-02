Imports System.ComponentModel
Imports DevExpress.XtraBars
Imports System.ComponentModel.DataAnnotations
Imports ActiveConnection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data

Partial Public Class MemberList
    Public Sub New()
        InitializeComponent()
        ribbonControl.Minimized = True
        'gridControl.DataSource = getdata()
        gridView.OptionsView.ShowFooter = True
        Dim item As GridGroupSummaryItem = New GridGroupSummaryItem
        item.FieldName = "Location"
        item.SummaryType = SummaryItemType.Count
        item.DisplayFormat = "Total Members : {0}"
        item.ShowInGroupColumnFooter = gridView.Columns("unknown")
        gridView.GroupSummary.Add(item)
        gridView.BestFitColumns()
        gridView.MoveLast()
        gridView.ExpandAllGroups()
        gridControl.UseEmbeddedNavigator = True
        Dim gv As GridView = CType(gridControl.FocusedView, GridView)
        gv.SortInfo.ClearAndAddRange(New GridColumnSortInfo() {
        New GridColumnSortInfo(gv.Columns("Location"), ColumnSortOrder.Ascending)}, 1)
        gv.ExpandAllGroups()
    End Sub

    Public Sub getdataoff()
        gridControl.DataSource = DB.readlocal("select a.id ,a.memberid, a.firstname AS `firstname`, a.lastname AS `lastname`,`a`.`phone` AS `phone`,`a`.`email` AS `email`,`a`.`gender` AS `gender`,`a`.`address1` AS `address1`,`a`.`address2` AS `address2`,`a`.`address3` AS `address3`,`a`.`religion` AS `religion`,`a`.`location` AS `location`,`a`.`idtype` AS `idtype`,`a`.`noid` AS `noid`,`b`.`fullname` AS `fullname`,`a`.`remarks` AS `remarks`,`a`.`city` AS `city` from (`t_members` `a` left join `t_user` `b` on(`a`.`createby` = `b`.`id`)) where `a`.`dob` <> '0000-00-00' and `a`.`dob` is not null and `a`.`id` <> 1")
    End Sub

    Public Shared getfoc As String

    Private Sub bbiPrintPreview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiPrintPreview.ItemClick
        gridControl.ShowRibbonPrintPreview()
    End Sub

    Public Shared Function getdata() As BindingList(Of Members)
        Dim result As New BindingList(Of Members)()
        Dim dt As New DataTable
        dt = DB.readlocal("select a.id ,a.memberid, a.firstname AS `firstname`, a.dob, a.lastname AS `lastname`,`a`.`phone` AS `phone`,`a`.`email` AS `email`,ifnull(`a`.`gender`, 'Unspesified') AS `gender`,ifnull(`a`.`address1`, 'No data') as `address1`,`a`.`address2` AS `address2`,`a`.`address3` AS `address3`,ifnull(`a`.`religion`, 'Unspesified') AS `religion`,`a`.`location` AS `location`,ifnull(`a`.`idtype`, 'KTP') AS `idtype`,ifnull(`a`.`noid`, 'No data') as `noid`,`b`.`fullname` AS `fullname`,`a`.`remarks` AS `remarks`,`a`.`city` AS `city` from (`t_members` `a` left join `t_user` `b` on(`a`.`createby` = `b`.`id`)) where `a`.`dob` <> '0000-00-00' and `a`.`dob` is not null and `a`.`id` <> 1")
        For i As Integer = 0 To dt.Rows.Count - 1
            result.Add(New Members() With {.ID = dt.Rows(i).Item("id"), .MemberID = dt.Rows(i).Item("memberid"), .Name = dt.Rows(i).Item("firstname"),
                       .DateOfBirth = dt.Rows(i).Item("dob"), .Phone = dt.Rows(i).Item("phone"), .Email = dt.Rows(i).Item("email"),
                       .Gender = dt.Rows(i).Item("gender"), .Address = dt.Rows(i).Item("address1"), .Religion = dt.Rows(i).Item("religion"),
                       .Location = dt.Rows(i).Item("location"), .IDType = dt.Rows(i).Item("idtype"), .NOID = dt.Rows(i).Item("noid"), .CreatedBy = dt.Rows(i).Item("fullname")})
        Next
        Return result
    End Function

    Public Shared Function getdataapi() As BindingList(Of Members)
        Dim result As New BindingList(Of Members)()
        Dim jsondata As Dictionary(Of String, Object) = DB.ApiRead(DB.getlink("GetMemberList"))
        For Each item In jsondata("data")
            result.Add(New Members() With {.ID = item("ID"), .MemberID = item("memberid"), .Name = item("firstname"),
                       .DateOfBirth = item("dob"), .Phone = item("phone"), .Email = item("email"),
                       .Gender = item("gender"), .Address = item("address1"), .Religion = item("religion"),
                       .Location = item("location"), .IDType = item("idtype"), .NOID = item("noid"), .CreatedBy = item("fullname")})
        Next
        Return result
    End Function

    Public Class Members
        <Key, Display(AutoGenerateField:=False)>
        Public Property ID() As Integer
        <Required>
        Public Property MemberID() As String
        Public Property Name() As String
        Public Property Address() As String
        Public Property DateOfBirth() As Date
        Public Property Phone() As String
        Public Property Email() As String
        Public Property Gender() As String
        Public Property IDType() As String
        <Display(Name:="No ID")>
        Public Property NOID() As String
        Public Property Religion() As String
        Public Property CreatedBy() As String
        Public Property Location() As String
    End Class

    Sub viewdi()
        Dim v As New ViewProfile
        v.ShowDialog()
    End Sub

    Private Sub gridView_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles gridView.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        getfoc = gridView.GetFocusedRowCellValue("MemberID")
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim item As DXMenuItem = AccessHandler.CreateMergingEnabledMenuItem(view, rowHandle)
            item.BeginGroup = True
            e.Menu.Items.Add(item)
        End If
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            e.Menu.Items.Add(New DXMenuItem("View Profile", New EventHandler(AddressOf viewdi), ImageCollection1.Images(0)))
        End If
    End Sub

    Sub voidmember()
        Dim s As String
        DB.ApiRead(DB.getlink("VoidTable", MemberList.getfoc))
    End Sub

    Private Class1 As New Paging

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextPage.Click
        Class1.NextPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreviousPage.Click
        Class1.PreviousPage()
    End Sub
    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstPage.Click
        Class1.FirstPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Class1.LastPage()
    End Sub
    Private Sub txtPageSize_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPageSize.EditValueChanged
        MemberList_Load(sender, e)
    End Sub

    Private Sub MemberList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Class1.Innitial(gridControl, txtDisplayPageNo, txtPageSize)
        gridView.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        gridControl.DataSource = Class1.dtSource
        gridView.ExpandAllGroups()
        gridView.ShowFilterEditor(gridView.Columns(0))
    End Sub
End Class