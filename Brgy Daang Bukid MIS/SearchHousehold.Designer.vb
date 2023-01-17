<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchHousehold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchHousehold))
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchResidents = New System.Windows.Forms.Button()
        Me.txtSearchResidents = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 2
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.btnSearchResidents, 1, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.txtSearchResidents, 0, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel19.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel19.RowCount = 1
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(959, 43)
        Me.TableLayoutPanel19.TabIndex = 2
        '
        'btnSearchResidents
        '
        Me.btnSearchResidents.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnSearchResidents.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearchResidents.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchResidents.FlatAppearance.BorderSize = 0
        Me.btnSearchResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchResidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchResidents.ForeColor = System.Drawing.Color.White
        Me.btnSearchResidents.Image = CType(resources.GetObject("btnSearchResidents.Image"), System.Drawing.Image)
        Me.btnSearchResidents.Location = New System.Drawing.Point(914, 8)
        Me.btnSearchResidents.Name = "btnSearchResidents"
        Me.btnSearchResidents.Size = New System.Drawing.Size(37, 27)
        Me.btnSearchResidents.TabIndex = 16
        Me.btnSearchResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchResidents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchResidents.UseVisualStyleBackColor = False
        '
        'txtSearchResidents
        '
        Me.txtSearchResidents.BackColor = System.Drawing.Color.White
        Me.txtSearchResidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchResidents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResidents.ForeColor = System.Drawing.Color.Black
        Me.txtSearchResidents.Location = New System.Drawing.Point(8, 8)
        Me.txtSearchResidents.MaxLength = 50
        Me.txtSearchResidents.Multiline = True
        Me.txtSearchResidents.Name = "txtSearchResidents"
        Me.txtSearchResidents.Size = New System.Drawing.Size(876, 27)
        Me.txtSearchResidents.TabIndex = 12
        Me.txtSearchResidents.Text = "Search by household id or resident name"
        '
        'SearchHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 531)
        Me.Controls.Add(Me.TableLayoutPanel19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchHousehold"
        Me.Text = "Search Household"
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents btnSearchResidents As Button
    Friend WithEvents txtSearchResidents As TextBox
End Class
