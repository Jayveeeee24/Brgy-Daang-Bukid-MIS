<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account_Settings))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.Label()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnVisibilityNewPass = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelGuestAccount = New System.Windows.Forms.Panel()
        Me.btnChangePasswordGuest = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVisibilityGuest = New System.Windows.Forms.Button()
        Me.txtPasswordGuest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelUsernameGuest = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGuestAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(124, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label1.Size = New System.Drawing.Size(381, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BARANGAY DAANG BUKID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.White
        Me.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(194, 151)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(311, 29)
        Me.txtAccountName.TabIndex = 109
        Me.txtAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(44, 156)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(133, 18)
        Me.labelHousehold.TabIndex = 108
        Me.labelHousehold.Text = "Logged in as*: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 18)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "New Password*: "
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(194, 232)
        Me.txtPassword.MaxLength = 100
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(311, 27)
        Me.txtPassword.TabIndex = 111
        '
        'btnVisibilityNewPass
        '
        Me.btnVisibilityNewPass.BackColor = System.Drawing.Color.White
        Me.btnVisibilityNewPass.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityNewPass.FlatAppearance.BorderSize = 0
        Me.btnVisibilityNewPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityNewPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityNewPass.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityNewPass.Location = New System.Drawing.Point(473, 234)
        Me.btnVisibilityNewPass.Name = "btnVisibilityNewPass"
        Me.btnVisibilityNewPass.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityNewPass.TabIndex = 112
        Me.btnVisibilityNewPass.TabStop = False
        Me.btnVisibilityNewPass.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassword.Location = New System.Drawing.Point(206, 274)
        Me.btnChangePassword.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(158, 41)
        Me.btnChangePassword.TabIndex = 116
        Me.btnChangePassword.TabStop = False
        Me.btnChangePassword.Text = "  Change Password"
        Me.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "YOUR ACCOUNT"
        '
        'panelGuestAccount
        '
        Me.panelGuestAccount.Controls.Add(Me.btnChangePasswordGuest)
        Me.panelGuestAccount.Controls.Add(Me.Label4)
        Me.panelGuestAccount.Controls.Add(Me.btnVisibilityGuest)
        Me.panelGuestAccount.Controls.Add(Me.txtPasswordGuest)
        Me.panelGuestAccount.Controls.Add(Me.Label5)
        Me.panelGuestAccount.Controls.Add(Me.labelUsernameGuest)
        Me.panelGuestAccount.Controls.Add(Me.Label7)
        Me.panelGuestAccount.Location = New System.Drawing.Point(12, 325)
        Me.panelGuestAccount.Name = "panelGuestAccount"
        Me.panelGuestAccount.Size = New System.Drawing.Size(511, 203)
        Me.panelGuestAccount.TabIndex = 118
        '
        'btnChangePasswordGuest
        '
        Me.btnChangePasswordGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnChangePasswordGuest.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnChangePasswordGuest.FlatAppearance.BorderSize = 0
        Me.btnChangePasswordGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChangePasswordGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnChangePasswordGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePasswordGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePasswordGuest.ForeColor = System.Drawing.Color.White
        Me.btnChangePasswordGuest.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnChangePasswordGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePasswordGuest.Location = New System.Drawing.Point(194, 150)
        Me.btnChangePasswordGuest.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChangePasswordGuest.Name = "btnChangePasswordGuest"
        Me.btnChangePasswordGuest.Size = New System.Drawing.Size(158, 41)
        Me.btnChangePasswordGuest.TabIndex = 119
        Me.btnChangePasswordGuest.TabStop = False
        Me.btnChangePasswordGuest.Text = "  Change Password"
        Me.btnChangePasswordGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangePasswordGuest.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 18)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "GUEST ACCOUNT"
        '
        'btnVisibilityGuest
        '
        Me.btnVisibilityGuest.BackColor = System.Drawing.Color.White
        Me.btnVisibilityGuest.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityGuest.FlatAppearance.BorderSize = 0
        Me.btnVisibilityGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityGuest.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityGuest.Location = New System.Drawing.Point(461, 103)
        Me.btnVisibilityGuest.Name = "btnVisibilityGuest"
        Me.btnVisibilityGuest.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityGuest.TabIndex = 128
        Me.btnVisibilityGuest.TabStop = False
        Me.btnVisibilityGuest.UseVisualStyleBackColor = False
        '
        'txtPasswordGuest
        '
        Me.txtPasswordGuest.BackColor = System.Drawing.Color.White
        Me.txtPasswordGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordGuest.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordGuest.Location = New System.Drawing.Point(182, 101)
        Me.txtPasswordGuest.MaxLength = 100
        Me.txtPasswordGuest.Multiline = True
        Me.txtPasswordGuest.Name = "txtPasswordGuest"
        Me.txtPasswordGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordGuest.Size = New System.Drawing.Size(311, 27)
        Me.txtPasswordGuest.TabIndex = 127
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 18)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "New Password*: "
        '
        'labelUsernameGuest
        '
        Me.labelUsernameGuest.BackColor = System.Drawing.Color.White
        Me.labelUsernameGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelUsernameGuest.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsernameGuest.Location = New System.Drawing.Point(182, 54)
        Me.labelUsernameGuest.Name = "labelUsernameGuest"
        Me.labelUsernameGuest.Size = New System.Drawing.Size(311, 29)
        Me.labelUsernameGuest.TabIndex = 125
        Me.labelUsernameGuest.Text = "guest"
        Me.labelUsernameGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Username*:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Username*: "
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(194, 193)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(311, 27)
        Me.txtUsername.TabIndex = 121
        '
        'Account_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 540)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.panelGuestAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnVisibilityNewPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.labelHousehold)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Account_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGuestAccount.ResumeLayout(False)
        Me.panelGuestAccount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountName As Label
    Friend WithEvents labelHousehold As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnVisibilityNewPass As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents panelGuestAccount As Panel
    Friend WithEvents btnChangePasswordGuest As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVisibilityGuest As Button
    Friend WithEvents txtPasswordGuest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents labelUsernameGuest As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
End Class
