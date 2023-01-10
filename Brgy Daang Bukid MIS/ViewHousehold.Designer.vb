<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewHousehold
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewHousehold))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageViewHousehold = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelDateAdded = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datagridViewHousehold = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.labelElectricitySource = New System.Windows.Forms.Label()
        Me.labelHouseholdId = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelWaterSource = New System.Windows.Forms.Label()
        Me.labelHeadFirstName = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelHousetype = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.labelHeadMiddleName = New System.Windows.Forms.Label()
        Me.labelResidenceType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.labelHeadLastName = New System.Windows.Forms.Label()
        Me.labelStreetName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labelHeadExtName = New System.Windows.Forms.Label()
        Me.labelBldgNo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnModifyHousehold = New System.Windows.Forms.Button()
        Me.pageModifyHousehold = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveHousehold = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelParent = New System.Windows.Forms.Panel()
        Me.comboResidentId = New System.Windows.Forms.ComboBox()
        Me.txtHouseholdId = New System.Windows.Forms.TextBox()
        Me.comboHouseholdHead = New System.Windows.Forms.ComboBox()
        Me.labelHouseholdHead = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.comboHouseType = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtElectricitySource = New System.Windows.Forms.TextBox()
        Me.txtWaterSource = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBldgNo = New System.Windows.Forms.TextBox()
        Me.comboResidenceType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelHousehold = New System.Windows.Forms.Label()
        Me.comboStreetName = New System.Windows.Forms.ComboBox()
        Me.mainTabControl.SuspendLayout()
        Me.pageViewHousehold.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridViewHousehold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageModifyHousehold.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panelParent.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageViewHousehold)
        Me.mainTabControl.Controls.Add(Me.pageModifyHousehold)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(926, 551)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 0
        '
        'pageViewHousehold
        '
        Me.pageViewHousehold.BackColor = System.Drawing.SystemColors.Control
        Me.pageViewHousehold.Controls.Add(Me.Panel2)
        Me.pageViewHousehold.Location = New System.Drawing.Point(4, 22)
        Me.pageViewHousehold.Name = "pageViewHousehold"
        Me.pageViewHousehold.Padding = New System.Windows.Forms.Padding(3)
        Me.pageViewHousehold.Size = New System.Drawing.Size(918, 525)
        Me.pageViewHousehold.TabIndex = 0
        Me.pageViewHousehold.Text = "View Household"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel2.Size = New System.Drawing.Size(912, 519)
        Me.Panel2.TabIndex = 90
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label104, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnModifyHousehold, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.251473!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.30059!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.447937!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(892, 509)
        Me.TableLayoutPanel1.TabIndex = 90
        '
        'Label104
        '
        Me.Label104.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label104.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(3, 0)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(886, 42)
        Me.Label104.TabIndex = 72
        Me.Label104.Text = "HOUSEHOLD INFORMATION"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.labelDateAdded)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.datagridViewHousehold)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label103)
        Me.Panel1.Controls.Add(Me.labelElectricitySource)
        Me.Panel1.Controls.Add(Me.labelHouseholdId)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.labelWaterSource)
        Me.Panel1.Controls.Add(Me.labelHeadFirstName)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.labelHousetype)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.labelHeadMiddleName)
        Me.Panel1.Controls.Add(Me.labelResidenceType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.labelHeadLastName)
        Me.Panel1.Controls.Add(Me.labelStreetName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.labelHeadExtName)
        Me.Panel1.Controls.Add(Me.labelBldgNo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 418)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(855, 600)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 100)
        Me.Panel4.TabIndex = 118
        '
        'labelDateAdded
        '
        Me.labelDateAdded.AutoSize = True
        Me.labelDateAdded.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDateAdded.Location = New System.Drawing.Point(693, 237)
        Me.labelDateAdded.Name = "labelDateAdded"
        Me.labelDateAdded.Size = New System.Drawing.Size(138, 18)
        Me.labelDateAdded.TabIndex = 117
        Me.labelDateAdded.Text = "January 1, 2023"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Date Added: "
        '
        'datagridViewHousehold
        '
        Me.datagridViewHousehold.AllowUserToAddRows = False
        Me.datagridViewHousehold.AllowUserToDeleteRows = False
        Me.datagridViewHousehold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridViewHousehold.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridViewHousehold.BackgroundColor = System.Drawing.SystemColors.Control
        Me.datagridViewHousehold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridViewHousehold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridViewHousehold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridViewHousehold.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridViewHousehold.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridViewHousehold.Location = New System.Drawing.Point(19, 325)
        Me.datagridViewHousehold.Name = "datagridViewHousehold"
        Me.datagridViewHousehold.ReadOnly = True
        Me.datagridViewHousehold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridViewHousehold.Size = New System.Drawing.Size(830, 352)
        Me.datagridViewHousehold.TabIndex = 115
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Household Role"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "MEMBERS LIST"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(34, 25)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(129, 18)
        Me.Label103.TabIndex = 90
        Me.Label103.Text = "Household ID: "
        '
        'labelElectricitySource
        '
        Me.labelElectricitySource.AutoSize = True
        Me.labelElectricitySource.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelElectricitySource.Location = New System.Drawing.Point(262, 237)
        Me.labelElectricitySource.Name = "labelElectricitySource"
        Me.labelElectricitySource.Size = New System.Drawing.Size(70, 18)
        Me.labelElectricitySource.TabIndex = 112
        Me.labelElectricitySource.Text = "Meralco"
        '
        'labelHouseholdId
        '
        Me.labelHouseholdId.AutoSize = True
        Me.labelHouseholdId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHouseholdId.Location = New System.Drawing.Point(262, 25)
        Me.labelHouseholdId.Name = "labelHouseholdId"
        Me.labelHouseholdId.Size = New System.Drawing.Size(68, 18)
        Me.labelHouseholdId.TabIndex = 91
        Me.labelHouseholdId.Text = "102314"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(34, 237)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(159, 18)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "Electricity Source: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "First Name: "
        '
        'labelWaterSource
        '
        Me.labelWaterSource.AutoSize = True
        Me.labelWaterSource.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWaterSource.Location = New System.Drawing.Point(262, 209)
        Me.labelWaterSource.Name = "labelWaterSource"
        Me.labelWaterSource.Size = New System.Drawing.Size(80, 18)
        Me.labelWaterSource.TabIndex = 110
        Me.labelWaterSource.Text = "Maynilad"
        '
        'labelHeadFirstName
        '
        Me.labelHeadFirstName.AutoSize = True
        Me.labelHeadFirstName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHeadFirstName.Location = New System.Drawing.Point(693, 109)
        Me.labelHeadFirstName.Name = "labelHeadFirstName"
        Me.labelHeadFirstName.Size = New System.Drawing.Size(54, 18)
        Me.labelHeadFirstName.TabIndex = 93
        Me.labelHeadFirstName.Text = "Jopay"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 18)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Water Souce: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Household Head "
        '
        'labelHousetype
        '
        Me.labelHousetype.AutoSize = True
        Me.labelHousetype.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousetype.Location = New System.Drawing.Point(262, 160)
        Me.labelHousetype.Name = "labelHousetype"
        Me.labelHousetype.Size = New System.Drawing.Size(80, 18)
        Me.labelHousetype.TabIndex = 108
        Me.labelHousetype.Text = "Concrete"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Middle Name: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 18)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "House Type: "
        '
        'labelHeadMiddleName
        '
        Me.labelHeadMiddleName.AutoSize = True
        Me.labelHeadMiddleName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHeadMiddleName.Location = New System.Drawing.Point(693, 136)
        Me.labelHeadMiddleName.Name = "labelHeadMiddleName"
        Me.labelHeadMiddleName.Size = New System.Drawing.Size(80, 18)
        Me.labelHeadMiddleName.TabIndex = 96
        Me.labelHeadMiddleName.Text = "Kamusta"
        '
        'labelResidenceType
        '
        Me.labelResidenceType.AutoSize = True
        Me.labelResidenceType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelResidenceType.Location = New System.Drawing.Point(262, 132)
        Me.labelResidenceType.Name = "labelResidenceType"
        Me.labelResidenceType.Size = New System.Drawing.Size(64, 18)
        Me.labelResidenceType.TabIndex = 106
        Me.labelResidenceType.Text = "Owned"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(465, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 18)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Last Name: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 18)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "Residence Type: "
        '
        'labelHeadLastName
        '
        Me.labelHeadLastName.AutoSize = True
        Me.labelHeadLastName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHeadLastName.Location = New System.Drawing.Point(693, 164)
        Me.labelHeadLastName.Name = "labelHeadLastName"
        Me.labelHeadLastName.Size = New System.Drawing.Size(29, 18)
        Me.labelHeadLastName.TabIndex = 98
        Me.labelHeadLastName.Text = "Ka"
        '
        'labelStreetName
        '
        Me.labelStreetName.AutoSize = True
        Me.labelStreetName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStreetName.Location = New System.Drawing.Point(262, 105)
        Me.labelStreetName.Name = "labelStreetName"
        Me.labelStreetName.Size = New System.Drawing.Size(137, 18)
        Me.labelStreetName.TabIndex = 104
        Me.labelStreetName.Text = "Dollar, Westbay"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(465, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 18)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Extension Name: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 18)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Street Name: "
        '
        'labelHeadExtName
        '
        Me.labelHeadExtName.AutoSize = True
        Me.labelHeadExtName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHeadExtName.Location = New System.Drawing.Point(693, 192)
        Me.labelHeadExtName.Name = "labelHeadExtName"
        Me.labelHeadExtName.Size = New System.Drawing.Size(30, 18)
        Me.labelHeadExtName.TabIndex = 100
        Me.labelHeadExtName.Text = "Na"
        '
        'labelBldgNo
        '
        Me.labelBldgNo.AutoSize = True
        Me.labelBldgNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBldgNo.Location = New System.Drawing.Point(262, 75)
        Me.labelBldgNo.Name = "labelBldgNo"
        Me.labelBldgNo.Size = New System.Drawing.Size(73, 18)
        Me.labelBldgNo.TabIndex = 102
        Me.labelBldgNo.Text = "BL10 L1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 18)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Building Number: "
        '
        'btnModifyHousehold
        '
        Me.btnModifyHousehold.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyHousehold.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnModifyHousehold.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnModifyHousehold.FlatAppearance.BorderSize = 0
        Me.btnModifyHousehold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyHousehold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyHousehold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyHousehold.ForeColor = System.Drawing.Color.White
        Me.btnModifyHousehold.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnModifyHousehold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyHousehold.Location = New System.Drawing.Point(738, 466)
        Me.btnModifyHousehold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModifyHousehold.Name = "btnModifyHousehold"
        Me.btnModifyHousehold.Size = New System.Drawing.Size(154, 43)
        Me.btnModifyHousehold.TabIndex = 73
        Me.btnModifyHousehold.TabStop = False
        Me.btnModifyHousehold.Text = "  Modify Household"
        Me.btnModifyHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyHousehold.UseVisualStyleBackColor = False
        '
        'pageModifyHousehold
        '
        Me.pageModifyHousehold.BackColor = System.Drawing.SystemColors.Control
        Me.pageModifyHousehold.Controls.Add(Me.Panel5)
        Me.pageModifyHousehold.Location = New System.Drawing.Point(4, 22)
        Me.pageModifyHousehold.Name = "pageModifyHousehold"
        Me.pageModifyHousehold.Padding = New System.Windows.Forms.Padding(3)
        Me.pageModifyHousehold.Size = New System.Drawing.Size(918, 525)
        Me.pageModifyHousehold.TabIndex = 1
        Me.pageModifyHousehold.Text = "Modify Household"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel5.Size = New System.Drawing.Size(912, 519)
        Me.Panel5.TabIndex = 91
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSaveHousehold, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.panelParent, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.874015!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.85827!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.267716!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(892, 509)
        Me.TableLayoutPanel2.TabIndex = 90
        '
        'btnSaveHousehold
        '
        Me.btnSaveHousehold.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveHousehold.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSaveHousehold.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveHousehold.FlatAppearance.BorderSize = 0
        Me.btnSaveHousehold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveHousehold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveHousehold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveHousehold.ForeColor = System.Drawing.Color.White
        Me.btnSaveHousehold.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveHousehold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveHousehold.Location = New System.Drawing.Point(745, 466)
        Me.btnSaveHousehold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveHousehold.Name = "btnSaveHousehold"
        Me.btnSaveHousehold.Size = New System.Drawing.Size(147, 43)
        Me.btnSaveHousehold.TabIndex = 74
        Me.btnSaveHousehold.TabStop = False
        Me.btnSaveHousehold.Text = "  Save Household"
        Me.btnSaveHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveHousehold.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(886, 40)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "HOUSEHOLD INFORMATION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelParent
        '
        Me.panelParent.AutoScroll = True
        Me.panelParent.BackColor = System.Drawing.Color.White
        Me.panelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParent.Controls.Add(Me.comboStreetName)
        Me.panelParent.Controls.Add(Me.comboResidentId)
        Me.panelParent.Controls.Add(Me.txtHouseholdId)
        Me.panelParent.Controls.Add(Me.comboHouseholdHead)
        Me.panelParent.Controls.Add(Me.labelHouseholdHead)
        Me.panelParent.Controls.Add(Me.Panel3)
        Me.panelParent.Controls.Add(Me.comboHouseType)
        Me.panelParent.Controls.Add(Me.Label20)
        Me.panelParent.Controls.Add(Me.txtElectricitySource)
        Me.panelParent.Controls.Add(Me.txtWaterSource)
        Me.panelParent.Controls.Add(Me.Label18)
        Me.panelParent.Controls.Add(Me.Label16)
        Me.panelParent.Controls.Add(Me.Label14)
        Me.panelParent.Controls.Add(Me.Label12)
        Me.panelParent.Controls.Add(Me.Label9)
        Me.panelParent.Controls.Add(Me.txtBldgNo)
        Me.panelParent.Controls.Add(Me.comboResidenceType)
        Me.panelParent.Controls.Add(Me.Label7)
        Me.panelParent.Controls.Add(Me.labelHousehold)
        Me.panelParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelParent.Location = New System.Drawing.Point(3, 43)
        Me.panelParent.Name = "panelParent"
        Me.panelParent.Size = New System.Drawing.Size(886, 420)
        Me.panelParent.TabIndex = 0
        '
        'comboResidentId
        '
        Me.comboResidentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboResidentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboResidentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboResidentId.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboResidentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboResidentId.FormattingEnabled = True
        Me.comboResidentId.Location = New System.Drawing.Point(661, 133)
        Me.comboResidentId.Name = "comboResidentId"
        Me.comboResidentId.Size = New System.Drawing.Size(204, 28)
        Me.comboResidentId.TabIndex = 139
        '
        'txtHouseholdId
        '
        Me.txtHouseholdId.BackColor = System.Drawing.Color.White
        Me.txtHouseholdId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseholdId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholdId.ForeColor = System.Drawing.Color.Black
        Me.txtHouseholdId.Location = New System.Drawing.Point(303, 100)
        Me.txtHouseholdId.MaxLength = 100
        Me.txtHouseholdId.Multiline = True
        Me.txtHouseholdId.Name = "txtHouseholdId"
        Me.txtHouseholdId.Size = New System.Drawing.Size(295, 27)
        Me.txtHouseholdId.TabIndex = 138
        '
        'comboHouseholdHead
        '
        Me.comboHouseholdHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboHouseholdHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHouseholdHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboHouseholdHead.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboHouseholdHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHouseholdHead.FormattingEnabled = True
        Me.comboHouseholdHead.Location = New System.Drawing.Point(305, 133)
        Me.comboHouseholdHead.Name = "comboHouseholdHead"
        Me.comboHouseholdHead.Size = New System.Drawing.Size(295, 28)
        Me.comboHouseholdHead.TabIndex = 137
        '
        'labelHouseholdHead
        '
        Me.labelHouseholdHead.AutoSize = True
        Me.labelHouseholdHead.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHouseholdHead.Location = New System.Drawing.Point(78, 137)
        Me.labelHouseholdHead.Name = "labelHouseholdHead"
        Me.labelHouseholdHead.Size = New System.Drawing.Size(151, 18)
        Me.labelHouseholdHead.TabIndex = 136
        Me.labelHouseholdHead.Text = "Household Head: "
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(808, 298)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 100)
        Me.Panel3.TabIndex = 135
        '
        'comboHouseType
        '
        Me.comboHouseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.comboHouseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHouseType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboHouseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHouseType.FormattingEnabled = True
        Me.comboHouseType.Items.AddRange(New Object() {"Wood", "Concrete", "Bricks", "Metal"})
        Me.comboHouseType.Location = New System.Drawing.Point(303, 285)
        Me.comboHouseType.Name = "comboHouseType"
        Me.comboHouseType.Size = New System.Drawing.Size(295, 28)
        Me.comboHouseType.TabIndex = 134
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(76, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 18)
        Me.Label20.TabIndex = 133
        Me.Label20.Text = "House Type*: "
        '
        'txtElectricitySource
        '
        Me.txtElectricitySource.BackColor = System.Drawing.Color.White
        Me.txtElectricitySource.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtElectricitySource.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElectricitySource.ForeColor = System.Drawing.Color.Black
        Me.txtElectricitySource.Location = New System.Drawing.Point(305, 352)
        Me.txtElectricitySource.MaxLength = 100
        Me.txtElectricitySource.Multiline = True
        Me.txtElectricitySource.Name = "txtElectricitySource"
        Me.txtElectricitySource.Size = New System.Drawing.Size(295, 27)
        Me.txtElectricitySource.TabIndex = 132
        '
        'txtWaterSource
        '
        Me.txtWaterSource.BackColor = System.Drawing.Color.White
        Me.txtWaterSource.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWaterSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterSource.ForeColor = System.Drawing.Color.Black
        Me.txtWaterSource.Location = New System.Drawing.Point(305, 319)
        Me.txtWaterSource.MaxLength = 100
        Me.txtWaterSource.Multiline = True
        Me.txtWaterSource.Name = "txtWaterSource"
        Me.txtWaterSource.Size = New System.Drawing.Size(295, 27)
        Me.txtWaterSource.TabIndex = 131
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(77, 353)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(159, 18)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "Electricity Source: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(76, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 18)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Water Source: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(684, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 18)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "Note: * Required "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(76, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 18)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Street Name*: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(78, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "House No*: "
        '
        'txtBldgNo
        '
        Me.txtBldgNo.BackColor = System.Drawing.Color.White
        Me.txtBldgNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBldgNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBldgNo.ForeColor = System.Drawing.Color.Black
        Me.txtBldgNo.Location = New System.Drawing.Point(305, 185)
        Me.txtBldgNo.MaxLength = 100
        Me.txtBldgNo.Multiline = True
        Me.txtBldgNo.Name = "txtBldgNo"
        Me.txtBldgNo.Size = New System.Drawing.Size(293, 27)
        Me.txtBldgNo.TabIndex = 123
        '
        'comboResidenceType
        '
        Me.comboResidenceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.comboResidenceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboResidenceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboResidenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboResidenceType.FormattingEnabled = True
        Me.comboResidenceType.Items.AddRange(New Object() {"Owned", "Rent", "Informal Settler", "Tenancy", "Co Owned"})
        Me.comboResidenceType.Location = New System.Drawing.Point(303, 251)
        Me.comboResidenceType.Name = "comboResidenceType"
        Me.comboResidenceType.Size = New System.Drawing.Size(295, 28)
        Me.comboResidenceType.TabIndex = 122
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 18)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Residence Type*: "
        '
        'labelHousehold
        '
        Me.labelHousehold.AutoSize = True
        Me.labelHousehold.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHousehold.Location = New System.Drawing.Point(78, 103)
        Me.labelHousehold.Name = "labelHousehold"
        Me.labelHousehold.Size = New System.Drawing.Size(138, 18)
        Me.labelHousehold.TabIndex = 119
        Me.labelHousehold.Text = "Household Id*: "
        '
        'comboStreetName
        '
        Me.comboStreetName.AutoCompleteCustomSource.AddRange(New String() {"A. Aragon", "Evangelista", "E. Gomez", "F. Gaudier", "Casimiro Ave, Westbay", "Baht, Westbay", "Dinar, Westbay", "Dirham,Westbay", "Dollar, Westbay", "Euro, Westbay", "Franc, Westbay", "Lira, Westbay", "Peso, Westbay", "Pound, Westbay", "Ringgit, Westbay", "Riyal, Westbay", "Ruble, Westbay", "Rupee, Westbay", "Shekel, Westbay", "Won, Westbay", "Yen, Westbay", "Yuan, Westbay"})
        Me.comboStreetName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.comboStreetName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboStreetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboStreetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStreetName.FormattingEnabled = True
        Me.comboStreetName.Items.AddRange(New Object() {"A. Aragon", "Evangelista", "E. Gomez", "F. Gaudier", "Casimiro Ave, Westbay", "Baht, Westbay", "Dinar, Westbay", "Dirham, Westbay", "Dollar, Westbay", "Euro, Westbay", "Franc, Westbay", "Lira, Westbay", "Peso, Westbay", "Pound, Westbay", "Ringgit, Westbay", "Riyal, Westbay", "Ruble, Westbay", "Rupee, Westbay", "Shekel, Westbay", "Won, Westbay", "Yen, Westbay", "Yuan, Westbay"})
        Me.comboStreetName.Location = New System.Drawing.Point(303, 217)
        Me.comboStreetName.Name = "comboStreetName"
        Me.comboStreetName.Size = New System.Drawing.Size(295, 28)
        Me.comboStreetName.TabIndex = 140
        '
        'ViewHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewHousehold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Household Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageViewHousehold.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagridViewHousehold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageModifyHousehold.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.panelParent.ResumeLayout(False)
        Me.panelParent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageViewHousehold As TabPage
    Friend WithEvents pageModifyHousehold As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label104 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnModifyHousehold As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents panelParent As Panel
    Friend WithEvents labelDateAdded As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datagridViewHousehold As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents labelElectricitySource As Label
    Friend WithEvents labelHouseholdId As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelWaterSource As Label
    Friend WithEvents labelHeadFirstName As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelHousetype As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents labelHeadMiddleName As Label
    Friend WithEvents labelResidenceType As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents labelHeadLastName As Label
    Friend WithEvents labelStreetName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents labelHeadExtName As Label
    Friend WithEvents labelBldgNo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labelHousehold As Label
    Friend WithEvents comboResidenceType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBldgNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtElectricitySource As TextBox
    Friend WithEvents txtWaterSource As TextBox
    Friend WithEvents btnSaveHousehold As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents comboHouseType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents comboHouseholdHead As ComboBox
    Friend WithEvents labelHouseholdHead As Label
    Friend WithEvents txtHouseholdId As TextBox
    Friend WithEvents comboResidentId As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents comboStreetName As ComboBox
End Class
