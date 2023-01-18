Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient
Imports Syncfusion.Windows.Forms.Tools

Public Class ViewComplaints

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Public complaintId As Integer

    Dim clickableComplainant, clickableDefendant As Boolean
    Public complainantId, defendantId As Integer

    Public complainant As String = ""
    Public defendant As String = ""


    Private Sub ViewComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        clearEverything()

        datePickerDateComplaint.Format = DateTimePickerFormat.Custom
        datePickerDateComplaint.CustomFormat = "MMMM d, yyyy"

        loadInitialData()
    End Sub

    Private Sub ViewComplaints_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub
    Private Sub ViewComplaints_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" Then
            If txtComplaint.Text.Trim <> "" Or txtComplainant.Text.Trim <> "" Or txtDefendant.Text.Trim <> "" Or txtDetails.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.YesNo, "Are you sure to exit?") = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    Private Sub loadInitialData()
        txtComplaint.Select()
        mainTabControl.SelectedIndex = 0


        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtComplaintId.Hide()
            labelId.Hide()
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
                    Else
                        complainant = mySQLReader!complainant
                        clickableComplainant = False
                        labelComplainant.ForeColor = Color.Black
                    End If
                    labelComplainant.Text = complainant
                    If IsNumeric(mySQLReader!defendant) Then
                        defendant = getResidentNameById(mySQLReader!defendant)
                        clickableDefendant = True
                        defendantId = mySQLReader!defendant
                        labelDefendant.ForeColor = Color.Blue
                    Else
                        defendant = mySQLReader!defendant
                        clickableDefendant = False
                        labelDefendant.ForeColor = Color.Black
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
        txtStatus.Text = "Ongoing"

        txtComplaint.Enabled = True
        txtComplainant.Enabled = True
        txtDefendant.Enabled = True
        datePickerDateComplaint.Enabled = True
        panelHearingParent.Hide()
        panelSearchParent.Show()
        If labelStatus.Text = "Closed" Then
            btnModifyComplaint.Text = "  Closed"
            btnModifyComplaint.Enabled = False
        Else
            btnModifyComplaint.Text = "  Update Complaint"
            btnModifyComplaint.Enabled = True
        End If

    End Sub
    Private Sub clearEverything()
        txtComplaintId.Clear()
        txtComplaint.Clear()
        txtComplainant.Clear()
        txtDefendant.Clear()
        txtStatus.Clear()
        datePickerDateComplaint.Value = Date.Now
        txtDetails.Clear()

        comboFirstResult.SelectedIndex = -1
        comboSecondResult.SelectedIndex = -1
        comboThirdResult.SelectedIndex = -1

        labelComplaintId.Text = ""
        labelComplaint.Text = ""
        labelComplainant.Text = ""
        labelDefendant.Text = ""
        labelStatus.Text = ""
        labelDateFiled.Text = ""
        labelDetails.Text = ""
        labelFirstDate.Text = ""
        labelFirstResult.Text = ""
        labelSecondDate.Text = ""
        labelSecondResult.Text = ""
        labelThirdDate.Text = ""
        labelThirdResult.Text = ""

        clickableComplainant = False
        clickableDefendant = False
        complainantId = 0
        defendantId = 0
        complainant = ""
        defendant = ""

        comboFirstResult.Enabled = False
        comboSecondResult.Enabled = False
        comboThirdResult.Enabled = False

        Panel12.VerticalScroll.Value = 0
        panelParent.VerticalScroll.Value = 0

    End Sub

    Private Sub btnModifyComplaint_Click(sender As Object, e As EventArgs) Handles btnModifyComplaint.Click


        mainTabControl.SelectedIndex = 1
        action = "modify"

        txtComplaintId.Show()
        labelId.Show()

        txtComplaint.Enabled = False
        txtComplainant.Enabled = False
        txtDefendant.Enabled = False
        datePickerDateComplaint.Enabled = False
        panelHearingParent.Show()
        panelSearchParent.Hide()

        comboFirstResult.SelectedIndex = comboFirstResult.FindStringExact(labelFirstResult.Text)
        comboSecondResult.SelectedIndex = comboSecondResult.FindStringExact(labelSecondResult.Text)
        comboThirdResult.SelectedIndex = comboThirdResult.FindStringExact(labelThirdResult.Text)

        txtComplaintId.Text = labelComplainant.Text
        txtComplaint.Text = labelComplaint.Text
        txtComplainant.Text = labelComplainant.Text
        txtDefendant.Text = labelDefendant.Text
        txtStatus.Text = labelStatus.Text
        Dim dt As DateTime = DateTime.ParseExact(labelDateFiled.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        datePickerDateComplaint.Value = dt
        txtDetails.Text = labelDetails.Text



        If comboFirstResult.Text = "" Then
            comboFirstResult.Enabled = True
            comboSecondResult.Enabled = False
            comboThirdResult.Enabled = False
        ElseIf comboFirstResult.Text <> "" And comboSecondResult.Text = "" Then
            comboSecondResult.Enabled = True
            comboThirdResult.Enabled = False
        ElseIf comboSecondResult.Text <> "" And comboThirdResult.Text = "" Then
            comboThirdResult.Enabled = True
        End If

    End Sub
    Private Sub btnSaveComplaint_Click(sender As Object, e As EventArgs) Handles btnSaveComplaint.Click
        If txtComplaint.Text.Trim = "" Or txtComplainant.Text.Trim = "" Or txtDefendant.Text.Trim = "" Then
            MsgBox("Please Fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        ElseIf datePickerDateComplaint.Value > Date.Now Then
            MsgBox("Please Fill out valid date filed!", vbCritical, "Warning")
            Exit Sub
        ElseIf complainantId = 0 And defendantId = 0 Then
            MsgBox("There must be at least one resident residing in the barangay!", vbCritical, "Warning")
            Exit Sub
        Else
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
                cmd.CommandText = "UPDATE complaints SET complaint = @complaint " & If(comboFirstResult.Text = "", "", ", first_date = @datenow, first_result = @firstresult ") & If(comboSecondResult.Text = "", "", " ,second_date = @datenow, second_result = @secondresult ") & If(comboThirdResult.Text = "", "", " ,third_date = @datenow, third_result = @thirdresult ") & If(comboFirstResult.Text = "Settled" Or comboSecondResult.Text = "Settled" Or comboThirdResult.Text = "Filed for Action" Or comboThirdResult.Text = "Settled", " ,complaint_status = 'Closed' ", "") & " where complaint_id = @complaintid"
                cmd.Parameters.AddWithValue("@complaintid", complaintId)
                cmd.Parameters.AddWithValue("@complaint", txtComplaint.Text)
                cmd.Parameters.AddWithValue("@datenow", Date.Now)
                cmd.Parameters.AddWithValue("@firstresult", comboFirstResult.Text)
                cmd.Parameters.AddWithValue("@secondresult", comboSecondResult.Text)
                cmd.Parameters.AddWithValue("@thirdresult", comboThirdResult.Text)

                cmd.ExecuteNonQuery()
            ElseIf action = "add" Then
                cmd.CommandText = "INSERT INTO complaints (complaint, complainant, defendant, complaint_status, date_filed, details) values (@complaint, @complainant, @defendant, 'Ongoing', @datefiled, @details)"
                cmd.Parameters.AddWithValue("@complaint", txtComplaint.Text)
                cmd.Parameters.AddWithValue("@complainant", If(complainantId = 0, txtComplainant.Text, complainantId))
                cmd.Parameters.AddWithValue("@defendant", If(defendantId = 0, txtDefendant.Text, defendantId))
                cmd.Parameters.AddWithValue("@datefiled", datePickerDateComplaint.Value.Date)
                cmd.Parameters.AddWithValue("@details", txtDetails.Text)

                cmd.ExecuteNonQuery()
            End If

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            MsgBox("Complaint Filed!", vbInformation, "Information")
            clearEverything()
            Me.Close()
            Main_Form.txtSearchComplaints.Text = "Search by complaint, complainant or defendant"
            Main_Form.btnComplaints.PerformClick()
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
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDefendant.KeyDown, txtComplaint.KeyDown, txtComplainant.KeyDown
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


    Private Sub comboFirstResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFirstResult.SelectedIndexChanged
        If comboFirstResult.SelectedIndex <> comboFirstResult.FindStringExact(labelFirstResult.Text) Then
            comboSecondResult.Enabled = True
        End If
    End Sub
    Private Sub comboSecondResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSecondResult.SelectedIndexChanged
        If comboSecondResult.SelectedIndex <> comboSecondResult.FindStringExact(labelSecondResult.Text) Then
            comboThirdResult.Enabled = True
        End If
    End Sub

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
End Class