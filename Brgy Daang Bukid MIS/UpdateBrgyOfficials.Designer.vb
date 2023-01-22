<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateBrgyOfficials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateBrgyOfficials))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGridBrgyOfficials = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAppointOfficial = New System.Windows.Forms.Button()
        Me.btnDismissOfficial = New System.Windows.Forms.Button()
        Me.btnElectOfficials = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridBrgyOfficials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(130, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label1.Size = New System.Drawing.Size(350, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BARANGAY DAANG BUKID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(131, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label2.Size = New System.Drawing.Size(758, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Address: F.Gaudier Street Daang Bukid, Bacoor Cavite"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dataGridBrgyOfficials
        '
        Me.dataGridBrgyOfficials.AllowUserToAddRows = False
        Me.dataGridBrgyOfficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridBrgyOfficials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridBrgyOfficials.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridBrgyOfficials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridBrgyOfficials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridBrgyOfficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridBrgyOfficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridBrgyOfficials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column1, Me.Column2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridBrgyOfficials.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridBrgyOfficials.Location = New System.Drawing.Point(12, 176)
        Me.dataGridBrgyOfficials.MultiSelect = False
        Me.dataGridBrgyOfficials.Name = "dataGridBrgyOfficials"
        Me.dataGridBrgyOfficials.ReadOnly = True
        Me.dataGridBrgyOfficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridBrgyOfficials.Size = New System.Drawing.Size(911, 327)
        Me.dataGridBrgyOfficials.TabIndex = 7
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
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "Position"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnAppointOfficial
        '
        Me.btnAppointOfficial.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAppointOfficial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAppointOfficial.FlatAppearance.BorderSize = 0
        Me.btnAppointOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAppointOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAppointOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAppointOfficial.ForeColor = System.Drawing.Color.White
        Me.btnAppointOfficial.Image = CType(resources.GetObject("btnAppointOfficial.Image"), System.Drawing.Image)
        Me.btnAppointOfficial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointOfficial.Location = New System.Drawing.Point(175, 129)
        Me.btnAppointOfficial.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAppointOfficial.Name = "btnAppointOfficial"
        Me.btnAppointOfficial.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAppointOfficial.Size = New System.Drawing.Size(146, 41)
        Me.btnAppointOfficial.TabIndex = 9
        Me.btnAppointOfficial.TabStop = False
        Me.btnAppointOfficial.Text = "  Appoint Official"
        Me.btnAppointOfficial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointOfficial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointOfficial.UseVisualStyleBackColor = False
        '
        'btnDismissOfficial
        '
        Me.btnDismissOfficial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDismissOfficial.Enabled = False
        Me.btnDismissOfficial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDismissOfficial.FlatAppearance.BorderSize = 0
        Me.btnDismissOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDismissOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDismissOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDismissOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDismissOfficial.ForeColor = System.Drawing.Color.White
        Me.btnDismissOfficial.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnDismissOfficial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDismissOfficial.Location = New System.Drawing.Point(336, 129)
        Me.btnDismissOfficial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDismissOfficial.Name = "btnDismissOfficial"
        Me.btnDismissOfficial.Size = New System.Drawing.Size(146, 41)
        Me.btnDismissOfficial.TabIndex = 107
        Me.btnDismissOfficial.TabStop = False
        Me.btnDismissOfficial.Text = "  Dismiss Official"
        Me.btnDismissOfficial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDismissOfficial.UseVisualStyleBackColor = False
        '
        'btnElectOfficials
        '
        Me.btnElectOfficials.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnElectOfficials.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnElectOfficials.FlatAppearance.BorderSize = 0
        Me.btnElectOfficials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnElectOfficials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnElectOfficials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElectOfficials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnElectOfficials.ForeColor = System.Drawing.Color.White
        Me.btnElectOfficials.Image = CType(resources.GetObject("btnElectOfficials.Image"), System.Drawing.Image)
        Me.btnElectOfficials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElectOfficials.Location = New System.Drawing.Point(17, 129)
        Me.btnElectOfficials.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnElectOfficials.Name = "btnElectOfficials"
        Me.btnElectOfficials.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnElectOfficials.Size = New System.Drawing.Size(146, 41)
        Me.btnElectOfficials.TabIndex = 108
        Me.btnElectOfficials.TabStop = False
        Me.btnElectOfficials.Text = "  Elect Officials"
        Me.btnElectOfficials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElectOfficials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnElectOfficials.UseVisualStyleBackColor = False
        '
        'UpdateBrgyOfficials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 515)
        Me.Controls.Add(Me.btnElectOfficials)
        Me.Controls.Add(Me.btnDismissOfficial)
        Me.Controls.Add(Me.btnAppointOfficial)
        Me.Controls.Add(Me.dataGridBrgyOfficials)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateBrgyOfficials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridBrgyOfficials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGridBrgyOfficials As DataGridView
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnAppointOfficial As Button
    Friend WithEvents btnDismissOfficial As Button
    Friend WithEvents btnElectOfficials As Button
End Class
