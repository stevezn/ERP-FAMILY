<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.mainRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(790, 452)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(790, 452)
        Me.layoutControlGroup1.TextVisible = False
        '
        'mainRibbonControl
        '
        Me.mainRibbonControl.ExpandCollapseItem.Id = 0
        Me.mainRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbonControl.ExpandCollapseItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiDelete, Me.bbiClose})
        Me.mainRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.mainRibbonControl.MaxItemId = 10
        Me.mainRibbonControl.Name = "mainRibbonControl"
        Me.mainRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.mainRibbonPage})
        Me.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mainRibbonControl.Size = New System.Drawing.Size(790, 143)
        Me.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 2
        Me.bbiSave.ImageOptions.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "Save And Close"
        Me.bbiSaveAndClose.Id = 3
        Me.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'bbiSaveAndNew
        '
        Me.bbiSaveAndNew.Caption = "Save And New"
        Me.bbiSaveAndNew.Id = 4
        Me.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew"
        Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "Reset Changes"
        Me.bbiReset.Id = 5
        Me.bbiReset.ImageOptions.ImageUri.Uri = "Reset"
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 6
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Close"
        Me.bbiClose.Id = 7
        Me.bbiClose.ImageOptions.ImageUri.Uri = "Close"
        Me.bbiClose.Name = "bbiClose"
        '
        'mainRibbonPage
        '
        Me.mainRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mainRibbonPageGroup})
        Me.mainRibbonPage.MergeOrder = 0
        Me.mainRibbonPage.Name = "mainRibbonPage"
        Me.mainRibbonPage.Text = "Home"
        '
        'mainRibbonPageGroup
        '
        Me.mainRibbonPageGroup.AllowTextClipping = False
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiSave)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiSaveAndClose)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiSaveAndNew)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiReset)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiDelete)
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.bbiClose)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        Me.mainRibbonPageGroup.Text = "Tasks"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(790, 595)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.Name = "Form1"
        Me.Ribbon = Me.mainRibbonControl
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents mainRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiReset As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
End Class
