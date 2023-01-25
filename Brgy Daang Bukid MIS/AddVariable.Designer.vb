<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVariable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVariable))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageAdd = New System.Windows.Forms.TabPage()
        Me.txtAddVariableName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelAddVariableCategory = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddVariable = New System.Windows.Forms.Button()
        Me.pageModify = New System.Windows.Forms.TabPage()
        Me.txtModifyVariableName = New System.Windows.Forms.TextBox()
        Me.btnModifyVariable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelModifyVariableCategory = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.pageAdd.SuspendLayout()
        Me.pageModify.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageAdd)
        Me.mainTabControl.Controls.Add(Me.pageModify)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(559, 275)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 103
        '
        'pageAdd
        '
        Me.pageAdd.Controls.Add(Me.txtAddVariableName)
        Me.pageAdd.Controls.Add(Me.Label5)
        Me.pageAdd.Controls.Add(Me.labelAddVariableCategory)
        Me.pageAdd.Controls.Add(Me.Label4)
        Me.pageAdd.Controls.Add(Me.btnAddVariable)
        Me.pageAdd.Location = New System.Drawing.Point(4, 22)
        Me.pageAdd.Name = "pageAdd"
        Me.pageAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.pageAdd.Size = New System.Drawing.Size(551, 249)
        Me.pageAdd.TabIndex = 0
        Me.pageAdd.Text = "TabPage1"
        Me.pageAdd.UseVisualStyleBackColor = True
        '
        'txtAddVariableName
        '
        Me.txtAddVariableName.BackColor = System.Drawing.Color.White
        Me.txtAddVariableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddVariableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddVariableName.ForeColor = System.Drawing.Color.Black
        Me.txtAddVariableName.Location = New System.Drawing.Point(195, 57)
        Me.txtAddVariableName.MaxLength = 100
        Me.txtAddVariableName.Multiline = True
        Me.txtAddVariableName.Name = "txtAddVariableName"
        Me.txtAddVariableName.Size = New System.Drawing.Size(329, 27)
        Me.txtAddVariableName.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Category*: "
        '
        'labelAddVariableCategory
        '
        Me.labelAddVariableCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelAddVariableCategory.Enabled = False
        Me.labelAddVariableCategory.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAddVariableCategory.Location = New System.Drawing.Point(195, 110)
        Me.labelAddVariableCategory.Name = "labelAddVariableCategory"
        Me.labelAddVariableCategory.Size = New System.Drawing.Size(329, 29)
        Me.labelAddVariableCategory.TabIndex = 173
        Me.labelAddVariableCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Variable Name*: "
        '
        'btnAddVariable
        '
        Me.btnAddVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddVariable.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAddVariable.FlatAppearance.BorderSize = 0
        Me.btnAddVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnAddVariable.ForeColor = System.Drawing.Color.White
        Me.btnAddVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddVariable.Location = New System.Drawing.Point(209, 188)
        Me.btnAddVariable.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnAddVariable.Name = "btnAddVariable"
        Me.btnAddVariable.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAddVariable.Size = New System.Drawing.Size(146, 41)
        Me.btnAddVariable.TabIndex = 170
        Me.btnAddVariable.TabStop = False
        Me.btnAddVariable.Text = "Add Variable"
        Me.btnAddVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddVariable.UseVisualStyleBackColor = False
        '
        'pageModify
        '
        Me.pageModify.Controls.Add(Me.txtModifyVariableName)
        Me.pageModify.Controls.Add(Me.btnModifyVariable)
        Me.pageModify.Controls.Add(Me.Label1)
        Me.pageModify.Controls.Add(Me.labelModifyVariableCategory)
        Me.pageModify.Controls.Add(Me.Label7)
        Me.pageModify.Location = New System.Drawing.Point(4, 22)
        Me.pageModify.Name = "pageModify"
        Me.pageModify.Padding = New System.Windows.Forms.Padding(3)
        Me.pageModify.Size = New System.Drawing.Size(551, 249)
        Me.pageModify.TabIndex = 1
        Me.pageModify.Text = "TabPage2"
        Me.pageModify.UseVisualStyleBackColor = True
        '
        'txtModifyVariableName
        '
        Me.txtModifyVariableName.BackColor = System.Drawing.Color.White
        Me.txtModifyVariableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModifyVariableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModifyVariableName.ForeColor = System.Drawing.Color.Black
        Me.txtModifyVariableName.Location = New System.Drawing.Point(195, 61)
        Me.txtModifyVariableName.MaxLength = 100
        Me.txtModifyVariableName.Multiline = True
        Me.txtModifyVariableName.Name = "txtModifyVariableName"
        Me.txtModifyVariableName.Size = New System.Drawing.Size(329, 27)
        Me.txtModifyVariableName.TabIndex = 181
        '
        'btnModifyVariable
        '
        Me.btnModifyVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyVariable.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnModifyVariable.FlatAppearance.BorderSize = 0
        Me.btnModifyVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnModifyVariable.ForeColor = System.Drawing.Color.White
        Me.btnModifyVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyVariable.Location = New System.Drawing.Point(207, 184)
        Me.btnModifyVariable.Margin = New System.Windows.Forms.Padding(7, 3, 5, 3)
        Me.btnModifyVariable.Name = "btnModifyVariable"
        Me.btnModifyVariable.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnModifyVariable.Size = New System.Drawing.Size(146, 41)
        Me.btnModifyVariable.TabIndex = 180
        Me.btnModifyVariable.TabStop = False
        Me.btnModifyVariable.Text = "Modify Variable"
        Me.btnModifyVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyVariable.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Category*: "
        '
        'labelModifyVariableCategory
        '
        Me.labelModifyVariableCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelModifyVariableCategory.Enabled = False
        Me.labelModifyVariableCategory.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelModifyVariableCategory.Location = New System.Drawing.Point(195, 114)
        Me.labelModifyVariableCategory.Name = "labelModifyVariableCategory"
        Me.labelModifyVariableCategory.Size = New System.Drawing.Size(329, 29)
        Me.labelModifyVariableCategory.TabIndex = 178
        Me.labelModifyVariableCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 18)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = "Variable Name*: "
        '
        'AddVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 275)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Variable"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageAdd.ResumeLayout(False)
        Me.pageAdd.PerformLayout()
        Me.pageModify.ResumeLayout(False)
        Me.pageModify.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageAdd As TabPage
    Friend WithEvents pageModify As TabPage
    Friend WithEvents btnAddVariable As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelModifyVariableCategory As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnModifyVariable As Button
    Friend WithEvents txtAddVariableName As TextBox
    Friend WithEvents labelAddVariableCategory As Label
    Friend WithEvents txtModifyVariableName As TextBox
End Class
