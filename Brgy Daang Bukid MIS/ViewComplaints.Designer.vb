<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewComplaints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewComplaints))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.labelDetails = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.labelDateFiled = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.labelThirdResult = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.labelThirdDate = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.labelSecondResult = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labelSecondDate = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.labelFirstResult = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.labelFirstDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labelDefendant = New System.Windows.Forms.Label()
        Me.labelComplainant = New System.Windows.Forms.Label()
        Me.labelComplaint = New System.Windows.Forms.Label()
        Me.labelComplaintId = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.panelParent = New System.Windows.Forms.Panel()
        Me.panelSearchParent = New System.Windows.Forms.Panel()
        Me.panelHearingParent = New System.Windows.Forms.Panel()
        Me.comboFirstResult = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.comboThirdResult = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.comboSecondResult = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.datePickerDateComplaint = New System.Windows.Forms.DateTimePicker()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtDefendant = New System.Windows.Forms.TextBox()
        Me.txtComplainant = New System.Windows.Forms.TextBox()
        Me.txtComplaintId = New System.Windows.Forms.TextBox()
        Me.txtComplaint = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.labelId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModifyComplaint = New System.Windows.Forms.Button()
        Me.btnSaveComplaint = New System.Windows.Forms.Button()
        Me.btnSearchComplainant = New System.Windows.Forms.Button()
        Me.btnSearchDefendant = New System.Windows.Forms.Button()
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
        Me.panelHearingParent.SuspendLayout()
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
        Me.mainTabControl.TabIndex = 2
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
        Me.Panel12.Controls.Add(Me.labelDetails)
        Me.Panel12.Controls.Add(Me.Label29)
        Me.Panel12.Controls.Add(Me.labelDateFiled)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Controls.Add(Me.labelThirdResult)
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.labelThirdDate)
        Me.Panel12.Controls.Add(Me.Label21)
        Me.Panel12.Controls.Add(Me.Label22)
        Me.Panel12.Controls.Add(Me.labelSecondResult)
        Me.Panel12.Controls.Add(Me.Label14)
        Me.Panel12.Controls.Add(Me.labelSecondDate)
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Controls.Add(Me.labelFirstResult)
        Me.Panel12.Controls.Add(Me.Label12)
        Me.Panel12.Controls.Add(Me.labelFirstDate)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.labelStatus)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.labelDefendant)
        Me.Panel12.Controls.Add(Me.labelComplainant)
        Me.Panel12.Controls.Add(Me.labelComplaint)
        Me.Panel12.Controls.Add(Me.labelComplaintId)
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
        'labelDetails
        '
        Me.labelDetails.AutoSize = True
        Me.labelDetails.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDetails.Location = New System.Drawing.Point(282, 269)
        Me.labelDetails.Name = "labelDetails"
        Me.labelDetails.Size = New System.Drawing.Size(25, 18)
        Me.labelDetails.TabIndex = 65
        Me.labelDetails.Text = "Jr."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(54, 269)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(75, 18)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "Details: "
        '
        'labelDateFiled
        '
        Me.labelDateFiled.AutoSize = True
        Me.labelDateFiled.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDateFiled.Location = New System.Drawing.Point(282, 231)
        Me.labelDateFiled.Name = "labelDateFiled"
        Me.labelDateFiled.Size = New System.Drawing.Size(25, 18)
        Me.labelDateFiled.TabIndex = 63
        Me.labelDateFiled.Text = "Jr."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(54, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 18)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Date Filed: "
        '
        'labelThirdResult
        '
        Me.labelThirdResult.AutoSize = True
        Me.labelThirdResult.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelThirdResult.Location = New System.Drawing.Point(282, 610)
        Me.labelThirdResult.Name = "labelThirdResult"
        Me.labelThirdResult.Size = New System.Drawing.Size(25, 18)
        Me.labelThirdResult.TabIndex = 61
        Me.labelThirdResult.Text = "Jr."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(54, 610)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 18)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Result: "
        '
        'labelThirdDate
        '
        Me.labelThirdDate.AutoSize = True
        Me.labelThirdDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelThirdDate.Location = New System.Drawing.Point(282, 578)
        Me.labelThirdDate.Name = "labelThirdDate"
        Me.labelThirdDate.Size = New System.Drawing.Size(25, 18)
        Me.labelThirdDate.TabIndex = 59
        Me.labelThirdDate.Text = "Jr."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(54, 578)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 18)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Date: "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(54, 546)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(156, 18)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "THIRD HEARING: "
        '
        'labelSecondResult
        '
        Me.labelSecondResult.AutoSize = True
        Me.labelSecondResult.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSecondResult.Location = New System.Drawing.Point(282, 512)
        Me.labelSecondResult.Name = "labelSecondResult"
        Me.labelSecondResult.Size = New System.Drawing.Size(25, 18)
        Me.labelSecondResult.TabIndex = 55
        Me.labelSecondResult.Text = "Jr."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(54, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 18)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Result: "
        '
        'labelSecondDate
        '
        Me.labelSecondDate.AutoSize = True
        Me.labelSecondDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSecondDate.Location = New System.Drawing.Point(282, 480)
        Me.labelSecondDate.Name = "labelSecondDate"
        Me.labelSecondDate.Size = New System.Drawing.Size(25, 18)
        Me.labelSecondDate.TabIndex = 53
        Me.labelSecondDate.Text = "Jr."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(54, 480)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 18)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Date: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(54, 448)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(171, 18)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "SECOND HEARING: "
        '
        'labelFirstResult
        '
        Me.labelFirstResult.AutoSize = True
        Me.labelFirstResult.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirstResult.Location = New System.Drawing.Point(282, 411)
        Me.labelFirstResult.Name = "labelFirstResult"
        Me.labelFirstResult.Size = New System.Drawing.Size(25, 18)
        Me.labelFirstResult.TabIndex = 50
        Me.labelFirstResult.Text = "Jr."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 18)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Result: "
        '
        'labelFirstDate
        '
        Me.labelFirstDate.AutoSize = True
        Me.labelFirstDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirstDate.Location = New System.Drawing.Point(282, 379)
        Me.labelFirstDate.Name = "labelFirstDate"
        Me.labelFirstDate.Size = New System.Drawing.Size(25, 18)
        Me.labelFirstDate.TabIndex = 48
        Me.labelFirstDate.Text = "Jr."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Date: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "FIRST HEARING: "
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatus.Location = New System.Drawing.Point(282, 196)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(25, 18)
        Me.labelStatus.TabIndex = 45
        Me.labelStatus.Text = "Jr."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Status: "
        '
        'labelDefendant
        '
        Me.labelDefendant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelDefendant.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDefendant.Location = New System.Drawing.Point(282, 161)
        Me.labelDefendant.Name = "labelDefendant"
        Me.labelDefendant.Size = New System.Drawing.Size(347, 18)
        Me.labelDefendant.TabIndex = 43
        Me.labelDefendant.Text = "Jr."
        '
        'labelComplainant
        '
        Me.labelComplainant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelComplainant.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelComplainant.Location = New System.Drawing.Point(282, 129)
        Me.labelComplainant.Name = "labelComplainant"
        Me.labelComplainant.Size = New System.Drawing.Size(347, 18)
        Me.labelComplainant.TabIndex = 42
        Me.labelComplainant.Text = "Kamusta ka na "
        '
        'labelComplaint
        '
        Me.labelComplaint.AutoSize = True
        Me.labelComplaint.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelComplaint.Location = New System.Drawing.Point(282, 95)
        Me.labelComplaint.Name = "labelComplaint"
        Me.labelComplaint.Size = New System.Drawing.Size(116, 18)
        Me.labelComplaint.TabIndex = 41
        Me.labelComplaint.Text = "KOMPLAINT"
        '
        'labelComplaintId
        '
        Me.labelComplaintId.AutoSize = True
        Me.labelComplaintId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelComplaintId.Location = New System.Drawing.Point(282, 60)
        Me.labelComplaintId.Name = "labelComplaintId"
        Me.labelComplaintId.Size = New System.Drawing.Size(54, 18)
        Me.labelComplaintId.TabIndex = 40
        Me.labelComplaintId.Text = "Jopay"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(54, 161)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(104, 18)
        Me.Label100.TabIndex = 39
        Me.Label100.Text = "Defendant: "
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(54, 129)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(121, 18)
        Me.Label101.TabIndex = 38
        Me.Label101.Text = "Complainant: "
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(54, 95)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(101, 18)
        Me.Label102.TabIndex = 37
        Me.Label102.Text = "Complaint: "
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(54, 60)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(126, 18)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Complaint ID: "
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(631, 578)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 100)
        Me.Panel2.TabIndex = 56
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.18703!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88688!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnModifyComplaint, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 465)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(663, 47)
        Me.TableLayoutPanel6.TabIndex = 37
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
        Me.Label104.Text = "COMPLAINT REPORT"
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
        Me.TableLayoutPanel4.Controls.Add(Me.btnSaveComplaint, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 465)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(663, 47)
        Me.TableLayoutPanel4.TabIndex = 37
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
        Me.Label64.Text = "COMPLAINT REPORT"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelParent
        '
        Me.panelParent.AutoScroll = True
        Me.panelParent.BackColor = System.Drawing.Color.White
        Me.panelParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelParent.Controls.Add(Me.panelSearchParent)
        Me.panelParent.Controls.Add(Me.panelHearingParent)
        Me.panelParent.Controls.Add(Me.txtStatus)
        Me.panelParent.Controls.Add(Me.datePickerDateComplaint)
        Me.panelParent.Controls.Add(Me.txtDetails)
        Me.panelParent.Controls.Add(Me.txtDefendant)
        Me.panelParent.Controls.Add(Me.txtComplainant)
        Me.panelParent.Controls.Add(Me.txtComplaintId)
        Me.panelParent.Controls.Add(Me.txtComplaint)
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
        'panelSearchParent
        '
        Me.panelSearchParent.Controls.Add(Me.btnSearchComplainant)
        Me.panelSearchParent.Controls.Add(Me.btnSearchDefendant)
        Me.panelSearchParent.Location = New System.Drawing.Point(572, 117)
        Me.panelSearchParent.Name = "panelSearchParent"
        Me.panelSearchParent.Size = New System.Drawing.Size(55, 100)
        Me.panelSearchParent.TabIndex = 130
        '
        'panelHearingParent
        '
        Me.panelHearingParent.Controls.Add(Me.comboFirstResult)
        Me.panelHearingParent.Controls.Add(Me.Label33)
        Me.panelHearingParent.Controls.Add(Me.comboThirdResult)
        Me.panelHearingParent.Controls.Add(Me.Label31)
        Me.panelHearingParent.Controls.Add(Me.comboSecondResult)
        Me.panelHearingParent.Controls.Add(Me.Label30)
        Me.panelHearingParent.Controls.Add(Me.Label28)
        Me.panelHearingParent.Controls.Add(Me.Label27)
        Me.panelHearingParent.Controls.Add(Me.Label25)
        Me.panelHearingParent.Location = New System.Drawing.Point(47, 363)
        Me.panelHearingParent.Name = "panelHearingParent"
        Me.panelHearingParent.Size = New System.Drawing.Size(531, 209)
        Me.panelHearingParent.TabIndex = 126
        '
        'comboFirstResult
        '
        Me.comboFirstResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFirstResult.Enabled = False
        Me.comboFirstResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFirstResult.FormattingEnabled = True
        Me.comboFirstResult.Items.AddRange(New Object() {"Unsettled", "Settled"})
        Me.comboFirstResult.Location = New System.Drawing.Point(216, 35)
        Me.comboFirstResult.Name = "comboFirstResult"
        Me.comboFirstResult.Size = New System.Drawing.Size(303, 28)
        Me.comboFirstResult.TabIndex = 122
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 11)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(153, 18)
        Me.Label33.TabIndex = 105
        Me.Label33.Text = "FIRST HEARING: "
        '
        'comboThirdResult
        '
        Me.comboThirdResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboThirdResult.Enabled = False
        Me.comboThirdResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboThirdResult.FormattingEnabled = True
        Me.comboThirdResult.Items.AddRange(New Object() {"Settled", "Filed for Action"})
        Me.comboThirdResult.Location = New System.Drawing.Point(216, 164)
        Me.comboThirdResult.Name = "comboThirdResult"
        Me.comboThirdResult.Size = New System.Drawing.Size(303, 28)
        Me.comboThirdResult.TabIndex = 124
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 39)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 18)
        Me.Label31.TabIndex = 107
        Me.Label31.Text = "Result: "
        '
        'comboSecondResult
        '
        Me.comboSecondResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSecondResult.Enabled = False
        Me.comboSecondResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSecondResult.FormattingEnabled = True
        Me.comboSecondResult.Items.AddRange(New Object() {"Unsettled", "Settled"})
        Me.comboSecondResult.Location = New System.Drawing.Point(216, 105)
        Me.comboSecondResult.Name = "comboSecondResult"
        Me.comboSecondResult.Size = New System.Drawing.Size(303, 28)
        Me.comboSecondResult.TabIndex = 123
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 74)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(171, 18)
        Me.Label30.TabIndex = 108
        Me.Label30.Text = "SECOND HEARING: "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 109)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 110
        Me.Label28.Text = "Result: "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(156, 18)
        Me.Label27.TabIndex = 111
        Me.Label27.Text = "THIRD HEARING: "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 18)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Result: "
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(263, 201)
        Me.txtStatus.MaxLength = 100
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(303, 27)
        Me.txtStatus.TabIndex = 125
        Me.txtStatus.Tag = ""
        '
        'datePickerDateComplaint
        '
        Me.datePickerDateComplaint.CustomFormat = ""
        Me.datePickerDateComplaint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePickerDateComplaint.Location = New System.Drawing.Point(263, 237)
        Me.datePickerDateComplaint.Name = "datePickerDateComplaint"
        Me.datePickerDateComplaint.Size = New System.Drawing.Size(303, 26)
        Me.datePickerDateComplaint.TabIndex = 121
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.White
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.ForeColor = System.Drawing.Color.Black
        Me.txtDetails.Location = New System.Drawing.Point(263, 274)
        Me.txtDetails.MaxLength = 100
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(303, 69)
        Me.txtDetails.TabIndex = 119
        Me.txtDetails.Tag = ""
        '
        'txtDefendant
        '
        Me.txtDefendant.BackColor = System.Drawing.Color.White
        Me.txtDefendant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDefendant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefendant.ForeColor = System.Drawing.Color.Black
        Me.txtDefendant.Location = New System.Drawing.Point(263, 168)
        Me.txtDefendant.MaxLength = 100
        Me.txtDefendant.Multiline = True
        Me.txtDefendant.Name = "txtDefendant"
        Me.txtDefendant.Size = New System.Drawing.Size(303, 27)
        Me.txtDefendant.TabIndex = 118
        Me.txtDefendant.Tag = ""
        '
        'txtComplainant
        '
        Me.txtComplainant.BackColor = System.Drawing.Color.White
        Me.txtComplainant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplainant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplainant.ForeColor = System.Drawing.Color.Black
        Me.txtComplainant.Location = New System.Drawing.Point(263, 135)
        Me.txtComplainant.MaxLength = 100
        Me.txtComplainant.Multiline = True
        Me.txtComplainant.Name = "txtComplainant"
        Me.txtComplainant.Size = New System.Drawing.Size(303, 27)
        Me.txtComplainant.TabIndex = 117
        Me.txtComplainant.Tag = ""
        '
        'txtComplaintId
        '
        Me.txtComplaintId.BackColor = System.Drawing.Color.White
        Me.txtComplaintId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplaintId.Enabled = False
        Me.txtComplaintId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplaintId.ForeColor = System.Drawing.Color.Black
        Me.txtComplaintId.Location = New System.Drawing.Point(263, 69)
        Me.txtComplaintId.MaxLength = 100
        Me.txtComplaintId.Multiline = True
        Me.txtComplaintId.Name = "txtComplaintId"
        Me.txtComplaintId.Size = New System.Drawing.Size(303, 27)
        Me.txtComplaintId.TabIndex = 116
        Me.txtComplaintId.Tag = ""
        '
        'txtComplaint
        '
        Me.txtComplaint.BackColor = System.Drawing.Color.White
        Me.txtComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplaint.ForeColor = System.Drawing.Color.Black
        Me.txtComplaint.Location = New System.Drawing.Point(263, 102)
        Me.txtComplaint.MaxLength = 100
        Me.txtComplaint.Multiline = True
        Me.txtComplaint.Name = "txtComplaint"
        Me.txtComplaint.Size = New System.Drawing.Size(303, 27)
        Me.txtComplaint.TabIndex = 115
        Me.txtComplaint.Tag = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(55, 277)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 18)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Details: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Date Filed*: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Status: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 18)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Defendant*: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(55, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 18)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Complainant*: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(55, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 18)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Complaint*: "
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelId.Location = New System.Drawing.Point(55, 72)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(126, 18)
        Me.labelId.TabIndex = 93
        Me.labelId.Text = "Complaint ID: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(458, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Note: * Required "
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(621, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 74)
        Me.Panel1.TabIndex = 68
        '
        'btnModifyComplaint
        '
        Me.btnModifyComplaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModifyComplaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModifyComplaint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnModifyComplaint.FlatAppearance.BorderSize = 0
        Me.btnModifyComplaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModifyComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyComplaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyComplaint.ForeColor = System.Drawing.Color.White
        Me.btnModifyComplaint.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnModifyComplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyComplaint.Location = New System.Drawing.Point(497, 10)
        Me.btnModifyComplaint.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModifyComplaint.Name = "btnModifyComplaint"
        Me.btnModifyComplaint.Size = New System.Drawing.Size(166, 37)
        Me.btnModifyComplaint.TabIndex = 34
        Me.btnModifyComplaint.TabStop = False
        Me.btnModifyComplaint.Text = "  Update Complaint"
        Me.btnModifyComplaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifyComplaint.UseVisualStyleBackColor = False
        '
        'btnSaveComplaint
        '
        Me.btnSaveComplaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaveComplaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveComplaint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSaveComplaint.FlatAppearance.BorderSize = 0
        Me.btnSaveComplaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveComplaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSaveComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveComplaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveComplaint.ForeColor = System.Drawing.Color.White
        Me.btnSaveComplaint.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.save
        Me.btnSaveComplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveComplaint.Location = New System.Drawing.Point(519, 10)
        Me.btnSaveComplaint.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveComplaint.Name = "btnSaveComplaint"
        Me.btnSaveComplaint.Size = New System.Drawing.Size(144, 37)
        Me.btnSaveComplaint.TabIndex = 34
        Me.btnSaveComplaint.TabStop = False
        Me.btnSaveComplaint.Text = "  Save Complaint"
        Me.btnSaveComplaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveComplaint.UseVisualStyleBackColor = False
        '
        'btnSearchComplainant
        '
        Me.btnSearchComplainant.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchComplainant.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchComplainant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchComplainant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchComplainant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchComplainant.ForeColor = System.Drawing.Color.White
        Me.btnSearchComplainant.Image = CType(resources.GetObject("btnSearchComplainant.Image"), System.Drawing.Image)
        Me.btnSearchComplainant.Location = New System.Drawing.Point(9, 18)
        Me.btnSearchComplainant.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchComplainant.Name = "btnSearchComplainant"
        Me.btnSearchComplainant.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchComplainant.TabIndex = 128
        Me.btnSearchComplainant.TabStop = False
        Me.btnSearchComplainant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchComplainant.UseVisualStyleBackColor = False
        '
        'btnSearchDefendant
        '
        Me.btnSearchDefendant.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSearchDefendant.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchDefendant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchDefendant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSearchDefendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchDefendant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchDefendant.ForeColor = System.Drawing.Color.White
        Me.btnSearchDefendant.Image = CType(resources.GetObject("btnSearchDefendant.Image"), System.Drawing.Image)
        Me.btnSearchDefendant.Location = New System.Drawing.Point(9, 51)
        Me.btnSearchDefendant.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearchDefendant.Name = "btnSearchDefendant"
        Me.btnSearchDefendant.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchDefendant.TabIndex = 129
        Me.btnSearchDefendant.TabStop = False
        Me.btnSearchDefendant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchDefendant.UseVisualStyleBackColor = False
        '
        'ViewComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 551)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewComplaints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Complaint Information"
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
        Me.panelHearingParent.ResumeLayout(False)
        Me.panelHearingParent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labelDefendant As Label
    Friend WithEvents labelComplainant As Label
    Friend WithEvents labelComplaint As Label
    Friend WithEvents labelComplaintId As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnModifyComplaint As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label104 As Label
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveComplaint As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents panelParent As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDateFiled As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents labelThirdResult As Label
    Friend WithEvents labelThirdDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelSecondResult As Label
    Friend WithEvents labelSecondDate As Label
    Friend WithEvents labelFirstResult As Label
    Friend WithEvents labelFirstDate As Label
    Friend WithEvents labelStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents labelId As Label
    Friend WithEvents labelDetails As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtDefendant As TextBox
    Friend WithEvents txtComplainant As TextBox
    Friend WithEvents txtComplaintId As TextBox
    Friend WithEvents txtComplaint As TextBox
    Friend WithEvents datePickerDateComplaint As DateTimePicker
    Friend WithEvents comboThirdResult As ComboBox
    Friend WithEvents comboSecondResult As ComboBox
    Friend WithEvents comboFirstResult As ComboBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents panelSearchParent As Panel
    Friend WithEvents btnSearchComplainant As Button
    Friend WithEvents btnSearchDefendant As Button
    Friend WithEvents panelHearingParent As Panel
End Class
