Imports System.ComponentModel
Imports System.Data.SQLite
Imports ActiveConnection

Partial Public Class MainForm
    Public Sub New()
        InitializeComponent()
        slblCorp.Text = DB.locations
        slblUser.Text = DB.user
        Text = "FAMILY ERP SYSTEM ( " & DB.user & " )"
    End Sub

    Sub auth()
        Try
            Dim sqliteconstr As String = Nothing
            Dim cmd As SQLiteCommand
            sqliteconstr = "Data Source=local.sqlite;Version=3"
            Dim localcon As New SQLiteConnection(sqliteconstr)
            localcon.Open()
            cmd = localcon.CreateCommand
            cmd.CommandText = "select AddMember, AddCard, AddFinger, VoidMember, ViewMember, ScanMember from t_auth where userid = '" & DB.id & "'"
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(0).Item("AddMember") = 0 Then
                    NavBarItem5.Visible = False
                End If
                If dt.Rows(0).Item("AddCard") = 0 Then
                    NavBarItem8.Visible = False
                End If
                If dt.Rows(0).Item("AddFinger") = 0 Then
                    NavBarItem9.Visible = False
                End If
                If dt.Rows(0).Item("ViewMember") = 0 Then
                    NavBarItem6.Visible = False
                End If
                If dt.Rows(0).Item("ScanMember") = 0 Then
                    NavBarItem11.Visible = False
                End If
            Next
        Catch ex As Exception
            log_file.storedata(Now & " Error : " & ex.Message & " on MainForm.Auth")
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth()
        Timer2.Interval = TimeSpan.FromMinutes(5).TotalMilliseconds
        Timer1.Start()
        Timer2.Start()
        ribbonControl.Minimized = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = Now.ToLongDateString
        datearea.Text = Now.ToLongTimeString
        If DB.CheckDB = True Then
            slblNetCheck.Text = "Connection Stable"
        Else
            slblNetCheck.Text = "Connection Lost"
        End If
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Membership", "AddMember", "New Member")
    End Sub

    Private Sub ConstructSqliteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstructSqliteToolStripMenuItem.Click
        DB.constructDB(1)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ApiConf.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        log_file.ended()
        Application.Exit()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        log_file.ended()
        Application.Exit()
    End Sub

    Private Sub NavBarItem6_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        GetControls.loadmodule(ClosableTabControl1, "Membership", "MemberList", "Member List")
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Sales", "SalesOrder", "Sales Order")
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Sales", "SalesDaily", "Sales Daily")
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Sales", "SalesFree", "Free Sales")
    End Sub

    Private Sub NavBarItem7_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Membership", "SearchMember", "Search Member")
    End Sub

    Private Sub NavBarItem8_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        GetControls.loadmodule(ClosableTabControl1, "Membership", "AddCard", "Add Card")
    End Sub

    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        GetControls.loadmodule(ClosableTabControl1, "Membership", "AddFinger", "Add Finger")
    End Sub

    Private Sub NavBarItem4_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem4.LinkClicked
        If slblNetCheck.Text = "Connection Lost" Then
            MsgBox("Lost connection to server", MsgBoxStyle.Information)
            Exit Sub
        End If
        GetControls.loadmodule(ClosableTabControl1, "Sales", "SearchSales", "Search Sales")
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim api As New API
        api.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        ViewLog.ShowDialog()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        EmailConf.ShowDialog()
    End Sub

    Private Sub NavBarItem10_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        GetControls.loadmodule(ClosableTabControl1, "Membership", "FingerV", "Finger Verification")
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Devices.ShowDialog()
    End Sub

    Private Sub NavBarItem11_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem11.LinkClicked
        GetControls.loadmodule(ClosableTabControl1, "Membership", "CFV", "CARD & Finger Verification")
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Dim s As New OtherSettings
        s.ShowDialog()
    End Sub

    Private Sub GetNewLocalDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetNewLocalDBToolStripMenuItem.Click
        BackgroundWorker1.RunWorkerAsync()
        spbUpdate.Visible = True
        slblUpdate.Visible = True
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        slblUpdate.Text = DoSync.syncdata(DB.getlink("GetQuery", AccessHandler.getMacAddress))
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        BackgroundWorker1.RunWorkerAsync()
        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        spbUpdate.Visible = False
        slblUpdate.Visible = False
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Authorization.ShowDialog()
    End Sub
End Class