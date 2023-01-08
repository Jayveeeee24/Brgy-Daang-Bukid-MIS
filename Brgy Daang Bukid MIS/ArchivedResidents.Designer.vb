<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchivedResidents
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArchivedResidents))
        Me.datagridResidentParent = New System.Windows.Forms.Panel()
        Me.datagridResident = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearchResident = New System.Windows.Forms.Button()
        Me.txtSearchResident = New System.Windows.Forms.TextBox()
        Me.searchResidentParent = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridResidentParent.SuspendLayout()
        CType(Me.datagridResident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.searchResidentParent.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagridResidentParent
        '
        Me.datagridResidentParent.Controls.Add(Me.datagridResident)
        Me.datagridResidentParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridResidentParent.Location = New System.Drawing.Point(5, 50)
        Me.datagridResidentParent.Name = "datagridResidentParent"
        Me.datagridResidentParent.Padding = New System.Windows.Forms.Padding(7, 7, 7, 0)
        Me.datagridResidentParent.Size = New System.Drawing.Size(1083, 588)
        Me.datagridResidentParent.TabIndex = 14
        '
        'datagridResident
        '
        Me.datagridResident.AllowUserToAddRows = False
        Me.datagridResident.AllowUserToDeleteRows = False
        Me.datagridResident.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridResident.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridResident.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridResident.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridResident.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridResident.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridResident.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridResident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridResident.Location = New System.Drawing.Point(7, 7)
        Me.datagridResident.Name = "datagridResident"
        Me.datagridResident.ReadOnly = True
        Me.datagridResident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridResident.Size = New System.Drawing.Size(1069, 581)
        Me.datagridResident.TabIndex = 13
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID Number"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'btnSearchResident
        '
        Me.btnSearchResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchResident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearchResident.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchResident.FlatAppearance.BorderSize = 0
        Me.btnSearchResident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchResident.ForeColor = System.Drawing.Color.White
        Me.btnSearchResident.Image = CType(resources.GetObject("btnSearchResident.Image"), System.Drawing.Image)
        Me.btnSearchResident.Location = New System.Drawing.Point(1015, 8)
        Me.btnSearchResident.Name = "btnSearchResident"
        Me.btnSearchResident.Size = New System.Drawing.Size(60, 29)
        Me.btnSearchResident.TabIndex = 9
        Me.btnSearchResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchResident.UseVisualStyleBackColor = False
        '
        'txtSearchResident
        '
        Me.txtSearchResident.BackColor = System.Drawing.Color.White
        Me.txtSearchResident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchResident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResident.ForeColor = System.Drawing.Color.Black
        Me.txtSearchResident.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchResident.MaxLength = 50
        Me.txtSearchResident.Multiline = True
        Me.txtSearchResident.Name = "txtSearchResident"
        Me.txtSearchResident.Size = New System.Drawing.Size(1001, 29)
        Me.txtSearchResident.TabIndex = 6
        Me.txtSearchResident.Text = "Type in your search"
        '
        'searchResidentParent
        '
        Me.searchResidentParent.ColumnCount = 2
        Me.searchResidentParent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.9399!))
        Me.searchResidentParent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.060097!))
        Me.searchResidentParent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.searchResidentParent.Controls.Add(Me.txtSearchResident, 0, 0)
        Me.searchResidentParent.Controls.Add(Me.btnSearchResident, 1, 0)
        Me.searchResidentParent.Dock = System.Windows.Forms.DockStyle.Top
        Me.searchResidentParent.Location = New System.Drawing.Point(5, 5)
        Me.searchResidentParent.Name = "searchResidentParent"
        Me.searchResidentParent.Padding = New System.Windows.Forms.Padding(5)
        Me.searchResidentParent.RowCount = 1
        Me.searchResidentParent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchResidentParent.Size = New System.Drawing.Size(1083, 45)
        Me.searchResidentParent.TabIndex = 9
        '
        'ArchivedResidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 643)
        Me.Controls.Add(Me.datagridResidentParent)
        Me.Controls.Add(Me.searchResidentParent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ArchivedResidents"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Archived Residents"
        Me.datagridResidentParent.ResumeLayout(False)
        CType(Me.datagridResident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.searchResidentParent.ResumeLayout(False)
        Me.searchResidentParent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagridResidentParent As Panel
    Friend WithEvents datagridResident As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearchResident As Button
    Friend WithEvents txtSearchResident As TextBox
    Friend WithEvents searchResidentParent As TableLayoutPanel
End Class
