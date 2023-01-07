<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Residents
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Residents))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datagridResidentParent = New System.Windows.Forms.Panel()
        Me.datagridResident = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchResidents = New System.Windows.Forms.Button()
        Me.txtSearchResidents = New System.Windows.Forms.TextBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.datagridResidentParent.SuspendLayout()
        CType(Me.datagridResident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datagridResidentParent)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel19)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 335)
        Me.Panel1.TabIndex = 0
        '
        'datagridResidentParent
        '
        Me.datagridResidentParent.Controls.Add(Me.datagridResident)
        Me.datagridResidentParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridResidentParent.Location = New System.Drawing.Point(0, 43)
        Me.datagridResidentParent.Name = "datagridResidentParent"
        Me.datagridResidentParent.Padding = New System.Windows.Forms.Padding(7)
        Me.datagridResidentParent.Size = New System.Drawing.Size(616, 292)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridResident.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridResident.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridResident.DefaultCellStyle = DataGridViewCellStyle4
        Me.datagridResident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridResident.Location = New System.Drawing.Point(7, 7)
        Me.datagridResident.Name = "datagridResident"
        Me.datagridResident.ReadOnly = True
        Me.datagridResident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridResident.Size = New System.Drawing.Size(602, 278)
        Me.datagridResident.TabIndex = 13
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 2
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.btnSearchResidents, 1, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.txtSearchResidents, 0, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel19.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel19.RowCount = 1
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(616, 43)
        Me.TableLayoutPanel19.TabIndex = 1
        '
        'btnSearchResidents
        '
        Me.btnSearchResidents.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchResidents.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchResidents.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchResidents.FlatAppearance.BorderSize = 0
        Me.btnSearchResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchResidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchResidents.ForeColor = System.Drawing.Color.White
        Me.btnSearchResidents.Image = CType(resources.GetObject("btnSearchResidents.Image"), System.Drawing.Image)
        Me.btnSearchResidents.Location = New System.Drawing.Point(571, 8)
        Me.btnSearchResidents.Name = "btnSearchResidents"
        Me.btnSearchResidents.Size = New System.Drawing.Size(37, 27)
        Me.btnSearchResidents.TabIndex = 16
        Me.btnSearchResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchResidents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchResidents.UseVisualStyleBackColor = False
        '
        'txtSearchResidents
        '
        Me.txtSearchResidents.BackColor = System.Drawing.Color.White
        Me.txtSearchResidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchResidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResidents.ForeColor = System.Drawing.Color.Black
        Me.txtSearchResidents.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchResidents.MaxLength = 50
        Me.txtSearchResidents.Multiline = True
        Me.txtSearchResidents.Name = "txtSearchResidents"
        Me.txtSearchResidents.Size = New System.Drawing.Size(557, 27)
        Me.txtSearchResidents.TabIndex = 12
        Me.txtSearchResidents.Text = "Search by household id or resident name"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID Number"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Household ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Search_Residents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 335)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Search_Residents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Residents"
        Me.Panel1.ResumeLayout(False)
        Me.datagridResidentParent.ResumeLayout(False)
        CType(Me.datagridResident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents btnSearchResidents As Button
    Friend WithEvents txtSearchResidents As TextBox
    Friend WithEvents datagridResidentParent As Panel
    Friend WithEvents datagridResident As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
