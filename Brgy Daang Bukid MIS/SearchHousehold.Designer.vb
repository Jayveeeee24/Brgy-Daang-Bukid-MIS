<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchHousehold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchHousehold))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchHousehold = New System.Windows.Forms.Button()
        Me.txtSearchHousehold = New System.Windows.Forms.TextBox()
        Me.datagridHouseholdParent = New System.Windows.Forms.Panel()
        Me.datagridHousehold = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.datagridHouseholdParent.SuspendLayout()
        CType(Me.datagridHousehold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 2
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.66951!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.330491!))
        Me.TableLayoutPanel19.Controls.Add(Me.btnSearchHousehold, 1, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.txtSearchHousehold, 0, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel19.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel19.RowCount = 1
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(948, 43)
        Me.TableLayoutPanel19.TabIndex = 2
        '
        'btnSearchHousehold
        '
        Me.btnSearchHousehold.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchHousehold.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchHousehold.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchHousehold.FlatAppearance.BorderSize = 0
        Me.btnSearchHousehold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchHousehold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchHousehold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchHousehold.ForeColor = System.Drawing.Color.White
        Me.btnSearchHousehold.Image = CType(resources.GetObject("btnSearchHousehold.Image"), System.Drawing.Image)
        Me.btnSearchHousehold.Location = New System.Drawing.Point(903, 8)
        Me.btnSearchHousehold.Name = "btnSearchHousehold"
        Me.btnSearchHousehold.Size = New System.Drawing.Size(37, 27)
        Me.btnSearchHousehold.TabIndex = 16
        Me.btnSearchHousehold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchHousehold.UseVisualStyleBackColor = False
        '
        'txtSearchHousehold
        '
        Me.txtSearchHousehold.BackColor = System.Drawing.Color.White
        Me.txtSearchHousehold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchHousehold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchHousehold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchHousehold.ForeColor = System.Drawing.Color.Black
        Me.txtSearchHousehold.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchHousehold.MaxLength = 50
        Me.txtSearchHousehold.Multiline = True
        Me.txtSearchHousehold.Name = "txtSearchHousehold"
        Me.txtSearchHousehold.Size = New System.Drawing.Size(882, 27)
        Me.txtSearchHousehold.TabIndex = 12
        Me.txtSearchHousehold.Text = "Search by household id, house no or street name"
        '
        'datagridHouseholdParent
        '
        Me.datagridHouseholdParent.Controls.Add(Me.datagridHousehold)
        Me.datagridHouseholdParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridHouseholdParent.Location = New System.Drawing.Point(0, 43)
        Me.datagridHouseholdParent.Name = "datagridHouseholdParent"
        Me.datagridHouseholdParent.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.datagridHouseholdParent.Size = New System.Drawing.Size(948, 478)
        Me.datagridHouseholdParent.TabIndex = 15
        '
        'datagridHousehold
        '
        Me.datagridHousehold.AllowUserToAddRows = False
        Me.datagridHousehold.AllowUserToDeleteRows = False
        Me.datagridHousehold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridHousehold.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridHousehold.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridHousehold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridHousehold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridHousehold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridHousehold.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridHousehold.DefaultCellStyle = DataGridViewCellStyle4
        Me.datagridHousehold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridHousehold.Location = New System.Drawing.Point(5, 7)
        Me.datagridHousehold.Name = "datagridHousehold"
        Me.datagridHousehold.ReadOnly = True
        Me.datagridHousehold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridHousehold.Size = New System.Drawing.Size(938, 464)
        Me.datagridHousehold.TabIndex = 13
        '
        'Column2
        '
        Me.Column2.HeaderText = "Household ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Head Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "House No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Street Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'SearchHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 521)
        Me.Controls.Add(Me.datagridHouseholdParent)
        Me.Controls.Add(Me.TableLayoutPanel19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchHousehold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Household"
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.datagridHouseholdParent.ResumeLayout(False)
        CType(Me.datagridHousehold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents btnSearchHousehold As Button
    Friend WithEvents txtSearchHousehold As TextBox
    Friend WithEvents datagridHouseholdParent As Panel
    Friend WithEvents datagridHousehold As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
