Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ViewVawc
    Public mySqlConn As String = My.Resources.constring
    Public action As String
    Public caseId As Integer

    Dim clickableVictim, clickableSuspect, clickableSubmittedBy As Boolean
    Public victimId, suspectId, submittedById As Integer

    Public victim As String = ""
    Public suspect As String = ""
    Public submittedBy As String = ""


    Private Sub ViewVawc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        clearEverything()

        datePickerSubmittedOn.Format = DateTimePickerFormat.Custom
        datePickerSubmittedOn.CustomFormat = "MMMM d, yyyy"

        loadInitialData()
    End Sub

    Private Sub ViewVawc_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()

    End Sub
    Private Sub ViewVawc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" Then
            If txtCaseName.Text.Trim <> "" Or txtVictim.Text.Trim <> "" Or txtSuspect.Text.Trim <> "" Or txtCaseDetails.Text.Trim <> "" Or txtRelationship.Text.Trim <> "" Or txtSubmittedBy.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    Private Sub loadInitialData()
        txtCaseName.Select()
        mainTabControl.SelectedIndex = 0


        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtCaseId.Hide()
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
            cmd.CommandText = "SELECT * FROM vawc where case_id = @caseid"
            cmd.Parameters.AddWithValue("@caseid", caseId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    labelCaseId.Text = mySQLReader!case_id
                    labelCaseName.Text = mySQLReader!case_name

                    If IsNumeric(mySQLReader!victim) Then
                        victim = getResidentNameById(mySQLReader!victim)
                        clickableVictim = True
                        victimId = mySQLReader!victim
                        labelVictim.ForeColor = Color.Blue
                    Else
                        victim = mySQLReader!victim
                        clickableVictim = False
                        labelVictim.ForeColor = Color.Black
                    End If
                    labelVictim.Text = victim

                    If IsNumeric(mySQLReader!suspect) Then
                        suspect = getResidentNameById(mySQLReader!suspect)
                        clickableSuspect = True
                        suspectId = mySQLReader!suspect
                        labelSuspect.ForeColor = Color.Blue
                    Else
                        suspect = mySQLReader!suspect
                        clickableSuspect = False
                        labelSuspect.ForeColor = Color.Black
                    End If
                    labelSuspect.Text = suspect

                    If IsNumeric(mySQLReader!submitted_by) Then
                        submittedBy = getResidentNameById(mySQLReader!submitted_by)
                        clickableSubmittedBy = True
                        submittedById = mySQLReader!submitted_by
                        labelSubmittedBy.ForeColor = Color.Blue
                    Else
                        submittedBy = mySQLReader!submitted_by
                        clickableSubmittedBy = False
                        labelSubmittedBy.ForeColor = Color.Black
                    End If
                    labelSubmittedBy.Text = submittedBy


                    labelRelationship.Text = mySQLReader!relationship
                    labelCaseStatus.Text = mySQLReader!case_status
                    Dim date1 As Date = mySQLReader!submitted_on
                    labelSubmittedOn.Text = date1.ToString("MMMM d, yyyy")
                    labelCaseDetails.Text = mySQLReader!case_details


                End While
            End If


            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
        Dim tempdate As Date = Date.Now
        datePickerSubmittedOn.Value = tempdate
        comboCaseStatus.SelectedIndex = comboCaseStatus.FindStringExact("Ongoing")

        txtCaseName.Enabled = True
        txtVictim.Enabled = True
        txtSuspect.Enabled = True
        datePickerSubmittedOn.Enabled = True
        panelSearchParent.Show()
        btnSearchSubmittedBy.Show()

        If labelCaseStatus.Text = "Closed" Or labelCaseStatus.Text = "Filed for Action" Then
            btnModifyVawc.Text = "  Case Closed"
            btnModifyVawc.Enabled = False
        Else
            btnModifyVawc.Text = "  Update Case"
            btnModifyVawc.Enabled = True
        End If
    End Sub
    Private Sub clearEverything()
        txtCaseId.Clear()
        txtCaseName.Clear()
        txtVictim.Clear()
        txtSuspect.Clear()
        txtRelationship.Clear()
        comboCaseStatus.SelectedIndex = 0
        datePickerSubmittedOn.Value = Date.Now
        txtSubmittedBy.Clear()
        txtCaseDetails.Clear()


        labelCaseId.Text = ""
        labelCaseName.Text = ""
        labelVictim.Text = ""
        labelSuspect.Text = ""
        labelRelationship.Text = ""
        labelCaseStatus.Text = ""
        labelSubmittedOn.Text = ""
        labelSubmittedBy.Text = ""
        labelCaseDetails.Text = ""


        clickableVictim = False
        clickableSuspect = False
        clickableSubmittedBy = False
        victimId = 0
        suspectId = 0
        submittedById = 0
        victim = ""
        suspect = ""
        submittedBy = ""

        Panel12.VerticalScroll.Value = 0
        panelParent.VerticalScroll.Value = 0

    End Sub
    Private Sub btnModifyVawc_Click(sender As Object, e As EventArgs) Handles btnModifyVawc.Click

        mainTabControl.SelectedIndex = 1
        action = "modify"

        txtCaseId.Show()
        labelId.Show()

        txtCaseName.Enabled = False
        txtVictim.Enabled = False
        txtSuspect.Enabled = False
        txtRelationship.Enabled = False

        txtSubmittedBy.Enabled = False
        datePickerSubmittedOn.Enabled = False

        panelSearchParent.Hide()
        btnSearchSubmittedBy.Hide()

        comboCaseStatus.SelectedIndex = comboCaseStatus.FindStringExact(labelCaseStatus.Text)

        txtCaseId.Text = labelCaseId.Text
        txtCaseName.Text = labelCaseName.Text
        txtVictim.Text = labelVictim.Text
        txtSuspect.Text = labelSuspect.Text
        txtRelationship.Text = labelRelationship.Text
        txtCaseDetails.Text = labelCaseDetails.Text
        txtSubmittedBy.Text = labelSubmittedBy.Text

        Dim dt As DateTime = DateTime.ParseExact(labelSubmittedOn.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        datePickerSubmittedOn.Value = dt


    End Sub
    Private Sub btnSaveVawc_Click(sender As Object, e As EventArgs) Handles btnSaveVawc.Click
        If txtCaseName.Text.Trim = "" Or txtVictim.Text.Trim = "" Or txtSuspect.Text.Trim = "" Or txtRelationship.Text.Trim = "" Or txtSubmittedBy.Text = "" Then
            MsgBox("Please Fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        ElseIf datePickerSubmittedOn.Value > Date.Now Then
            MsgBox("Please Fill out valid date filed!", vbCritical, "Warning")
            Exit Sub
        ElseIf (victimId = 0 And suspectid = 0) And action = "add" Then
            MsgBox("There must be atleast one resident between victim or suspect!", vbCritical, "Warning")
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
                cmd.CommandText = "UPDATE vawc SET case_details = @casedetails, case_status = @casestatus where case_id = @caseid"
                cmd.Parameters.AddWithValue("@caseid", caseId)
                cmd.Parameters.AddWithValue("@casedetails", txtCaseDetails.Text)
                cmd.Parameters.AddWithValue("@casestatus", comboCaseStatus.Text)

                cmd.ExecuteNonQuery()

                addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Updated Vawc Case [" & caseId.ToString & "][" & txtCaseName.Text & "]")
            ElseIf action = "add" Then
                cmd.CommandText = "INSERT INTO vawc (case_name, victim, suspect, relationship, case_status, submitted_by, submitted_on, case_details) values (@casename, @victim, @suspect, @relationship, @casestatus, @submittedby, @submittedon, @casedetails)"
                cmd.Parameters.AddWithValue("@casename", txtCaseName.Text)
                cmd.Parameters.AddWithValue("@victim", If(victimId = 0, txtVictim.Text, victimId))
                cmd.Parameters.AddWithValue("@suspect", If(suspectId = 0, txtSuspect.Text, suspectId))
                cmd.Parameters.AddWithValue("@submittedby", If(submittedById = 0, txtSubmittedBy.Text, submittedById))
                cmd.Parameters.AddWithValue("@submittedon", datePickerSubmittedOn.Value.Date)
                cmd.Parameters.AddWithValue("@casedetails", txtCaseDetails.Text)
                cmd.Parameters.AddWithValue("@casestatus", comboCaseStatus.Text)
                cmd.Parameters.AddWithValue("@relationship", txtRelationship.Text)

                cmd.ExecuteNonQuery()

                addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Added Vawc Case [" & txtCaseName.Text & "] Victim [" & txtVictim.Text & "] Suspect [" & txtSuspect.Text & "]")
            End If

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            MsgBox("Case Filed!", vbInformation, "Information")
            clearEverything()
            Me.Close()
            Main_Form.txtSearchVawc.Text = "Search by case name or id"
            Main_Form.btnVawc.PerformClick()
        End If
    End Sub

    Private Sub labelVictim_Click(sender As Object, e As EventArgs) Handles labelVictim.Click
        If clickableVictim = True Then
            ViewResident.resident_id = victimId
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub labelSuspect_Click(sender As Object, e As EventArgs) Handles labelSuspect.Click
        If clickableSuspect = True Then
            ViewResident.resident_id = suspectId
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub labelSubmittedBy_Click(sender As Object, e As EventArgs) Handles labelSubmittedBy.Click
        If clickableSubmittedBy = True Then
            ViewResident.resident_id = submittedById
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub

    Private Sub btnSearchVictim_Click(sender As Object, e As EventArgs) Handles btnSearchVictim.Click
        Search_Residents.origin = "VawcVictim"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchSuspect_Click(sender As Object, e As EventArgs) Handles btnSearchSuspect.Click
        Search_Residents.origin = "VawcSuspect"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchSubmittedBy_Click(sender As Object, e As EventArgs) Handles btnSearchSubmittedBy.Click
        Search_Residents.origin = "VawcSubmittedBy"
        Search_Residents.ShowDialog()
    End Sub

    Private Sub txtView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVictim.KeyPress, txtSuspect.KeyPress, txtSubmittedBy.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVictim.KeyDown, txtSuspect.KeyDown, txtSubmittedBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
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