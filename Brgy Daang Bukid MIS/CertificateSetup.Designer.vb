<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Certificate_Setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Certificate_Setup))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageCertificates = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtYearsResidency = New System.Windows.Forms.TextBox()
        Me.labelYears = New System.Windows.Forms.Label()
        Me.txtResidentPurpose = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchResident = New System.Windows.Forms.Button()
        Me.txtResidentName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfirmProcess = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.labelCertificateType = New System.Windows.Forms.Label()
        Me.pageSummon = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboTime = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datePickerSummon = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchRespondent2 = New System.Windows.Forms.Button()
        Me.txtRespondent2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearchRespondent1 = New System.Windows.Forms.Button()
        Me.txtRespondent1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSearchComplainant2 = New System.Windows.Forms.Button()
        Me.txtComplainant2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchComplainant1 = New System.Windows.Forms.Button()
        Me.txtComplainant1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfirmSummon = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.pageCertificates.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.pageSummon.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageCertificates)
        Me.mainTabControl.Controls.Add(Me.pageSummon)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(528, 420)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 1
        '
        'pageCertificates
        '
        Me.pageCertificates.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageCertificates.Controls.Add(Me.Panel11)
        Me.pageCertificates.Location = New System.Drawing.Point(4, 22)
        Me.pageCertificates.Margin = New System.Windows.Forms.Padding(0)
        Me.pageCertificates.Name = "pageCertificates"
        Me.pageCertificates.Size = New System.Drawing.Size(520, 394)
        Me.pageCertificates.TabIndex = 2
        Me.pageCertificates.Text = "Certificates"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel11.Size = New System.Drawing.Size(520, 394)
        Me.Panel11.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel12, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel16, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.84404!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.78125!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45833!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(500, 384)
        Me.TableLayoutPanel5.TabIndex = 39
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtYearsResidency)
        Me.Panel12.Controls.Add(Me.labelYears)
        Me.Panel12.Controls.Add(Me.txtResidentPurpose)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Controls.Add(Me.btnSearchResident)
        Me.Panel12.Controls.Add(Me.txtResidentName)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(3, 52)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(494, 284)
        Me.Panel12.TabIndex = 38
        '
        'txtYearsResidency
        '
        Me.txtYearsResidency.BackColor = System.Drawing.Color.White
        Me.txtYearsResidency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYearsResidency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearsResidency.ForeColor = System.Drawing.Color.Black
        Me.txtYearsResidency.Location = New System.Drawing.Point(161, 151)
        Me.txtYearsResidency.MaxLength = 3
        Me.txtYearsResidency.Multiline = True
        Me.txtYearsResidency.Name = "txtYearsResidency"
        Me.txtYearsResidency.Size = New System.Drawing.Size(263, 27)
        Me.txtYearsResidency.TabIndex = 149
        Me.txtYearsResidency.Tag = ""
        '
        'labelYears
        '
        Me.labelYears.AutoSize = True
        Me.labelYears.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelYears.Location = New System.Drawing.Point(31, 154)
        Me.labelYears.Name = "labelYears"
        Me.labelYears.Size = New System.Drawing.Size(77, 18)
        Me.labelYears.TabIndex = 148
        Me.labelYears.Text = "Years*: "
        '
        'txtResidentPurpose
        '
        Me.txtResidentPurpose.BackColor = System.Drawing.Color.White
        Me.txtResidentPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResidentPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentPurpose.ForeColor = System.Drawing.Color.Black
        Me.txtResidentPurpose.Location = New System.Drawing.Point(161, 109)
        Me.txtResidentPurpose.MaxLength = 20
        Me.txtResidentPurpose.Multiline = True
        Me.txtResidentPurpose.Name = "txtResidentPurpose"
        Me.txtResidentPurpose.Size = New System.Drawing.Size(263, 27)
        Me.txtResidentPurpose.TabIndex = 147
        Me.txtResidentPurpose.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Purpose*: "
        '
        'btnSearchResident
        '
        Me.btnSearchResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchResident.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchResident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchResident.ForeColor = System.Drawing.Color.White
        Me.btnSearchResident.Image = CType(resources.GetObject("btnSearchResident.Image"), System.Drawing.Image)
        Me.btnSearchResident.Location = New System.Drawing.Point(437, 67)
        Me.btnSearchResident.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchResident.Name = "btnSearchResident"
        Me.btnSearchResident.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchResident.TabIndex = 145
        Me.btnSearchResident.TabStop = False
        Me.btnSearchResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchResident.UseVisualStyleBackColor = False
        '
        'txtResidentName
        '
        Me.txtResidentName.BackColor = System.Drawing.Color.White
        Me.txtResidentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResidentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResidentName.ForeColor = System.Drawing.Color.Black
        Me.txtResidentName.Location = New System.Drawing.Point(161, 67)
        Me.txtResidentName.MaxLength = 50
        Me.txtResidentName.Multiline = True
        Me.txtResidentName.Name = "txtResidentName"
        Me.txtResidentName.Size = New System.Drawing.Size(263, 27)
        Me.txtResidentName.TabIndex = 144
        Me.txtResidentName.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "Name*: "
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnConfirmProcess, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 342)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(494, 39)
        Me.TableLayoutPanel6.TabIndex = 37
        '
        'btnConfirmProcess
        '
        Me.btnConfirmProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnConfirmProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirmProcess.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirmProcess.FlatAppearance.BorderSize = 0
        Me.btnConfirmProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfirmProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfirmProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmProcess.ForeColor = System.Drawing.Color.White
        Me.btnConfirmProcess.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnConfirmProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmProcess.Location = New System.Drawing.Point(379, 0)
        Me.btnConfirmProcess.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirmProcess.Name = "btnConfirmProcess"
        Me.btnConfirmProcess.Size = New System.Drawing.Size(115, 39)
        Me.btnConfirmProcess.TabIndex = 34
        Me.btnConfirmProcess.TabStop = False
        Me.btnConfirmProcess.Text = "  Confirm"
        Me.btnConfirmProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmProcess.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.labelCertificateType)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(494, 43)
        Me.Panel16.TabIndex = 78
        '
        'labelCertificateType
        '
        Me.labelCertificateType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelCertificateType.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCertificateType.Location = New System.Drawing.Point(0, 0)
        Me.labelCertificateType.Name = "labelCertificateType"
        Me.labelCertificateType.Size = New System.Drawing.Size(494, 43)
        Me.labelCertificateType.TabIndex = 71
        Me.labelCertificateType.Text = "CERTIFICATE OF RESIDENCY"
        Me.labelCertificateType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pageSummon
        '
        Me.pageSummon.Controls.Add(Me.Panel1)
        Me.pageSummon.Location = New System.Drawing.Point(4, 22)
        Me.pageSummon.Name = "pageSummon"
        Me.pageSummon.Size = New System.Drawing.Size(520, 394)
        Me.pageSummon.TabIndex = 4
        Me.pageSummon.Text = "Summon"
        Me.pageSummon.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel1.Size = New System.Drawing.Size(520, 394)
        Me.Panel1.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.84404!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.31193!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.14985!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 384)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.comboTime)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.datePickerSummon)
        Me.Panel2.Controls.Add(Me.btnSearchRespondent2)
        Me.Panel2.Controls.Add(Me.txtRespondent2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnSearchRespondent1)
        Me.Panel2.Controls.Add(Me.txtRespondent1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnSearchComplainant2)
        Me.Panel2.Controls.Add(Me.txtComplainant2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCaseNo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnSearchComplainant1)
        Me.Panel2.Controls.Add(Me.txtComplainant1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 278)
        Me.Panel2.TabIndex = 38
        '
        'comboTime
        '
        Me.comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTime.FormattingEnabled = True
        Me.comboTime.Items.AddRange(New Object() {"1:00 AM", "2:00 AM", "3:00 AM", "4:00 AM", "5:00 AM", "6:00 AM", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM", "12:00 AM"})
        Me.comboTime.Location = New System.Drawing.Point(172, 226)
        Me.comboTime.Name = "comboTime"
        Me.comboTime.Size = New System.Drawing.Size(264, 28)
        Me.comboTime.TabIndex = 162
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 18)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "Time Summon*: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Date Summon*: "
        '
        'datePickerSummon
        '
        Me.datePickerSummon.CustomFormat = ""
        Me.datePickerSummon.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerSummon.Location = New System.Drawing.Point(172, 194)
        Me.datePickerSummon.Name = "datePickerSummon"
        Me.datePickerSummon.Size = New System.Drawing.Size(264, 26)
        Me.datePickerSummon.TabIndex = 159
        '
        'btnSearchRespondent2
        '
        Me.btnSearchRespondent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchRespondent2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchRespondent2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchRespondent2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchRespondent2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRespondent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRespondent2.ForeColor = System.Drawing.Color.White
        Me.btnSearchRespondent2.Image = CType(resources.GetObject("btnSearchRespondent2.Image"), System.Drawing.Image)
        Me.btnSearchRespondent2.Location = New System.Drawing.Point(449, 160)
        Me.btnSearchRespondent2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchRespondent2.Name = "btnSearchRespondent2"
        Me.btnSearchRespondent2.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchRespondent2.TabIndex = 158
        Me.btnSearchRespondent2.TabStop = False
        Me.btnSearchRespondent2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchRespondent2.UseVisualStyleBackColor = False
        '
        'txtRespondent2
        '
        Me.txtRespondent2.BackColor = System.Drawing.Color.White
        Me.txtRespondent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRespondent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespondent2.ForeColor = System.Drawing.Color.Black
        Me.txtRespondent2.Location = New System.Drawing.Point(173, 160)
        Me.txtRespondent2.MaxLength = 100
        Me.txtRespondent2.Multiline = True
        Me.txtRespondent2.Name = "txtRespondent2"
        Me.txtRespondent2.Size = New System.Drawing.Size(263, 27)
        Me.txtRespondent2.TabIndex = 157
        Me.txtRespondent2.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 18)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Respondent 2: "
        '
        'btnSearchRespondent1
        '
        Me.btnSearchRespondent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchRespondent1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchRespondent1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchRespondent1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchRespondent1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchRespondent1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRespondent1.ForeColor = System.Drawing.Color.White
        Me.btnSearchRespondent1.Image = CType(resources.GetObject("btnSearchRespondent1.Image"), System.Drawing.Image)
        Me.btnSearchRespondent1.Location = New System.Drawing.Point(449, 127)
        Me.btnSearchRespondent1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchRespondent1.Name = "btnSearchRespondent1"
        Me.btnSearchRespondent1.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchRespondent1.TabIndex = 155
        Me.btnSearchRespondent1.TabStop = False
        Me.btnSearchRespondent1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchRespondent1.UseVisualStyleBackColor = False
        '
        'txtRespondent1
        '
        Me.txtRespondent1.BackColor = System.Drawing.Color.White
        Me.txtRespondent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRespondent1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespondent1.ForeColor = System.Drawing.Color.Black
        Me.txtRespondent1.Location = New System.Drawing.Point(173, 127)
        Me.txtRespondent1.MaxLength = 100
        Me.txtRespondent1.Multiline = True
        Me.txtRespondent1.Name = "txtRespondent1"
        Me.txtRespondent1.Size = New System.Drawing.Size(263, 27)
        Me.txtRespondent1.TabIndex = 154
        Me.txtRespondent1.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 18)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Respondent 1*: "
        '
        'btnSearchComplainant2
        '
        Me.btnSearchComplainant2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchComplainant2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchComplainant2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchComplainant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchComplainant2.ForeColor = System.Drawing.Color.White
        Me.btnSearchComplainant2.Image = CType(resources.GetObject("btnSearchComplainant2.Image"), System.Drawing.Image)
        Me.btnSearchComplainant2.Location = New System.Drawing.Point(449, 94)
        Me.btnSearchComplainant2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchComplainant2.Name = "btnSearchComplainant2"
        Me.btnSearchComplainant2.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchComplainant2.TabIndex = 152
        Me.btnSearchComplainant2.TabStop = False
        Me.btnSearchComplainant2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchComplainant2.UseVisualStyleBackColor = False
        '
        'txtComplainant2
        '
        Me.txtComplainant2.BackColor = System.Drawing.Color.White
        Me.txtComplainant2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplainant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplainant2.ForeColor = System.Drawing.Color.Black
        Me.txtComplainant2.Location = New System.Drawing.Point(173, 94)
        Me.txtComplainant2.MaxLength = 100
        Me.txtComplainant2.Multiline = True
        Me.txtComplainant2.Name = "txtComplainant2"
        Me.txtComplainant2.Size = New System.Drawing.Size(263, 27)
        Me.txtComplainant2.TabIndex = 151
        Me.txtComplainant2.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 18)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "Complainant 2: "
        '
        'txtCaseNo
        '
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.ForeColor = System.Drawing.Color.Black
        Me.txtCaseNo.Location = New System.Drawing.Point(173, 28)
        Me.txtCaseNo.MaxLength = 100
        Me.txtCaseNo.Multiline = True
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(263, 27)
        Me.txtCaseNo.TabIndex = 147
        Me.txtCaseNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Case No*: "
        '
        'btnSearchComplainant1
        '
        Me.btnSearchComplainant1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchComplainant1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchComplainant1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchComplainant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchComplainant1.ForeColor = System.Drawing.Color.White
        Me.btnSearchComplainant1.Image = CType(resources.GetObject("btnSearchComplainant1.Image"), System.Drawing.Image)
        Me.btnSearchComplainant1.Location = New System.Drawing.Point(449, 61)
        Me.btnSearchComplainant1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchComplainant1.Name = "btnSearchComplainant1"
        Me.btnSearchComplainant1.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchComplainant1.TabIndex = 145
        Me.btnSearchComplainant1.TabStop = False
        Me.btnSearchComplainant1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchComplainant1.UseVisualStyleBackColor = False
        '
        'txtComplainant1
        '
        Me.txtComplainant1.BackColor = System.Drawing.Color.White
        Me.txtComplainant1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplainant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplainant1.ForeColor = System.Drawing.Color.Black
        Me.txtComplainant1.Location = New System.Drawing.Point(173, 61)
        Me.txtComplainant1.MaxLength = 100
        Me.txtComplainant1.Multiline = True
        Me.txtComplainant1.Name = "txtComplainant1"
        Me.txtComplainant1.Size = New System.Drawing.Size(263, 27)
        Me.txtComplainant1.TabIndex = 144
        Me.txtComplainant1.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Complainant 1*: "
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfirmSummon, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 336)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(494, 45)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'btnConfirmSummon
        '
        Me.btnConfirmSummon.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnConfirmSummon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirmSummon.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfirmSummon.FlatAppearance.BorderSize = 0
        Me.btnConfirmSummon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfirmSummon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfirmSummon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmSummon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmSummon.ForeColor = System.Drawing.Color.White
        Me.btnConfirmSummon.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.arrow_forward_white
        Me.btnConfirmSummon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmSummon.Location = New System.Drawing.Point(379, 0)
        Me.btnConfirmSummon.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirmSummon.Name = "btnConfirmSummon"
        Me.btnConfirmSummon.Size = New System.Drawing.Size(115, 45)
        Me.btnConfirmSummon.TabIndex = 34
        Me.btnConfirmSummon.TabStop = False
        Me.btnConfirmSummon.Text = "  Confirm"
        Me.btnConfirmSummon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmSummon.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 43)
        Me.Panel3.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(494, 43)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "BARANGAY SUMMON"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Certificate_Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 420)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Certificate_Setup"
        Me.Text = "Issue Certificates"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageCertificates.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.pageSummon.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageCertificates As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnConfirmProcess As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents labelCertificateType As Label
    Friend WithEvents pageSummon As TabPage
    Friend WithEvents txtResidentPurpose As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearchResident As Button
    Friend WithEvents txtResidentName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtYearsResidency As TextBox
    Friend WithEvents labelYears As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearchComplainant1 As Button
    Friend WithEvents txtComplainant1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnConfirmSummon As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearchRespondent2 As Button
    Friend WithEvents txtRespondent2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearchRespondent1 As Button
    Friend WithEvents txtRespondent1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearchComplainant2 As Button
    Friend WithEvents txtComplainant2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents datePickerSummon As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents comboTime As ComboBox
End Class
