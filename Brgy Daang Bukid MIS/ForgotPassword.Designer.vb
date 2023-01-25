<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnUsername = New System.Windows.Forms.Button()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageUsername = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.pageRecovery = New System.Windows.Forms.TabPage()
        Me.labelRecovery = New System.Windows.Forms.Label()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.pageNewPassword = New System.Windows.Forms.TabPage()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConfirmPassword = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewPassowrd = New System.Windows.Forms.Button()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelLogo.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTabControl.SuspendLayout()
        Me.pageUsername.SuspendLayout()
        Me.pageRecovery.SuspendLayout()
        Me.pageNewPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(377, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Forgot Password"
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.White
        Me.panelLogo.Controls.Add(Me.Label3)
        Me.panelLogo.Controls.Add(Me.picLogo)
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(343, 491)
        Me.panelLogo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(43, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 102)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Management Information System for Brgy Daang Bukid"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.logo_daang_bukid_legitbgremoved
        Me.picLogo.Location = New System.Drawing.Point(86, 70)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(174, 179)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnUsername
        '
        Me.btnUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnUsername.Image = CType(resources.GetObject("btnUsername.Image"), System.Drawing.Image)
        Me.btnUsername.Location = New System.Drawing.Point(209, 94)
        Me.btnUsername.Name = "btnUsername"
        Me.btnUsername.Size = New System.Drawing.Size(66, 45)
        Me.btnUsername.TabIndex = 18
        Me.btnUsername.UseVisualStyleBackColor = False
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageUsername)
        Me.mainTabControl.Controls.Add(Me.pageRecovery)
        Me.mainTabControl.Controls.Add(Me.pageNewPassword)
        Me.mainTabControl.Location = New System.Drawing.Point(359, 154)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(323, 218)
        Me.mainTabControl.TabIndex = 23
        '
        'pageUsername
        '
        Me.pageUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pageUsername.Controls.Add(Me.Label4)
        Me.pageUsername.Controls.Add(Me.txtUsername)
        Me.pageUsername.Controls.Add(Me.btnUsername)
        Me.pageUsername.Location = New System.Drawing.Point(4, 22)
        Me.pageUsername.Name = "pageUsername"
        Me.pageUsername.Padding = New System.Windows.Forms.Padding(3)
        Me.pageUsername.Size = New System.Drawing.Size(315, 192)
        Me.pageUsername.TabIndex = 0
        Me.pageUsername.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(30, 39)
        Me.txtUsername.MaxLength = 20
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(259, 27)
        Me.txtUsername.TabIndex = 23
        '
        'pageRecovery
        '
        Me.pageRecovery.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pageRecovery.Controls.Add(Me.labelRecovery)
        Me.pageRecovery.Controls.Add(Me.btnRecovery)
        Me.pageRecovery.Controls.Add(Me.Label9)
        Me.pageRecovery.Controls.Add(Me.Label8)
        Me.pageRecovery.Controls.Add(Me.txtAnswer)
        Me.pageRecovery.Location = New System.Drawing.Point(4, 22)
        Me.pageRecovery.Name = "pageRecovery"
        Me.pageRecovery.Padding = New System.Windows.Forms.Padding(3)
        Me.pageRecovery.Size = New System.Drawing.Size(315, 192)
        Me.pageRecovery.TabIndex = 1
        Me.pageRecovery.Text = "Recovery"
        '
        'labelRecovery
        '
        Me.labelRecovery.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRecovery.ForeColor = System.Drawing.Color.White
        Me.labelRecovery.Location = New System.Drawing.Point(31, 19)
        Me.labelRecovery.Name = "labelRecovery"
        Me.labelRecovery.Size = New System.Drawing.Size(262, 54)
        Me.labelRecovery.TabIndex = 165
        '
        'btnRecovery
        '
        Me.btnRecovery.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRecovery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecovery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRecovery.Image = CType(resources.GetObject("btnRecovery.Image"), System.Drawing.Image)
        Me.btnRecovery.Location = New System.Drawing.Point(225, 141)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(66, 45)
        Me.btnRecovery.TabIndex = 164
        Me.btnRecovery.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(31, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 16)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Recovery answer: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(31, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Recovery question: "
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtAnswer.Location = New System.Drawing.Point(34, 91)
        Me.txtAnswer.MaxLength = 20
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(259, 40)
        Me.txtAnswer.TabIndex = 161
        Me.txtAnswer.Tag = ""
        '
        'pageNewPassword
        '
        Me.pageNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pageNewPassword.Controls.Add(Me.btnPassword)
        Me.pageNewPassword.Controls.Add(Me.Label5)
        Me.pageNewPassword.Controls.Add(Me.btnConfirmPassword)
        Me.pageNewPassword.Controls.Add(Me.txtConfirmPassword)
        Me.pageNewPassword.Controls.Add(Me.Label2)
        Me.pageNewPassword.Controls.Add(Me.btnNewPassowrd)
        Me.pageNewPassword.Controls.Add(Me.txtNewPassword)
        Me.pageNewPassword.Location = New System.Drawing.Point(4, 22)
        Me.pageNewPassword.Name = "pageNewPassword"
        Me.pageNewPassword.Size = New System.Drawing.Size(315, 192)
        Me.pageNewPassword.TabIndex = 2
        Me.pageNewPassword.Text = "NewPassword"
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPassword.Image = CType(resources.GetObject("btnPassword.Image"), System.Drawing.Image)
        Me.btnPassword.Location = New System.Drawing.Point(224, 141)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(66, 45)
        Me.btnPassword.TabIndex = 165
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "ConfirmPassword"
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
        Me.btnConfirmPassword.Location = New System.Drawing.Point(262, 106)
        Me.btnConfirmPassword.Name = "btnConfirmPassword"
        Me.btnConfirmPassword.Size = New System.Drawing.Size(29, 23)
        Me.btnConfirmPassword.TabIndex = 30
        Me.btnConfirmPassword.TabStop = False
        Me.btnConfirmPassword.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Location = New System.Drawing.Point(32, 104)
        Me.txtConfirmPassword.MaxLength = 17
        Me.txtConfirmPassword.Multiline = True
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(259, 27)
        Me.txtConfirmPassword.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "New Password"
        '
        'btnNewPassowrd
        '
        Me.btnNewPassowrd.BackColor = System.Drawing.Color.White
        Me.btnNewPassowrd.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNewPassowrd.FlatAppearance.BorderSize = 0
        Me.btnNewPassowrd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNewPassowrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnNewPassowrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPassowrd.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.visi
        Me.btnNewPassowrd.Location = New System.Drawing.Point(261, 44)
        Me.btnNewPassowrd.Name = "btnNewPassowrd"
        Me.btnNewPassowrd.Size = New System.Drawing.Size(29, 23)
        Me.btnNewPassowrd.TabIndex = 27
        Me.btnNewPassowrd.TabStop = False
        Me.btnNewPassowrd.UseVisualStyleBackColor = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Location = New System.Drawing.Point(32, 42)
        Me.txtNewPassword.MaxLength = 17
        Me.txtNewPassword.Multiline = True
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(259, 27)
        Me.txtNewPassword.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(359, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 41)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(349, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(23, 208)
        Me.Panel2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(368, 368)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 20)
        Me.Panel3.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(677, 176)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 208)
        Me.Panel4.TabIndex = 29
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(694, 489)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelLogo)
        Me.Controls.Add(Me.mainTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.panelLogo.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainTabControl.ResumeLayout(False)
        Me.pageUsername.ResumeLayout(False)
        Me.pageUsername.PerformLayout()
        Me.pageRecovery.ResumeLayout(False)
        Me.pageRecovery.PerformLayout()
        Me.pageNewPassword.ResumeLayout(False)
        Me.pageNewPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUsername As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents panelLogo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageUsername As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pageRecovery As TabPage
    Friend WithEvents pageNewPassword As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRecovery As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConfirmPassword As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewPassowrd As Button
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents labelRecovery As Label
End Class
