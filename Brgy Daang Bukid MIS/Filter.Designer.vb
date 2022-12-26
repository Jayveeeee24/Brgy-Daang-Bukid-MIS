<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Filter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filter))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageFilterResident = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtYearRegistered = New System.Windows.Forms.TextBox()
        Me.txtDayRegistered = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.comboMonthRegistered = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.comboHouseholdId = New System.Windows.Forms.ComboBox()
        Me.comboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.comboHouseholdRole = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comboPwd = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboSex = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAgeMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAgeMin = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnApplyFiltersResidents = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClearSelectionResidents = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pageFilterHousehold = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.mainTabControl.SuspendLayout()
        Me.pageFilterResident.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pageFilterHousehold.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageFilterResident)
        Me.mainTabControl.Controls.Add(Me.pageFilterHousehold)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(336, 551)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 0
        '
        'pageFilterResident
        '
        Me.pageFilterResident.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageFilterResident.Controls.Add(Me.Panel1)
        Me.pageFilterResident.Controls.Add(Me.Panel4)
        Me.pageFilterResident.Controls.Add(Me.Panel3)
        Me.pageFilterResident.Controls.Add(Me.Panel2)
        Me.pageFilterResident.Location = New System.Drawing.Point(4, 22)
        Me.pageFilterResident.Name = "pageFilterResident"
        Me.pageFilterResident.Padding = New System.Windows.Forms.Padding(5)
        Me.pageFilterResident.Size = New System.Drawing.Size(328, 525)
        Me.pageFilterResident.TabIndex = 0
        Me.pageFilterResident.Text = "Filter Resident"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtYearRegistered)
        Me.Panel1.Controls.Add(Me.txtDayRegistered)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.comboMonthRegistered)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.comboHouseholdId)
        Me.Panel1.Controls.Add(Me.comboCivilStatus)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.comboHouseholdRole)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.comboPwd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.comboSex)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAgeMax)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAgeMin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 99)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 380)
        Me.Panel1.TabIndex = 7
        '
        'txtYearRegistered
        '
        Me.txtYearRegistered.BackColor = System.Drawing.Color.White
        Me.txtYearRegistered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYearRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearRegistered.ForeColor = System.Drawing.Color.Black
        Me.txtYearRegistered.Location = New System.Drawing.Point(130, 341)
        Me.txtYearRegistered.MaxLength = 4
        Me.txtYearRegistered.Multiline = True
        Me.txtYearRegistered.Name = "txtYearRegistered"
        Me.txtYearRegistered.Size = New System.Drawing.Size(167, 27)
        Me.txtYearRegistered.TabIndex = 36
        '
        'txtDayRegistered
        '
        Me.txtDayRegistered.BackColor = System.Drawing.Color.White
        Me.txtDayRegistered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDayRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayRegistered.ForeColor = System.Drawing.Color.Black
        Me.txtDayRegistered.Location = New System.Drawing.Point(130, 308)
        Me.txtDayRegistered.MaxLength = 2
        Me.txtDayRegistered.Multiline = True
        Me.txtDayRegistered.Name = "txtDayRegistered"
        Me.txtDayRegistered.Size = New System.Drawing.Size(167, 27)
        Me.txtDayRegistered.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(98, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 18)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Date Registered"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 346)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 18)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Year: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 312)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Day: "
        '
        'comboMonthRegistered
        '
        Me.comboMonthRegistered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMonthRegistered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMonthRegistered.FormattingEnabled = True
        Me.comboMonthRegistered.Items.AddRange(New Object() {"Any", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.comboMonthRegistered.Location = New System.Drawing.Point(130, 274)
        Me.comboMonthRegistered.Name = "comboMonthRegistered"
        Me.comboMonthRegistered.Size = New System.Drawing.Size(167, 28)
        Me.comboMonthRegistered.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Month: "
        '
        'comboHouseholdId
        '
        Me.comboHouseholdId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHouseholdId.FormattingEnabled = True
        Me.comboHouseholdId.Items.AddRange(New Object() {"Any"})
        Me.comboHouseholdId.Location = New System.Drawing.Point(130, 14)
        Me.comboHouseholdId.Name = "comboHouseholdId"
        Me.comboHouseholdId.Size = New System.Drawing.Size(167, 28)
        Me.comboHouseholdId.TabIndex = 27
        '
        'comboCivilStatus
        '
        Me.comboCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCivilStatus.FormattingEnabled = True
        Me.comboCivilStatus.Items.AddRange(New Object() {"Any", "Single", "Married", "Divorced", "Separated", "Widowed"})
        Me.comboCivilStatus.Location = New System.Drawing.Point(130, 144)
        Me.comboCivilStatus.Name = "comboCivilStatus"
        Me.comboCivilStatus.Size = New System.Drawing.Size(167, 28)
        Me.comboCivilStatus.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 18)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Household Id:"
        '
        'comboHouseholdRole
        '
        Me.comboHouseholdRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboHouseholdRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHouseholdRole.FormattingEnabled = True
        Me.comboHouseholdRole.Items.AddRange(New Object() {"Any", "Head", "Member"})
        Me.comboHouseholdRole.Location = New System.Drawing.Point(165, 212)
        Me.comboHouseholdRole.Name = "comboHouseholdRole"
        Me.comboHouseholdRole.Size = New System.Drawing.Size(132, 28)
        Me.comboHouseholdRole.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Household Role: "
        '
        'comboPwd
        '
        Me.comboPwd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPwd.FormattingEnabled = True
        Me.comboPwd.Items.AddRange(New Object() {"Any", "Yes", "No"})
        Me.comboPwd.Location = New System.Drawing.Point(130, 178)
        Me.comboPwd.Name = "comboPwd"
        Me.comboPwd.Size = New System.Drawing.Size(167, 28)
        Me.comboPwd.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PWD: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Civil Status:"
        '
        'comboSex
        '
        Me.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSex.FormattingEnabled = True
        Me.comboSex.Items.AddRange(New Object() {"Any", "Male", "Female"})
        Me.comboSex.Location = New System.Drawing.Point(130, 110)
        Me.comboSex.Name = "comboSex"
        Me.comboSex.Size = New System.Drawing.Size(167, 28)
        Me.comboSex.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sex: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Age: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "max"
        '
        'txtAgeMax
        '
        Me.txtAgeMax.BackColor = System.Drawing.Color.White
        Me.txtAgeMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgeMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeMax.ForeColor = System.Drawing.Color.Black
        Me.txtAgeMax.Location = New System.Drawing.Point(218, 51)
        Me.txtAgeMax.MaxLength = 3
        Me.txtAgeMax.Multiline = True
        Me.txtAgeMax.Name = "txtAgeMax"
        Me.txtAgeMax.Size = New System.Drawing.Size(79, 27)
        Me.txtAgeMax.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "min"
        '
        'txtAgeMin
        '
        Me.txtAgeMin.BackColor = System.Drawing.Color.White
        Me.txtAgeMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgeMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgeMin.ForeColor = System.Drawing.Color.Black
        Me.txtAgeMin.Location = New System.Drawing.Point(89, 51)
        Me.txtAgeMin.MaxLength = 3
        Me.txtAgeMin.Multiline = True
        Me.txtAgeMin.Name = "txtAgeMin"
        Me.txtAgeMin.Size = New System.Drawing.Size(77, 27)
        Me.txtAgeMin.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnApplyFiltersResidents)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 479)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(25, 3, 25, 3)
        Me.Panel4.Size = New System.Drawing.Size(318, 41)
        Me.Panel4.TabIndex = 14
        '
        'btnApplyFiltersResidents
        '
        Me.btnApplyFiltersResidents.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnApplyFiltersResidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnApplyFiltersResidents.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnApplyFiltersResidents.FlatAppearance.BorderSize = 0
        Me.btnApplyFiltersResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnApplyFiltersResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnApplyFiltersResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyFiltersResidents.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyFiltersResidents.ForeColor = System.Drawing.Color.White
        Me.btnApplyFiltersResidents.Location = New System.Drawing.Point(25, 3)
        Me.btnApplyFiltersResidents.Margin = New System.Windows.Forms.Padding(0)
        Me.btnApplyFiltersResidents.Name = "btnApplyFiltersResidents"
        Me.btnApplyFiltersResidents.Size = New System.Drawing.Size(268, 35)
        Me.btnApplyFiltersResidents.TabIndex = 13
        Me.btnApplyFiltersResidents.Text = "Apply Filters"
        Me.btnApplyFiltersResidents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplyFiltersResidents.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnClearSelectionResidents)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 53)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 15, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(318, 46)
        Me.Panel3.TabIndex = 13
        '
        'btnClearSelectionResidents
        '
        Me.btnClearSelectionResidents.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClearSelectionResidents.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClearSelectionResidents.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClearSelectionResidents.FlatAppearance.BorderSize = 0
        Me.btnClearSelectionResidents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnClearSelectionResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnClearSelectionResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSelectionResidents.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSelectionResidents.ForeColor = System.Drawing.Color.White
        Me.btnClearSelectionResidents.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.clear
        Me.btnClearSelectionResidents.Location = New System.Drawing.Point(174, 15)
        Me.btnClearSelectionResidents.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClearSelectionResidents.Name = "btnClearSelectionResidents"
        Me.btnClearSelectionResidents.Size = New System.Drawing.Size(144, 31)
        Me.btnClearSelectionResidents.TabIndex = 12
        Me.btnClearSelectionResidents.Text = " Clear Selection"
        Me.btnClearSelectionResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearSelectionResidents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearSelectionResidents.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(318, 48)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter Residents"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pageFilterHousehold
        '
        Me.pageFilterHousehold.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageFilterHousehold.Controls.Add(Me.Panel6)
        Me.pageFilterHousehold.Controls.Add(Me.Panel7)
        Me.pageFilterHousehold.Controls.Add(Me.Panel5)
        Me.pageFilterHousehold.Controls.Add(Me.Panel8)
        Me.pageFilterHousehold.Location = New System.Drawing.Point(4, 22)
        Me.pageFilterHousehold.Name = "pageFilterHousehold"
        Me.pageFilterHousehold.Padding = New System.Windows.Forms.Padding(5)
        Me.pageFilterHousehold.Size = New System.Drawing.Size(328, 525)
        Me.pageFilterHousehold.TabIndex = 1
        Me.pageFilterHousehold.Text = "Filter Household"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ComboBox7)
        Me.Panel6.Controls.Add(Me.TextBox4)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.ComboBox5)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.ComboBox6)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(5, 99)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(318, 380)
        Me.Panel6.TabIndex = 15
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(131, 177)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(167, 28)
        Me.ComboBox7.TabIndex = 30
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(131, 74)
        Me.TextBox4.MaxLength = 11
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(167, 27)
        Me.TextBox4.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Head Name:"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(146, 231)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(152, 28)
        Me.ComboBox5.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Water Source: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 18)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Street Name:"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(159, 125)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(139, 28)
        Me.ComboBox6.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 18)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Residence Type: "
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(5, 53)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5, 15, 0, 0)
        Me.Panel7.Size = New System.Drawing.Size(318, 46)
        Me.Panel7.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.clear
        Me.Button3.Location = New System.Drawing.Point(174, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 31)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = " Clear Selection"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(318, 48)
        Me.Panel5.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Filter Household"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(5, 479)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(25, 3, 25, 3)
        Me.Panel8.Size = New System.Drawing.Size(318, 41)
        Me.Panel8.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(25, 3)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(268, 35)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Apply Filters"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Filter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.mainTabControl.ResumeLayout(False)
        Me.pageFilterResident.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pageFilterHousehold.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageFilterResident As TabPage
    Friend WithEvents pageFilterHousehold As TabPage
    Friend WithEvents txtAgeMin As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClearSelectionResidents As Button
    Friend WithEvents comboSex As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAgeMax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents comboPwd As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnApplyFiltersResidents As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents comboHouseholdRole As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtYearRegistered As TextBox
    Friend WithEvents txtDayRegistered As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents comboMonthRegistered As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents comboHouseholdId As ComboBox
    Friend WithEvents comboCivilStatus As ComboBox
    Friend WithEvents Label16 As Label
End Class
