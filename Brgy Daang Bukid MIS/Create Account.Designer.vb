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
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.txtUsernameAdmin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.comboRecovery = New System.Windows.Forms.ComboBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveAccounts = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVisibilityPassword = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserLevel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboAccountFor = New System.Windows.Forms.ComboBox()
        Me.btnConfirmPassword = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.Black
        Me.labelTitle.Location = New System.Drawing.Point(134, 9)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.labelTitle.Size = New System.Drawing.Size(457, 42)
        Me.labelTitle.TabIndex = 3
        Me.labelTitle.Text = "INITIAL SETUP: ACCOUNT CREATION"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsernameAdmin
        '
        Me.txtUsernameAdmin.BackColor = System.Drawing.Color.White
        Me.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsernameAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtUsernameAdmin.Location = New System.Drawing.Point(287, 177)
        Me.txtUsernameAdmin.MaxLength = 20
        Me.txtUsernameAdmin.Multiline = True
        Me.txtUsernameAdmin.Name = "txtUsernameAdmin"
        Me.txtUsernameAdmin.Size = New System.Drawing.Size(278, 27)
        Me.txtUsernameAdmin.TabIndex = 1
        Me.txtUsernameAdmin.Tag = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(287, 212)
        Me.txtPassword.MaxLength = 17
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(278, 27)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Password*: "
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(88, 180)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(121, 18)
        Me.labelHousehold.TabIndex = 142
        Me.labelHousehold.Text = "User Name*: "
        '
        'comboRecovery
        '
        Me.comboRecovery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRecovery.FormattingEnabled = True
        Me.comboRecovery.Items.AddRange(New Object() {"What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "What was your childhood nickname?", "In what city did you meet your spouse/significant other?", "What is the name of your favorite childhood friend?", "What street did you live on in third grade?", "In what city or town did your mother and father meet?", "Where were you when you had your first kiss?"})
        Me.comboRecovery.Location = New System.Drawing.Point(287, 311)
        Me.comboRecovery.Name = "comboRecovery"
        Me.comboRecovery.Size = New System.Drawing.Size(278, 28)
        Me.comboRecovery.TabIndex = 4
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.Location = New System.Drawing.Point(287, 345)
        Me.txtAnswer.MaxLength = 20
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(278, 64)
        Me.txtAnswer.TabIndex = 5
        Me.txtAnswer.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "User Level"
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
        Me.btnSaveAccounts.Location = New System.Drawing.Point(259, 437)
        Me.btnSaveAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveAccounts.Name = "btnSaveAccounts"
        Me.btnSaveAccounts.Size = New System.Drawing.Size(144, 37)
        Me.btnSaveAccounts.TabIndex = 162
        Me.btnSaveAccounts.TabStop = False
        Me.btnSaveAccounts.Text = "Save Account"
        Me.btnSaveAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveAccounts.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.logo_daang_bukid_legitbgremoved
        Me.PictureBox1.Location = New System.Drawing.Point(91, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 163
        Me.PictureBox1.TabStop = False
        '
        'btnVisibilityPassword
        '
        Me.btnVisibilityPassword.BackColor = System.Drawing.Color.White
        Me.btnVisibilityPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityPassword.FlatAppearance.BorderSize = 0
        Me.btnVisibilityPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityPassword.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityPassword.Location = New System.Drawing.Point(535, 214)
        Me.btnVisibilityPassword.Name = "btnVisibilityPassword"
        Me.btnVisibilityPassword.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityPassword.TabIndex = 164
        Me.btnVisibilityPassword.TabStop = False
        Me.btnVisibilityPassword.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 18)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Recovery Question*: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 18)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Recovery Answer*: "
        '
        'txtUserLevel
        '
        Me.txtUserLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserLevel.Enabled = False
        Me.txtUserLevel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLevel.Location = New System.Drawing.Point(287, 70)
        Me.txtUserLevel.Name = "txtUserLevel"
        Me.txtUserLevel.Size = New System.Drawing.Size(278, 29)
        Me.txtUserLevel.TabIndex = 140
        Me.txtUserLevel.Text = "Administrator"
        Me.txtUserLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Account for*: "
        '
        'comboAccountFor
        '
        Me.comboAccountFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAccountFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAccountFor.FormattingEnabled = True
        Me.comboAccountFor.Location = New System.Drawing.Point(287, 111)
        Me.comboAccountFor.Name = "comboAccountFor"
        Me.comboAccountFor.Size = New System.Drawing.Size(278, 28)
        Me.comboAccountFor.TabIndex = 0
        '
        'btnConfirmPassword
        '
        Me.btnConfirmPassword.BackColor = System.Drawing.Color.White
        Me.btnConfirmPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnConfirmPassword.FlatAppearance.BorderSize = 0
        Me.btnConfirmPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnConfirmPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPassword.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnConfirmPassword.Location = New System.Drawing.Point(534, 250)
        Me.btnConfirmPassword.Name = "btnConfirmPassword"
        Me.btnConfirmPassword.Size = New System.Drawing.Size(29, 23)
        Me.btnConfirmPassword.TabIndex = 171
        Me.btnConfirmPassword.TabStop = False
        Me.btnConfirmPassword.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 18)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Confirm Password*: "
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Location = New System.Drawing.Point(287, 248)
        Me.txtConfirmPassword.MaxLength = 17
        Me.txtConfirmPassword.Multiline = True
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(278, 27)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'Create_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 494)
        Me.Controls.Add(Me.btnConfirmPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboAccountFor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVisibilityPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSaveAccounts)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.comboRecovery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelHousehold)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserLevel)
        Me.Controls.Add(Me.txtUsernameAdmin)
        Me.Controls.Add(Me.labelTitle)
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

    Friend WithEvents labelTitle As Label
    Friend WithEvents txtUsernameAdmin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labelHousehold As Label
    Friend WithEvents comboRecovery As ComboBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveAccounts As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVisibilityPassword As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserLevel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents comboAccountFor As ComboBox
    Friend WithEvents btnConfirmPassword As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmPassword As TextBox
End Class
