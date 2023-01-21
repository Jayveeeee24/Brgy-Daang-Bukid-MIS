<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBlotters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewBlotters))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.labelSuspectContactNo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelSuspectAddress = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelBlotterDetails = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.labelSubmittedOn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelSubmittedBy = New System.Windows.Forms.Label()
        Me.labelSuspect = New System.Windows.Forms.Label()
        Me.labelBlotter = New System.Windows.Forms.Label()
        Me.labelBlotterId = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelParent = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.txtBlotterDetails = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.datePickerSubmittedOn = New System.Windows.Forms.DateTimePicker()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnSearchSubmittedBy = New System.Windows.Forms.Button()
        Me.txtSubmittedBy = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.panelSuspectDetails = New System.Windows.Forms.Panel()
        Me.txtSuspectAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSuspectContactNo = New System.Windows.Forms.TextBox()
        Me.panelSuspectRadio = New System.Windows.Forms.Panel()
        Me.radioSuspectNonResident = New System.Windows.Forms.RadioButton()
        Me.radioSuspectResident = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchSuspect = New System.Windows.Forms.Button()
        Me.txtSuspect = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.comboBlotteredFor = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.panelBlotterId = New System.Windows.Forms.Panel()
        Me.txtBlotterId = New System.Windows.Forms.TextBox()
        Me.labelId = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveBlotter = New System.Windows.Forms.Button()
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.pageAddModify.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.panelParent.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.panelSuspectDetails.SuspendLayout()
        Me.panelSuspectRadio.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.panelBlotterId.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.pageView)
        Me.mainTabControl.Controls.Add(Me.pageAddModify)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(697, 551)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 3
        '
        'pageView
        '
        Me.pageView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageView.Controls.Add(Me.Panel11)
        Me.pageView.Location = New System.Drawing.Point(4, 22)
        Me.pageView.Margin = New System.Windows.Forms.Padding(0)
        Me.pageView.Name = "pageView"
        Me.pageView.Size = New System.Drawing.Size(689, 525)
        Me.pageView.TabIndex = 2
        Me.pageView.Text = "View"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel11.Size = New System.Drawing.Size(689, 525)
        Me.Panel11.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.labelSuspectContactNo)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Controls.Add(Me.labelSuspectAddress)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.labelBlotterDetails)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Controls.Add(Me.labelSubmittedOn)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.labelSubmittedBy)
        Me.Panel12.Controls.Add(Me.labelSuspect)
        Me.Panel12.Controls.Add(Me.labelBlotter)
        Me.Panel12.Controls.Add(Me.labelBlotterId)
        Me.Panel12.Controls.Add(Me.Label100)
        Me.Panel12.Controls.Add(Me.Label101)
        Me.Panel12.Controls.Add(Me.Label102)
        Me.Panel12.Controls.Add(Me.Label103)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(10, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(669, 515)
        Me.Panel12.TabIndex = 39
        '
        'labelSuspectContactNo
        '
        Me.labelSuspectContactNo.AutoSize = True
        Me.labelSuspectContactNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSuspectContactNo.Location = New System.Drawing.Point(304, 217)
        Me.labelSuspectContactNo.Name = "labelSuspectContactNo"
        Me.labelSuspectContactNo.Size = New System.Drawing.Size(23, 18)
        Me.labelSuspectContactNo.TabIndex = 73
        Me.labelSuspectContactNo.Text = "id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Contact No: "
        '
        'labelSuspectAddress
        '
        Me.labelSuspectAddress.AutoSize = True
        Me.labelSuspectAddress.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSuspectAddress.Location = New System.Drawing.Point(304, 178)
        Me.labelSuspectAddress.Name = "labelSuspectAddress"
        Me.labelSuspectAddress.Size = New System.Drawing.Size(23, 18)
        Me.labelSuspectAddress.TabIndex = 71
        Me.labelSuspectAddress.Text = "id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Address: "
        '
        'labelBlotterDetails
        '
        Me.labelBlotterDetails.AutoSize = True
        Me.labelBlotterDetails.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBlotterDetails.Location = New System.Drawing.Point(304, 340)
        Me.labelBlotterDetails.Name = "labelBlotterDetails"
        Me.labelBlotterDetails.Size = New System.Drawing.Size(25, 18)
        Me.labelBlotterDetails.TabIndex = 63
        Me.labelBlotterDetails.Text = "Jr."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(76, 340)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 18)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Details: "
        '
        'labelSubmittedOn
        '
        Me.labelSubmittedOn.AutoSize = True
        Me.labelSubmittedOn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubmittedOn.Location = New System.Drawing.Point(304, 299)
        Me.labelSubmittedOn.Name = "labelSubmittedOn"
        Me.labelSubmittedOn.Size = New System.Drawing.Size(25, 18)
        Me.labelSubmittedOn.TabIndex = 45
        Me.labelSubmittedOn.Text = "Jr."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Submitted on: "
        '
        'labelSubmittedBy
        '
        Me.labelSubmittedBy.AutoSize = True
        Me.labelSubmittedBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelSubmittedBy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubmittedBy.Location = New System.Drawing.Point(304, 259)
        Me.labelSubmittedBy.Name = "labelSubmittedBy"
        Me.labelSubmittedBy.Size = New System.Drawing.Size(25, 18)
        Me.labelSubmittedBy.TabIndex = 43
        Me.labelSubmittedBy.Text = "Jr."
        '
        'labelSuspect
        '
        Me.labelSuspect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelSuspect.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSuspect.Location = New System.Drawing.Point(304, 144)
        Me.labelSuspect.Name = "labelSuspect"
        Me.labelSuspect.Size = New System.Drawing.Size(313, 18)
        Me.labelSuspect.TabIndex = 42
        Me.labelSuspect.Text = "Kamusta ka na "
        '
        'labelBlotter
        '
        Me.labelBlotter.AutoSize = True
        Me.labelBlotter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBlotter.Location = New System.Drawing.Point(304, 106)
        Me.labelBlotter.Name = "labelBlotter"
        Me.labelBlotter.Size = New System.Drawing.Size(116, 18)
        Me.labelBlotter.TabIndex = 41
        Me.labelBlotter.Text = "KOMPLAINT"
        '
        'labelBlotterId
        '
        Me.labelBlotterId.AutoSize = True
        Me.labelBlotterId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBlotterId.Location = New System.Drawing.Point(304, 68)
        Me.labelBlotterId.Name = "labelBlotterId"
        Me.labelBlotterId.Size = New System.Drawing.Size(54, 18)
        Me.labelBlotterId.TabIndex = 40
        Me.labelBlotterId.Text = "Jopay"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(76, 259)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(129, 18)
        Me.Label100.TabIndex = 39
        Me.Label100.Text = "Submitted by: "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(76, 144)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(84, 18)
        Me.Label101.TabIndex = 38
        Me.Label101.Text = "Suspect: "
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(76, 106)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(123, 18)
        Me.Label102.TabIndex = 37
        Me.Label102.Text = "Blottered for: "
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(76, 68)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(100, 18)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Blotter ID: "
        '
        'pageAddModify
        '
        Me.pageAddModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageAddModify.Controls.Add(Me.Panel5)
        Me.pageAddModify.Location = New System.Drawing.Point(4, 22)
        Me.pageAddModify.Margin = New System.Windows.Forms.Padding(0)
        Me.pageAddModify.Name = "pageAddModify"
        Me.pageAddModify.Size = New System.Drawing.Size(689, 525)
        Me.pageAddModify.TabIndex = 1
        Me.pageAddModify.Text = "Modify"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel5.Size = New System.Drawing.Size(689, 525)
        Me.Panel5.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.panelParent, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.67961!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.320389!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(669, 515)
        Me.TableLayoutPanel3.TabIndex = 39
        '
        'panelParent
        '
        Me.panelParent.AutoScroll = True
        Me.panelParent.BackColor = System.Drawing.Color.White
        Me.panelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParent.Controls.Add(Me.Panel20)
        Me.panelParent.Controls.Add(Me.Panel19)
        Me.panelParent.Controls.Add(Me.Panel18)
        Me.panelParent.Controls.Add(Me.panelSuspectDetails)
        Me.panelParent.Controls.Add(Me.panelSuspectRadio)
        Me.panelParent.Controls.Add(Me.Panel1)
        Me.panelParent.Controls.Add(Me.Panel9)
        Me.panelParent.Controls.Add(Me.panelBlotterId)
        Me.panelParent.Controls.Add(Me.Label45)
        Me.panelParent.Controls.Add(Me.Label13)
        Me.panelParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelParent.Location = New System.Drawing.Point(3, 3)
        Me.panelParent.Name = "panelParent"
        Me.panelParent.Padding = New System.Windows.Forms.Padding(10)
        Me.panelParent.Size = New System.Drawing.Size(663, 461)
        Me.panelParent.TabIndex = 43
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.txtBlotterDetails)
        Me.Panel20.Controls.Add(Me.Label38)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(10, 384)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(624, 120)
        Me.Panel20.TabIndex = 164
        '
        'txtBlotterDetails
        '
        Me.txtBlotterDetails.BackColor = System.Drawing.Color.White
        Me.txtBlotterDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBlotterDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlotterDetails.ForeColor = System.Drawing.Color.Black
        Me.txtBlotterDetails.Location = New System.Drawing.Point(262, 3)
        Me.txtBlotterDetails.MaxLength = 150
        Me.txtBlotterDetails.Multiline = True
        Me.txtBlotterDetails.Name = "txtBlotterDetails"
        Me.txtBlotterDetails.Size = New System.Drawing.Size(303, 79)
        Me.txtBlotterDetails.TabIndex = 12
        Me.txtBlotterDetails.Tag = ""
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(67, 6)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 18)
        Me.Label38.TabIndex = 114
        Me.Label38.Text = "Details: "
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.datePickerSubmittedOn)
        Me.Panel19.Controls.Add(Me.Label39)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(10, 351)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(624, 33)
        Me.Panel19.TabIndex = 163
        '
        'datePickerSubmittedOn
        '
        Me.datePickerSubmittedOn.CustomFormat = ""
        Me.datePickerSubmittedOn.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerSubmittedOn.Location = New System.Drawing.Point(262, 4)
        Me.datePickerSubmittedOn.Name = "datePickerSubmittedOn"
        Me.datePickerSubmittedOn.Size = New System.Drawing.Size(303, 26)
        Me.datePickerSubmittedOn.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(67, 10)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(140, 18)
        Me.Label39.TabIndex = 103
        Me.Label39.Text = "Submitted on*: "
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.btnSearchSubmittedBy)
        Me.Panel18.Controls.Add(Me.txtSubmittedBy)
        Me.Panel18.Controls.Add(Me.Label40)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(10, 289)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(624, 62)
        Me.Panel18.TabIndex = 162
        '
        'btnSearchSubmittedBy
        '
        Me.btnSearchSubmittedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchSubmittedBy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchSubmittedBy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchSubmittedBy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchSubmittedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSubmittedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSubmittedBy.ForeColor = System.Drawing.Color.White
        Me.btnSearchSubmittedBy.Image = CType(resources.GetObject("btnSearchSubmittedBy.Image"), System.Drawing.Image)
        Me.btnSearchSubmittedBy.Location = New System.Drawing.Point(568, 32)
        Me.btnSearchSubmittedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchSubmittedBy.Name = "btnSearchSubmittedBy"
        Me.btnSearchSubmittedBy.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchSubmittedBy.TabIndex = 130
        Me.btnSearchSubmittedBy.TabStop = False
        Me.btnSearchSubmittedBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchSubmittedBy.UseVisualStyleBackColor = False
        '
        'txtSubmittedBy
        '
        Me.txtSubmittedBy.BackColor = System.Drawing.Color.White
        Me.txtSubmittedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubmittedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubmittedBy.ForeColor = System.Drawing.Color.Black
        Me.txtSubmittedBy.Location = New System.Drawing.Point(262, 32)
        Me.txtSubmittedBy.MaxLength = 50
        Me.txtSubmittedBy.Multiline = True
        Me.txtSubmittedBy.Name = "txtSubmittedBy"
        Me.txtSubmittedBy.Size = New System.Drawing.Size(303, 27)
        Me.txtSubmittedBy.TabIndex = 10
        Me.txtSubmittedBy.Tag = ""
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(67, 35)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(140, 18)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "Submitted by*: "
        '
        'panelSuspectDetails
        '
        Me.panelSuspectDetails.Controls.Add(Me.txtSuspectAddress)
        Me.panelSuspectDetails.Controls.Add(Me.Label11)
        Me.panelSuspectDetails.Controls.Add(Me.Label9)
        Me.panelSuspectDetails.Controls.Add(Me.txtSuspectContactNo)
        Me.panelSuspectDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuspectDetails.Location = New System.Drawing.Point(10, 225)
        Me.panelSuspectDetails.Name = "panelSuspectDetails"
        Me.panelSuspectDetails.Size = New System.Drawing.Size(624, 64)
        Me.panelSuspectDetails.TabIndex = 158
        '
        'txtSuspectAddress
        '
        Me.txtSuspectAddress.BackColor = System.Drawing.Color.White
        Me.txtSuspectAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuspectAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuspectAddress.ForeColor = System.Drawing.Color.Black
        Me.txtSuspectAddress.Location = New System.Drawing.Point(262, 3)
        Me.txtSuspectAddress.MaxLength = 50
        Me.txtSuspectAddress.Multiline = True
        Me.txtSuspectAddress.Name = "txtSuspectAddress"
        Me.txtSuspectAddress.Size = New System.Drawing.Size(303, 27)
        Me.txtSuspectAddress.TabIndex = 5
        Me.txtSuspectAddress.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(67, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "Address: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Contact No: "
        '
        'txtSuspectContactNo
        '
        Me.txtSuspectContactNo.BackColor = System.Drawing.Color.White
        Me.txtSuspectContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuspectContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuspectContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtSuspectContactNo.Location = New System.Drawing.Point(262, 34)
        Me.txtSuspectContactNo.MaxLength = 50
        Me.txtSuspectContactNo.Multiline = True
        Me.txtSuspectContactNo.Name = "txtSuspectContactNo"
        Me.txtSuspectContactNo.Size = New System.Drawing.Size(303, 27)
        Me.txtSuspectContactNo.TabIndex = 7
        Me.txtSuspectContactNo.Tag = ""
        '
        'panelSuspectRadio
        '
        Me.panelSuspectRadio.Controls.Add(Me.radioSuspectNonResident)
        Me.panelSuspectRadio.Controls.Add(Me.radioSuspectResident)
        Me.panelSuspectRadio.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuspectRadio.Location = New System.Drawing.Point(10, 192)
        Me.panelSuspectRadio.Name = "panelSuspectRadio"
        Me.panelSuspectRadio.Size = New System.Drawing.Size(624, 33)
        Me.panelSuspectRadio.TabIndex = 157
        '
        'radioSuspectNonResident
        '
        Me.radioSuspectNonResident.AutoSize = True
        Me.radioSuspectNonResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSuspectNonResident.Location = New System.Drawing.Point(392, 6)
        Me.radioSuspectNonResident.Name = "radioSuspectNonResident"
        Me.radioSuspectNonResident.Size = New System.Drawing.Size(119, 20)
        Me.radioSuspectNonResident.TabIndex = 1
        Me.radioSuspectNonResident.TabStop = True
        Me.radioSuspectNonResident.Text = "Non Resident"
        Me.radioSuspectNonResident.UseVisualStyleBackColor = True
        '
        'radioSuspectResident
        '
        Me.radioSuspectResident.AutoSize = True
        Me.radioSuspectResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSuspectResident.Location = New System.Drawing.Point(305, 6)
        Me.radioSuspectResident.Name = "radioSuspectResident"
        Me.radioSuspectResident.Size = New System.Drawing.Size(87, 20)
        Me.radioSuspectResident.TabIndex = 4
        Me.radioSuspectResident.TabStop = True
        Me.radioSuspectResident.Text = "Resident"
        Me.radioSuspectResident.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchSuspect)
        Me.Panel1.Controls.Add(Me.txtSuspect)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 45)
        Me.Panel1.TabIndex = 156
        '
        'btnSearchSuspect
        '
        Me.btnSearchSuspect.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchSuspect.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchSuspect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchSuspect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchSuspect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSuspect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSuspect.ForeColor = System.Drawing.Color.White
        Me.btnSearchSuspect.Image = CType(resources.GetObject("btnSearchSuspect.Image"), System.Drawing.Image)
        Me.btnSearchSuspect.Location = New System.Drawing.Point(568, 15)
        Me.btnSearchSuspect.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchSuspect.Name = "btnSearchSuspect"
        Me.btnSearchSuspect.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchSuspect.TabIndex = 130
        Me.btnSearchSuspect.TabStop = False
        Me.btnSearchSuspect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchSuspect.UseVisualStyleBackColor = False
        '
        'txtSuspect
        '
        Me.txtSuspect.BackColor = System.Drawing.Color.White
        Me.txtSuspect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuspect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuspect.ForeColor = System.Drawing.Color.Black
        Me.txtSuspect.Location = New System.Drawing.Point(262, 15)
        Me.txtSuspect.MaxLength = 50
        Me.txtSuspect.Multiline = True
        Me.txtSuspect.Name = "txtSuspect"
        Me.txtSuspect.Size = New System.Drawing.Size(303, 27)
        Me.txtSuspect.TabIndex = 3
        Me.txtSuspect.Tag = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(67, 18)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(95, 18)
        Me.Label42.TabIndex = 95
        Me.Label42.Text = "Suspect*: "
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.comboBlotteredFor)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(10, 114)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(624, 33)
        Me.Panel9.TabIndex = 155
        '
        'comboBlotteredFor
        '
        Me.comboBlotteredFor.AutoCompleteCustomSource.AddRange(New String() {"Batanes", "Ilocos Norte", "Apayao", "Cagayan", "Abra", "Kalinga", "Ilocos Sur", "Mountain Province", "Ifugao", "Isabela", "La Union", "Benguet", "Nueva Vizcaya", "Quirino", "Pangasinan", "Tarlac", "Nueva Ecija", "Aurora", "Zambales", "Pampanga", "Bulacan", "Bataan", "Rizal", "Cavite", "Laguna", "Batangas", "Quezon", "Camarines Norte", "Marinduque", "Camarines Sur", "Catanduanes", "Albay", "Occidental Mindoro", "Oriental Mindoro", "Romblon", "Sorsogon", "Masbate", "Northern Samar", "Samar", "Eastern Samar", "Aklan", "Capiz", "Antique", "Iloilo", "Biliran", "Guimaras", "Negros Occidental", "Cebu", "Leyte", "Southern Leyte", "Palawan", "Negros Oriental", "Bohol", "Siquijor", "Camiguin", "Dinagat Islands", "Surigao del Norte", "Zamboanga del Norte", "Zamboanga Sibugay", "Zamboanga del Sur", "Misamis Occidental", "Lanao del Norte", "Lanao del Sur", "Misamis Oriental", "Bukidnon", "Agusan del Norte", "Agusan del Sur", "Surigao del Sur", "Cotabato", "Davao del Sur", "Davao del Norte", "Davao de Oro", "Davao Oriental", "Maguindanao del Norte", "Maguindanao del Sur", "Sultan Kudarat", "South Cotabato", "Sarangani", "Davao Occidental", "Basilan", "Sulu", "Tawi-Tawi", "National Capital Region", "Zamboanga City"})
        Me.comboBlotteredFor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBlotteredFor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBlotteredFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBlotteredFor.FormattingEnabled = True
        Me.comboBlotteredFor.Items.AddRange(New Object() {"Destruction of property", "Violence or injury", "Theft or larceny", "Extortion or Scam", "Threatening"})
        Me.comboBlotteredFor.Location = New System.Drawing.Point(262, 3)
        Me.comboBlotteredFor.Name = "comboBlotteredFor"
        Me.comboBlotteredFor.Size = New System.Drawing.Size(303, 28)
        Me.comboBlotteredFor.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(67, 6)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(134, 18)
        Me.Label43.TabIndex = 94
        Me.Label43.Text = "Blottered for*: "
        '
        'panelBlotterId
        '
        Me.panelBlotterId.Controls.Add(Me.txtBlotterId)
        Me.panelBlotterId.Controls.Add(Me.labelId)
        Me.panelBlotterId.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBlotterId.Location = New System.Drawing.Point(10, 81)
        Me.panelBlotterId.Name = "panelBlotterId"
        Me.panelBlotterId.Size = New System.Drawing.Size(624, 33)
        Me.panelBlotterId.TabIndex = 154
        '
        'txtBlotterId
        '
        Me.txtBlotterId.BackColor = System.Drawing.Color.White
        Me.txtBlotterId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBlotterId.Enabled = False
        Me.txtBlotterId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlotterId.ForeColor = System.Drawing.Color.Black
        Me.txtBlotterId.Location = New System.Drawing.Point(262, 3)
        Me.txtBlotterId.MaxLength = 100
        Me.txtBlotterId.Multiline = True
        Me.txtBlotterId.Name = "txtBlotterId"
        Me.txtBlotterId.Size = New System.Drawing.Size(303, 27)
        Me.txtBlotterId.TabIndex = 1
        Me.txtBlotterId.Tag = ""
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(67, 6)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(100, 18)
        Me.labelId.TabIndex = 93
        Me.labelId.Text = "Blotter ID: "
        '
        'Label45
        '
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label45.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label45.Location = New System.Drawing.Point(10, 26)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(624, 55)
        Me.Label45.TabIndex = 92
        Me.Label45.Text = "Note: * Required "
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(624, 16)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Note: You can search for residents in the barangay using the search button"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.47589!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.61742!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveBlotter, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 470)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(663, 42)
        Me.TableLayoutPanel4.TabIndex = 37
        '
        'btnSaveBlotter
        '
        Me.btnSaveBlotter.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveBlotter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveBlotter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveBlotter.FlatAppearance.BorderSize = 0
        Me.btnSaveBlotter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveBlotter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBlotter.ForeColor = System.Drawing.Color.White
        Me.btnSaveBlotter.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveBlotter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveBlotter.Location = New System.Drawing.Point(519, 0)
        Me.btnSaveBlotter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveBlotter.Name = "btnSaveBlotter"
        Me.btnSaveBlotter.Size = New System.Drawing.Size(144, 42)
        Me.btnSaveBlotter.TabIndex = 34
        Me.btnSaveBlotter.TabStop = False
        Me.btnSaveBlotter.Text = "  Save Blotter"
        Me.btnSaveBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveBlotter.UseVisualStyleBackColor = False
        '
        'ViewBlotters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewBlotters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blotter Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageView.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.pageAddModify.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.panelParent.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.panelSuspectDetails.ResumeLayout(False)
        Me.panelSuspectDetails.PerformLayout()
        Me.panelSuspectRadio.ResumeLayout(False)
        Me.panelSuspectRadio.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.panelBlotterId.ResumeLayout(False)
        Me.panelBlotterId.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveBlotter As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labelBlotterDetails As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents labelSubmittedOn As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelSubmittedBy As Label
    Friend WithEvents labelSuspect As Label
    Friend WithEvents labelBlotter As Label
    Friend WithEvents labelBlotterId As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents labelSuspectContactNo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labelSuspectAddress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelParent As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents txtBlotterDetails As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents datePickerSubmittedOn As DateTimePicker
    Friend WithEvents Label39 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents btnSearchSubmittedBy As Button
    Friend WithEvents txtSubmittedBy As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents panelSuspectDetails As Panel
    Friend WithEvents txtSuspectAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSuspectContactNo As TextBox
    Friend WithEvents panelSuspectRadio As Panel
    Friend WithEvents radioSuspectNonResident As RadioButton
    Friend WithEvents radioSuspectResident As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchSuspect As Button
    Friend WithEvents txtSuspect As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents comboBlotteredFor As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents panelBlotterId As Panel
    Friend WithEvents txtBlotterId As TextBox
    Friend WithEvents labelId As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label13 As Label
End Class
