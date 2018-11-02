<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class MemberList
    Inherits DevExpress.XtraEditors.XtraUserControl
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemberList))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.txtPageSize = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisplayPageNo = New DevExpress.XtraEditors.LabelControl()
        Me.BtnNextPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPreviousPage = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFirstPage = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.ribbonControl
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(890, 459)
        Me.gridControl.TabIndex = 2
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.gridView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gridView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gridView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gridView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gridView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gridView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gridView.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.gridView.Appearance.Empty.Options.UseBackColor = True
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Appearance.EvenRow.Options.UseBorderColor = True
        Me.gridView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gridView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.gridView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gridView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gridView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gridView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.gridView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gridView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gridView.Appearance.FixedLine.Options.UseBackColor = True
        Me.gridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.gridView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gridView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridView.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gridView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gridView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gridView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gridView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gridView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gridView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gridView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.gridView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gridView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gridView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gridView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gridView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.gridView.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gridView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gridView.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gridView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.HorzLine.Options.UseBackColor = True
        Me.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView.Appearance.OddRow.Options.UseBorderColor = True
        Me.gridView.Appearance.OddRow.Options.UseForeColor = True
        Me.gridView.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.gridView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gridView.Appearance.Preview.Options.UseFont = True
        Me.gridView.Appearance.Preview.Options.UseForeColor = True
        Me.gridView.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gridView.Appearance.Row.Options.UseBackColor = True
        Me.gridView.Appearance.Row.Options.UseForeColor = True
        Me.gridView.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.gridView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gridView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gridView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gridView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gridView.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.gridView.Appearance.TopNewRow.Options.UseBackColor = True
        Me.gridView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gridView.Appearance.VertLine.Options.UseBackColor = True
        Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsView.ColumnAutoWidth = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.PaintStyleName = "Flat"
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.bbiPrintPreview, Me.bsiRecordsCount, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh, Me.BarHeaderItem1})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 21
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(890, 103)
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiPrintPreview
        '
        Me.bbiPrintPreview.Caption = "Print Preview"
        Me.bbiPrintPreview.Id = 14
        Me.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview"
        Me.bbiPrintPreview.Name = "bbiPrintPreview"
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "RECORDS : 0"
        Me.bsiRecordsCount.Id = 15
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "New"
        Me.bbiNew.Id = 16
        Me.bbiNew.ImageOptions.ImageUri.Uri = "New"
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Edit"
        Me.bbiEdit.Id = 17
        Me.bbiEdit.ImageOptions.ImageUri.Uri = "Edit"
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 18
        Me.bbiDelete.ImageOptions.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 19
        Me.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh"
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 20
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Home"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        Me.ribbonPageGroup1.Text = "Tasks"
        '
        'ribbonPageGroup2
        '
        Me.ribbonPageGroup2.AllowTextClipping = False
        Me.ribbonPageGroup2.ItemLinks.Add(Me.bbiPrintPreview)
        Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
        Me.ribbonPageGroup2.ShowCaptionButton = False
        Me.ribbonPageGroup2.Text = "Print and Export"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.InsertGalleryImage("boperson_16x16.png", "images/business%20objects/boperson_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/boperson_16x16.png"), 0)
        Me.ImageCollection1.Images.SetKeyName(0, "boperson_16x16.png")
        '
        'txtPageSize
        '
        Me.txtPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPageSize.EditValue = "5"
        Me.txtPageSize.Location = New System.Drawing.Point(570, 9)
        Me.txtPageSize.Name = "txtPageSize"
        Me.txtPageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPageSize.Properties.Items.AddRange(New Object() {"5", "10", "25", "50", "100", "1000"})
        Me.txtPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPageSize.Size = New System.Drawing.Size(48, 20)
        Me.txtPageSize.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(516, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Page Size:"
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(755, 11)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(29, 13)
        Me.txtDisplayPageNo.TabIndex = 9
        Me.txtDisplayPageNo.Text = "Pages"
        '
        'BtnNextPage
        '
        Me.BtnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNextPage.Location = New System.Drawing.Point(822, 6)
        Me.BtnNextPage.Name = "BtnNextPage"
        Me.BtnNextPage.Size = New System.Drawing.Size(59, 23)
        Me.BtnNextPage.TabIndex = 4
        Me.BtnNextPage.Text = "Next"
        '
        'BtnPreviousPage
        '
        Me.BtnPreviousPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreviousPage.Location = New System.Drawing.Point(671, 6)
        Me.BtnPreviousPage.Name = "BtnPreviousPage"
        Me.BtnPreviousPage.Size = New System.Drawing.Size(59, 23)
        Me.BtnPreviousPage.TabIndex = 5
        Me.BtnPreviousPage.Text = "Previous"
        '
        'BtnFirstPage
        '
        Me.BtnFirstPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFirstPage.Location = New System.Drawing.Point(624, 6)
        Me.BtnFirstPage.Name = "BtnFirstPage"
        Me.BtnFirstPage.Size = New System.Drawing.Size(41, 23)
        Me.BtnFirstPage.TabIndex = 7
        Me.BtnFirstPage.Text = "First"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(102, 23)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Advanced Filter"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 103)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPageSize)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnNextPage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDisplayPageNo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnPreviousPage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnFirstPage)
        Me.SplitContainer1.Size = New System.Drawing.Size(890, 497)
        Me.SplitContainer1.SplitterDistance = 459
        Me.SplitContainer1.TabIndex = 13
        '
        'MemberList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "MemberList"
        Me.Size = New System.Drawing.Size(890, 600)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Private WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPageSize As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisplayPageNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnNextPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPreviousPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirstPage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
End Class
