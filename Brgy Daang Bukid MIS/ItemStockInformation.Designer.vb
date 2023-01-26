<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemStockInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemStockInformation))
        Me.labelReturnDate = New System.Windows.Forms.Label()
        Me.dateStock = New System.Windows.Forms.DateTimePicker()
        Me.comboItemState = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtStockItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransactionType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelReturnDate
        '
        Me.labelReturnDate.AutoSize = True
        Me.labelReturnDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelReturnDate.Location = New System.Drawing.Point(49, 327)
        Me.labelReturnDate.Name = "labelReturnDate"
        Me.labelReturnDate.Size = New System.Drawing.Size(69, 18)
        Me.labelReturnDate.TabIndex = 160
        Me.labelReturnDate.Text = "Date*: "
        '
        'dateStock
        '
        Me.dateStock.CustomFormat = ""
        Me.dateStock.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateStock.Location = New System.Drawing.Point(255, 321)
        Me.dateStock.Name = "dateStock"
        Me.dateStock.Size = New System.Drawing.Size(303, 26)
        Me.dateStock.TabIndex = 159
        '
        'comboItemState
        '
        Me.comboItemState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboItemState.FormattingEnabled = True
        Me.comboItemState.Location = New System.Drawing.Point(255, 224)
        Me.comboItemState.Name = "comboItemState"
        Me.comboItemState.Size = New System.Drawing.Size(303, 28)
        Me.comboItemState.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Item State*: "
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(255, 271)
        Me.txtQuantity.MaxLength = 100000000
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
        Me.Label12.Location = New System.Drawing.Point(49, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Quantity*: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 18)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Transaction type*: "
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.Location = New System.Drawing.Point(255, 368)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(303, 106)
        Me.txtReason.TabIndex = 152
        Me.txtReason.Tag = ""
        '
        'txtStockItemName
        '
        Me.txtStockItemName.BackColor = System.Drawing.Color.White
        Me.txtStockItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockItemName.Enabled = False
        Me.txtStockItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockItemName.ForeColor = System.Drawing.Color.Black
        Me.txtStockItemName.Location = New System.Drawing.Point(255, 132)
        Me.txtStockItemName.MaxLength = 100
        Me.txtStockItemName.Multiline = True
        Me.txtStockItemName.Name = "txtStockItemName"
        Me.txtStockItemName.Size = New System.Drawing.Size(303, 27)
        Me.txtStockItemName.TabIndex = 147
        Me.txtStockItemName.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Reason: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Item Name*: "
        '
        'txtTransactionType
        '
        Me.txtTransactionType.BackColor = System.Drawing.Color.White
        Me.txtTransactionType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransactionType.Enabled = False
        Me.txtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionType.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionType.Location = New System.Drawing.Point(255, 179)
        Me.txtTransactionType.MaxLength = 100
        Me.txtTransactionType.Multiline = True
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.Size = New System.Drawing.Size(303, 27)
        Me.txtTransactionType.TabIndex = 161
        Me.txtTransactionType.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(438, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 18)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Note: * Required "
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdateStock.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateStock.FlatAppearance.BorderSize = 0
        Me.btnUpdateStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnUpdateStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStock.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStock.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStock.Location = New System.Drawing.Point(453, 549)
        Me.btnUpdateStock.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(138, 41)
        Me.btnUpdateStock.TabIndex = 164
        Me.btnUpdateStock.TabStop = False
        Me.btnUpdateStock.Text = "  Update Stock"
        Me.btnUpdateStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'ItemStockInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 610)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTransactionType)
        Me.Controls.Add(Me.labelReturnDate)
        Me.Controls.Add(Me.dateStock)
        Me.Controls.Add(Me.comboItemState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtStockItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ItemStockInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Stock Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelReturnDate As Label
    Friend WithEvents dateStock As DateTimePicker
    Friend WithEvents comboItemState As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtStockItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTransactionType As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnUpdateStock As Button
End Class
