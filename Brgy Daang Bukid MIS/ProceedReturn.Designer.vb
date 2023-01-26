<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProceedReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProceedReturn))
        Me.labelReturnDate = New System.Windows.Forms.Label()
        Me.dateReturned = New System.Windows.Forms.DateTimePicker()
        Me.comboItemState = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtTransactionBy = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnReturnItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelReturnDate
        '
        Me.labelReturnDate.AutoSize = True
        Me.labelReturnDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelReturnDate.Location = New System.Drawing.Point(52, 306)
        Me.labelReturnDate.Name = "labelReturnDate"
        Me.labelReturnDate.Size = New System.Drawing.Size(150, 18)
        Me.labelReturnDate.TabIndex = 163
        Me.labelReturnDate.Text = "Date Returned*: "
        '
        'dateReturned
        '
        Me.dateReturned.CustomFormat = ""
        Me.dateReturned.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturned.Location = New System.Drawing.Point(258, 300)
        Me.dateReturned.Name = "dateReturned"
        Me.dateReturned.Size = New System.Drawing.Size(303, 26)
        Me.dateReturned.TabIndex = 162
        '
        'comboItemState
        '
        Me.comboItemState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboItemState.FormattingEnabled = True
        Me.comboItemState.Location = New System.Drawing.Point(258, 159)
        Me.comboItemState.Name = "comboItemState"
        Me.comboItemState.Size = New System.Drawing.Size(303, 28)
        Me.comboItemState.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Item State*: "
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(258, 207)
        Me.txtQuantity.MaxLength = 10000000
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(303, 27)
        Me.txtQuantity.TabIndex = 150
        Me.txtQuantity.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Quantity*: "
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Enabled = False
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.Location = New System.Drawing.Point(260, 342)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(303, 88)
        Me.txtReason.TabIndex = 152
        Me.txtReason.Tag = ""
        '
        'txtTransactionBy
        '
        Me.txtTransactionBy.BackColor = System.Drawing.Color.White
        Me.txtTransactionBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransactionBy.Enabled = False
        Me.txtTransactionBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionBy.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionBy.Location = New System.Drawing.Point(258, 255)
        Me.txtTransactionBy.MaxLength = 100
        Me.txtTransactionBy.Multiline = True
        Me.txtTransactionBy.Name = "txtTransactionBy"
        Me.txtTransactionBy.Size = New System.Drawing.Size(303, 27)
        Me.txtTransactionBy.TabIndex = 151
        Me.txtTransactionBy.Tag = ""
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.White
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.Location = New System.Drawing.Point(258, 108)
        Me.txtItemName.MaxLength = 100
        Me.txtItemName.Multiline = True
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(303, 27)
        Me.txtItemName.TabIndex = 147
        Me.txtItemName.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Reason: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Borrowed by*: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Item Name*: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(441, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 18)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Note: * Required "
        '
        'btnReturnItem
        '
        Me.btnReturnItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReturnItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReturnItem.FlatAppearance.BorderSize = 0
        Me.btnReturnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReturnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReturnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnItem.ForeColor = System.Drawing.Color.White
        Me.btnReturnItem.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnReturnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnItem.Location = New System.Drawing.Point(455, 483)
        Me.btnReturnItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReturnItem.Name = "btnReturnItem"
        Me.btnReturnItem.Size = New System.Drawing.Size(138, 41)
        Me.btnReturnItem.TabIndex = 164
        Me.btnReturnItem.TabStop = False
        Me.btnReturnItem.Text = "  Return Item"
        Me.btnReturnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReturnItem.UseVisualStyleBackColor = False
        '
        'ProceedReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 549)
        Me.Controls.Add(Me.btnReturnItem)
        Me.Controls.Add(Me.labelReturnDate)
        Me.Controls.Add(Me.dateReturned)
        Me.Controls.Add(Me.comboItemState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtTransactionBy)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ProceedReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelReturnDate As Label
    Friend WithEvents dateReturned As DateTimePicker
    Friend WithEvents comboItemState As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtTransactionBy As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnReturnItem As Button
End Class
