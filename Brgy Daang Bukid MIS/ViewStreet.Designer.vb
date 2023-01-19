<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStreet
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewStreet))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboTemp = New System.Windows.Forms.ComboBox()
        Me.labelPwd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelRegisteredVoters = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datagridHoseholds = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.labelStreetName = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.labelSeniors = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.labelFemale = New System.Windows.Forms.Label()
        Me.cnjkanfd = New System.Windows.Forms.Label()
        Me.labelMale = New System.Windows.Forms.Label()
        Me.fjdakfn = New System.Windows.Forms.Label()
        Me.labelResidents = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labelNoHousehold = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.labelUnemployed = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridHoseholds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel2.Size = New System.Drawing.Size(926, 551)
        Me.Panel2.TabIndex = 91
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 541)
        Me.TableLayoutPanel1.TabIndex = 90
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.labelUnemployed)
        Me.Panel1.Controls.Add(Me.comboTemp)
        Me.Panel1.Controls.Add(Me.labelPwd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.labelRegisteredVoters)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.datagridHoseholds)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label103)
        Me.Panel1.Controls.Add(Me.labelStreetName)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.labelSeniors)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.labelFemale)
        Me.Panel1.Controls.Add(Me.cnjkanfd)
        Me.Panel1.Controls.Add(Me.labelMale)
        Me.Panel1.Controls.Add(Me.fjdakfn)
        Me.Panel1.Controls.Add(Me.labelResidents)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.labelNoHousehold)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 535)
        Me.Panel1.TabIndex = 0
        '
        'comboTemp
        '
        Me.comboTemp.FormattingEnabled = True
        Me.comboTemp.Location = New System.Drawing.Point(502, 42)
        Me.comboTemp.Name = "comboTemp"
        Me.comboTemp.Size = New System.Drawing.Size(121, 21)
        Me.comboTemp.TabIndex = 123
        Me.comboTemp.Visible = False
        '
        'labelPwd
        '
        Me.labelPwd.AutoSize = True
        Me.labelPwd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPwd.Location = New System.Drawing.Point(727, 125)
        Me.labelPwd.Name = "labelPwd"
        Me.labelPwd.Size = New System.Drawing.Size(73, 18)
        Me.labelPwd.TabIndex = 122
        Me.labelPwd.Text = "BL10 L1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "PWDs: "
        '
        'labelRegisteredVoters
        '
        Me.labelRegisteredVoters.AutoSize = True
        Me.labelRegisteredVoters.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegisteredVoters.Location = New System.Drawing.Point(727, 95)
        Me.labelRegisteredVoters.Name = "labelRegisteredVoters"
        Me.labelRegisteredVoters.Size = New System.Drawing.Size(73, 18)
        Me.labelRegisteredVoters.TabIndex = 120
        Me.labelRegisteredVoters.Text = "BL10 L1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(499, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 18)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Registered Voters: "
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(868, 548)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 100)
        Me.Panel4.TabIndex = 118
        '
        'datagridHoseholds
        '
        Me.datagridHoseholds.AllowUserToAddRows = False
        Me.datagridHoseholds.AllowUserToDeleteRows = False
        Me.datagridHoseholds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridHoseholds.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridHoseholds.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridHoseholds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridHoseholds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridHoseholds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridHoseholds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridHoseholds.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridHoseholds.Location = New System.Drawing.Point(29, 276)
        Me.datagridHoseholds.Name = "datagridHoseholds"
        Me.datagridHoseholds.ReadOnly = True
        Me.datagridHoseholds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridHoseholds.Size = New System.Drawing.Size(830, 352)
        Me.datagridHoseholds.TabIndex = 115
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Household ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Household Head"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "House No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "HOUSEHOLD LIST"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(26, 45)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(124, 18)
        Me.Label103.TabIndex = 90
        Me.Label103.Text = "Street Name: "
        '
        'labelStreetName
        '
        Me.labelStreetName.AutoSize = True
        Me.labelStreetName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStreetName.Location = New System.Drawing.Point(254, 45)
        Me.labelStreetName.Name = "labelStreetName"
        Me.labelStreetName.Size = New System.Drawing.Size(68, 18)
        Me.labelStreetName.TabIndex = 91
        Me.labelStreetName.Text = "102314"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(499, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 18)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "Unemployed: "
        '
        'labelSeniors
        '
        Me.labelSeniors.AutoSize = True
        Me.labelSeniors.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSeniors.Location = New System.Drawing.Point(727, 152)
        Me.labelSeniors.Name = "labelSeniors"
        Me.labelSeniors.Size = New System.Drawing.Size(80, 18)
        Me.labelSeniors.TabIndex = 110
        Me.labelSeniors.Text = "Maynilad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(499, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 18)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Seniors: "
        '
        'labelFemale
        '
        Me.labelFemale.AutoSize = True
        Me.labelFemale.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFemale.Location = New System.Drawing.Point(254, 180)
        Me.labelFemale.Name = "labelFemale"
        Me.labelFemale.Size = New System.Drawing.Size(80, 18)
        Me.labelFemale.TabIndex = 108
        Me.labelFemale.Text = "Concrete"
        '
        'cnjkanfd
        '
        Me.cnjkanfd.AutoSize = True
        Me.cnjkanfd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnjkanfd.Location = New System.Drawing.Point(26, 180)
        Me.cnjkanfd.Name = "cnjkanfd"
        Me.cnjkanfd.Size = New System.Drawing.Size(79, 18)
        Me.cnjkanfd.TabIndex = 107
        Me.cnjkanfd.Text = "Female: "
        '
        'labelMale
        '
        Me.labelMale.AutoSize = True
        Me.labelMale.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMale.Location = New System.Drawing.Point(254, 152)
        Me.labelMale.Name = "labelMale"
        Me.labelMale.Size = New System.Drawing.Size(64, 18)
        Me.labelMale.TabIndex = 106
        Me.labelMale.Text = "Owned"
        '
        'fjdakfn
        '
        Me.fjdakfn.AutoSize = True
        Me.fjdakfn.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fjdakfn.Location = New System.Drawing.Point(26, 152)
        Me.fjdakfn.Name = "fjdakfn"
        Me.fjdakfn.Size = New System.Drawing.Size(57, 18)
        Me.fjdakfn.TabIndex = 105
        Me.fjdakfn.Text = "Male: "
        '
        'labelResidents
        '
        Me.labelResidents.AutoSize = True
        Me.labelResidents.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResidents.Location = New System.Drawing.Point(254, 125)
        Me.labelResidents.Name = "labelResidents"
        Me.labelResidents.Size = New System.Drawing.Size(137, 18)
        Me.labelResidents.TabIndex = 104
        Me.labelResidents.Text = "Dollar, Westbay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 18)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "No. of Residents: "
        '
        'labelNoHousehold
        '
        Me.labelNoHousehold.AutoSize = True
        Me.labelNoHousehold.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNoHousehold.Location = New System.Drawing.Point(254, 95)
        Me.labelNoHousehold.Name = "labelNoHousehold"
        Me.labelNoHousehold.Size = New System.Drawing.Size(73, 18)
        Me.labelNoHousehold.TabIndex = 102
        Me.labelNoHousehold.Text = "BL10 L1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 18)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "No. of Households: "
        '
        'labelUnemployed
        '
        Me.labelUnemployed.AutoSize = True
        Me.labelUnemployed.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUnemployed.Location = New System.Drawing.Point(727, 180)
        Me.labelUnemployed.Name = "labelUnemployed"
        Me.labelUnemployed.Size = New System.Drawing.Size(70, 18)
        Me.labelUnemployed.TabIndex = 124
        Me.labelUnemployed.Text = "Meralco"
        '
        'ViewStreet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 551)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewStreet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Street Information"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagridHoseholds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents comboTemp As ComboBox
    Friend WithEvents labelPwd As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelRegisteredVoters As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents datagridHoseholds As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents labelStreetName As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents labelSeniors As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents labelFemale As Label
    Friend WithEvents cnjkanfd As Label
    Friend WithEvents labelMale As Label
    Friend WithEvents fjdakfn As Label
    Friend WithEvents labelResidents As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents labelNoHousehold As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labelUnemployed As Label
End Class
