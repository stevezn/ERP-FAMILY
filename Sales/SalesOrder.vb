Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports ActiveConnection


Public Class SalesOrder

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Lookupedit()
        ' Add any initialization after the InitializeComponent() call.

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

    'Public Shared Function getdata() As BindingList(Of Members)
    '    Dim result As New BindingList(Of Members)()

    '    Dim jsondata As Dictionary(Of String, Object) = DB.ApiRead(DB.getlink("GetMemberList"))
    '    For Each item In jsondata("data")
    '        result.Add(New Members() With {.ID = item("ID"), .MemberID = item("memberid"), .Name = item("firstname"),
    '                   .DateOfBirth = item("dob"), .Phone = item("phone"), .Email = item("email"),
    '                   .Gender = item("gender"), .Address = item("address1"), .Religion = item("religion"),
    '                   .Location = item("location"), .IDType = item("idtype"), .NOID = item("noid"), .CreatedBy = item("fullname")})
    '    Next
    '    Return result
    'End Function

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


    Sub Lookupedit()
        LookUpEdit1.Properties.DataSource = getdata()
        LookUpEdit1.Properties.DisplayMember = "Name"
        LookUpEdit1.Properties.ValueMember = "Name"
    End Sub

End Class
