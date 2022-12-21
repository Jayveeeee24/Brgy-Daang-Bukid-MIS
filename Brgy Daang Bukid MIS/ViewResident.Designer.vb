<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewResident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewResident))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.pageView = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelHouseholdHead = New System.Windows.Forms.Panel()
        Me.labelRegisteredBy = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.labelDateRegistered = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.labelReligion = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.labelPwd = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.labelVoter = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.labelFreelancer = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.labelContactNo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.labelSex = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.labelCivilStatus = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.labelBirthPlace = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.labelAge = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.labelBirthdate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelExtension = New System.Windows.Forms.Label()
        Me.labelLast = New System.Windows.Forms.Label()
        Me.labelMiddle = New System.Windows.Forms.Label()
        Me.labelFirst = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddHousehold = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pageAddModify = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mainTabControl.SuspendLayout()
        Me.pageView.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelHouseholdHead.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        Me.mainTabControl.Size = New System.Drawing.Size(770, 584)
        Me.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.mainTabControl.TabIndex = 0
        '
        'pageView
        '
        Me.pageView.Controls.Add(Me.Panel1)
        Me.pageView.Location = New System.Drawing.Point(4, 22)
        Me.pageView.Name = "pageView"
        Me.pageView.Padding = New System.Windows.Forms.Padding(3)
        Me.pageView.Size = New System.Drawing.Size(762, 558)
        Me.pageView.TabIndex = 0
        Me.pageView.Text = "View"
        Me.pageView.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel1.Size = New System.Drawing.Size(756, 552)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.panelHouseholdHead)
        Me.Panel2.Controls.Add(Me.labelRegisteredBy)
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.labelDateRegistered)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.labelReligion)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.labelPwd)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.labelVoter)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.labelFreelancer)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.labelContactNo)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.labelSex)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.labelCivilStatus)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.labelBirthPlace)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.labelAge)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.labelBirthdate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.labelExtension)
        Me.Panel2.Controls.Add(Me.labelLast)
        Me.Panel2.Controls.Add(Me.labelMiddle)
        Me.Panel2.Controls.Add(Me.labelFirst)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(734, 484)
        Me.Panel2.TabIndex = 38
        '
        'panelHouseholdHead
        '
        Me.panelHouseholdHead.Controls.Add(Me.Label31)
        Me.panelHouseholdHead.Controls.Add(Me.Label30)
        Me.panelHouseholdHead.Location = New System.Drawing.Point(51, 180)
        Me.panelHouseholdHead.Name = "panelHouseholdHead"
        Me.panelHouseholdHead.Size = New System.Drawing.Size(308, 27)
        Me.panelHouseholdHead.TabIndex = 75
        '
        'labelRegisteredBy
        '
        Me.labelRegisteredBy.AutoSize = True
        Me.labelRegisteredBy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegisteredBy.Location = New System.Drawing.Point(285, 614)
        Me.labelRegisteredBy.Name = "labelRegisteredBy"
        Me.labelRegisteredBy.Size = New System.Drawing.Size(325, 18)
        Me.labelRegisteredBy.TabIndex = 74
        Me.labelRegisteredBy.Text = "John Bernard Tinio [Barangay Captain]"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(57, 614)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(128, 18)
        Me.Label36.TabIndex = 73
        Me.Label36.Text = "Registered by:"
        '
        'labelDateRegistered
        '
        Me.labelDateRegistered.AutoSize = True
        Me.labelDateRegistered.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDateRegistered.Location = New System.Drawing.Point(285, 585)
        Me.labelDateRegistered.Name = "labelDateRegistered"
        Me.labelDateRegistered.Size = New System.Drawing.Size(167, 18)
        Me.labelDateRegistered.TabIndex = 72
        Me.labelDateRegistered.Text = "December 21, 2022"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(57, 585)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(148, 18)
        Me.Label34.TabIndex = 71
        Me.Label34.Text = "Date Registered:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(24, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(289, 25)
        Me.Label32.TabIndex = 70
        Me.Label32.Text = "PERSONAL INFORMATION"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(234, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 18)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Yes"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(149, 18)
        Me.Label31.TabIndex = 67
        Me.Label31.Text = "Household Head:"
        '
        'labelReligion
        '
        Me.labelReligion.AutoSize = True
        Me.labelReligion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelReligion.Location = New System.Drawing.Point(285, 526)
        Me.labelReligion.Name = "labelReligion"
        Me.labelReligion.Size = New System.Drawing.Size(136, 18)
        Me.labelReligion.TabIndex = 66
        Me.labelReligion.Text = "Roman Catholic"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(57, 526)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 18)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Religion:"
        '
        'labelPwd
        '
        Me.labelPwd.AutoSize = True
        Me.labelPwd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPwd.Location = New System.Drawing.Point(285, 497)
        Me.labelPwd.Name = "labelPwd"
        Me.labelPwd.Size = New System.Drawing.Size(30, 18)
        Me.labelPwd.TabIndex = 64
        Me.labelPwd.Text = "No"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(57, 497)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 18)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "PWD:"
        '
        'labelVoter
        '
        Me.labelVoter.AutoSize = True
        Me.labelVoter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVoter.Location = New System.Drawing.Point(285, 469)
        Me.labelVoter.Name = "labelVoter"
        Me.labelVoter.Size = New System.Drawing.Size(37, 18)
        Me.labelVoter.TabIndex = 62
        Me.labelVoter.Text = "Yes"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(57, 469)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(152, 18)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Registered Voter:"
        '
        'labelFreelancer
        '
        Me.labelFreelancer.AutoSize = True
        Me.labelFreelancer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFreelancer.Location = New System.Drawing.Point(285, 439)
        Me.labelFreelancer.Name = "labelFreelancer"
        Me.labelFreelancer.Size = New System.Drawing.Size(92, 18)
        Me.labelFreelancer.TabIndex = 60
        Me.labelFreelancer.Text = "Freelancer"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(57, 439)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 18)
        Me.Label23.TabIndex = 59
        Me.Label23.Text = "Occupation:"
        '
        'labelContactNo
        '
        Me.labelContactNo.AutoSize = True
        Me.labelContactNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContactNo.Location = New System.Drawing.Point(285, 410)
        Me.labelContactNo.Name = "labelContactNo"
        Me.labelContactNo.Size = New System.Drawing.Size(118, 18)
        Me.labelContactNo.TabIndex = 58
        Me.labelContactNo.Text = "09069141416"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(57, 410)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 18)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Contact No:"
        '
        'labelSex
        '
        Me.labelSex.AutoSize = True
        Me.labelSex.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSex.Location = New System.Drawing.Point(285, 350)
        Me.labelSex.Name = "labelSex"
        Me.labelSex.Size = New System.Drawing.Size(46, 18)
        Me.labelSex.TabIndex = 56
        Me.labelSex.Text = "Male"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(57, 350)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 18)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Sex:"
        '
        'labelCivilStatus
        '
        Me.labelCivilStatus.AutoSize = True
        Me.labelCivilStatus.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCivilStatus.Location = New System.Drawing.Point(285, 322)
        Me.labelCivilStatus.Name = "labelCivilStatus"
        Me.labelCivilStatus.Size = New System.Drawing.Size(58, 18)
        Me.labelCivilStatus.TabIndex = 54
        Me.labelCivilStatus.Text = "Single"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(57, 322)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 18)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Civil Status:"
        '
        'labelBirthPlace
        '
        Me.labelBirthPlace.AutoSize = True
        Me.labelBirthPlace.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBirthPlace.Location = New System.Drawing.Point(285, 292)
        Me.labelBirthPlace.Name = "labelBirthPlace"
        Me.labelBirthPlace.Size = New System.Drawing.Size(98, 18)
        Me.labelBirthPlace.TabIndex = 52
        Me.labelBirthPlace.Text = "Cavite City"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(57, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 18)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Place of Birth:"
        '
        'labelAge
        '
        Me.labelAge.AutoSize = True
        Me.labelAge.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAge.Location = New System.Drawing.Point(285, 263)
        Me.labelAge.Name = "labelAge"
        Me.labelAge.Size = New System.Drawing.Size(28, 18)
        Me.labelAge.TabIndex = 50
        Me.labelAge.Text = "22"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(57, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 18)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Age:"
        '
        'labelBirthdate
        '
        Me.labelBirthdate.AutoSize = True
        Me.labelBirthdate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBirthdate.Location = New System.Drawing.Point(285, 236)
        Me.labelBirthdate.Name = "labelBirthdate"
        Me.labelBirthdate.Size = New System.Drawing.Size(156, 18)
        Me.labelBirthdate.TabIndex = 46
        Me.labelBirthdate.Text = "February 24, 2000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(285, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 18)
        Me.Label8.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Date of Birth: "
        '
        'labelExtension
        '
        Me.labelExtension.AutoSize = True
        Me.labelExtension.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelExtension.Location = New System.Drawing.Point(285, 159)
        Me.labelExtension.Name = "labelExtension"
        Me.labelExtension.Size = New System.Drawing.Size(25, 18)
        Me.labelExtension.TabIndex = 43
        Me.labelExtension.Text = "Jr."
        '
        'labelLast
        '
        Me.labelLast.AutoSize = True
        Me.labelLast.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLast.Location = New System.Drawing.Point(285, 131)
        Me.labelLast.Name = "labelLast"
        Me.labelLast.Size = New System.Drawing.Size(48, 18)
        Me.labelLast.TabIndex = 42
        Me.labelLast.Text = "Tinio"
        '
        'labelMiddle
        '
        Me.labelMiddle.AutoSize = True
        Me.labelMiddle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMiddle.Location = New System.Drawing.Point(285, 102)
        Me.labelMiddle.Name = "labelMiddle"
        Me.labelMiddle.Size = New System.Drawing.Size(74, 18)
        Me.labelMiddle.TabIndex = 41
        Me.labelMiddle.Text = "Jimenez"
        '
        'labelFirst
        '
        Me.labelFirst.AutoSize = True
        Me.labelFirst.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirst.Location = New System.Drawing.Point(285, 73)
        Me.labelFirst.Name = "labelFirst"
        Me.labelFirst.Size = New System.Drawing.Size(114, 18)
        Me.labelFirst.TabIndex = 40
        Me.labelFirst.Text = "John Bernard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Name Extension: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Last Name: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Middle Name: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(57, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 18)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "First Name: "
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(613, 643)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 69
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.89101!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.23161!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.74115!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 489)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 56)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.archive
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 46)
        Me.Button1.TabIndex = 35
        Me.Button1.TabStop = False
        Me.Button1.Text = "  Archive Resident"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddHousehold)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(478, 10)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(256, 46)
        Me.FlowLayoutPanel1.TabIndex = 36
        '
        'btnAddHousehold
        '
        Me.btnAddHousehold.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnAddHousehold.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddHousehold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddHousehold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddHousehold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddHousehold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHousehold.ForeColor = System.Drawing.Color.White
        Me.btnAddHousehold.Image = Global.Brgy_Daang_Bukid_MIS.My.Resources.Resources.modify
        Me.btnAddHousehold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddHousehold.Location = New System.Drawing.Point(109, 0)
        Me.btnAddHousehold.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddHousehold.Name = "btnAddHousehold"
        Me.btnAddHousehold.Size = New System.Drawing.Size(147, 42)
        Me.btnAddHousehold.TabIndex = 34
        Me.btnAddHousehold.TabStop = False
        Me.btnAddHousehold.Text = "  Modify Resident"
        Me.btnAddHousehold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddHousehold.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(41, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 42)
        Me.Button2.TabIndex = 36
        Me.Button2.TabStop = False
        Me.Button2.Text = "Back"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pageAddModify
        '
        Me.pageAddModify.Location = New System.Drawing.Point(4, 22)
        Me.pageAddModify.Name = "pageAddModify"
        Me.pageAddModify.Padding = New System.Windows.Forms.Padding(3)
        Me.pageAddModify.Size = New System.Drawing.Size(762, 558)
        Me.pageAddModify.TabIndex = 1
        Me.pageAddModify.Text = "TabPage2"
        Me.pageAddModify.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 643)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 643)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Date Archived:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 673)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 18)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "N/A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 673)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Archived By:"
        '
        'ViewResident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 584)
        Me.Controls.Add(Me.mainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewResident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resident's Information"
        Me.mainTabControl.ResumeLayout(False)
        Me.pageView.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelHouseholdHead.ResumeLayout(False)
        Me.panelHouseholdHead.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents pageView As TabPage
    Friend WithEvents pageAddModify As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAddHousehold As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelBirthdate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents labelExtension As Label
    Friend WithEvents labelLast As Label
    Friend WithEvents labelMiddle As Label
    Friend WithEvents labelFirst As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents labelReligion As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents labelPwd As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents labelVoter As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents labelFreelancer As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents labelContactNo As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents labelSex As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents labelCivilStatus As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents labelBirthPlace As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents labelAge As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents labelRegisteredBy As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents labelDateRegistered As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents panelHouseholdHead As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
