<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnItem))
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.datagridBorrowed = New System.Windows.Forms.DataGridView()
        Me.labelTotalBorrowed = New System.Windows.Forms.Label()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchBorrowedItem = New System.Windows.Forms.Button()
        Me.txtSearchBorrowedItems = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReturnItem = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.datagridBorrowed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.Panel22, 0, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel16, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel17, 0, 1)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 3
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(1029, 551)
        Me.TableLayoutPanel15.TabIndex = 2
        '
        'Panel22
        '
        Me.Panel22.AutoScroll = True
        Me.Panel22.Controls.Add(Me.datagridBorrowed)
        Me.Panel22.Controls.Add(Me.labelTotalBorrowed)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(4, 88)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Panel22.Size = New System.Drawing.Size(1021, 459)
        Me.Panel22.TabIndex = 14
        '
        'datagridBorrowed
        '
        Me.datagridBorrowed.AllowUserToAddRows = False
        Me.datagridBorrowed.AllowUserToDeleteRows = False
        Me.datagridBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridBorrowed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridBorrowed.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridBorrowed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridBorrowed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridBorrowed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.Column3, Me.DataGridViewTextBoxColumn8, Me.Column2, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Column8, Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridBorrowed.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridBorrowed.Dock = System.Windows.Forms.DockStyle.Top
        Me.datagridBorrowed.Location = New System.Drawing.Point(7, 34)
        Me.datagridBorrowed.Name = "datagridBorrowed"
        Me.datagridBorrowed.ReadOnly = True
        Me.datagridBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridBorrowed.Size = New System.Drawing.Size(1007, 422)
        Me.datagridBorrowed.TabIndex = 13
        '
        'labelTotalBorrowed
        '
        Me.labelTotalBorrowed.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelTotalBorrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalBorrowed.ForeColor = System.Drawing.Color.Black
        Me.labelTotalBorrowed.Location = New System.Drawing.Point(7, 0)
        Me.labelTotalBorrowed.Name = "labelTotalBorrowed"
        Me.labelTotalBorrowed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.labelTotalBorrowed.Size = New System.Drawing.Size(1007, 34)
        Me.labelTotalBorrowed.TabIndex = 14
        Me.labelTotalBorrowed.Text = "Total Complaints: "
        Me.labelTotalBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 2
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.btnSearchBorrowedItem, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.txtSearchBorrowedItems, 0, 0)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel16.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel16.RowCount = 1
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(1027, 41)
        Me.TableLayoutPanel16.TabIndex = 0
        '
        'btnSearchBorrowedItem
        '
        Me.btnSearchBorrowedItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchBorrowedItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchBorrowedItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchBorrowedItem.FlatAppearance.BorderSize = 0
        Me.btnSearchBorrowedItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchBorrowedItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchBorrowedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBorrowedItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrowedItem.ForeColor = System.Drawing.Color.White
        Me.btnSearchBorrowedItem.Image = CType(resources.GetObject("btnSearchBorrowedItem.Image"), System.Drawing.Image)
        Me.btnSearchBorrowedItem.Location = New System.Drawing.Point(969, 8)
        Me.btnSearchBorrowedItem.Name = "btnSearchBorrowedItem"
        Me.btnSearchBorrowedItem.Size = New System.Drawing.Size(50, 25)
        Me.btnSearchBorrowedItem.TabIndex = 16
        Me.btnSearchBorrowedItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchBorrowedItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchBorrowedItem.UseVisualStyleBackColor = False
        '
        'txtSearchBorrowedItems
        '
        Me.txtSearchBorrowedItems.BackColor = System.Drawing.Color.White
        Me.txtSearchBorrowedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBorrowedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchBorrowedItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBorrowedItems.ForeColor = System.Drawing.Color.Black
        Me.txtSearchBorrowedItems.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchBorrowedItems.MaxLength = 50
        Me.txtSearchBorrowedItems.Multiline = True
        Me.txtSearchBorrowedItems.Name = "txtSearchBorrowedItems"
        Me.txtSearchBorrowedItems.Size = New System.Drawing.Size(939, 25)
        Me.txtSearchBorrowedItems.TabIndex = 12
        Me.txtSearchBorrowedItems.Text = "Search by item name or borrower"
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 5
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4334!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24947!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.28893!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.48405!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.35201!))
        Me.TableLayoutPanel17.Controls.Add(Me.btnReturnItem, 0, 0)
        Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(1, 43)
        Me.TableLayoutPanel17.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.Padding = New System.Windows.Forms.Padding(2, 2, 5, 2)
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(1027, 41)
        Me.TableLayoutPanel17.TabIndex = 1
        '
        'btnReturnItem
        '
        Me.btnReturnItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnReturnItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReturnItem.Enabled = False
        Me.btnReturnItem.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnReturnItem.FlatAppearance.BorderSize = 0
        Me.btnReturnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnReturnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnReturnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnItem.ForeColor = System.Drawing.Color.White
        Me.btnReturnItem.Image = CType(resources.GetObject("btnReturnItem.Image"), System.Drawing.Image)
        Me.btnReturnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnItem.Location = New System.Drawing.Point(9, 5)
        Me.btnReturnItem.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnReturnItem.Name = "btnReturnItem"
        Me.btnReturnItem.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnReturnItem.Size = New System.Drawing.Size(145, 31)
        Me.btnReturnItem.TabIndex = 9
        Me.btnReturnItem.TabStop = False
        Me.btnReturnItem.Text = "  Return Item"
        Me.btnReturnItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReturnItem.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Item ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Borrowed Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Return Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Borrowed By"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reason"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ReturnItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 551)
        Me.Controls.Add(Me.TableLayoutPanel15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReturnItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Borrowed Items"
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        CType(Me.datagridBorrowed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents datagridBorrowed As DataGridView
    Friend WithEvents labelTotalBorrowed As Label
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents btnSearchBorrowedItem As Button
    Friend WithEvents txtSearchBorrowedItems As TextBox
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents btnReturnItem As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
