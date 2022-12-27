<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmAccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmAccess))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReasonForArchived = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAccountName = New System.Windows.Forms.Label()
        Me.btnConfirmAccess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.TabPage1)
        Me.mainTabControl.Controls.Add(Me.TabPage2)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(469, 256)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 102
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtReasonForArchived)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(461, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(175, 144)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 48)
        Me.btnNext.TabIndex = 107
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "      Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Reason for Archive (optional): "
        '
        'txtReasonForArchived
        '
        Me.txtReasonForArchived.BackColor = System.Drawing.Color.White
        Me.txtReasonForArchived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReasonForArchived.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReasonForArchived.ForeColor = System.Drawing.Color.Black
        Me.txtReasonForArchived.Location = New System.Drawing.Point(58, 88)
        Me.txtReasonForArchived.MaxLength = 100
        Me.txtReasonForArchived.Multiline = True
        Me.txtReasonForArchived.Name = "txtReasonForArchived"
        Me.txtReasonForArchived.Size = New System.Drawing.Size(354, 27)
        Me.txtReasonForArchived.TabIndex = 105
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAccountName)
        Me.TabPage2.Controls.Add(Me.btnConfirmAccess)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.labelHousehold)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(461, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAccountName
        '
        Me.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(171, 68)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(268, 29)
        Me.txtAccountName.TabIndex = 107
        Me.txtAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConfirmAccess
        '
        Me.btnConfirmAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnConfirmAccess.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirmAccess.FlatAppearance.BorderSize = 0
        Me.btnConfirmAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnConfirmAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnConfirmAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAccess.ForeColor = System.Drawing.Color.White
        Me.btnConfirmAccess.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnConfirmAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmAccess.Location = New System.Drawing.Point(152, 167)
        Me.btnConfirmAccess.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirmAccess.Name = "btnConfirmAccess"
        Me.btnConfirmAccess.Size = New System.Drawing.Size(146, 41)
        Me.btnConfirmAccess.TabIndex = 106
        Me.btnConfirmAccess.TabStop = False
        Me.btnConfirmAccess.Text = "  Confirm Access"
        Me.btnConfirmAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmAccess.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 23)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "GRANT ACCESS TO PROCEED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Password*: "
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(171, 119)
        Me.txtPassword.MaxLength = 100
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(268, 27)
        Me.txtPassword.TabIndex = 103
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(21, 73)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(124, 18)
        Me.labelHousehold.TabIndex = 102
        Me.labelHousehold.Text = "Granting as*: "
        '
        'ConfirmAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 256)
        Me.Controls.Add(Me.mainTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfirmAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConfirmAccess"
        Me.mainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnNext As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReasonForArchived As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAccountName As Label
    Friend WithEvents btnConfirmAccess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents labelHousehold As Label
End Class
