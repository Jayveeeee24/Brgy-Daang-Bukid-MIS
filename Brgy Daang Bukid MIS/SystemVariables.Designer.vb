<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemVariables))
        Me.datagridViewSystemVariables = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comboSystemVariables = New System.Windows.Forms.ComboBox()
        Me.btnModifyVariable = New System.Windows.Forms.Button()
        Me.btnDeleteVariable = New System.Windows.Forms.Button()
        Me.btnAddVariable = New System.Windows.Forms.Button()
        Me.txtSearchVariable = New System.Windows.Forms.TextBox()
        Me.btnSearchVariable = New System.Windows.Forms.Button()
        Me.labelHousehold = New System.Windows.Forms.Label()
        CType(Me.datagridViewSystemVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridViewSystemVariables
        '
        Me.datagridViewSystemVariables.AllowUserToAddRows = False
        Me.datagridViewSystemVariables.AllowUserToDeleteRows = False
        Me.datagridViewSystemVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridViewSystemVariables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridViewSystemVariables.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridViewSystemVariables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridViewSystemVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridViewSystemVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridViewSystemVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridViewSystemVariables.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridViewSystemVariables.Location = New System.Drawing.Point(12, 92)
        Me.datagridViewSystemVariables.Name = "datagridViewSystemVariables"
        Me.datagridViewSystemVariables.ReadOnly = True
        Me.datagridViewSystemVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridViewSystemVariables.Size = New System.Drawing.Size(931, 412)
        Me.datagridViewSystemVariables.TabIndex = 117
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Variable Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'comboSystemVariables
        '
        Me.comboSystemVariables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSystemVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSystemVariables.FormattingEnabled = True
        Me.comboSystemVariables.Items.AddRange(New Object() {"Birthplace", "Citizenship", "Civil Status", "Religion", "Street Name", "Residence Type", "House Type", "Water Source", "Electricity Source", "Recovery Question", "Reason For Archive", "Return Item State", "Certificate Purpose", "Blottered for", "Stock Out Reason"})
        Me.comboSystemVariables.Location = New System.Drawing.Point(664, 58)
        Me.comboSystemVariables.Name = "comboSystemVariables"
        Me.comboSystemVariables.Size = New System.Drawing.Size(276, 28)
        Me.comboSystemVariables.TabIndex = 168
        '
        'btnModifyVariable
        '
        Me.btnModifyVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyVariable.Enabled = False
        Me.btnModifyVariable.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnModifyVariable.FlatAppearance.BorderSize = 0
        Me.btnModifyVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnModifyVariable.ForeColor = System.Drawing.Color.White
        Me.btnModifyVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyVariable.Location = New System.Drawing.Point(171, 45)
        Me.btnModifyVariable.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnModifyVariable.Name = "btnModifyVariable"
        Me.btnModifyVariable.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnModifyVariable.Size = New System.Drawing.Size(146, 41)
        Me.btnModifyVariable.TabIndex = 171
        Me.btnModifyVariable.TabStop = False
        Me.btnModifyVariable.Text = "Modify Variable"
        Me.btnModifyVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyVariable.UseVisualStyleBackColor = False
        '
        'btnDeleteVariable
        '
        Me.btnDeleteVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeleteVariable.Enabled = False
        Me.btnDeleteVariable.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteVariable.FlatAppearance.BorderSize = 0
        Me.btnDeleteVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteVariable.ForeColor = System.Drawing.Color.White
        Me.btnDeleteVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteVariable.Location = New System.Drawing.Point(335, 45)
        Me.btnDeleteVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDeleteVariable.Name = "btnDeleteVariable"
        Me.btnDeleteVariable.Size = New System.Drawing.Size(146, 41)
        Me.btnDeleteVariable.TabIndex = 170
        Me.btnDeleteVariable.TabStop = False
        Me.btnDeleteVariable.Text = "Delete Variable"
        Me.btnDeleteVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteVariable.UseVisualStyleBackColor = False
        '
        'btnAddVariable
        '
        Me.btnAddVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddVariable.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAddVariable.FlatAppearance.BorderSize = 0
        Me.btnAddVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAddVariable.ForeColor = System.Drawing.Color.White
        Me.btnAddVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddVariable.Location = New System.Drawing.Point(13, 45)
        Me.btnAddVariable.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAddVariable.Name = "btnAddVariable"
        Me.btnAddVariable.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAddVariable.Size = New System.Drawing.Size(146, 41)
        Me.btnAddVariable.TabIndex = 169
        Me.btnAddVariable.TabStop = False
        Me.btnAddVariable.Text = "Add Variable"
        Me.btnAddVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddVariable.UseVisualStyleBackColor = False
        '
        'txtSearchVariable
        '
        Me.txtSearchVariable.BackColor = System.Drawing.Color.White
        Me.txtSearchVariable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchVariable.ForeColor = System.Drawing.Color.Black
        Me.txtSearchVariable.Location = New System.Drawing.Point(12, 12)
        Me.txtSearchVariable.MaxLength = 50
        Me.txtSearchVariable.Multiline = True
        Me.txtSearchVariable.Name = "txtSearchVariable"
        Me.txtSearchVariable.Size = New System.Drawing.Size(856, 27)
        Me.txtSearchVariable.TabIndex = 172
        Me.txtSearchVariable.Text = "Search by variable name"
        '
        'btnSearchVariable
        '
        Me.btnSearchVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchVariable.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchVariable.FlatAppearance.BorderSize = 0
        Me.btnSearchVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchVariable.ForeColor = System.Drawing.Color.White
        Me.btnSearchVariable.Image = CType(resources.GetObject("btnSearchVariable.Image"), System.Drawing.Image)
        Me.btnSearchVariable.Location = New System.Drawing.Point(874, 12)
        Me.btnSearchVariable.Name = "btnSearchVariable"
        Me.btnSearchVariable.Size = New System.Drawing.Size(69, 27)
        Me.btnSearchVariable.TabIndex = 173
        Me.btnSearchVariable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchVariable.UseVisualStyleBackColor = False
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(518, 62)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(144, 18)
        Me.labelHousehold.TabIndex = 174
        Me.labelHousehold.Text = "Select Category:"
        '
        'SystemVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 516)
        Me.Controls.Add(Me.labelHousehold)
        Me.Controls.Add(Me.btnSearchVariable)
        Me.Controls.Add(Me.txtSearchVariable)
        Me.Controls.Add(Me.btnModifyVariable)
        Me.Controls.Add(Me.btnDeleteVariable)
        Me.Controls.Add(Me.btnAddVariable)
        Me.Controls.Add(Me.comboSystemVariables)
        Me.Controls.Add(Me.datagridViewSystemVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SystemVariables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Variables"
        CType(Me.datagridViewSystemVariables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagridViewSystemVariables As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents comboSystemVariables As ComboBox
    Friend WithEvents btnModifyVariable As Button
    Friend WithEvents btnDeleteVariable As Button
    Friend WithEvents btnAddVariable As Button
    Friend WithEvents txtSearchVariable As TextBox
    Friend WithEvents btnSearchVariable As Button
    Friend WithEvents labelHousehold As Label
End Class
