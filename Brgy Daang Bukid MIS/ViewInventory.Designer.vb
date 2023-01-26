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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewInventory))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.labeItemUnusable = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.labelItemBorrowed = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.labelItemSerial = New System.Windows.Forms.Label()
        Me.labelItemColor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dataGridItemHistory = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dataGridItemHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageView)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(955, 607)
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
        Me.pageView.Size = New System.Drawing.Size(947, 581)
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
        Me.Panel11.Size = New System.Drawing.Size(947, 581)
        Me.Panel11.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel12, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 515.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(927, 571)
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
        Me.Panel12.Size = New System.Drawing.Size(921, 565)
        Me.Panel12.TabIndex = 38
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
        Me.Panel6.Location = New System.Drawing.Point(891, 679)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridItemHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridItemHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridItemHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridItemHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridItemHistory.Location = New System.Drawing.Point(26, 343)
        Me.dataGridItemHistory.MultiSelect = False
        Me.dataGridItemHistory.Name = "dataGridItemHistory"
        Me.dataGridItemHistory.ReadOnly = True
        Me.dataGridItemHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridItemHistory.Size = New System.Drawing.Size(859, 362)
        Me.dataGridItemHistory.TabIndex = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Item Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Transaction"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = "Transact by"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Description: "
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
        'ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 607)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labeItemUnusable As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents labelItemBorrowed As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents labelItemSerial As Label
    Friend WithEvents labelItemColor As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dataGridItemHistory As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
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
End Class
