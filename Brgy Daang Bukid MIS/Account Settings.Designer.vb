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
        Me.txtAccountName = New System.Windows.Forms.Label()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnVisibilityNewPass = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnVisibilityConfirm = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.White
        Me.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(232, 74)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(276, 29)
        Me.txtAccountName.TabIndex = 109
        Me.txtAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(47, 79)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(133, 18)
        Me.labelHousehold.TabIndex = 108
        Me.labelHousehold.Text = "Logged in as*: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 184)
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
        Me.txtPassword.Location = New System.Drawing.Point(232, 178)
        Me.txtPassword.MaxLength = 100
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(276, 27)
        Me.txtPassword.TabIndex = 2
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
        Me.btnVisibilityNewPass.Location = New System.Drawing.Point(476, 180)
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
        Me.btnChangePassword.Location = New System.Drawing.Point(206, 289)
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
        Me.Label2.Location = New System.Drawing.Point(28, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "YOUR ACCOUNT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 139)
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
        Me.txtUsername.Location = New System.Drawing.Point(232, 136)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(276, 27)
        Me.txtUsername.TabIndex = 1
        '
        'btnVisibilityConfirm
        '
        Me.btnVisibilityConfirm.BackColor = System.Drawing.Color.White
        Me.btnVisibilityConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnVisibilityConfirm.FlatAppearance.BorderSize = 0
        Me.btnVisibilityConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnVisibilityConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisibilityConfirm.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnVisibilityConfirm.Location = New System.Drawing.Point(476, 221)
        Me.btnVisibilityConfirm.Name = "btnVisibilityConfirm"
        Me.btnVisibilityConfirm.Size = New System.Drawing.Size(29, 23)
        Me.btnVisibilityConfirm.TabIndex = 124
        Me.btnVisibilityConfirm.TabStop = False
        Me.btnVisibilityConfirm.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Location = New System.Drawing.Point(232, 219)
        Me.txtConfirmPassword.MaxLength = 100
        Me.txtConfirmPassword.Multiline = True
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(276, 27)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 18)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Confirm Password*: "
        '
        'Account_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 349)
        Me.Controls.Add(Me.btnVisibilityConfirm)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnVisibilityNewPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountName)
        Me.Controls.Add(Me.labelHousehold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Account_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAccountName As Label
    Friend WithEvents labelHousehold As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnVisibilityNewPass As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnVisibilityConfirm As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
End Class
