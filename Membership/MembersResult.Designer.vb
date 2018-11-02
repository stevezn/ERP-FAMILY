<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MembersResult))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.LightBlue
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 87)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridControl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox3)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 363)
        Me.SplitContainer1.SplitterDistance = 245
        Me.SplitContainer1.TabIndex = 169
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(800, 363)
        Me.gridControl.TabIndex = 145
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
        Me.gridView.OptionsFind.AlwaysVisible = True
        Me.gridView.OptionsView.ColumnAutoWidth = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.PaintStyleName = "Flat"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"KTP", "SIM", "Passport", "Student Card"})
        Me.ComboBox3.Location = New System.Drawing.Point(-6, 295)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(0, 21)
        Me.ComboBox3.TabIndex = 144
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(655, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 18)
        Me.Label16.TabIndex = 168
        Me.Label16.Text = "ID Card"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Teal
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabel1.TabIndex = 152
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modify"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 23)
        Me.GroupBox2.TabIndex = 164
        Me.GroupBox2.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(55, 4)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel2.TabIndex = 153
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Void Item"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.CornflowerBlue
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(417, 39)
        Me.LabelControl2.TabIndex = 170
        Me.LabelControl2.Text = "*Members Search Results"
        '
        'MembersResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MembersResult"
        Me.Text = "Member Result"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents ComboBox3 As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents LinkLabel1 As Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LinkLabel2 As Windows.Forms.LinkLabel
End Class
