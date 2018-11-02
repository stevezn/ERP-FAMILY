<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesOrder))
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbTotalAmt = New System.Windows.Forms.Label()
        Me.lbTotalWithTax = New System.Windows.Forms.Label()
        Me.lbTotalAfterTax = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(126, 135)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(208, 20)
        Me.TextBox5.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Others :"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(126, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(208, 20)
        Me.TextBox4.TabIndex = 201
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(126, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 20)
        Me.TextBox3.TabIndex = 200
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(126, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 199
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(126, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(208, 20)
        Me.TextBox2.TabIndex = 198
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 18)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Member ID :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 18)
        Me.Label12.TabIndex = 196
        Me.Label12.Text = "Phone No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "ID Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "Full Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 192
        Me.Label2.Text = "Select Member :"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LookUpEdit1.EditValue = ""
        Me.LookUpEdit1.Location = New System.Drawing.Point(127, 5)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LookUpEdit1.Size = New System.Drawing.Size(773, 20)
        Me.LookUpEdit1.TabIndex = 191
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LookUpEdit1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbTotalAmt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbTotalWithTax)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbTotalAfterTax)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbTotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 489)
        Me.SplitContainer1.SplitterDistance = 164
        Me.SplitContainer1.TabIndex = 174
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(778, 295)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 23)
        Me.SimpleButton1.TabIndex = 218
        Me.SimpleButton1.Text = "Go To Payment -->"
        '
        'lbTotalAmt
        '
        Me.lbTotalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalAmt.Location = New System.Drawing.Point(776, 261)
        Me.lbTotalAmt.Name = "lbTotalAmt"
        Me.lbTotalAmt.Size = New System.Drawing.Size(119, 14)
        Me.lbTotalAmt.TabIndex = 217
        Me.lbTotalAmt.Text = "0"
        Me.lbTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalWithTax
        '
        Me.lbTotalWithTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotalWithTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalWithTax.Location = New System.Drawing.Point(776, 277)
        Me.lbTotalWithTax.Name = "lbTotalWithTax"
        Me.lbTotalWithTax.Size = New System.Drawing.Size(119, 14)
        Me.lbTotalWithTax.TabIndex = 216
        Me.lbTotalWithTax.Text = "0"
        Me.lbTotalWithTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalAfterTax
        '
        Me.lbTotalAfterTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotalAfterTax.AutoSize = True
        Me.lbTotalAfterTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalAfterTax.Location = New System.Drawing.Point(638, 277)
        Me.lbTotalAfterTax.Name = "lbTotalAfterTax"
        Me.lbTotalAfterTax.Size = New System.Drawing.Size(109, 16)
        Me.lbTotalAfterTax.TabIndex = 215
        Me.lbTotalAfterTax.Text = "Total after Tax"
        '
        'lbTotal
        '
        Me.lbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(701, 260)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(44, 16)
        Me.lbTotal.TabIndex = 214
        Me.lbTotal.Text = "Total"
        '
        'gridControl
        '
        Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl.Location = New System.Drawing.Point(0, 0)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(903, 257)
        Me.gridControl.TabIndex = 146
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(655, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 18)
        Me.Label16.TabIndex = 173
        Me.Label16.Text = "ID Card"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Teal
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 13)
        Me.LinkLabel1.TabIndex = 152
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.CornflowerBlue
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(226, 39)
        Me.LabelControl2.TabIndex = 175
        Me.LabelControl2.Text = "*Sales Orders"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 23)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(903, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 172
        Me.PictureBox1.TabStop = False
        '
        'SalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SalesOrder"
        Me.Size = New System.Drawing.Size(903, 576)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents LinkLabel1 As Windows.Forms.LinkLabel
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lbTotalAmt As Windows.Forms.Label
    Friend WithEvents lbTotalWithTax As Windows.Forms.Label
    Friend WithEvents lbTotalAfterTax As Windows.Forms.Label
    Friend WithEvents lbTotal As Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
