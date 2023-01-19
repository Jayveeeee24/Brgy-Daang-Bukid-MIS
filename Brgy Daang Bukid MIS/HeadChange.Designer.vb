<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadChange))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelHouseholdId = New System.Windows.Forms.Label()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelBirthdate = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(428, 18)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "You are about to archive the head in this household"
        '
        'labelHouseholdId
        '
        Me.labelHouseholdId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHouseholdId.Location = New System.Drawing.Point(30, 66)
        Me.labelHouseholdId.Name = "labelHouseholdId"
        Me.labelHouseholdId.Size = New System.Drawing.Size(411, 27)
        Me.labelHouseholdId.TabIndex = 108
        Me.labelHouseholdId.Text = "12345"
        Me.labelHouseholdId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelAddress
        '
        Me.labelAddress.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAddress.Location = New System.Drawing.Point(30, 93)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(411, 25)
        Me.labelAddress.TabIndex = 109
        Me.labelAddress.Text = "Yen, Westbay"
        Me.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Would you like to pass the head to:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelBirthdate
        '
        Me.labelBirthdate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBirthdate.Location = New System.Drawing.Point(30, 214)
        Me.labelBirthdate.Name = "labelBirthdate"
        Me.labelBirthdate.Size = New System.Drawing.Size(411, 25)
        Me.labelBirthdate.TabIndex = 112
        Me.labelBirthdate.Text = "birthdate"
        Me.labelBirthdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelName
        '
        Me.labelName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.Location = New System.Drawing.Point(30, 187)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(411, 27)
        Me.labelName.TabIndex = 111
        Me.labelName.Text = "name"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProceed.Location = New System.Drawing.Point(119, 271)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(96, 37)
        Me.btnProceed.TabIndex = 113
        Me.btnProceed.TabStop = False
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(248, 271)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 37)
        Me.btnCancel.TabIndex = 114
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'HeadChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 334)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.labelBirthdate)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.labelHouseholdId)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HeadChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Household Head Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents labelHouseholdId As Label
    Friend WithEvents labelAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelBirthdate As Label
    Friend WithEvents labelName As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnCancel As Button
End Class
