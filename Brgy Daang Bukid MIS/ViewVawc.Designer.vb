<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewVawc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewVawc))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.labelCaseDetails = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelSubmittedOn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelSubmittedBy = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.labelCaseStatus = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.labelRelationship = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelSuspect = New System.Windows.Forms.Label()
        Me.labelVictim = New System.Windows.Forms.Label()
        Me.labelCaseName = New System.Windows.Forms.Label()
        Me.labelCaseId = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModifyVawc = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveVawc = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.panelParent = New System.Windows.Forms.Panel()
        Me.btnSearchSubmittedBy = New System.Windows.Forms.Button()
        Me.comboCaseStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRelationship = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSearchParent = New System.Windows.Forms.Panel()
        Me.btnSearchVictim = New System.Windows.Forms.Button()
        Me.btnSearchSuspect = New System.Windows.Forms.Button()
        Me.txtSubmittedBy = New System.Windows.Forms.TextBox()
        Me.datePickerSubmittedOn = New System.Windows.Forms.DateTimePicker()
        Me.txtCaseDetails = New System.Windows.Forms.TextBox()
        Me.txtSuspect = New System.Windows.Forms.TextBox()
        Me.txtVictim = New System.Windows.Forms.TextBox()
        Me.txtCaseId = New System.Windows.Forms.TextBox()
        Me.txtCaseName = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.labelId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.pageAddModify.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.panelParent.SuspendLayout()
        Me.panelSearchParent.SuspendLayout()
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
        Me.Panel11.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel11.Size = New System.Drawing.Size(689, 525)
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
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.487085!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.36531!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1476!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(669, 515)
        Me.TableLayoutPanel5.TabIndex = 39
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.labelCaseDetails)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.labelSubmittedOn)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.labelSubmittedBy)
        Me.Panel12.Controls.Add(Me.Label29)
        Me.Panel12.Controls.Add(Me.labelCaseStatus)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Controls.Add(Me.labelRelationship)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.labelSuspect)
        Me.Panel12.Controls.Add(Me.labelVictim)
        Me.Panel12.Controls.Add(Me.labelCaseName)
        Me.Panel12.Controls.Add(Me.labelCaseId)
        Me.Panel12.Controls.Add(Me.Label100)
        Me.Panel12.Controls.Add(Me.Label101)
        Me.Panel12.Controls.Add(Me.Label102)
        Me.Panel12.Controls.Add(Me.Label103)
        Me.Panel12.Controls.Add(Me.Panel2)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(3, 46)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(663, 413)
        Me.Panel12.TabIndex = 38
        '
        'labelCaseDetails
        '
        Me.labelCaseDetails.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaseDetails.Location = New System.Drawing.Point(280, 270)
        Me.labelCaseDetails.Name = "labelCaseDetails"
        Me.labelCaseDetails.Size = New System.Drawing.Size(327, 56)
        Me.labelCaseDetails.TabIndex = 69
        Me.labelCaseDetails.Text = "Jr."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Case Details: "
        '
        'labelSubmittedOn
        '
        Me.labelSubmittedOn.AutoSize = True
        Me.labelSubmittedOn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubmittedOn.Location = New System.Drawing.Point(282, 388)
        Me.labelSubmittedOn.Name = "labelSubmittedOn"
        Me.labelSubmittedOn.Size = New System.Drawing.Size(25, 18)
        Me.labelSubmittedOn.TabIndex = 67
        Me.labelSubmittedOn.Text = "Jr."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Submitted On: "
        '
        'labelSubmittedBy
        '
        Me.labelSubmittedBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelSubmittedBy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubmittedBy.Location = New System.Drawing.Point(282, 350)
        Me.labelSubmittedBy.Name = "labelSubmittedBy"
        Me.labelSubmittedBy.Size = New System.Drawing.Size(347, 18)
        Me.labelSubmittedBy.TabIndex = 65
        Me.labelSubmittedBy.Text = "Jr."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(54, 350)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(130, 18)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "Submitted By: "
        '
        'labelCaseStatus
        '
        Me.labelCaseStatus.AutoSize = True
        Me.labelCaseStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaseStatus.Location = New System.Drawing.Point(282, 231)
        Me.labelCaseStatus.Name = "labelCaseStatus"
        Me.labelCaseStatus.Size = New System.Drawing.Size(25, 18)
        Me.labelCaseStatus.TabIndex = 63
        Me.labelCaseStatus.Text = "Jr."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(54, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(118, 18)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Case Status: "
        '
        'labelRelationship
        '
        Me.labelRelationship.AutoSize = True
        Me.labelRelationship.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRelationship.Location = New System.Drawing.Point(282, 196)
        Me.labelRelationship.Name = "labelRelationship"
        Me.labelRelationship.Size = New System.Drawing.Size(25, 18)
        Me.labelRelationship.TabIndex = 45
        Me.labelRelationship.Text = "Jr."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Relationship to Suspect:"
        '
        'labelSuspect
        '
        Me.labelSuspect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelSuspect.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSuspect.Location = New System.Drawing.Point(282, 161)
        Me.labelSuspect.Name = "labelSuspect"
        Me.labelSuspect.Size = New System.Drawing.Size(347, 18)
        Me.labelSuspect.TabIndex = 43
        Me.labelSuspect.Text = "Jr."
        '
        'labelVictim
        '
        Me.labelVictim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelVictim.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVictim.Location = New System.Drawing.Point(282, 129)
        Me.labelVictim.Name = "labelVictim"
        Me.labelVictim.Size = New System.Drawing.Size(347, 18)
        Me.labelVictim.TabIndex = 42
        Me.labelVictim.Text = "Kamusta ka na "
        '
        'labelCaseName
        '
        Me.labelCaseName.AutoSize = True
        Me.labelCaseName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaseName.Location = New System.Drawing.Point(282, 95)
        Me.labelCaseName.Name = "labelCaseName"
        Me.labelCaseName.Size = New System.Drawing.Size(116, 18)
        Me.labelCaseName.TabIndex = 41
        Me.labelCaseName.Text = "KOMPLAINT"
        '
        'labelCaseId
        '
        Me.labelCaseId.AutoSize = True
        Me.labelCaseId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaseId.Location = New System.Drawing.Point(282, 60)
        Me.labelCaseId.Name = "labelCaseId"
        Me.labelCaseId.Size = New System.Drawing.Size(54, 18)
        Me.labelCaseId.TabIndex = 40
        Me.labelCaseId.Text = "Jopay"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(54, 161)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(84, 18)
        Me.Label100.TabIndex = 39
        Me.Label100.Text = "Suspect: "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(54, 129)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(69, 18)
        Me.Label101.TabIndex = 38
        Me.Label101.Text = "Victim: "
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(54, 95)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(112, 18)
        Me.Label102.TabIndex = 37
        Me.Label102.Text = "Case Name: "
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(54, 60)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(84, 18)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Case ID: "
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(619, 410)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 61)
        Me.Panel2.TabIndex = 56
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.18703!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88688!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnModifyVawc, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 465)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(663, 47)
        Me.TableLayoutPanel6.TabIndex = 37
        '
        'btnModifyVawc
        '
        Me.btnModifyVawc.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyVawc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModifyVawc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnModifyVawc.FlatAppearance.BorderSize = 0
        Me.btnModifyVawc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVawc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyVawc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyVawc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyVawc.ForeColor = System.Drawing.Color.White
        Me.btnModifyVawc.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnModifyVawc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyVawc.Location = New System.Drawing.Point(497, 10)
        Me.btnModifyVawc.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModifyVawc.Name = "btnModifyVawc"
        Me.btnModifyVawc.Size = New System.Drawing.Size(166, 37)
        Me.btnModifyVawc.TabIndex = 34
        Me.btnModifyVawc.TabStop = False
        Me.btnModifyVawc.Text = "  Update Case"
        Me.btnModifyVawc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyVawc.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Label104)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(663, 37)
        Me.Panel16.TabIndex = 78
        '
        'Label104
        '
        Me.Label104.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label104.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(0, 0)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(663, 37)
        Me.Label104.TabIndex = 71
        Me.Label104.Text = "VAWC CASE REPORT"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.panelParent, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.487085!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.36531!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.1476!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(669, 515)
        Me.TableLayoutPanel3.TabIndex = 39
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.47589!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.61742!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveVawc, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 465)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(663, 47)
        Me.TableLayoutPanel4.TabIndex = 37
        '
        'btnSaveVawc
        '
        Me.btnSaveVawc.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveVawc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveVawc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveVawc.FlatAppearance.BorderSize = 0
        Me.btnSaveVawc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveVawc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveVawc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveVawc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveVawc.ForeColor = System.Drawing.Color.White
        Me.btnSaveVawc.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveVawc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveVawc.Location = New System.Drawing.Point(519, 10)
        Me.btnSaveVawc.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveVawc.Name = "btnSaveVawc"
        Me.btnSaveVawc.Size = New System.Drawing.Size(144, 37)
        Me.btnSaveVawc.TabIndex = 34
        Me.btnSaveVawc.TabStop = False
        Me.btnSaveVawc.Text = "  Save Case"
        Me.btnSaveVawc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveVawc.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label64)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(663, 37)
        Me.Panel10.TabIndex = 78
        '
        'Label64
        '
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label64.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(0, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(663, 37)
        Me.Label64.TabIndex = 71
        Me.Label64.Text = "VAWC CASE REPORT"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelParent
        '
        Me.panelParent.AutoScroll = True
        Me.panelParent.BackColor = System.Drawing.Color.White
        Me.panelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParent.Controls.Add(Me.Label9)
        Me.panelParent.Controls.Add(Me.btnSearchSubmittedBy)
        Me.panelParent.Controls.Add(Me.comboCaseStatus)
        Me.panelParent.Controls.Add(Me.Label8)
        Me.panelParent.Controls.Add(Me.txtRelationship)
        Me.panelParent.Controls.Add(Me.Label1)
        Me.panelParent.Controls.Add(Me.panelSearchParent)
        Me.panelParent.Controls.Add(Me.txtSubmittedBy)
        Me.panelParent.Controls.Add(Me.datePickerSubmittedOn)
        Me.panelParent.Controls.Add(Me.txtCaseDetails)
        Me.panelParent.Controls.Add(Me.txtSuspect)
        Me.panelParent.Controls.Add(Me.txtVictim)
        Me.panelParent.Controls.Add(Me.txtCaseId)
        Me.panelParent.Controls.Add(Me.txtCaseName)
        Me.panelParent.Controls.Add(Me.Label32)
        Me.panelParent.Controls.Add(Me.Label2)
        Me.panelParent.Controls.Add(Me.Label6)
        Me.panelParent.Controls.Add(Me.Label15)
        Me.panelParent.Controls.Add(Me.Label18)
        Me.panelParent.Controls.Add(Me.Label20)
        Me.panelParent.Controls.Add(Me.labelId)
        Me.panelParent.Controls.Add(Me.Label7)
        Me.panelParent.Controls.Add(Me.Panel1)
        Me.panelParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelParent.Location = New System.Drawing.Point(3, 46)
        Me.panelParent.Name = "panelParent"
        Me.panelParent.Size = New System.Drawing.Size(663, 413)
        Me.panelParent.TabIndex = 38
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
        Me.btnSearchSubmittedBy.Location = New System.Drawing.Point(581, 403)
        Me.btnSearchSubmittedBy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchSubmittedBy.Name = "btnSearchSubmittedBy"
        Me.btnSearchSubmittedBy.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchSubmittedBy.TabIndex = 136
        Me.btnSearchSubmittedBy.TabStop = False
        Me.btnSearchSubmittedBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchSubmittedBy.UseVisualStyleBackColor = False
        '
        'comboCaseStatus
        '
        Me.comboCaseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCaseStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCaseStatus.FormattingEnabled = True
        Me.comboCaseStatus.Items.AddRange(New Object() {"Ongoing", "Closed", "Filed for Action"})
        Me.comboCaseStatus.Location = New System.Drawing.Point(263, 253)
        Me.comboCaseStatus.Name = "comboCaseStatus"
        Me.comboCaseStatus.Size = New System.Drawing.Size(303, 28)
        Me.comboCaseStatus.TabIndex = 135
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 18)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Case Status*: "
        '
        'txtRelationship
        '
        Me.txtRelationship.BackColor = System.Drawing.Color.White
        Me.txtRelationship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationship.ForeColor = System.Drawing.Color.Black
        Me.txtRelationship.Location = New System.Drawing.Point(263, 220)
        Me.txtRelationship.MaxLength = 50
        Me.txtRelationship.Multiline = True
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(303, 27)
        Me.txtRelationship.TabIndex = 132
        Me.txtRelationship.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Relationship*: "
        '
        'panelSearchParent
        '
        Me.panelSearchParent.Controls.Add(Me.btnSearchVictim)
        Me.panelSearchParent.Controls.Add(Me.btnSearchSuspect)
        Me.panelSearchParent.Location = New System.Drawing.Point(572, 136)
        Me.panelSearchParent.Name = "panelSearchParent"
        Me.panelSearchParent.Size = New System.Drawing.Size(55, 100)
        Me.panelSearchParent.TabIndex = 130
        '
        'btnSearchVictim
        '
        Me.btnSearchVictim.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchVictim.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchVictim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchVictim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchVictim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchVictim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchVictim.ForeColor = System.Drawing.Color.White
        Me.btnSearchVictim.Image = CType(resources.GetObject("btnSearchVictim.Image"), System.Drawing.Image)
        Me.btnSearchVictim.Location = New System.Drawing.Point(9, 18)
        Me.btnSearchVictim.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchVictim.Name = "btnSearchVictim"
        Me.btnSearchVictim.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchVictim.TabIndex = 128
        Me.btnSearchVictim.TabStop = False
        Me.btnSearchVictim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchVictim.UseVisualStyleBackColor = False
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
        Me.btnSearchSuspect.Location = New System.Drawing.Point(9, 51)
        Me.btnSearchSuspect.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchSuspect.Name = "btnSearchSuspect"
        Me.btnSearchSuspect.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchSuspect.TabIndex = 129
        Me.btnSearchSuspect.TabStop = False
        Me.btnSearchSuspect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchSuspect.UseVisualStyleBackColor = False
        '
        'txtSubmittedBy
        '
        Me.txtSubmittedBy.BackColor = System.Drawing.Color.White
        Me.txtSubmittedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubmittedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubmittedBy.ForeColor = System.Drawing.Color.Black
        Me.txtSubmittedBy.Location = New System.Drawing.Point(263, 403)
        Me.txtSubmittedBy.MaxLength = 50
        Me.txtSubmittedBy.Multiline = True
        Me.txtSubmittedBy.Name = "txtSubmittedBy"
        Me.txtSubmittedBy.Size = New System.Drawing.Size(303, 27)
        Me.txtSubmittedBy.TabIndex = 125
        Me.txtSubmittedBy.Tag = ""
        '
        'datePickerSubmittedOn
        '
        Me.datePickerSubmittedOn.CustomFormat = ""
        Me.datePickerSubmittedOn.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerSubmittedOn.Location = New System.Drawing.Point(263, 439)
        Me.datePickerSubmittedOn.Name = "datePickerSubmittedOn"
        Me.datePickerSubmittedOn.Size = New System.Drawing.Size(303, 26)
        Me.datePickerSubmittedOn.TabIndex = 121
        '
        'txtCaseDetails
        '
        Me.txtCaseDetails.BackColor = System.Drawing.Color.White
        Me.txtCaseDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCaseDetails.Location = New System.Drawing.Point(263, 287)
        Me.txtCaseDetails.MaxLength = 150
        Me.txtCaseDetails.Multiline = True
        Me.txtCaseDetails.Name = "txtCaseDetails"
        Me.txtCaseDetails.Size = New System.Drawing.Size(303, 69)
        Me.txtCaseDetails.TabIndex = 119
        Me.txtCaseDetails.Tag = ""
        '
        'txtSuspect
        '
        Me.txtSuspect.BackColor = System.Drawing.Color.White
        Me.txtSuspect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuspect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuspect.ForeColor = System.Drawing.Color.Black
        Me.txtSuspect.Location = New System.Drawing.Point(263, 187)
        Me.txtSuspect.MaxLength = 50
        Me.txtSuspect.Multiline = True
        Me.txtSuspect.Name = "txtSuspect"
        Me.txtSuspect.Size = New System.Drawing.Size(303, 27)
        Me.txtSuspect.TabIndex = 118
        Me.txtSuspect.Tag = ""
        '
        'txtVictim
        '
        Me.txtVictim.BackColor = System.Drawing.Color.White
        Me.txtVictim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVictim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVictim.ForeColor = System.Drawing.Color.Black
        Me.txtVictim.Location = New System.Drawing.Point(263, 154)
        Me.txtVictim.MaxLength = 50
        Me.txtVictim.Multiline = True
        Me.txtVictim.Name = "txtVictim"
        Me.txtVictim.Size = New System.Drawing.Size(303, 27)
        Me.txtVictim.TabIndex = 117
        Me.txtVictim.Tag = ""
        '
        'txtCaseId
        '
        Me.txtCaseId.BackColor = System.Drawing.Color.White
        Me.txtCaseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseId.Enabled = False
        Me.txtCaseId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseId.ForeColor = System.Drawing.Color.Black
        Me.txtCaseId.Location = New System.Drawing.Point(263, 88)
        Me.txtCaseId.MaxLength = 100
        Me.txtCaseId.Multiline = True
        Me.txtCaseId.Name = "txtCaseId"
        Me.txtCaseId.Size = New System.Drawing.Size(303, 27)
        Me.txtCaseId.TabIndex = 116
        Me.txtCaseId.Tag = ""
        '
        'txtCaseName
        '
        Me.txtCaseName.BackColor = System.Drawing.Color.White
        Me.txtCaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseName.ForeColor = System.Drawing.Color.Black
        Me.txtCaseName.Location = New System.Drawing.Point(263, 121)
        Me.txtCaseName.MaxLength = 20
        Me.txtCaseName.Multiline = True
        Me.txtCaseName.Name = "txtCaseName"
        Me.txtCaseName.Size = New System.Drawing.Size(303, 27)
        Me.txtCaseName.TabIndex = 115
        Me.txtCaseName.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(55, 290)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 18)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Case Details: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Submitted On: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Submitted By*: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 18)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Suspect*: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(55, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Victim*: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(55, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 18)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Case Name*: "
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(55, 91)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(84, 18)
        Me.labelId.TabIndex = 93
        Me.labelId.Text = "Case ID: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(465, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Note: * Required "
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(631, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 74)
        Me.Panel1.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(531, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Note: You can use the search button to search for a resident in the barangay "
        '
        'ViewVawc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewVawc"
        Me.Text = "Vawc Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageView.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.pageAddModify.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.panelParent.ResumeLayout(False)
        Me.panelParent.PerformLayout()
        Me.panelSearchParent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labelSubmittedBy As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents labelCaseStatus As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents labelRelationship As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents labelSuspect As Label
    Friend WithEvents labelVictim As Label
    Friend WithEvents labelCaseName As Label
    Friend WithEvents labelCaseId As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnModifyVawc As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label104 As Label
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveVawc As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents panelParent As Panel
    Friend WithEvents panelSearchParent As Panel
    Friend WithEvents btnSearchVictim As Button
    Friend WithEvents btnSearchSuspect As Button
    Friend WithEvents txtSubmittedBy As TextBox
    Friend WithEvents datePickerSubmittedOn As DateTimePicker
    Friend WithEvents txtCaseDetails As TextBox
    Friend WithEvents txtSuspect As TextBox
    Friend WithEvents txtVictim As TextBox
    Friend WithEvents txtCaseId As TextBox
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents labelId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelSubmittedOn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelCaseDetails As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRelationship As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboCaseStatus As ComboBox
    Friend WithEvents btnSearchSubmittedBy As Button
    Friend WithEvents Label9 As Label
End Class
