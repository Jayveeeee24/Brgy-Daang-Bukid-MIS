Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient


Public Class ViewBlotters

    Public mySqlConn As String = My.Resources.constring
    Public action As String
    Public blotterId As Integer

    Dim clickableSuspect, clickableSubmittedBy As Boolean
    Public suspectId, submittedById As Integer
    Dim isSaved As Boolean = False

    Public suspect As String = ""
    Public submittedBy As String = ""

    Private Sub ViewBlotters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)

        datePickerSubmittedOn.Format = DateTimePickerFormat.Custom
        datePickerSubmittedOn.CustomFormat = "MMMM d, yyyy"
        getSystemVariable(comboBlotteredFor, "Blottered for")

        loadInitialData()
    End Sub
    Private Sub ViewBlotters_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub ViewBlotters_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If comboBlotteredFor.Text.Trim <> "" Or txtSuspect.Text.Trim <> "" Or txtSubmittedBy.Text.Trim <> "" Or txtBlotterDetails.Text.Trim <> "" Then
                If mainTabControl.SelectedIndex = 1 Then
                    If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub loadInitialData()
        comboBlotteredFor.Select()

        mainTabControl.SelectedIndex = 0


        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            panelBlotterId.Hide()
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
            cmd.CommandText = "SELECT * FROM blotters where blotter_id = @blotterid"
            cmd.Parameters.AddWithValue("@blotterid", blotterId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    labelBlotterId.Text = mySQLReader!blotter_id
                    labelBlotter.Text = mySQLReader!blotter

                    If IsNumeric(mySQLReader!suspect) Then
                        suspect = getResidentNameById(mySQLReader!suspect)
                        clickableSuspect = True
                        suspectId = mySQLReader!suspect
                        labelSuspect.ForeColor = Color.Blue
                        labelSuspectAddress.Text = getAddressByResidentId(suspectId)
                        labelSuspectContactNo.Text = getContactNoById(suspectId)
                    Else
                        suspect = mySQLReader!suspect
                        clickableSuspect = False
                        labelSuspect.ForeColor = Color.Black
                        labelSuspectAddress.Text = mySQLReader!suspect_address
                        labelSuspectContactNo.Text = mySQLReader!suspect_contactno
                    End If
                    labelSuspect.Text = suspect
                    If IsNumeric(mySQLReader!submmited_by) Then
                        submittedBy = getResidentNameById(mySQLReader!submmited_by)
                        clickableSubmittedBy = True
                        submittedById = mySQLReader!submmited_by
                        labelSubmittedBy.ForeColor = Color.Blue
                    Else
                        submittedBy = mySQLReader!submmited_by
                        clickableSubmittedBy = False
                        labelSubmittedBy.ForeColor = Color.Black
                    End If
                    labelSubmittedBy.Text = submittedBy

                    Dim date1 As Date = mySQLReader!submitted_on
                    labelSubmittedOn.Text = date1.ToString("MMMM d, yyyy")
                    labelBlotterDetails.Text = mySQLReader!blotter_details

                End While
            End If
            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

        End If

        Dim tempdate As Date = Date.Now
        datePickerSubmittedOn.Value = tempdate

        comboBlotteredFor.Enabled = True
        txtSuspect.Enabled = True
        txtSubmittedBy.Enabled = True
        datePickerSubmittedOn.Enabled = True
        btnSearchSuspect.Show()
        btnSearchSubmittedBy.Show()

        txtSubmittedBy.Enabled = True
        datePickerSubmittedOn.Enabled = True

        panelSuspectRadio.Show()
        radioSuspectResident.Checked = True


    End Sub

    Private Sub radioSuspectResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioSuspectResident.CheckedChanged
        If radioSuspectResident.Checked = True Then
            btnSearchSuspect.Show()
            panelSuspectDetails.Hide()

            txtSubmittedBy.Enabled = True

            txtSuspect.Enabled = False
            txtSuspect.Clear()
        End If
    End Sub
    Private Sub radioSuspectNonResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioSuspectNonResident.CheckedChanged
        If radioSuspectNonResident.Checked = True Then
            btnSearchSuspect.Hide()
            panelSuspectDetails.Show()

            txtSubmittedBy.Enabled = False

            txtSuspect.Enabled = True
            txtSuspect.Clear()
            suspectId = 0
        End If
    End Sub
    Private Sub labelSuspect_Click(sender As Object, e As EventArgs) Handles labelSuspect.Click
        If clickableSuspect = True Then
            ViewResident.resident_id = suspectId
            ViewResident.viewChoice = "Normal"
            ViewResident.action = "modify"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub labelSubmittedBy_Click(sender As Object, e As EventArgs) Handles labelSubmittedBy.Click
        If clickableSubmittedBy = True Then
            ViewResident.resident_id = submittedById
            ViewResident.viewChoice = "Normal"
            ViewResident.action = "modify"
            ViewResident.ShowDialog()
        End If
    End Sub
    Private Sub txtView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSuspect.KeyPress, txtSubmittedBy.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSubmittedBy.KeyDown, txtSuspect.KeyDown, txtSuspectAddress.KeyDown, txtSuspectContactNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnSearchSuspect_Click(sender As Object, e As EventArgs) Handles btnSearchSuspect.Click
        Search_Residents.origin = "suspect"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchSubmittedBy_Click(sender As Object, e As EventArgs) Handles btnSearchSubmittedBy.Click
        Search_Residents.origin = "submittedBy"
        Search_Residents.ShowDialog()
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

    Private Sub btnSaveBlotter_Click(sender As Object, e As EventArgs) Handles btnSaveBlotter.Click
        If comboBlotteredFor.Text.Trim = "" Then
            MsgBox("Blotter name cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtSuspect.Text.Trim = "" Then
            MsgBox("Suspect name cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtSubmittedBy.Text.Trim = "" Then
            MsgBox("Submitted by cannot be blank!", vbCritical, "Warning")
            Exit Sub
        End If
        If datePickerSubmittedOn.Value.Date > Date.Now Then
            MsgBox("Please provide a valid submitted date!", vbCritical, "Warning")
            Exit Sub
        End If
        If suspectId = 0 And submittedById = 0 Then
            MsgBox("There must be at least one resident residing in the barangay!", vbCritical, "Warning")
            Exit Sub
        End If
        If suspectId = 0 And (txtSuspectAddress.Text.Trim = "" Or txtSuspectContactNo.Text = "") Then
            MsgBox("Please provide address and contact no for suspect!", vbCritical, "Warning")
            Exit Sub
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

        If action = "add" Then
            cmd.CommandText = "INSERT INTO blotters (blotter, suspect, suspect_address, suspect_contactno, submmited_by, submitted_on, blotter_details) values (@blotter, @suspect, @suspectaddress, @suspectcontactno, @submittedby, @submittedon, @blotterdetails)"
            cmd.Parameters.AddWithValue("@blotter", comboBlotteredFor.Text)
            cmd.Parameters.AddWithValue("@suspect", If(radioSuspectResident.Checked = True, suspectId, txtSuspect.Text))
            cmd.Parameters.AddWithValue("@suspectaddress", If(radioSuspectResident.Checked = True, "", txtSuspectAddress.Text))
            cmd.Parameters.AddWithValue("@suspectcontactno", If(radioSuspectResident.Checked = True, "", txtSuspectContactNo.Text))

            cmd.Parameters.AddWithValue("@submittedby", If(submittedById = 0 Or txtSubmittedBy.Text <> submittedBy, txtSubmittedBy.Text, submittedById))
            cmd.Parameters.AddWithValue("@submittedon", datePickerSubmittedOn.Value.Date)
            cmd.Parameters.AddWithValue("@blotterdetails", txtBlotterDetails.Text)

            cmd.ExecuteNonQuery()
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Blotter Filed!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchBlotters.Text = "Search by blotter or suspect"
        Main_Form.btnBlotters.PerformClick()

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