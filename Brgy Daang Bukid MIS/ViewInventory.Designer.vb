<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewInventory))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dataGridItemHistory = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelRemarks = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelAddedOn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelAddedBy = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.labelItemStock = New System.Windows.Forms.Label()
        Me.labelItemStatus = New System.Windows.Forms.Label()
        Me.labelItemName = New System.Windows.Forms.Label()
        Me.labelItemId = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModifyItem = New System.Windows.Forms.Button()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.panel123 = New System.Windows.Forms.Panel()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.labelId = New System.Windows.Forms.Label()
        Me.comboItemStatus = New System.Windows.Forms.ComboBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pageInOut = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comboTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtTransactionBy = New System.Windows.Forms.TextBox()
        Me.txtStockItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelItemSerial = New System.Windows.Forms.Label()
        Me.labelItemColor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labelItemBorrowed = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.labeItemUnusable = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboReason = New System.Windows.Forms.ComboBox()
        Me.txtItemColor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemSerial = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dataGridItemHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.pageAddModify.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.panel123.SuspendLayout()
        Me.pageInOut.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageView)
        Me.mainTabControl.Controls.Add(Me.pageAddModify)
        Me.mainTabControl.Controls.Add(Me.pageInOut)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(955, 551)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 4
        '
        'pageView
        '
        Me.pageView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageView.Controls.Add(Me.Panel11)
        Me.pageView.Location = New System.Drawing.Point(4, 22)
        Me.pageView.Margin = New System.Windows.Forms.Padding(0)
        Me.pageView.Name = "pageView"
        Me.pageView.Size = New System.Drawing.Size(947, 525)
        Me.pageView.TabIndex = 2
        Me.pageView.Text = "View"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel11.Size = New System.Drawing.Size(947, 525)
        Me.Panel11.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel12, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.29126!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.708738!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(927, 515)
        Me.TableLayoutPanel5.TabIndex = 39
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.labeItemUnusable)
        Me.Panel12.Controls.Add(Me.Label22)
        Me.Panel12.Controls.Add(Me.labelItemBorrowed)
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.labelItemSerial)
        Me.Panel12.Controls.Add(Me.labelItemColor)
        Me.Panel12.Controls.Add(Me.Label14)
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label13)
        Me.Panel12.Controls.Add(Me.Panel6)
        Me.Panel12.Controls.Add(Me.dataGridItemHistory)
        Me.Panel12.Controls.Add(Me.labelRemarks)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.labelAddedOn)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.labelAddedBy)
        Me.Panel12.Controls.Add(Me.Label29)
        Me.Panel12.Controls.Add(Me.labelItemStock)
        Me.Panel12.Controls.Add(Me.labelItemStatus)
        Me.Panel12.Controls.Add(Me.labelItemName)
        Me.Panel12.Controls.Add(Me.labelItemId)
        Me.Panel12.Controls.Add(Me.Label100)
        Me.Panel12.Controls.Add(Me.Label101)
        Me.Panel12.Controls.Add(Me.Label102)
        Me.Panel12.Controls.Add(Me.Label103)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(921, 459)
        Me.Panel12.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(325, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(260, 18)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "ITEM TRANSACTION HISTORY"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(892, 700)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 35)
        Me.Panel6.TabIndex = 71
        '
        'dataGridItemHistory
        '
        Me.dataGridItemHistory.AllowUserToAddRows = False
        Me.dataGridItemHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridItemHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridItemHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridItemHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridItemHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridItemHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dataGridItemHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridItemHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridItemHistory.DefaultCellStyle = DataGridViewCellStyle16
        Me.dataGridItemHistory.Location = New System.Drawing.Point(26, 343)
        Me.dataGridItemHistory.MultiSelect = False
        Me.dataGridItemHistory.Name = "dataGridItemHistory"
        Me.dataGridItemHistory.ReadOnly = True
        Me.dataGridItemHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridItemHistory.Size = New System.Drawing.Size(859, 306)
        Me.dataGridItemHistory.TabIndex = 70
        '
        'Column14
        '
        Me.Column14.HeaderText = "ID"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        Me.Column1.HeaderText = "Transaction"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = "Transact by"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Reason"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'labelRemarks
        '
        Me.labelRemarks.AutoSize = True
        Me.labelRemarks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRemarks.Location = New System.Drawing.Point(700, 235)
        Me.labelRemarks.Name = "labelRemarks"
        Me.labelRemarks.Size = New System.Drawing.Size(25, 18)
        Me.labelRemarks.TabIndex = 69
        Me.labelRemarks.Text = "Jr."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Remarks: "
        '
        'labelAddedOn
        '
        Me.labelAddedOn.AutoSize = True
        Me.labelAddedOn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAddedOn.Location = New System.Drawing.Point(231, 235)
        Me.labelAddedOn.Name = "labelAddedOn"
        Me.labelAddedOn.Size = New System.Drawing.Size(25, 18)
        Me.labelAddedOn.TabIndex = 67
        Me.labelAddedOn.Text = "Jr."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Added on: "
        '
        'labelAddedBy
        '
        Me.labelAddedBy.AutoSize = True
        Me.labelAddedBy.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelAddedBy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAddedBy.Location = New System.Drawing.Point(231, 197)
        Me.labelAddedBy.Name = "labelAddedBy"
        Me.labelAddedBy.Size = New System.Drawing.Size(25, 18)
        Me.labelAddedBy.TabIndex = 65
        Me.labelAddedBy.Text = "Jr."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(60, 197)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 18)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "Added by: "
        '
        'labelItemStock
        '
        Me.labelItemStock.AutoSize = True
        Me.labelItemStock.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelItemStock.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemStock.Location = New System.Drawing.Point(700, 125)
        Me.labelItemStock.Name = "labelItemStock"
        Me.labelItemStock.Size = New System.Drawing.Size(25, 18)
        Me.labelItemStock.TabIndex = 43
        Me.labelItemStock.Text = "Jr."
        '
        'labelItemStatus
        '
        Me.labelItemStatus.AutoSize = True
        Me.labelItemStatus.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelItemStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemStatus.Location = New System.Drawing.Point(700, 90)
        Me.labelItemStatus.Name = "labelItemStatus"
        Me.labelItemStatus.Size = New System.Drawing.Size(137, 18)
        Me.labelItemStatus.TabIndex = 42
        Me.labelItemStatus.Text = "Kamusta ka na "
        '
        'labelItemName
        '
        Me.labelItemName.AutoSize = True
        Me.labelItemName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemName.Location = New System.Drawing.Point(231, 90)
        Me.labelItemName.Name = "labelItemName"
        Me.labelItemName.Size = New System.Drawing.Size(116, 18)
        Me.labelItemName.TabIndex = 41
        Me.labelItemName.Text = "KOMPLAINT"
        '
        'labelItemId
        '
        Me.labelItemId.AutoSize = True
        Me.labelItemId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemId.Location = New System.Drawing.Point(231, 42)
        Me.labelItemId.Name = "labelItemId"
        Me.labelItemId.Size = New System.Drawing.Size(54, 18)
        Me.labelItemId.TabIndex = 40
        Me.labelItemId.Text = "Jopay"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(529, 125)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(130, 18)
        Me.Label100.TabIndex = 39
        Me.Label100.Text = "Item in Stock: "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(529, 90)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(119, 18)
        Me.Label101.TabIndex = 38
        Me.Label101.Text = "Item Status: "
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(60, 90)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(113, 18)
        Me.Label102.TabIndex = 37
        Me.Label102.Text = "Item Name: "
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(60, 42)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(85, 18)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Item ID: "
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.95222!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13789!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnModifyItem, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 468)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(921, 44)
        Me.TableLayoutPanel6.TabIndex = 37
        '
        'btnModifyItem
        '
        Me.btnModifyItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModifyItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnModifyItem.FlatAppearance.BorderSize = 0
        Me.btnModifyItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyItem.ForeColor = System.Drawing.Color.White
        Me.btnModifyItem.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnModifyItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyItem.Location = New System.Drawing.Point(799, 0)
        Me.btnModifyItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModifyItem.Name = "btnModifyItem"
        Me.btnModifyItem.Size = New System.Drawing.Size(122, 44)
        Me.btnModifyItem.TabIndex = 34
        Me.btnModifyItem.TabStop = False
        Me.btnModifyItem.Text = "  Modify Item"
        Me.btnModifyItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyItem.UseVisualStyleBackColor = False
        '
        'pageAddModify
        '
        Me.pageAddModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageAddModify.Controls.Add(Me.Panel5)
        Me.pageAddModify.Location = New System.Drawing.Point(4, 22)
        Me.pageAddModify.Margin = New System.Windows.Forms.Padding(0)
        Me.pageAddModify.Name = "pageAddModify"
        Me.pageAddModify.Size = New System.Drawing.Size(947, 525)
        Me.pageAddModify.TabIndex = 1
        Me.pageAddModify.Text = "Modify"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel5.Size = New System.Drawing.Size(947, 525)
        Me.Panel5.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.panel123, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48544!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.514564!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(927, 515)
        Me.TableLayoutPanel3.TabIndex = 39
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.31813!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.70358!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveItem, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 469)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(921, 43)
        Me.TableLayoutPanel4.TabIndex = 37
        '
        'btnSaveItem
        '
        Me.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveItem.FlatAppearance.BorderSize = 0
        Me.btnSaveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveItem.ForeColor = System.Drawing.Color.White
        Me.btnSaveItem.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveItem.Location = New System.Drawing.Point(803, 0)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(118, 43)
        Me.btnSaveItem.TabIndex = 34
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "  Save Item"
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = False
        '
        'panel123
        '
        Me.panel123.AutoScroll = True
        Me.panel123.BackColor = System.Drawing.Color.White
        Me.panel123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel123.Controls.Add(Me.txtItemSerial)
        Me.panel123.Controls.Add(Me.Label15)
        Me.panel123.Controls.Add(Me.txtItemColor)
        Me.panel123.Controls.Add(Me.Label8)
        Me.panel123.Controls.Add(Me.comboReason)
        Me.panel123.Controls.Add(Me.Label4)
        Me.panel123.Controls.Add(Me.txtItemId)
        Me.panel123.Controls.Add(Me.labelId)
        Me.panel123.Controls.Add(Me.comboItemStatus)
        Me.panel123.Controls.Add(Me.txtRemarks)
        Me.panel123.Controls.Add(Me.txtItemName)
        Me.panel123.Controls.Add(Me.Label32)
        Me.panel123.Controls.Add(Me.Label18)
        Me.panel123.Controls.Add(Me.Label20)
        Me.panel123.Controls.Add(Me.Label7)
        Me.panel123.Controls.Add(Me.Panel1)
        Me.panel123.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel123.Location = New System.Drawing.Point(3, 3)
        Me.panel123.Name = "panel123"
        Me.panel123.Size = New System.Drawing.Size(921, 460)
        Me.panel123.TabIndex = 38
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.White
        Me.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.ForeColor = System.Drawing.Color.Black
        Me.txtItemId.Location = New System.Drawing.Point(366, 68)
        Me.txtItemId.MaxLength = 100
        Me.txtItemId.Multiline = True
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(303, 27)
        Me.txtItemId.TabIndex = 1
        Me.txtItemId.Tag = ""
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(131, 73)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(96, 18)
        Me.labelId.TabIndex = 136
        Me.labelId.Text = "Item ID*: "
        '
        'comboItemStatus
        '
        Me.comboItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboItemStatus.FormattingEnabled = True
        Me.comboItemStatus.Items.AddRange(New Object() {"Unavailable", "Available"})
        Me.comboItemStatus.Location = New System.Drawing.Point(366, 224)
        Me.comboItemStatus.Name = "comboItemStatus"
        Me.comboItemStatus.Size = New System.Drawing.Size(303, 28)
        Me.comboItemStatus.TabIndex = 5
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(366, 304)
        Me.txtRemarks.MaxLength = 150
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(303, 111)
        Me.txtRemarks.TabIndex = 10
        Me.txtRemarks.Tag = ""
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.White
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.Location = New System.Drawing.Point(366, 108)
        Me.txtItemName.MaxLength = 100
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(303, 27)
        Me.txtItemName.TabIndex = 2
        Me.txtItemName.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(131, 307)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(93, 18)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Remarks: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(131, 231)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 18)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Item Status*: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(131, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 18)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Item Name*: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(706, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Note: * Required "
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(860, 365)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 74)
        Me.Panel1.TabIndex = 68
        '
        'pageInOut
        '
        Me.pageInOut.BackColor = System.Drawing.SystemColors.Control
        Me.pageInOut.Controls.Add(Me.TableLayoutPanel1)
        Me.pageInOut.ForeColor = System.Drawing.Color.Black
        Me.pageInOut.Location = New System.Drawing.Point(4, 22)
        Me.pageInOut.Margin = New System.Windows.Forms.Padding(5)
        Me.pageInOut.Name = "pageInOut"
        Me.pageInOut.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pageInOut.Size = New System.Drawing.Size(947, 525)
        Me.pageInOut.TabIndex = 3
        Me.pageInOut.Text = "InOut"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.487085!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.36531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1476!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(927, 515)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.14658!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.87514!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnUpdateStock, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 465)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(921, 47)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdateStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdateStock.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateStock.FlatAppearance.BorderSize = 0
        Me.btnUpdateStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnUpdateStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStock.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStock.Location = New System.Drawing.Point(783, 10)
        Me.btnUpdateStock.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(138, 37)
        Me.btnUpdateStock.TabIndex = 34
        Me.btnUpdateStock.TabStop = False
        Me.btnUpdateStock.Text = "  Update Stock"
        Me.btnUpdateStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 37)
        Me.Panel2.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(921, 37)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "STOCK INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnSearchItem)
        Me.Panel3.Controls.Add(Me.txtQuantity)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.comboTransactionType)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtReason)
        Me.Panel3.Controls.Add(Me.txtTransactionBy)
        Me.Panel3.Controls.Add(Me.txtStockItemName)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(921, 413)
        Me.Panel3.TabIndex = 38
        '
        'btnSearchItem
        '
        Me.btnSearchItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchItem.ForeColor = System.Drawing.Color.White
        Me.btnSearchItem.Image = CType(resources.GetObject("btnSearchItem.Image"), System.Drawing.Image)
        Me.btnSearchItem.Location = New System.Drawing.Point(639, 82)
        Me.btnSearchItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchItem.TabIndex = 142
        Me.btnSearchItem.TabStop = False
        Me.btnSearchItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchItem.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(319, 169)
        Me.txtQuantity.MaxLength = 100
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(303, 27)
        Me.txtQuantity.TabIndex = 139
        Me.txtQuantity.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(113, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Quantity*: "
        '
        'comboTransactionType
        '
        Me.comboTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTransactionType.FormattingEnabled = True
        Me.comboTransactionType.Items.AddRange(New Object() {"Stock In", "Stock Out"})
        Me.comboTransactionType.Location = New System.Drawing.Point(319, 125)
        Me.comboTransactionType.Name = "comboTransactionType"
        Me.comboTransactionType.Size = New System.Drawing.Size(303, 28)
        Me.comboTransactionType.TabIndex = 137
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(113, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 18)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Transaction type*: "
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.Location = New System.Drawing.Point(319, 260)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(303, 88)
        Me.txtReason.TabIndex = 119
        Me.txtReason.Tag = ""
        '
        'txtTransactionBy
        '
        Me.txtTransactionBy.BackColor = System.Drawing.Color.White
        Me.txtTransactionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransactionBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionBy.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionBy.Location = New System.Drawing.Point(319, 213)
        Me.txtTransactionBy.MaxLength = 100
        Me.txtTransactionBy.Multiline = True
        Me.txtTransactionBy.Name = "txtTransactionBy"
        Me.txtTransactionBy.Size = New System.Drawing.Size(303, 27)
        Me.txtTransactionBy.TabIndex = 118
        Me.txtTransactionBy.Tag = ""
        '
        'txtStockItemName
        '
        Me.txtStockItemName.BackColor = System.Drawing.Color.White
        Me.txtStockItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockItemName.ForeColor = System.Drawing.Color.Black
        Me.txtStockItemName.Location = New System.Drawing.Point(319, 82)
        Me.txtStockItemName.MaxLength = 100
        Me.txtStockItemName.Multiline = True
        Me.txtStockItemName.Name = "txtStockItemName"
        Me.txtStockItemName.Size = New System.Drawing.Size(303, 27)
        Me.txtStockItemName.TabIndex = 116
        Me.txtStockItemName.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Reason: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 18)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Transaction by: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(113, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Item Name*: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(689, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 18)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Note: * Required "
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(631, 420)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 74)
        Me.Panel4.TabIndex = 68
        '
        'labelItemSerial
        '
        Me.labelItemSerial.AutoSize = True
        Me.labelItemSerial.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelItemSerial.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemSerial.Location = New System.Drawing.Point(231, 159)
        Me.labelItemSerial.Name = "labelItemSerial"
        Me.labelItemSerial.Size = New System.Drawing.Size(25, 18)
        Me.labelItemSerial.TabIndex = 119
        Me.labelItemSerial.Text = "Jr."
        '
        'labelItemColor
        '
        Me.labelItemColor.AutoSize = True
        Me.labelItemColor.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelItemColor.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemColor.Location = New System.Drawing.Point(231, 125)
        Me.labelItemColor.Name = "labelItemColor"
        Me.labelItemColor.Size = New System.Drawing.Size(137, 18)
        Me.labelItemColor.TabIndex = 118
        Me.labelItemColor.Text = "Kamusta ka na "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(60, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 18)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "Serial Number: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(60, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 18)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Item Color: "
        '
        'labelItemBorrowed
        '
        Me.labelItemBorrowed.AutoSize = True
        Me.labelItemBorrowed.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labelItemBorrowed.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemBorrowed.Location = New System.Drawing.Point(700, 160)
        Me.labelItemBorrowed.Name = "labelItemBorrowed"
        Me.labelItemBorrowed.Size = New System.Drawing.Size(18, 18)
        Me.labelItemBorrowed.TabIndex = 121
        Me.labelItemBorrowed.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(529, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 18)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Borrowed: "
        '
        'labeItemUnusable
        '
        Me.labeItemUnusable.AutoSize = True
        Me.labeItemUnusable.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.labeItemUnusable.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeItemUnusable.Location = New System.Drawing.Point(700, 197)
        Me.labeItemUnusable.Name = "labeItemUnusable"
        Me.labeItemUnusable.Size = New System.Drawing.Size(18, 18)
        Me.labeItemUnusable.TabIndex = 123
        Me.labeItemUnusable.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(529, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 18)
        Me.Label22.TabIndex = 122
        Me.Label22.Text = "Unusable: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Reason*: "
        '
        'comboReason
        '
        Me.comboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboReason.Enabled = False
        Me.comboReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboReason.FormattingEnabled = True
        Me.comboReason.Items.AddRange(New Object() {"Defective", "Damaged", "Lost", "Replaced"})
        Me.comboReason.Location = New System.Drawing.Point(366, 264)
        Me.comboReason.Name = "comboReason"
        Me.comboReason.Size = New System.Drawing.Size(303, 28)
        Me.comboReason.TabIndex = 7
        '
        'txtItemColor
        '
        Me.txtItemColor.BackColor = System.Drawing.Color.White
        Me.txtItemColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemColor.ForeColor = System.Drawing.Color.Black
        Me.txtItemColor.Location = New System.Drawing.Point(366, 147)
        Me.txtItemColor.MaxLength = 100
        Me.txtItemColor.Multiline = True
        Me.txtItemColor.Name = "txtItemColor"
        Me.txtItemColor.Size = New System.Drawing.Size(303, 27)
        Me.txtItemColor.TabIndex = 3
        Me.txtItemColor.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(131, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Item Color: "
        '
        'txtItemSerial
        '
        Me.txtItemSerial.BackColor = System.Drawing.Color.White
        Me.txtItemSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSerial.ForeColor = System.Drawing.Color.Black
        Me.txtItemSerial.Location = New System.Drawing.Point(366, 186)
        Me.txtItemSerial.MaxLength = 100
        Me.txtItemSerial.Multiline = True
        Me.txtItemSerial.Name = "txtItemSerial"
        Me.txtItemSerial.Size = New System.Drawing.Size(303, 27)
        Me.txtItemSerial.TabIndex = 4
        Me.txtItemSerial.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(131, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 18)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Item Serial: "
        '
        'ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageView.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.dataGridItemHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.pageAddModify.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.panel123.ResumeLayout(False)
        Me.panel123.PerformLayout()
        Me.pageInOut.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labelRemarks As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelAddedOn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelAddedBy As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents labelItemStock As Label
    Friend WithEvents labelItemStatus As Label
    Friend WithEvents labelItemName As Label
    Friend WithEvents labelItemId As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnModifyItem As Button
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveItem As Button
    Friend WithEvents panel123 As Panel
    Friend WithEvents comboItemStatus As ComboBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pageInOut As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents comboTransactionType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtTransactionBy As TextBox
    Friend WithEvents txtStockItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSearchItem As Button
    Friend WithEvents dataGridItemHistory As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents labelId As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents labeItemUnusable As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents labelItemBorrowed As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents labelItemSerial As Label
    Friend WithEvents labelItemColor As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtItemSerial As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtItemColor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents comboReason As ComboBox
    Friend WithEvents Label4 As Label
End Class
