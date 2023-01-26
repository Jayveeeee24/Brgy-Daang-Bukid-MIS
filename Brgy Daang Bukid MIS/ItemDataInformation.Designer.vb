<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDataInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemDataInformation))
        Me.txtItemSerial = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtItemColor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboReason = New System.Windows.Forms.ComboBox()
        Me.labelReason = New System.Windows.Forms.Label()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.labelId = New System.Windows.Forms.Label()
        Me.comboItemStatus = New System.Windows.Forms.ComboBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.labelDateAdded = New System.Windows.Forms.Label()
        Me.datePickerAdded = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtItemSerial
        '
        Me.txtItemSerial.BackColor = System.Drawing.Color.White
        Me.txtItemSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSerial.ForeColor = System.Drawing.Color.Black
        Me.txtItemSerial.Location = New System.Drawing.Point(271, 227)
        Me.txtItemSerial.MaxLength = 100
        Me.txtItemSerial.Multiline = True
        Me.txtItemSerial.Name = "txtItemSerial"
        Me.txtItemSerial.Size = New System.Drawing.Size(303, 27)
        Me.txtItemSerial.TabIndex = 146
        Me.txtItemSerial.Tag = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 18)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "Item Serial: "
        '
        'txtItemColor
        '
        Me.txtItemColor.BackColor = System.Drawing.Color.White
        Me.txtItemColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemColor.ForeColor = System.Drawing.Color.Black
        Me.txtItemColor.Location = New System.Drawing.Point(271, 180)
        Me.txtItemColor.MaxLength = 100
        Me.txtItemColor.Multiline = True
        Me.txtItemColor.Name = "txtItemColor"
        Me.txtItemColor.Size = New System.Drawing.Size(303, 27)
        Me.txtItemColor.TabIndex = 145
        Me.txtItemColor.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Item Color: "
        '
        'comboReason
        '
        Me.comboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboReason.Enabled = False
        Me.comboReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboReason.FormattingEnabled = True
        Me.comboReason.Location = New System.Drawing.Point(271, 325)
        Me.comboReason.Name = "comboReason"
        Me.comboReason.Size = New System.Drawing.Size(303, 28)
        Me.comboReason.TabIndex = 148
        '
        'labelReason
        '
        Me.labelReason.AutoSize = True
        Me.labelReason.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelReason.Location = New System.Drawing.Point(36, 329)
        Me.labelReason.Name = "labelReason"
        Me.labelReason.Size = New System.Drawing.Size(91, 18)
        Me.labelReason.TabIndex = 155
        Me.labelReason.Text = "Reason*: "
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.White
        Me.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.ForeColor = System.Drawing.Color.Black
        Me.txtItemId.Location = New System.Drawing.Point(271, 89)
        Me.txtItemId.MaxLength = 100
        Me.txtItemId.Multiline = True
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(303, 27)
        Me.txtItemId.TabIndex = 143
        Me.txtItemId.Tag = ""
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(36, 94)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(96, 18)
        Me.labelId.TabIndex = 154
        Me.labelId.Text = "Item ID*: "
        '
        'comboItemStatus
        '
        Me.comboItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboItemStatus.FormattingEnabled = True
        Me.comboItemStatus.Items.AddRange(New Object() {"Unavailable", "Available"})
        Me.comboItemStatus.Location = New System.Drawing.Point(271, 277)
        Me.comboItemStatus.Name = "comboItemStatus"
        Me.comboItemStatus.Size = New System.Drawing.Size(303, 28)
        Me.comboItemStatus.TabIndex = 147
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(271, 418)
        Me.txtRemarks.MaxLength = 150
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(303, 111)
        Me.txtRemarks.TabIndex = 149
        Me.txtRemarks.Tag = ""
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.White
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.Location = New System.Drawing.Point(271, 134)
        Me.txtItemName.MaxLength = 100
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(303, 27)
        Me.txtItemName.TabIndex = 144
        Me.txtItemName.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(36, 421)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(93, 18)
        Me.Label32.TabIndex = 153
        Me.Label32.Text = "Remarks: "
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatus.Location = New System.Drawing.Point(36, 284)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(130, 18)
        Me.labelStatus.TabIndex = 152
        Me.labelStatus.Text = "Item Status*: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 18)
        Me.Label20.TabIndex = 151
        Me.Label20.Text = "Item Name*: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(439, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Note: * Required "
        '
        'btnSaveItem
        '
        Me.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveItem.FlatAppearance.BorderSize = 0
        Me.btnSaveItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveItem.ForeColor = System.Drawing.Color.White
        Me.btnSaveItem.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveItem.Location = New System.Drawing.Point(459, 558)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(115, 43)
        Me.btnSaveItem.TabIndex = 158
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "  Save Item"
        Me.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveItem.UseVisualStyleBackColor = False
        '
        'labelDateAdded
        '
        Me.labelDateAdded.AutoSize = True
        Me.labelDateAdded.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDateAdded.Location = New System.Drawing.Point(36, 376)
        Me.labelDateAdded.Name = "labelDateAdded"
        Me.labelDateAdded.Size = New System.Drawing.Size(126, 18)
        Me.labelDateAdded.TabIndex = 160
        Me.labelDateAdded.Text = "Date Added*: "
        '
        'datePickerAdded
        '
        Me.datePickerAdded.CustomFormat = ""
        Me.datePickerAdded.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerAdded.Location = New System.Drawing.Point(271, 370)
        Me.datePickerAdded.Name = "datePickerAdded"
        Me.datePickerAdded.Size = New System.Drawing.Size(303, 26)
        Me.datePickerAdded.TabIndex = 159
        Me.datePickerAdded.Visible = False
        '
        'ItemDataInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 610)
        Me.Controls.Add(Me.labelDateAdded)
        Me.Controls.Add(Me.datePickerAdded)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Controls.Add(Me.txtItemSerial)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtItemColor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.comboReason)
        Me.Controls.Add(Me.labelReason)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.labelId)
        Me.Controls.Add(Me.comboItemStatus)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ItemDataInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Data Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemSerial As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtItemColor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents comboReason As ComboBox
    Friend WithEvents labelReason As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents labelId As Label
    Friend WithEvents comboItemStatus As ComboBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents labelStatus As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSaveItem As Button
    Friend WithEvents labelDateAdded As Label
    Friend WithEvents datePickerAdded As DateTimePicker
End Class
