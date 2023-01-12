<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Account))
        Me.labelSignedIn = New System.Windows.Forms.Label()
        Me.txtUsernameAdmin = New System.Windows.Forms.TextBox()
        Me.txtLevelAdmin = New System.Windows.Forms.Label()
        Me.txtPasswordAdmin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPasswordStaff = New System.Windows.Forms.TextBox()
        Me.txtLevelStaff = New System.Windows.Forms.Label()
        Me.txtUsernameStaff = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboRecoveryAdmin = New System.Windows.Forms.ComboBox()
        Me.txtAnswerAdmin = New System.Windows.Forms.TextBox()
        Me.txtAnswerStaff = New System.Windows.Forms.TextBox()
        Me.comboRecoveryStaff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveAccounts = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVisibilityAdmin = New System.Windows.Forms.Button()
        Me.btnVisibilityStaff = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelSignedIn
        '
        Me.labelSignedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSignedIn.ForeColor = System.Drawing.Color.Black
        Me.labelSignedIn.Location = New System.Drawing.Point(181, 9)
        Me.labelSignedIn.Name = "labelSignedIn"
        Me.labelSignedIn.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.labelSignedIn.Size = New System.Drawing.Size(457, 42)
        Me.labelSignedIn.TabIndex = 3
        Me.labelSignedIn.Text = "INITIAL SETUP: ACCOUNT CREATION"
        Me.labelSignedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsernameAdmin
        '
        Me.txtUsernameAdmin.BackColor = System.Drawing.Color.White
        Me.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtUsernameAdmin.Location = New System.Drawing.Point(178, 128)
        Me.txtUsernameAdmin.MaxLength = 20
        Me.txtUsernameAdmin.Multiline = True
        Me.txtUsernameAdmin.Name = "txtUsernameAdmin"
        Me.txtUsernameAdmin.Size = New System.Drawing.Size(268, 27)
        Me.txtUsernameAdmin.TabIndex = 139
        Me.txtUsernameAdmin.Tag = ""
        '
        'txtLevelAdmin
        '
        Me.txtLevelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLevelAdmin.Enabled = False
        Me.txtLevelAdmin.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelAdmin.Location = New System.Drawing.Point(178, 82)
        Me.txtLevelAdmin.Name = "txtLevelAdmin"
        Me.txtLevelAdmin.Size = New System.Drawing.Size(268, 29)
        Me.txtLevelAdmin.TabIndex = 140
        Me.txtLevelAdmin.Text = "Administrator"
        Me.txtLevelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPasswordAdmin
        '
        Me.txtPasswordAdmin.BackColor = System.Drawing.Color.White
        Me.txtPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordAdmin.Location = New System.Drawing.Point(178, 170)
        Me.txtPasswordAdmin.MaxLength = 17
        Me.txtPasswordAdmin.Multiline = True
        Me.txtPasswordAdmin.Name = "txtPasswordAdmin"
        Me.txtPasswordAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordAdmin.Size = New System.Drawing.Size(268, 27)
        Me.txtPasswordAdmin.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Password*: "
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(30, 131)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(121, 18)
        Me.labelHousehold.TabIndex = 142
        Me.labelHousehold.Text = "User Name*: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Password*: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "User Name*: "
        '
        'txtPasswordStaff
        '
        Me.txtPasswordStaff.BackColor = System.Drawing.Color.White
        Me.txtPasswordStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordStaff.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordStaff.Location = New System.Drawing.Point(178, 334)
        Me.txtPasswordStaff.MaxLength = 17
        Me.txtPasswordStaff.Multiline = True
        Me.txtPasswordStaff.Name = "txtPasswordStaff"
        Me.txtPasswordStaff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordStaff.Size = New System.Drawing.Size(268, 27)
        Me.txtPasswordStaff.TabIndex = 147
        '
        'txtLevelStaff
        '
        Me.txtLevelStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLevelStaff.Enabled = False
        Me.txtLevelStaff.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelStaff.Location = New System.Drawing.Point(178, 246)
        Me.txtLevelStaff.Name = "txtLevelStaff"
        Me.txtLevelStaff.Size = New System.Drawing.Size(268, 29)
        Me.txtLevelStaff.TabIndex = 146
        Me.txtLevelStaff.Text = "Staff"
        Me.txtLevelStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsernameStaff
        '
        Me.txtUsernameStaff.BackColor = System.Drawing.Color.White
        Me.txtUsernameStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameStaff.ForeColor = System.Drawing.Color.Black
        Me.txtUsernameStaff.Location = New System.Drawing.Point(178, 292)
        Me.txtUsernameStaff.MaxLength = 20
        Me.txtUsernameStaff.Multiline = True
        Me.txtUsernameStaff.Name = "txtUsernameStaff"
        Me.txtUsernameStaff.Size = New System.Drawing.Size(268, 27)
        Me.txtUsernameStaff.TabIndex = 145
        Me.txtUsernameStaff.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(12, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 1)
        Me.Panel1.TabIndex = 151
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 1)
        Me.Panel2.TabIndex = 152
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 396)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(620, 14)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Note: By default, guest account has a username and password of 'guest' as it's lo" &
    "gin credentials "
        '
        'comboRecoveryAdmin
        '
        Me.comboRecoveryAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRecoveryAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRecoveryAdmin.FormattingEnabled = True
        Me.comboRecoveryAdmin.Items.AddRange(New Object() {"What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "In what city or town did your mother and father meet?", "Where were you when you had your first kiss?"})
        Me.comboRecoveryAdmin.Location = New System.Drawing.Point(470, 101)
        Me.comboRecoveryAdmin.Name = "comboRecoveryAdmin"
        Me.comboRecoveryAdmin.Size = New System.Drawing.Size(259, 28)
        Me.comboRecoveryAdmin.TabIndex = 154
        Me.comboRecoveryAdmin.TabStop = False
        '
        'txtAnswerAdmin
        '
        Me.txtAnswerAdmin.BackColor = System.Drawing.Color.White
        Me.txtAnswerAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswerAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtAnswerAdmin.Location = New System.Drawing.Point(470, 157)
        Me.txtAnswerAdmin.MaxLength = 20
        Me.txtAnswerAdmin.Multiline = True
        Me.txtAnswerAdmin.Name = "txtAnswerAdmin"
        Me.txtAnswerAdmin.Size = New System.Drawing.Size(259, 40)
        Me.txtAnswerAdmin.TabIndex = 155
        Me.txtAnswerAdmin.Tag = ""
        '
        'txtAnswerStaff
        '
        Me.txtAnswerStaff.BackColor = System.Drawing.Color.White
        Me.txtAnswerStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswerStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerStaff.ForeColor = System.Drawing.Color.Black
        Me.txtAnswerStaff.Location = New System.Drawing.Point(470, 322)
        Me.txtAnswerStaff.MaxLength = 20
        Me.txtAnswerStaff.Multiline = True
        Me.txtAnswerStaff.Name = "txtAnswerStaff"
        Me.txtAnswerStaff.Size = New System.Drawing.Size(259, 39)
        Me.txtAnswerStaff.TabIndex = 157
        Me.txtAnswerStaff.Tag = ""
        '
        'comboRecoveryStaff
        '
        Me.comboRecoveryStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRecoveryStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRecoveryStaff.FormattingEnabled = True
        Me.comboRecoveryStaff.Items.AddRange(New Object() {"What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "In what city or town did your mother and father meet?", "Where were you when you had your first kiss?"})
        Me.comboRecoveryStaff.Location = New System.Drawing.Point(470, 270)
        Me.comboRecoveryStaff.Name = "comboRecoveryStaff"
        Me.comboRecoveryStaff.Size = New System.Drawing.Size(259, 28)
        Me.comboRecoveryStaff.TabIndex = 156
        Me.comboRecoveryStaff.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "1st user level "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "2nd user level: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(467, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Recovery question: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(467, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 16)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Recovery answer: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(467, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 16)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Recovery answer: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(467, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 16)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Recovery question: "
        '
        'btnSaveAccounts
        '
        Me.btnSaveAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveAccounts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveAccounts.FlatAppearance.BorderSize = 0
        Me.btnSaveAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAccounts.ForeColor = System.Drawing.Color.White
        Me.btnSaveAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveAccounts.Location = New System.Drawing.Point(322, 438)
        Me.btnSaveAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveAccounts.Name = "btnSaveAccounts"
        Me.btnSaveAccounts.Size = New System.Drawing.Size(144, 37)
        Me.btnSaveAccounts.TabIndex = 162
        Me.btnSaveAccounts.TabStop = False
        Me.btnSaveAccounts.Text = "Save Accounts"
        Me.btnSaveAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveAccounts.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.logo_daang_bukid_legitbgremoved
        Me.PictureBox1.Location = New System.Drawing.Point(138, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 163
        Me.PictureBox1.TabStop = False
        '
        'btnVisibilityAdmin
        '
        Me.btnVisibilityAdmin.BackColor = System.Drawing.Color.White
        Me.btnVisibilityAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityAdmin.FlatAppearance.BorderSize = 0
        Me.btnVisibilityAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityAdmin.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityAdmin.Location = New System.Drawing.Point(416, 172)
        Me.btnVisibilityAdmin.Name = "btnVisibilityAdmin"
        Me.btnVisibilityAdmin.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityAdmin.TabIndex = 164
        Me.btnVisibilityAdmin.TabStop = False
        Me.btnVisibilityAdmin.UseVisualStyleBackColor = False
        '
        'btnVisibilityStaff
        '
        Me.btnVisibilityStaff.BackColor = System.Drawing.Color.White
        Me.btnVisibilityStaff.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityStaff.FlatAppearance.BorderSize = 0
        Me.btnVisibilityStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityStaff.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityStaff.Location = New System.Drawing.Point(416, 336)
        Me.btnVisibilityStaff.Name = "btnVisibilityStaff"
        Me.btnVisibilityStaff.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityStaff.TabIndex = 165
        Me.btnVisibilityStaff.TabStop = False
        Me.btnVisibilityStaff.UseVisualStyleBackColor = False
        '
        'Create_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 494)
        Me.Controls.Add(Me.btnVisibilityStaff)
        Me.Controls.Add(Me.btnVisibilityAdmin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSaveAccounts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAnswerStaff)
        Me.Controls.Add(Me.comboRecoveryStaff)
        Me.Controls.Add(Me.txtAnswerAdmin)
        Me.Controls.Add(Me.comboRecoveryAdmin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPasswordStaff)
        Me.Controls.Add(Me.txtLevelStaff)
        Me.Controls.Add(Me.txtUsernameStaff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelHousehold)
        Me.Controls.Add(Me.txtPasswordAdmin)
        Me.Controls.Add(Me.txtLevelAdmin)
        Me.Controls.Add(Me.txtUsernameAdmin)
        Me.Controls.Add(Me.labelSignedIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Create_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initial Setup: Management Information System of Barangay Daang Bukid"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSignedIn As Label
    Friend WithEvents txtUsernameAdmin As TextBox
    Friend WithEvents txtLevelAdmin As Label
    Friend WithEvents txtPasswordAdmin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labelHousehold As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPasswordStaff As TextBox
    Friend WithEvents txtLevelStaff As Label
    Friend WithEvents txtUsernameStaff As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents comboRecoveryAdmin As ComboBox
    Friend WithEvents txtAnswerAdmin As TextBox
    Friend WithEvents txtAnswerStaff As TextBox
    Friend WithEvents comboRecoveryStaff As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSaveAccounts As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVisibilityAdmin As Button
    Friend WithEvents btnVisibilityStaff As Button
End Class
