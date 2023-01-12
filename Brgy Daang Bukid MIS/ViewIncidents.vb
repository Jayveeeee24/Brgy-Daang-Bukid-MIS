Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class ViewIncidents
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Public incidentId As Integer

    Private Sub ViewIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)


        datePickerIncidentDate.Format = DateTimePickerFormat.Custom
        datePickerIncidentDate.CustomFormat = "MMMM d, yyyy"

        loadInitialData()
        checkPriveledges()
    End Sub
    Private Sub checkPriveledges()
        Dim id = Main_Form.account_id

        btnModifyIncident.Show()
        If id = 3 Then
            btnModifyIncident.Hide()
        End If

    End Sub
    Private Sub loadInitialData()
        txtIncidentId.Select()
        comboIncidentTime.SelectedIndex = 0
        mainTabControl.SelectedIndex = 0
        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtIncidentId.Hide()
            labelId.Hide()

            txtIncidentName.Enabled = True
            datePickerIncidentDate.Enabled = True
            comboIncidentTime.Enabled = True
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

        txtIncidentId.Text = labelIncidentId.Text
        txtIncidentName.Text = labelIncidentName.Text
        txtIncidentDetails.Text = labelIncidentDetails.Text

        comboIncidentTime.SelectedIndex = comboIncidentTime.FindStringExact(labelIncidentTime.Text)
        Dim dt As DateTime = DateTime.ParseExact(labelIncidentDate.Text, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        datePickerIncidentDate.Value = dt
    End Sub

    Private Sub txtViewKeydown(sender As Object, e As KeyEventArgs) Handles txtIncidentName.KeyDown, txtIncidentId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub clearEverything()
        action = ""
        incidentId = 0


        txtIncidentId.Text = ""
        txtIncidentName.Text = ""
        txtIncidentDetails.Text = ""

        comboIncidentTime.SelectedIndex = 0
        datePickerIncidentDate.Value = Date.Now
    End Sub

    Private Sub ViewIncidents_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub

    Private Sub btnSaveIncident_Click(sender As Object, e As EventArgs) Handles btnSaveIncident.Click

        If txtIncidentName.Text.Trim = "" Then
            MsgBox("Please Fill out a valid Incident Name", vbCritical, "Warning")
            Exit Sub
        ElseIf datePickerIncidentDate.Value > Date.Now Then
            MsgBox("Please Fill out a valid Incident Date", vbCritical, "Warning")
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
                cmd.CommandText = "UPDATE incidents SET incident_details = @incidentdetails WHERE incident_id = @incidentid"
                cmd.Parameters.AddWithValue("@incidentid", incidentId)
                cmd.Parameters.AddWithValue("@incidentdetails", txtIncidentDetails.Text.Trim)

                cmd.ExecuteNonQuery()
            ElseIf action = "add" Then
                cmd.CommandText = "INSERT INTO incidents (incident_name, incident_details, incident_date, incident_time) values (@incidentname, @incidentdetails, @incidentdate, @incidenttime)"
                cmd.Parameters.AddWithValue("@incidentname", txtIncidentName.Text.Trim)
                cmd.Parameters.AddWithValue("@incidentdetails", txtIncidentDetails.Text.Trim)
                cmd.Parameters.AddWithValue("@incidentdate", datePickerIncidentDate.Value.Date)
                cmd.Parameters.AddWithValue("@incidenttime", comboIncidentTime.Text.Trim)

                cmd.ExecuteNonQuery()
            End If


            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            MsgBox("Incident Filed!", vbInformation, "Information")
            clearEverything()
            Me.Close()
            Main_Form.txtSearchComplaints.Text = "Search by incident id or name"
            Main_Form.btnIncidents.PerformClick()
        End If

    End Sub

    Private Sub ViewIncidents_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" Then
            If txtIncidentName.Text.Trim <> "" Or txtIncidentDetails.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.YesNo, "Are you sure to exit?") = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class