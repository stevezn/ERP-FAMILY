Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports ActiveConnection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class Paging
    Private _comboPageSize As ComboBoxEdit
    Private _labelDisplay As LabelControl
    Private _gridControl As GridControl
    Private gridview As GridView
    Private _dtSource As DataTable
    Private _recNo As Integer
    Private _currentPage As Integer
    Private _pageSize As Integer
    Private _maxRec As Integer
    Private _pageCount As Integer

    Public Property PageCount As Integer
        Get
            Return _pageCount
        End Get
        Set(ByVal Value As Integer)
            _pageCount = Value
        End Set
    End Property

    Public Property MaxRec As Integer
        Get
            Return _maxRec
        End Get
        Set(ByVal Value As Integer)
            _maxRec = Value
        End Set
    End Property

    Public Property PageSize As Integer
        Get
            Return _pageSize
        End Get
        Set(ByVal Value As Integer)
            _pageSize = Value
        End Set
    End Property

    Public Property CurrentPage As Integer
        Get
            Return _currentPage
        End Get
        Set(ByVal Value As Integer)
            _currentPage = Value
        End Set
    End Property

    Public Property RecNo As Integer
        Get
            Return _recNo
        End Get
        Set(ByVal Value As Integer)
            _recNo = Value
        End Set
    End Property

    Public Property dtSource As DataTable
        Get
            Return _dtSource
        End Get
        Set(ByVal Value As DataTable)
            _dtSource = Value
        End Set
    End Property

    Public Property GridControl As GridControl
        Get
            Return _gridControl
        End Get
        Set(ByVal Value As GridControl)
            _gridControl = Value
        End Set
    End Property

    Public Property LabelDisplay As LabelControl
        Get
            Return _labelDisplay
        End Get
        Set(ByVal Value As LabelControl)
            _labelDisplay = Value
        End Set
    End Property

    Public Property ComboPageSize As ComboBoxEdit
        Get
            Return _comboPageSize
        End Get
        Set(ByVal Value As ComboBoxEdit)
            _comboPageSize = Value
        End Set
    End Property

    Public Sub LoadPage()
        Dim i As Integer
        Dim startRec As Integer = RecNo
        Dim endRec As Integer
        Dim dtTemp As DataTable
        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSource.Clone
        If CurrentPage = PageCount Then
            endRec = MaxRec
        Else
            endRec = PageSize * CurrentPage
        End If
        'Copy the rows from the source table to fill the temporary table.
        For i = startRec To endRec - 1
            If i < dtSource.Rows.Count Then
                dtTemp.ImportRow(dtSource.Rows(i))
                RecNo = RecNo + 1
            End If
        Next
        GridControl.DataSource = dtTemp
        DisplayPageInfo()
    End Sub
    Private Sub DisplayPageInfo()
        LabelDisplay.Text = "Page " & CurrentPage.ToString & "/ " & PageCount.ToString
    End Sub
    Public Sub LastPage()
        CurrentPage = PageCount
        RecNo = PageSize * (CurrentPage - 1)
        LoadPage()
    End Sub
    Public Sub FirstPage()
        If CurrentPage = 1 Then
            Exit Sub
        End If
        CurrentPage = 1
        RecNo = 0
        LoadPage()
    End Sub
    Public Sub PreviousPage()

        If CurrentPage = PageCount Then
            RecNo = PageSize * (CurrentPage - 2) '-2
            Exit Sub
        End If
        CurrentPage = CurrentPage - 1
        If CurrentPage < 1 Then
            CurrentPage = 1
        Else
            RecNo = PageSize * (CurrentPage - 1)
        End If
        LoadPage()

    End Sub
    Public Sub NextPage()
        If CurrentPage = PageCount Then
            Exit Sub
        End If
        CurrentPage = CurrentPage + 1
        If CurrentPage > PageCount Then
            CurrentPage = PageCount
            If RecNo = MaxRec Then
            End If
        End If
        LoadPage()
    End Sub

    Public Sub allpage()
        dtSource = DB.readlocal("select a.id AS ID ,a.memberid as MemberID, a.firstname AS `FirstName`, a.dob as DateOfBirth, a.lastname AS `LastName`,
`a`.`phone` AS `Phone`,`a`.`email` AS `Email`,ifnull(`a`.`gender`, 'Unspesified') AS `Gender`,ifnull(`a`.`address1`, 'No data') as `Address1`,`a`.`address2` AS `Address2`,`a`.`address3` AS `Address3`,
ifnull(`a`.`religion`, 'Unspesified') AS `Religion`,`a`.`location` AS `Location`,ifnull(`a`.`idtype`, 'KTP') AS `IdType`,ifnull(`a`.`noid`, 'No data') as `NoID`,`b`.`fullname` AS `FullName`,`a`.`remarks` AS `Remarks`,`a`.`city` AS `City` from (`t_members` `a` left join `t_user` `b` on(`a`.`createby` = `b`.`id`)) where `a`.`dob` <> '0000-00-00' and `a`.`dob` is not null and `a`.`id` <> 1")
        LoadPage()
    End Sub

    Public Sub Innitial(ByVal GridControlData As GridControl, ByVal LabelDisplyPage As LabelControl, ByVal DropPageSize As ComboBoxEdit)
        GridControl = GridControlData
        LabelDisplay = LabelDisplyPage
        ComboPageSize = DropPageSize
        PageSize = ComboPageSize.Text
        dtSource = DB.readlocal("select a.id AS ID ,a.memberid as MemberID, a.firstname AS `FirstName`, a.dob as DateOfBirth, a.lastname AS `LastName`,
`a`.`phone` AS `Phone`,`a`.`email` AS `Email`,ifnull(`a`.`gender`, 'Unspesified') AS `Gender`,ifnull(`a`.`address1`, 'No data') as `Address1`,`a`.`address2` AS `Address2`,`a`.`address3` AS `Address3`,
ifnull(`a`.`religion`, 'Unspesified') AS `Religion`,`a`.`location` AS `Location`,ifnull(`a`.`idtype`, 'KTP') AS `IdType`,ifnull(`a`.`noid`, 'No data') as `NoID`,`b`.`fullname` AS `FullName`,`a`.`remarks` AS `Remarks`,`a`.`city` AS `City` from (`t_members` `a` left join `t_user` `b` on(`a`.`createby` = `b`.`id`)) where `a`.`dob` <> '0000-00-00' and `a`.`dob` is not null and `a`.`id` <> 1")
        MaxRec = dtSource.Rows.Count
        PageCount = MaxRec \ PageSize
        If (MaxRec Mod PageSize) > 0 Then
            PageCount = PageCount - 1
        End If
        CurrentPage = 1
        RecNo = 0
        LoadPage()
    End Sub
End Class
