<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewIncidents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewIncidents))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.labelIncidentReportedOn = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labelIncidentReportedBy = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelIncidentDetails = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelIncidentTime = New System.Windows.Forms.Label()
        Me.labelIncidentDate = New System.Windows.Forms.Label()
        Me.labelIncidentName = New System.Windows.Forms.Label()
        Me.labelIncidentId = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModifyIncident = New System.Windows.Forms.Button()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveIncident = New System.Windows.Forms.Button()
        Me.panelParent = New System.Windows.Forms.Panel()
        Me.btnSearchIncidentReportedBy = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIncidentReportedBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboIncidentTime = New System.Windows.Forms.ComboBox()
        Me.datePickerIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.txtIncidentDetails = New System.Windows.Forms.TextBox()
        Me.txtIncidentName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIncidentId = New System.Windows.Forms.TextBox()
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.pageAddModify.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.panelParent.SuspendLayout()
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
        Me.mainTabControl.Size = New System.Drawing.Size(703, 551)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 1
        '
        'pageView
        '
        Me.pageView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageView.Controls.Add(Me.Panel11)
        Me.pageView.Location = New System.Drawing.Point(4, 22)
        Me.pageView.Margin = New System.Windows.Forms.Padding(0)
        Me.pageView.Name = "pageView"
        Me.pageView.Size = New System.Drawing.Size(695, 525)
        Me.pageView.TabIndex = 2
        Me.pageView.Text = "View"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel11.Size = New System.Drawing.Size(695, 525)
        Me.Panel11.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel12, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48544!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.514564!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(675, 515)
        Me.TableLayoutPanel5.TabIndex = 39
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.labelIncidentReportedOn)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.labelIncidentReportedBy)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.labelIncidentDetails)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.labelIncidentTime)
        Me.Panel12.Controls.Add(Me.labelIncidentDate)
        Me.Panel12.Controls.Add(Me.labelIncidentName)
        Me.Panel12.Controls.Add(Me.labelIncidentId)
        Me.Panel12.Controls.Add(Me.Label100)
        Me.Panel12.Controls.Add(Me.Label101)
        Me.Panel12.Controls.Add(Me.Label102)
        Me.Panel12.Controls.Add(Me.Label103)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(669, 460)
        Me.Panel12.TabIndex = 38
        '
        'labelIncidentReportedOn
        '
        Me.labelIncidentReportedOn.AutoSize = True
        Me.labelIncidentReportedOn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentReportedOn.Location = New System.Drawing.Point(301, 283)
        Me.labelIncidentReportedOn.Name = "labelIncidentReportedOn"
        Me.labelIncidentReportedOn.Size = New System.Drawing.Size(25, 18)
        Me.labelIncidentReportedOn.TabIndex = 83
        Me.labelIncidentReportedOn.Text = "Jr."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 18)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Reported On: "
        '
        'labelIncidentReportedBy
        '
        Me.labelIncidentReportedBy.AutoSize = True
        Me.labelIncidentReportedBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelIncidentReportedBy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentReportedBy.Location = New System.Drawing.Point(301, 238)
        Me.labelIncidentReportedBy.Name = "labelIncidentReportedBy"
        Me.labelIncidentReportedBy.Size = New System.Drawing.Size(25, 18)
        Me.labelIncidentReportedBy.TabIndex = 81
        Me.labelIncidentReportedBy.Text = "Jr."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Reported By: "
        '
        'labelIncidentDetails
        '
        Me.labelIncidentDetails.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentDetails.Location = New System.Drawing.Point(301, 326)
        Me.labelIncidentDetails.Name = "labelIncidentDetails"
        Me.labelIncidentDetails.Size = New System.Drawing.Size(306, 97)
        Me.labelIncidentDetails.TabIndex = 79
        Me.labelIncidentDetails.Text = "Pekeng Steet."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Incident Details: "
        '
        'labelIncidentTime
        '
        Me.labelIncidentTime.AutoSize = True
        Me.labelIncidentTime.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentTime.Location = New System.Drawing.Point(301, 195)
        Me.labelIncidentTime.Name = "labelIncidentTime"
        Me.labelIncidentTime.Size = New System.Drawing.Size(25, 18)
        Me.labelIncidentTime.TabIndex = 43
        Me.labelIncidentTime.Text = "Jr."
        '
        'labelIncidentDate
        '
        Me.labelIncidentDate.AutoSize = True
        Me.labelIncidentDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentDate.Location = New System.Drawing.Point(301, 152)
        Me.labelIncidentDate.Name = "labelIncidentDate"
        Me.labelIncidentDate.Size = New System.Drawing.Size(137, 18)
        Me.labelIncidentDate.TabIndex = 42
        Me.labelIncidentDate.Text = "Kamusta ka na "
        '
        'labelIncidentName
        '
        Me.labelIncidentName.AutoSize = True
        Me.labelIncidentName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentName.Location = New System.Drawing.Point(301, 114)
        Me.labelIncidentName.Name = "labelIncidentName"
        Me.labelIncidentName.Size = New System.Drawing.Size(215, 18)
        Me.labelIncidentName.TabIndex = 41
        Me.labelIncidentName.Text = "Wala syang middle name"
        '
        'labelIncidentId
        '
        Me.labelIncidentId.AutoSize = True
        Me.labelIncidentId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIncidentId.Location = New System.Drawing.Point(301, 73)
        Me.labelIncidentId.Name = "labelIncidentId"
        Me.labelIncidentId.Size = New System.Drawing.Size(54, 18)
        Me.labelIncidentId.TabIndex = 40
        Me.labelIncidentId.Text = "Jopay"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(73, 195)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(59, 18)
        Me.Label100.TabIndex = 39
        Me.Label100.Text = "Time: "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(73, 152)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(58, 18)
        Me.Label101.TabIndex = 38
        Me.Label101.Text = "Date: "
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(73, 114)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(139, 18)
        Me.Label102.TabIndex = 37
        Me.Label102.Text = "Incident Name: "
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(73, 73)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(111, 18)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Incident ID: "
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.55904!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.571!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnModifyIncident, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 469)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(669, 43)
        Me.TableLayoutPanel6.TabIndex = 37
        '
        'btnModifyIncident
        '
        Me.btnModifyIncident.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyIncident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModifyIncident.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnModifyIncident.FlatAppearance.BorderSize = 0
        Me.btnModifyIncident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyIncident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyIncident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyIncident.ForeColor = System.Drawing.Color.White
        Me.btnModifyIncident.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnModifyIncident.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyIncident.Location = New System.Drawing.Point(517, 0)
        Me.btnModifyIncident.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModifyIncident.Name = "btnModifyIncident"
        Me.btnModifyIncident.Size = New System.Drawing.Size(152, 43)
        Me.btnModifyIncident.TabIndex = 34
        Me.btnModifyIncident.TabStop = False
        Me.btnModifyIncident.Text = "  Update Incident"
        Me.btnModifyIncident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyIncident.UseVisualStyleBackColor = False
        '
        'pageAddModify
        '
        Me.pageAddModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageAddModify.Controls.Add(Me.Panel5)
        Me.pageAddModify.Location = New System.Drawing.Point(4, 22)
        Me.pageAddModify.Margin = New System.Windows.Forms.Padding(0)
        Me.pageAddModify.Name = "pageAddModify"
        Me.pageAddModify.Size = New System.Drawing.Size(695, 525)
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
        Me.Panel5.Size = New System.Drawing.Size(695, 525)
        Me.Panel5.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.panelParent, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.91129!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.08871!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(675, 515)
        Me.TableLayoutPanel3.TabIndex = 39
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.47589!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.61742!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveIncident, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 460)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(669, 52)
        Me.TableLayoutPanel4.TabIndex = 37
        '
        'btnSaveIncident
        '
        Me.btnSaveIncident.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveIncident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveIncident.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveIncident.FlatAppearance.BorderSize = 0
        Me.btnSaveIncident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveIncident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveIncident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveIncident.ForeColor = System.Drawing.Color.White
        Me.btnSaveIncident.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveIncident.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveIncident.Location = New System.Drawing.Point(523, 10)
        Me.btnSaveIncident.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveIncident.Name = "btnSaveIncident"
        Me.btnSaveIncident.Size = New System.Drawing.Size(146, 42)
        Me.btnSaveIncident.TabIndex = 34
        Me.btnSaveIncident.TabStop = False
        Me.btnSaveIncident.Text = "  Save Incident"
        Me.btnSaveIncident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveIncident.UseVisualStyleBackColor = False
        '
        'panelParent
        '
        Me.panelParent.AutoScroll = True
        Me.panelParent.BackColor = System.Drawing.Color.White
        Me.panelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParent.Controls.Add(Me.btnSearchIncidentReportedBy)
        Me.panelParent.Controls.Add(Me.Label6)
        Me.panelParent.Controls.Add(Me.txtIncidentReportedBy)
        Me.panelParent.Controls.Add(Me.Label4)
        Me.panelParent.Controls.Add(Me.comboIncidentTime)
        Me.panelParent.Controls.Add(Me.datePickerIncidentDate)
        Me.panelParent.Controls.Add(Me.txtIncidentDetails)
        Me.panelParent.Controls.Add(Me.txtIncidentName)
        Me.panelParent.Controls.Add(Me.Label1)
        Me.panelParent.Controls.Add(Me.Label2)
        Me.panelParent.Controls.Add(Me.Label8)
        Me.panelParent.Controls.Add(Me.Label9)
        Me.panelParent.Controls.Add(Me.labelId)
        Me.panelParent.Controls.Add(Me.Label7)
        Me.panelParent.Controls.Add(Me.txtIncidentId)
        Me.panelParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelParent.Location = New System.Drawing.Point(3, 3)
        Me.panelParent.Name = "panelParent"
        Me.panelParent.Size = New System.Drawing.Size(669, 451)
        Me.panelParent.TabIndex = 38
        '
        'btnSearchIncidentReportedBy
        '
        Me.btnSearchIncidentReportedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchIncidentReportedBy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchIncidentReportedBy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchIncidentReportedBy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchIncidentReportedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchIncidentReportedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchIncidentReportedBy.ForeColor = System.Drawing.Color.White
        Me.btnSearchIncidentReportedBy.Image = CType(resources.GetObject("btnSearchIncidentReportedBy.Image"), System.Drawing.Image)
        Me.btnSearchIncidentReportedBy.Location = New System.Drawing.Point(589, 245)
        Me.btnSearchIncidentReportedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchIncidentReportedBy.Name = "btnSearchIncidentReportedBy"
        Me.btnSearchIncidentReportedBy.Size = New System.Drawing.Size(36, 27)
        Me.btnSearchIncidentReportedBy.TabIndex = 166
        Me.btnSearchIncidentReportedBy.TabStop = False
        Me.btnSearchIncidentReportedBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchIncidentReportedBy.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(512, 16)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Note: You can search for residents in the barangay using the search button"
        '
        'txtIncidentReportedBy
        '
        Me.txtIncidentReportedBy.BackColor = System.Drawing.Color.White
        Me.txtIncidentReportedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncidentReportedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidentReportedBy.ForeColor = System.Drawing.Color.Black
        Me.txtIncidentReportedBy.Location = New System.Drawing.Point(293, 245)
        Me.txtIncidentReportedBy.MaxLength = 20
        Me.txtIncidentReportedBy.Multiline = True
        Me.txtIncidentReportedBy.Name = "txtIncidentReportedBy"
        Me.txtIncidentReportedBy.Size = New System.Drawing.Size(293, 27)
        Me.txtIncidentReportedBy.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 18)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Reported By*: "
        '
        'comboIncidentTime
        '
        Me.comboIncidentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboIncidentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboIncidentTime.FormattingEnabled = True
        Me.comboIncidentTime.Items.AddRange(New Object() {"1:00 AM", "2:00 AM", "3:00 AM", "4:00 AM", "5:00 AM", "6:00 AM", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM", "12:00 AM"})
        Me.comboIncidentTime.Location = New System.Drawing.Point(293, 210)
        Me.comboIncidentTime.Name = "comboIncidentTime"
        Me.comboIncidentTime.Size = New System.Drawing.Size(293, 28)
        Me.comboIncidentTime.TabIndex = 4
        '
        'datePickerIncidentDate
        '
        Me.datePickerIncidentDate.CustomFormat = ""
        Me.datePickerIncidentDate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerIncidentDate.Location = New System.Drawing.Point(293, 179)
        Me.datePickerIncidentDate.Name = "datePickerIncidentDate"
        Me.datePickerIncidentDate.Size = New System.Drawing.Size(293, 26)
        Me.datePickerIncidentDate.TabIndex = 3
        '
        'txtIncidentDetails
        '
        Me.txtIncidentDetails.BackColor = System.Drawing.Color.White
        Me.txtIncidentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncidentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidentDetails.ForeColor = System.Drawing.Color.Black
        Me.txtIncidentDetails.Location = New System.Drawing.Point(293, 305)
        Me.txtIncidentDetails.MaxLength = 150
        Me.txtIncidentDetails.Multiline = True
        Me.txtIncidentDetails.Name = "txtIncidentDetails"
        Me.txtIncidentDetails.Size = New System.Drawing.Size(293, 120)
        Me.txtIncidentDetails.TabIndex = 7
        '
        'txtIncidentName
        '
        Me.txtIncidentName.BackColor = System.Drawing.Color.White
        Me.txtIncidentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncidentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidentName.ForeColor = System.Drawing.Color.Black
        Me.txtIncidentName.Location = New System.Drawing.Point(293, 145)
        Me.txtIncidentName.MaxLength = 20
        Me.txtIncidentName.Multiline = True
        Me.txtIncidentName.Name = "txtIncidentName"
        Me.txtIncidentName.Size = New System.Drawing.Size(293, 27)
        Me.txtIncidentName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Incident Details: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Time*: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Date*: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 18)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Incident Name*: "
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(75, 115)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(122, 18)
        Me.labelId.TabIndex = 101
        Me.labelId.Text = "Incident ID*: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(488, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Note: * Required "
        '
        'txtIncidentId
        '
        Me.txtIncidentId.BackColor = System.Drawing.Color.White
        Me.txtIncidentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncidentId.Enabled = False
        Me.txtIncidentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidentId.ForeColor = System.Drawing.Color.Black
        Me.txtIncidentId.Location = New System.Drawing.Point(293, 112)
        Me.txtIncidentId.MaxLength = 100
        Me.txtIncidentId.Multiline = True
        Me.txtIncidentId.Name = "txtIncidentId"
        Me.txtIncidentId.Size = New System.Drawing.Size(293, 27)
        Me.txtIncidentId.TabIndex = 1
        '
        'ViewIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewIncidents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incident Report Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageView.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.pageAddModify.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.panelParent.ResumeLayout(False)
        Me.panelParent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labelIncidentDetails As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelIncidentTime As Label
    Friend WithEvents labelIncidentDate As Label
    Friend WithEvents labelIncidentName As Label
    Friend WithEvents labelIncidentId As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnModifyIncident As Button
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveIncident As Button
    Friend WithEvents panelParent As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIncidentId As TextBox
    Friend WithEvents txtIncidentDetails As TextBox
    Friend WithEvents txtIncidentName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents labelId As Label
    Friend WithEvents datePickerIncidentDate As DateTimePicker
    Friend WithEvents comboIncidentTime As ComboBox
    Friend WithEvents labelIncidentReportedOn As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents labelIncidentReportedBy As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIncidentReportedBy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearchIncidentReportedBy As Button
End Class
