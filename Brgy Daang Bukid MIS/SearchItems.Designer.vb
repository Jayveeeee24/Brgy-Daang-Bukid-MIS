<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchItems))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchItems = New System.Windows.Forms.Button()
        Me.txtSearchitems = New System.Windows.Forms.TextBox()
        Me.datagridResidentParent = New System.Windows.Forms.Panel()
        Me.datagridItems = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.datagridResidentParent.SuspendLayout()
        CType(Me.datagridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 2
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.btnSearchItems, 1, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.txtSearchitems, 0, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel19.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel19.RowCount = 1
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(946, 43)
        Me.TableLayoutPanel19.TabIndex = 2
        '
        'btnSearchItems
        '
        Me.btnSearchItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchItems.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchItems.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchItems.FlatAppearance.BorderSize = 0
        Me.btnSearchItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchItems.ForeColor = System.Drawing.Color.White
        Me.btnSearchItems.Image = CType(resources.GetObject("btnSearchItems.Image"), System.Drawing.Image)
        Me.btnSearchItems.Location = New System.Drawing.Point(901, 8)
        Me.btnSearchItems.Name = "btnSearchItems"
        Me.btnSearchItems.Size = New System.Drawing.Size(37, 27)
        Me.btnSearchItems.TabIndex = 16
        Me.btnSearchItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchItems.UseVisualStyleBackColor = False
        '
        'txtSearchitems
        '
        Me.txtSearchitems.BackColor = System.Drawing.Color.White
        Me.txtSearchitems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchitems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchitems.ForeColor = System.Drawing.Color.Black
        Me.txtSearchitems.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchitems.MaxLength = 50
        Me.txtSearchitems.Multiline = True
        Me.txtSearchitems.Name = "txtSearchitems"
        Me.txtSearchitems.Size = New System.Drawing.Size(864, 27)
        Me.txtSearchitems.TabIndex = 12
        Me.txtSearchitems.Text = "Search by item name"
        '
        'datagridResidentParent
        '
        Me.datagridResidentParent.Controls.Add(Me.datagridItems)
        Me.datagridResidentParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridResidentParent.Location = New System.Drawing.Point(0, 43)
        Me.datagridResidentParent.Name = "datagridResidentParent"
        Me.datagridResidentParent.Padding = New System.Windows.Forms.Padding(7)
        Me.datagridResidentParent.Size = New System.Drawing.Size(946, 470)
        Me.datagridResidentParent.TabIndex = 15
        '
        'datagridItems
        '
        Me.datagridItems.AllowUserToAddRows = False
        Me.datagridItems.AllowUserToDeleteRows = False
        Me.datagridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridItems.DefaultCellStyle = DataGridViewCellStyle4
        Me.datagridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridItems.Location = New System.Drawing.Point(7, 7)
        Me.datagridItems.Name = "datagridItems"
        Me.datagridItems.ReadOnly = True
        Me.datagridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridItems.Size = New System.Drawing.Size(932, 456)
        Me.datagridItems.TabIndex = 13
        '
        'Column3
        '
        Me.Column3.HeaderText = "Item ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Stock"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item Status"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SearchItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 513)
        Me.Controls.Add(Me.datagridResidentParent)
        Me.Controls.Add(Me.TableLayoutPanel19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Items"
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.datagridResidentParent.ResumeLayout(False)
        CType(Me.datagridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents btnSearchItems As Button
    Friend WithEvents txtSearchitems As TextBox
    Friend WithEvents datagridResidentParent As Panel
    Friend WithEvents datagridItems As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
