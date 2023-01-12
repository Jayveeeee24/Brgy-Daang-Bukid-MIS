<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointOfficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointOfficial))
        Me.comboOfficialPosition = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOfficialName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAppointOfficial = New System.Windows.Forms.Button()
        Me.btnSearchOfficial = New System.Windows.Forms.Button()
        Me.labelPositionWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboOfficialPosition
        '
        Me.comboOfficialPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOfficialPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboOfficialPosition.FormattingEnabled = True
        Me.comboOfficialPosition.Items.AddRange(New Object() {"Barangay Captain", "Barangay Secretary", "Barangay Treasurer", "Barangay Kagawad", "SK Chairperson", "SK Secretary", "SK Treasurer"})
        Me.comboOfficialPosition.Location = New System.Drawing.Point(113, 92)
        Me.comboOfficialPosition.Name = "comboOfficialPosition"
        Me.comboOfficialPosition.Size = New System.Drawing.Size(259, 28)
        Me.comboOfficialPosition.TabIndex = 136
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Position*: "
        '
        'txtOfficialName
        '
        Me.txtOfficialName.BackColor = System.Drawing.Color.White
        Me.txtOfficialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOfficialName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficialName.ForeColor = System.Drawing.Color.Black
        Me.txtOfficialName.Location = New System.Drawing.Point(113, 41)
        Me.txtOfficialName.MaxLength = 100
        Me.txtOfficialName.Multiline = True
        Me.txtOfficialName.Name = "txtOfficialName"
        Me.txtOfficialName.Size = New System.Drawing.Size(259, 27)
        Me.txtOfficialName.TabIndex = 138
        Me.txtOfficialName.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Name*: "
        '
        'btnAppointOfficial
        '
        Me.btnAppointOfficial.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAppointOfficial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAppointOfficial.FlatAppearance.BorderSize = 0
        Me.btnAppointOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAppointOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAppointOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointOfficial.ForeColor = System.Drawing.Color.White
        Me.btnAppointOfficial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointOfficial.Location = New System.Drawing.Point(151, 166)
        Me.btnAppointOfficial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAppointOfficial.Name = "btnAppointOfficial"
        Me.btnAppointOfficial.Size = New System.Drawing.Size(144, 37)
        Me.btnAppointOfficial.TabIndex = 140
        Me.btnAppointOfficial.TabStop = False
        Me.btnAppointOfficial.Text = "Appoint Official"
        Me.btnAppointOfficial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointOfficial.UseVisualStyleBackColor = False
        '
        'btnSearchOfficial
        '
        Me.btnSearchOfficial.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchOfficial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchOfficial.ForeColor = System.Drawing.Color.White
        Me.btnSearchOfficial.Image = CType(resources.GetObject("btnSearchOfficial.Image"), System.Drawing.Image)
        Me.btnSearchOfficial.Location = New System.Drawing.Point(384, 41)
        Me.btnSearchOfficial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchOfficial.Name = "btnSearchOfficial"
        Me.btnSearchOfficial.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchOfficial.TabIndex = 141
        Me.btnSearchOfficial.TabStop = False
        Me.btnSearchOfficial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchOfficial.UseVisualStyleBackColor = False
        '
        'labelPositionWarning
        '
        Me.labelPositionWarning.AutoSize = True
        Me.labelPositionWarning.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPositionWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.labelPositionWarning.Location = New System.Drawing.Point(148, 123)
        Me.labelPositionWarning.Name = "labelPositionWarning"
        Me.labelPositionWarning.Size = New System.Drawing.Size(171, 14)
        Me.labelPositionWarning.TabIndex = 143
        Me.labelPositionWarning.Text = "Position is already filled!"
        '
        'AppointOfficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 228)
        Me.Controls.Add(Me.labelPositionWarning)
        Me.Controls.Add(Me.btnSearchOfficial)
        Me.Controls.Add(Me.btnAppointOfficial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtOfficialName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboOfficialPosition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AppointOfficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppointOfficial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboOfficialPosition As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOfficialName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAppointOfficial As Button
    Friend WithEvents btnSearchOfficial As Button
    Friend WithEvents labelPositionWarning As Label
End Class
