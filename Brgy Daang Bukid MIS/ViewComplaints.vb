Imports System.ComponentModel
Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Imports Syncfusion.Windows.Forms.Tools

Public Class ViewComplaints

    Public mySqlConn As String = My.Resources.constring
    Public action As String
    Public complaintId As Integer

    Dim clickableComplainant, clickableDefendant As Boolean
    Public complainantId, defendantId As Integer
    Dim isSaved As Boolean = False

    Public complainant As String = ""
    Public defendant As String = ""



    Private Sub ViewComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)

        datePickerDateComplaint.Format = DateTimePickerFormat.Custom
        datePickerDateComplaint.CustomFormat = "MMMM d, yyyy"

        dateFirstHearing.Format = DateTimePickerFormat.Custom
        dateFirstHearing.CustomFormat = "MMMM d, yyyy"

        dateSecondHearing.Format = DateTimePickerFormat.Custom
        dateSecondHearing.CustomFormat = "MMMM d, yyyy"

        dateThirdHearing.Format = DateTimePickerFormat.Custom
        dateThirdHearing.CustomFormat = "MMMM d, yyyy"


        loadInitialData()
    End Sub
    Private Sub ViewComplaints_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub ViewComplaints_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If txtComplaint.Text.Trim <> "" Or txtComplainant.Text.Trim <> "" Or txtDefendant.Text.Trim <> "" Or txtDetails.Text.Trim <> "" Then
                If mainTabControl.SelectedIndex = 1 Then
                    If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub loadInitialData()
        txtComplaint.Select()

        mainTabControl.SelectedIndex = 0


        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            panelComplaintId.Hide()
        End If

        If mainTabControl.SelectedIndex = 0 Then
            Dim mySql As MySqlConnection
            mySql = New MySqlConnection(mySqlConn)
            On Error Resume Next
            mySql.Open()

            Select Case Err.Number
                Case 0
                Case Else
                    MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
            End Select

            Dim cmd As MySqlCommand
            Dim mySQLReader As MySqlDataReader
            cmd = mySql.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM complaints where complaint_id = @complaintid"
            cmd.Parameters.AddWithValue("@complaintid", complaintId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    labelComplaintId.Text = mySQLReader!complaint_id
                    labelComplaint.Text = mySQLReader!complaint

                    If IsNumeric(mySQLReader!complainant) Then
                        complainant = getResidentNameById(mySQLReader!complainant)
                        clickableComplainant = True
                        complainantId = mySQLReader!complainant
                        labelComplainant.ForeColor = Color.Blue
                        labelComplainantAddress.Text = getAddressByResidentId(complainantId)
                        labelComplainantContactNo.Text = getContactNoById(complainantId)
                    Else
                        complainant = mySQLReader!complainant
                        clickableComplainant = False
                        labelComplainant.ForeColor = Color.Black
                        labelComplainantAddress.Text = mySQLReader!complainant_address
                        labelComplainantContactNo.Text = mySQLReader!complainant_contactno
                    End If
                    labelComplainant.Text = complainant
                    If IsNumeric(mySQLReader!defendant) Then
                        defendant = getResidentNameById(mySQLReader!defendant)
                        clickableDefendant = True
                        defendantId = mySQLReader!defendant
                        labelDefendant.ForeColor = Color.Blue
                        labelDefendantAddress.Text = getAddressByResidentId(defendantId)
                        labelDefendantContactNo.Text = getContactNoById(defendantId)
                    Else
                        defendant = mySQLReader!defendant
                        clickableDefendant = False
                        labelDefendant.ForeColor = Color.Black
                        labelDefendantAddress.Text = mySQLReader!defendant_address
                        labelDefendantContactNo.Text = mySQLReader!defendat_contactno
                    End If
                    labelDefendant.Text = defendant

                    labelStatus.Text = mySQLReader!complaint_status
                    Dim date1 As Date = mySQLReader!date_filed
                    labelDateFiled.Text = date1.ToString("MMMM d, yyyy")
                    labelDetails.Text = mySQLReader!details

                    Dim date2 As Date = mySQLReader!first_date
                    labelFirstDate.Text = If(date2.ToString("MMMM d, yyyy") = "January 1, 0001", "", date2.ToString("MMMM d, yyyy"))
                    labelFirstResult.Text = mySQLReader!first_result
                    Dim date3 As Date = mySQLReader!second_date
                    labelSecondDate.Text = If(date3.ToString("MMMM d, yyyy") = "January 1, 0001", "", date3.ToString("MMMM d, yyyy"))
                    labelSecondResult.Text = mySQLReader!second_result
                    Dim date4 As Date = mySQLReader!third_date
                    labelThirdDate.Text = If(date4.ToString("MMMM d, yyyy") = "January 1, 0001", "", date4.ToString("MMMM d, yyyy"))
                    labelThirdResult.Text = mySQLReader!third_result

                End While
            End If
            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

        End If

        Dim tempdate As Date = Date.Now
        datePickerDateComplaint.Value = tempdate
        dateFirstHearing.Value = tempdate
        dateSecondHearing.Value = tempdate
        dateThirdHearing.Value = tempdate
        txtStatus.Text = "Ongoing"

        txtComplaint.Enabled = True
        txtComplainant.Enabled = True
        txtComplainantAddress.Enabled = True
        txtComplainantContactNo.Enabled = True

        txtDefendant.Enabled = True
        txtDefendantAddress.Enabled = True
        txtDefendantContactNo.Enabled = True

        datePickerDateComplaint.Enabled = True
        panelHearingParent.Hide()

        btnSearchComplainant.Show()
        btnSearchDefendant.Show()

        panelComplainantRadio.Show()
        panelDefendantRadio.Show()

        btnModifyComplaint.Enabled = False

        If labelStatus.Text = "Settled" Then
            btnModifyComplaint.Enabled = False
            btnModifyComplaint.Text = "  Settled"
        ElseIf labelStatus.Text = "Filed for Action" Then
            btnModifyComplaint.Text = "  Filed For Action"
            btnModifyComplaint.Enabled = False
        Else
            btnModifyComplaint.Text = "  Update Complaint"
            btnModifyComplaint.Enabled = True
        End If
        radioComplainantResident.Checked = True
        radioDefendantResident.Checked = True

    End Sub

    Private Sub radioComplainantResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioComplainantResident.CheckedChanged
        If radioComplainantResident.Checked = True Then
            btnSearchComplainant.Show()
            panelComplainantDetails.Hide()

            panelDefendantRadio.Enabled = True

            txtComplainant.Enabled = False
            txtComplainant.Clear()
        End If
    End Sub
    Private Sub radioComplainantNonResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioComplainantNonResident.CheckedChanged
        If radioComplainantNonResident.Checked = True Then
            btnSearchComplainant.Hide()
            panelComplainantDetails.Show()

            panelDefendantRadio.Enabled = False
            radioDefendantResident.Checked = True

            txtComplainant.Enabled = True
            txtComplainant.Clear()
            complainantId = 0
        End If
    End Sub
    Private Sub radioDefendantResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioDefendantResident.CheckedChanged
        If radioDefendantResident.Checked = True Then
            btnSearchDefendant.Show()
            panelDefendantDetails.Hide()

            panelComplainantRadio.Enabled = True

            txtDefendant.Enabled = False
            txtDefendant.Clear()
        End If
    End Sub
    Private Sub radioDefendantNonResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioDefendantNonResident.CheckedChanged
        If radioDefendantNonResident.Checked = True Then
            btnSearchDefendant.Hide()
            panelDefendantDetails.Show()

            panelComplainantRadio.Enabled = False
            radioComplainantResident.Checked = True

            txtDefendant.Enabled = True
            txtDefendant.Clear()
            defendantId = 0
        End If
    End Sub

    Private Sub labelComplainant_Click(sender As Object, e As EventArgs) Handles labelComplainant.Click
        If clickableComplainant = True Then
            ViewResident.resident_id = complainantId
            ViewResident.viewChoice = "Normal"
            ViewResident.action = "modify"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub labelDefendant_Click(sender As Object, e As EventArgs) Handles labelDefendant.Click
        If clickableDefendant = True Then
            ViewResident.resident_id = defendantId
            ViewResident.action = "modify"
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub txtComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComplainant.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtDefendant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDefendant.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDefendant.KeyDown, txtComplaint.KeyDown, txtComplainant.KeyDown, txtComplainantAddress.KeyDown, txtComplainantContactNo.KeyDown, txtDefendantAddress.KeyDown, txtDefendantContactNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnSearchComplainant_Click(sender As Object, e As EventArgs) Handles btnSearchComplainant.Click
        Search_Residents.origin = "complainant"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchDefendant_Click(sender As Object, e As EventArgs) Handles btnSearchDefendant.Click
        Search_Residents.origin = "defendant"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub comboFirstResult_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comboFirstResult.SelectedIndexChanged
        ' <> comboFirstResult.FindStringExact(labelFirstResult.Text)
        If comboFirstResult.SelectedIndex = 0 Then
            comboSecondResult.Enabled = True
            dateSecondHearing.Enabled = True
        Else
            comboSecondResult.Enabled = False
            dateSecondHearing.Enabled = False
        End If
    End Sub
    Private Sub comboSecondResult_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comboSecondResult.SelectedIndexChanged
        '<> comboSecondResult.FindStringExact(labelSecondResult.Text)
        If comboSecondResult.SelectedIndex = 0 Then
            comboThirdResult.Enabled = True
            dateThirdHearing.Enabled = True
        End If
    End Sub

    Private Sub btnModifyComplaint_Click(sender As Object, e As EventArgs) Handles btnModifyComplaint.Click

        mainTabControl.SelectedIndex = 1
        action = "modify"

        panelComplaintId.Show()

        btnSearchComplainant.Hide()
        btnSearchDefendant.Hide()

        panelComplainantRadio.Hide()
        panelDefendantRadio.Hide()

        txtComplaint.Enabled = False
        txtComplainant.Enabled = False
        txtComplainantAddress.Enabled = False
        txtComplainantContactNo.Enabled = False

        txtDefendant.Enabled = False
        txtDefendantAddress.Enabled = False
        txtDefendantContactNo.Enabled = False

        datePickerDateComplaint.Enabled = False
        panelHearingParent.Show()

        txtComplaintId.Text = labelComplaintId.Text
        txtComplaint.Text = labelComplaint.Text
        txtComplainant.Text = labelComplainant.Text
        txtComplainantAddress.Text = labelComplainantAddress.Text
        txtComplainantContactNo.Text = labelComplainantContactNo.Text

        txtDefendant.Text = labelDefendant.Text
        txtDefendantAddress.Text = labelDefendantAddress.Text
        txtDefendantContactNo.Text = labelDefendantContactNo.Text

        txtStatus.Text = labelStatus.Text

        Dim dt As DateTime = DateTime.ParseExact(labelDateFiled.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        datePickerDateComplaint.Value = dt
        txtDetails.Text = labelDetails.Text

        comboFirstResult.SelectedIndex = comboFirstResult.FindStringExact(labelFirstResult.Text)
        comboSecondResult.SelectedIndex = comboSecondResult.FindStringExact(labelSecondResult.Text)
        comboThirdResult.SelectedIndex = comboThirdResult.FindStringExact(labelThirdResult.Text)

        If labelFirstDate.Text.Trim <> "" Then
            Dim dt1 As DateTime = DateTime.ParseExact(labelFirstDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
            dateFirstHearing.Value = dt1
        End If

        If labelSecondDate.Text.Trim <> "" Then
            Dim dt2 As DateTime = DateTime.ParseExact(labelSecondDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
            dateSecondHearing.Value = dt2
        End If

        If labelThirdDate.Text.Trim <> "" Then
            Dim dt3 As DateTime = DateTime.ParseExact(labelThirdDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
            dateThirdHearing.Value = dt3
        End If


        If comboFirstResult.Text = "" Then
            comboFirstResult.Enabled = True
            comboSecondResult.Enabled = False
            comboThirdResult.Enabled = False

            dateFirstHearing.Enabled = True
            dateSecondHearing.Enabled = False
            dateThirdHearing.Enabled = False
        ElseIf comboFirstResult.Text <> "" And comboSecondResult.Text = "" Then
            comboSecondResult.Enabled = True
            comboThirdResult.Enabled = False

            dateSecondHearing.Enabled = True
            dateThirdHearing.Enabled = False
        ElseIf comboSecondResult.Text <> "" And comboThirdResult.Text = "" Then
            comboSecondResult.Enabled = False
            dateSecondHearing.Enabled = False

            comboThirdResult.Enabled = True
            dateThirdHearing.Enabled = True
        End If

    End Sub
    Private Sub btnSaveComplaint_Click(sender As Object, e As EventArgs) Handles btnSaveComplaint.Click
        If txtComplaint.Text.Trim = "" Then
            MsgBox("Complaint name cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtComplainant.Text.Trim = "" Then
            MsgBox("Complainant name cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtDefendant.Text.Trim = "" Then
            MsgBox("Respondent name cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If datePickerDateComplaint.Value > Date.Now Then
            MsgBox("Please provide a valid date of filing!", vbCritical, "Warning")
            Exit Sub
        End If

        If action = "add" Then
            If complainantId = 0 And defendantId = 0 Then
                MsgBox("There must be at least one resident residing in the barangay!", vbCritical, "Warning")
                Exit Sub
            End If
            If complainantId = 0 And (txtComplainantAddress.Text.Trim = "" Or txtComplainantContactNo.Text = "") Then
                MsgBox("Please provide address and contact no for complainant!", vbCritical, "Warning")
                Exit Sub
            End If
            If defendantId = 0 And (txtDefendantAddress.Text.Trim = "" Or txtDefendantContactNo.Text = "") Then
                MsgBox("Please provide address and contact no for respondent!", vbCritical, "Warning")
                Exit Sub
            End If
        End If

        If comboFirstResult.SelectedIndex >= 0 And dateFirstHearing.Value.Date > Date.Now.Date Then
            MsgBox("Please provide a valid date for first hearing!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboSecondResult.SelectedIndex >= 0 And dateSecondHearing.Value.Date > Date.Now.Date Then
            MsgBox("Please provide a valid date for second hearing!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboThirdResult.SelectedIndex >= 0 And dateThirdHearing.Value.Date > Date.Now.Date Then
            MsgBox("Please provide a valid date for third hearing!", vbCritical, "Warning")
            Exit Sub
        End If
        If dateSecondHearing.Value.Date < dateFirstHearing.Value.Date Then
            MsgBox("You can't set second hearing date less than first hearing date!", vbCritical, "Warning")
            Exit Sub
        End If
        If dateThirdHearing.Value.Date < dateSecondHearing.Value.Date Then
            MsgBox("You can't set third hearing date less than second hearing date!", vbCritical, "Warning")
            Exit Sub
        End If
        If dateFirstHearing.Value.Date < datePickerDateComplaint.Value.Date Or dateSecondHearing.Value.Date < datePickerDateComplaint.Value.Date Or dateThirdHearing.Value.Date < datePickerDateComplaint.Value.Date Then
            MsgBox("You can't set hearing dates less than the date filed!", vbCritical, "Warning")
            Exit Sub
        End If

        If action = "modify" Then
                Dim dt1 As Date
                If labelFirstDate.Text.Trim <> "" Then
                    dt1 = Date.ParseExact(labelFirstDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
                End If
                Dim dt2 As Date
                If labelSecondDate.Text.Trim <> "" Then
                    dt2 = Date.ParseExact(labelSecondDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
                End If
                Dim dt3 As Date
            If labelThirdDate.Text.Trim <> "" Then
                dt3 = Date.ParseExact(labelThirdDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
            End If
        End If


        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        If action = "modify" Then
            cmd.CommandText = "UPDATE complaints SET complaint = @complaint " & If(comboFirstResult.Text = "", "", ", first_date = @firstdate, first_result = @firstresult ") & If(comboSecondResult.Text = "", "", " ,second_date = @seconddate, second_result = @secondresult ") & If(comboThirdResult.Text = "", "", " ,third_date = @thirddate, third_result = @thirdresult ") & ",complaint_status = @status" & " ,details = @details where complaint_id = @complaintid"
            cmd.Parameters.AddWithValue("@complaintid", complaintId)
            cmd.Parameters.AddWithValue("@complaint", txtComplaint.Text)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)

            If comboFirstResult.Text = "Settled" Or comboSecondResult.Text = "Settled" Or comboThirdResult.Text = "Settled" Then
                cmd.Parameters.AddWithValue("@status", "Settled")
            ElseIf comboThirdResult.Text = "Filed for Action" Then
                cmd.Parameters.AddWithValue("@status", "Filed for Action")
            Else
                cmd.Parameters.AddWithValue("@status", "Ongoing")
            End If

            cmd.Parameters.AddWithValue("@firstresult", comboFirstResult.Text)
            cmd.Parameters.AddWithValue("@secondresult", comboSecondResult.Text)
            cmd.Parameters.AddWithValue("@thirdresult", comboThirdResult.Text)

            cmd.Parameters.AddWithValue("@firstdate", dateFirstHearing.Value.Date)
            cmd.Parameters.AddWithValue("@seconddate", dateSecondHearing.Value.Date)
            cmd.Parameters.AddWithValue("@thirddate", dateThirdHearing.Value.Date)

            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Updated Complaint [" & complaintId.ToString & "][" & txtComplaint.Text & "] for [" & txtComplainant.Text & "] against [" & txtDefendant.Text & "]")
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO complaints (complaint, complainant, complainant_address, complainant_contactno, defendant, defendant_address, defendat_contactno, complaint_status, date_filed, details) values (@complaint, @complainant, @complainantaddress, @complainantcontactno, @defendant, @defendantaddress, @defendantcontactno, 'Ongoing', @datefiled, @details)"
            cmd.Parameters.AddWithValue("@complaint", txtComplaint.Text)

            cmd.Parameters.AddWithValue("@complainant", If(radioComplainantResident.Checked = True, complainantId, txtComplainant.Text))
            cmd.Parameters.AddWithValue("@complainantaddress", If(radioComplainantResident.Checked = True, "", txtComplainantAddress.Text))
            cmd.Parameters.AddWithValue("@complainantcontactno", If(radioComplainantResident.Checked = True, "", txtComplainantContactNo.Text))

            cmd.Parameters.AddWithValue("@defendant", If(radioDefendantResident.Checked = True, defendantId, txtDefendant.Text))
            cmd.Parameters.AddWithValue("@defendantaddress", If(radioDefendantResident.Checked = True, "", txtDefendantAddress.Text))
            cmd.Parameters.AddWithValue("@defendantcontactno", If(radioDefendantResident.Checked = True, "", txtDefendantContactNo.Text))

            cmd.Parameters.AddWithValue("@datefiled", datePickerDateComplaint.Value.Date)
            cmd.Parameters.AddWithValue("@details", txtDetails.Text)

            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Filed Complaint [" & txtComplaint.Text & "] for [" & txtComplainant.Text & "] against [" & txtDefendant.Text & "]")
        End If
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Complaint Filed!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchComplaints.Text = "Search by complaint, complainant or defendant"
        Main_Form.btnComplaints.PerformClick()

    End Sub




    '' ''''''''''''''''FUNCTION HELPERS ''''''''''''''''''''''''''''''''''
    Private Function getAddressByResidentId(ByVal residentId As Integer) As String

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        Dim address As String = ""
        cmd.CommandText = "SELECT household.bldg_no, household.street_name from household LEFT JOIN residents on household.household_id = residents.household_id AND (residents.resident_id = @residentid)"
        cmd.Parameters.AddWithValue("@residentid", residentId)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                address = mySQLReader!bldg_no + " " + mySQLReader!street_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return address
    End Function
    Private Function getContactNoById(ByVal residentId As Integer) As String

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        Dim contactno As String = ""
        cmd.CommandText = "SELECT contact_no from residents where resident_id = @residentid"
        cmd.Parameters.AddWithValue("@residentid", residentId)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                contactno = mySQLReader!contact_no
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return contactno
    End Function
    Private Function getResidentNameById(ByVal id As Integer) As String

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT first_name, middle_name, last_name, ext_name from residents WHERE resident_id = @residentid "
        cmd.Parameters.AddWithValue("@residentid", id)

        Dim name As String = ""
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                name = mySQLReader!first_name + If(mySQLReader!middle_name = "", "", " " + mySQLReader!middle_name) + " " + mySQLReader!last_name + " " + mySQLReader!ext_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return name
    End Function
    Private Sub checkInputCharactersOnly(e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If

    End Sub


End Class