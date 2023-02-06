<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemBorrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemBorrow))
        Me.labelReturnDate = New System.Windows.Forms.Label()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchTransactionBy = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtTransactionBy = New System.Windows.Forms.TextBox()
        Me.txtStockItemName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBorrowItem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datePickerBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'labelReturnDate
        '
        Me.labelReturnDate.AutoSize = True
        Me.labelReturnDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelReturnDate.Location = New System.Drawing.Point(41, 317)
        Me.labelReturnDate.Name = "labelReturnDate"
        Me.labelReturnDate.Size = New System.Drawing.Size(130, 18)
        Me.labelReturnDate.TabIndex = 162
        Me.labelReturnDate.Text = "Return Date*: "
        '
        'dateReturn
        '
        Me.dateReturn.CustomFormat = ""
        Me.dateReturn.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Location = New System.Drawing.Point(247, 311)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(303, 26)
        Me.dateReturn.TabIndex = 161
        '
        'btnSearchTransactionBy
        '
        Me.btnSearchTransactionBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchTransactionBy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchTransactionBy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchTransactionBy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchTransactionBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTransactionBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTransactionBy.ForeColor = System.Drawing.Color.White
        Me.btnSearchTransactionBy.Image = CType(resources.GetObject("btnSearchTransactionBy.Image"), System.Drawing.Image)
        Me.btnSearchTransactionBy.Location = New System.Drawing.Point(556, 212)
        Me.btnSearchTransactionBy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchTransactionBy.Name = "btnSearchTransactionBy"
        Me.btnSearchTransactionBy.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchTransactionBy.TabIndex = 160
        Me.btnSearchTransactionBy.TabStop = False
        Me.btnSearchTransactionBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchTransactionBy.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(247, 164)
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
        Me.Label12.Location = New System.Drawing.Point(41, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Quantity*: "
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.White
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.Black
        Me.txtReason.Location = New System.Drawing.Point(247, 361)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(303, 117)
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
        Me.txtTransactionBy.Location = New System.Drawing.Point(247, 212)
        Me.txtTransactionBy.MaxLength = 100
        Me.txtTransactionBy.Multiline = True
        Me.txtTransactionBy.Name = "txtTransactionBy"
        Me.txtTransactionBy.Size = New System.Drawing.Size(303, 27)
        Me.txtTransactionBy.TabIndex = 151
        Me.txtTransactionBy.Tag = ""
        '
        'txtStockItemName
        '
        Me.txtStockItemName.BackColor = System.Drawing.Color.White
        Me.txtStockItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockItemName.Enabled = False
        Me.txtStockItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockItemName.ForeColor = System.Drawing.Color.Black
        Me.txtStockItemName.Location = New System.Drawing.Point(247, 115)
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
        Me.Label2.Location = New System.Drawing.Point(39, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Reason: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 18)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Transaction by*: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Item Name*: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(440, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 18)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Note: * Required "
        '
        'btnBorrowItem
        '
        Me.btnBorrowItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnBorrowItem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBorrowItem.FlatAppearance.BorderSize = 0
        Me.btnBorrowItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBorrowItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBorrowItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowItem.ForeColor = System.Drawing.Color.White
        Me.btnBorrowItem.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnBorrowItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowItem.Location = New System.Drawing.Point(454, 530)
        Me.btnBorrowItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBorrowItem.Name = "btnBorrowItem"
        Me.btnBorrowItem.Size = New System.Drawing.Size(138, 41)
        Me.btnBorrowItem.TabIndex = 164
        Me.btnBorrowItem.TabStop = False
        Me.btnBorrowItem.Text = "  Borrow Item"
        Me.btnBorrowItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowItem.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Borrowed Date*: "
        '
        'datePickerBorrowed
        '
        Me.datePickerBorrowed.CustomFormat = ""
        Me.datePickerBorrowed.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerBorrowed.Location = New System.Drawing.Point(247, 261)
        Me.datePickerBorrowed.Name = "datePickerBorrowed"
        Me.datePickerBorrowed.Size = New System.Drawing.Size(303, 26)
        Me.datePickerBorrowed.TabIndex = 165
        '
        'ItemBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 580)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datePickerBorrowed)
        Me.Controls.Add(Me.btnBorrowItem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.labelReturnDate)
        Me.Controls.Add(Me.dateReturn)
        Me.Controls.Add(Me.btnSearchTransactionBy)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtTransactionBy)
        Me.Controls.Add(Me.txtStockItemName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ItemBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Borrow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelReturnDate As Label
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents btnSearchTransactionBy As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtTransactionBy As TextBox
    Friend WithEvents txtStockItemName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBorrowItem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents datePickerBorrowed As DateTimePicker
End Class
