<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountManagement))
        Me.datagridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.btnUpdateAccount = New System.Windows.Forms.Button()
        Me.btnRemoveAccount = New System.Windows.Forms.Button()
        CType(Me.datagridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridViewAccounts
        '
        Me.datagridViewAccounts.AllowUserToAddRows = False
        Me.datagridViewAccounts.AllowUserToDeleteRows = False
        Me.datagridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridViewAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridViewAccounts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridViewAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridViewAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridViewAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column2, Me.Column1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridViewAccounts.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridViewAccounts.Location = New System.Drawing.Point(12, 63)
        Me.datagridViewAccounts.Name = "datagridViewAccounts"
        Me.datagridViewAccounts.ReadOnly = True
        Me.datagridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridViewAccounts.Size = New System.Drawing.Size(802, 318)
        Me.datagridViewAccounts.TabIndex = 116
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Account ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "User Level"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "User Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Official Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Official Position"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'btnAddAccount
        '
        Me.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAddAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAccount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAccount.ForeColor = System.Drawing.Color.White
        Me.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAccount.Location = New System.Drawing.Point(12, 24)
        Me.btnAddAccount.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAddAccount.Size = New System.Drawing.Size(164, 33)
        Me.btnAddAccount.TabIndex = 117
        Me.btnAddAccount.TabStop = False
        Me.btnAddAccount.Text = "ADD NEW ACCOUNT"
        Me.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAccount.UseVisualStyleBackColor = False
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdateAccount.Enabled = False
        Me.btnUpdateAccount.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnUpdateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAccount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateAccount.ForeColor = System.Drawing.Color.White
        Me.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateAccount.Location = New System.Drawing.Point(188, 24)
        Me.btnUpdateAccount.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnUpdateAccount.Size = New System.Drawing.Size(164, 33)
        Me.btnUpdateAccount.TabIndex = 118
        Me.btnUpdateAccount.TabStop = False
        Me.btnUpdateAccount.Text = "UPDATE ACCOUNT"
        Me.btnUpdateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateAccount.UseVisualStyleBackColor = False
        '
        'btnRemoveAccount
        '
        Me.btnRemoveAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnRemoveAccount.Enabled = False
        Me.btnRemoveAccount.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnRemoveAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRemoveAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAccount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveAccount.ForeColor = System.Drawing.Color.White
        Me.btnRemoveAccount.Location = New System.Drawing.Point(366, 24)
        Me.btnRemoveAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoveAccount.Name = "btnRemoveAccount"
        Me.btnRemoveAccount.Size = New System.Drawing.Size(171, 33)
        Me.btnRemoveAccount.TabIndex = 119
        Me.btnRemoveAccount.TabStop = False
        Me.btnRemoveAccount.Text = "REMOVE ACCOUNT"
        Me.btnRemoveAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveAccount.UseVisualStyleBackColor = False
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 392)
        Me.Controls.Add(Me.btnRemoveAccount)
        Me.Controls.Add(Me.btnUpdateAccount)
        Me.Controls.Add(Me.btnAddAccount)
        Me.Controls.Add(Me.datagridViewAccounts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AccountManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Management"
        CType(Me.datagridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagridViewAccounts As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddAccount As Button
    Friend WithEvents btnUpdateAccount As Button
    Friend WithEvents btnRemoveAccount As Button
End Class
