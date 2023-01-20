Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class ViewIncidents
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Public incidentId As Integer = 0
    Public reportedById As Integer = 0
    Public reportedByName As String = ""
    Dim isSaved As Boolean = False
    Public clickableReportedBy As Boolean

    Private Sub ViewIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)


        datePickerIncidentDate.Format = DateTimePickerFormat.Custom
        datePickerIncidentDate.CustomFormat = "MMMM d, yyyy"

        loadInitialData()
    End Sub
    Private Sub loadInitialData()
        txtIncidentId.Select()
        comboIncidentTime.SelectedIndex = 0
        mainTabControl.SelectedIndex = 0
        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtIncidentId.Hide()
            labelId.Hide()
            reportedById = 0
            reportedByName = ""

            txtIncidentName.Enabled = True
            datePickerIncidentDate.Enabled = True
            comboIncidentTime.Enabled = True
            txtIncidentReportedBy.Enabled = True
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
            cmd.CommandText = "SELECT * FROM incidents where incident_id = @incidentid"
            cmd.Parameters.AddWithValue("@incidentid", incidentId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    labelIncidentId.Text = mySQLReader!incident_id
                    labelIncidentName.Text = mySQLReader!incident_name
                    Dim date1 As Date = mySQLReader!incident_date
                    labelIncidentDate.Text = date1.ToString("MMMM d, yyyy")
                    labelIncidentTime.Text = mySQLReader!incident_time
                    labelIncidentDetails.Text = mySQLReader!incident_details

                    If IsNumeric(mySQLReader!reported_by) Then
                        labelIncidentReportedBy.Text = getResidentNameById(mySQLReader!reported_by)
                        clickableReportedBy = True
                        reportedById = mySQLReader!reported_by
                        labelIncidentReportedBy.ForeColor = Color.Blue
                    Else
                        labelIncidentReportedBy.Text = mySQLReader!reported_by
                        clickableReportedBy = False
                        labelIncidentReportedBy.ForeColor = Color.Black
                    End If

                    Dim datetime1 As DateTime = mySQLReader!reported_on
                    labelIncidentReportedOn.Text = Format(datetime1, "MMMM d, yyyy h:mm tt")
                End While
            End If


            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
        comboIncidentTime.SelectedIndex = 0
        Dim tempdate As Date = Date.Now
        datePickerIncidentDate.Value = tempdate

        txtIncidentName.Enabled = True
        comboIncidentTime.SelectedIndex = 12
        btnSearchIncidentReportedBy.Show()


    End Sub

    Private Sub btnModifyIncident_Click(sender As Object, e As EventArgs) Handles btnModifyIncident.Click
        mainTabControl.SelectedIndex = 1
        action = "modify"
        txtIncidentName.Enabled = False
        txtIncidentId.Show()
        labelId.Show()
        txtIncidentName.Enabled = False
        datePickerIncidentDate.Enabled = False
        comboIncidentTime.Enabled = False
        txtIncidentReportedBy.Enabled = False
        btnSearchIncidentReportedBy.Hide()


        txtIncidentId.Text = labelIncidentId.Text
        txtIncidentName.Text = labelIncidentName.Text
        txtIncidentDetails.Text = labelIncidentDetails.Text
        txtIncidentReportedBy.Text = labelIncidentReportedBy.Text

        comboIncidentTime.SelectedIndex = comboIncidentTime.FindStringExact(labelIncidentTime.Text)
        Dim dt As DateTime = DateTime.ParseExact(labelIncidentDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        datePickerIncidentDate.Value = dt
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

    Private Sub txtViewKeydown(sender As Object, e As KeyEventArgs) Handles txtIncidentName.KeyDown, txtIncidentId.KeyDown, txtIncidentReportedBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ViewIncidents_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub btnSaveIncident_Click(sender As Object, e As EventArgs) Handles btnSaveIncident.Click
        If txtIncidentName.Text.Trim = "" Then
            MsgBox("Please fill out a valid Incident Name", vbCritical, "Warning")
            Exit Sub
        End If
        If datePickerIncidentDate.Value > Date.Now Then
            MsgBox("Please fill out a valid Incident Date", vbCritical, "Warning")
            Exit Sub
        End If
        If txtIncidentReportedBy.Text.Trim = "" Then
            MsgBox("Please provide a person who reported", vbCritical, "Warning")
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

        If action = "modify" Then
            cmd.CommandText = "UPDATE incidents SET incident_details = @incidentdetails WHERE incident_id = @incidentid"
            cmd.Parameters.AddWithValue("@incidentid", incidentId)
            cmd.Parameters.AddWithValue("@incidentdetails", txtIncidentDetails.Text.Trim)

            cmd.ExecuteNonQuery()
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO incidents (incident_name, incident_details, incident_date, incident_time, reported_by, reported_on) values (@incidentname, @incidentdetails, @incidentdate, @incidenttime, @reportedby, @reportedon)"
            cmd.Parameters.AddWithValue("@incidentname", txtIncidentName.Text.Trim)
            cmd.Parameters.AddWithValue("@incidentdetails", txtIncidentDetails.Text.Trim)
            cmd.Parameters.AddWithValue("@incidentdate", datePickerIncidentDate.Value.Date)
            cmd.Parameters.AddWithValue("@incidenttime", comboIncidentTime.Text.Trim)

            cmd.Parameters.AddWithValue("@reportedby", If(reportedById = 0 Or reportedByName <> txtIncidentReportedBy.Text, txtIncidentReportedBy.Text, reportedById))
            cmd.Parameters.AddWithValue("@reportedon", Date.Now)


            cmd.ExecuteNonQuery()
        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Incident Filed!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchComplaints.Text = "Search by incident id or name"
        Main_Form.btnIncidents.PerformClick()

    End Sub

    Private Sub ViewIncidents_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If txtIncidentName.Text.Trim <> "" Or txtIncidentDetails.Text.Trim <> "" Or txtIncidentReportedBy.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.YesNo, "Are you sure to exit?") = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub labelIncidentReportedBy_Click(sender As Object, e As EventArgs) Handles labelIncidentReportedBy.Click
        If clickableReportedBy = True Then
            ViewResident.resident_id = reportedById
            ViewResident.action = "modify"
            ViewResident.viewChoice = "Normal"
            ViewResident.ShowDialog()
        End If
    End Sub

    Private Sub txtIncidentReportedBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIncidentReportedBy.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSearchIncidentReportedBy_Click(sender As Object, e As EventArgs) Handles btnSearchIncidentReportedBy.Click
        Search_Residents.origin = "incident"
        Search_Residents.ShowDialog()
    End Sub
End Class