Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient


Public Class ViewBlotters

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Public blotterId As Integer

    Dim clickableSuspect, clickableSubmittedBy As Boolean
    Public suspectId, submittedById As Integer

    Public suspect As String = ""
    Public submittedBy As String = ""

    Private Sub ViewBlotters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        clearEverything()

        datePickerSubmittedOn.Format = DateTimePickerFormat.Custom
        datePickerSubmittedOn.CustomFormat = "MMMM d, yyyy"

        loadInitialData()
    End Sub
    Private Sub ViewBlotters_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub
    Private Sub ViewBlotters_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub loadInitialData()
        txtBlotter.Select()
        mainTabControl.SelectedIndex = 0


        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtBlotterId.Hide()
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
                    Else
                        suspect = mySQLReader!suspect
                        clickableSuspect = False
                        labelSuspect.ForeColor = Color.Black
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

        txtBlotter.Enabled = True
        txtSuspect.Enabled = True
        txtSubmittedBy.Enabled = True
        datePickerSubmittedOn.Enabled = True
        panelSearchParent.Show()

    End Sub
    Private Sub btnSaveComplaint_Click(sender As Object, e As EventArgs) Handles btnSaveComplaint.Click
        If txtBlotter.Text.Trim = "" Or txtSuspect.Text.Trim = "" Or txtSubmittedBy.Text.Trim = "" Then
            MsgBox("Please Fill out the required fields!", vbCritical, "Warning")
            Exit Sub
        ElseIf datePickerSubmittedOn.Value > Date.Now Then
            MsgBox("Please Fill out valid date filed!", vbCritical, "Warning")
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

            If action = "add" Then
                cmd.CommandText = "INSERT INTO blotters (blotter, suspect, submmited_by, submitted_on, blotter_details) values (@blotter, @suspect, @submittedby, @submittedon, @blotterdetails)"
                cmd.Parameters.AddWithValue("@blotter", txtBlotter.Text)
                cmd.Parameters.AddWithValue("@suspect", If(suspectId = 0, txtSuspect.Text, suspectId))
                cmd.Parameters.AddWithValue("@submittedby", If(submittedById = 0, txtSubmittedBy.Text, submittedById))
                cmd.Parameters.AddWithValue("@datefiled", datePickerSubmittedOn.Value.Date)
                cmd.Parameters.AddWithValue("@details", txtBlotterDetails.Text)

                cmd.ExecuteNonQuery()
            End If

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            MsgBox("Blotter Filed!", vbInformation, "Information")
            clearEverything()
            Me.Close()
            Main_Form.txtSearchBlotters.Text = "Search by blotter or suspect"
            Main_Form.btnBlotters.PerformClick()
        End If
    End Sub

    Private Sub clearEverything()
        txtBlotterId.Clear()
        txtBlotter.Clear()
        txtSuspect.Clear()
        txtSubmittedBy.Clear()
        datePickerSubmittedOn.Value = Date.Now
        txtBlotterDetails.Clear()


        labelBlotterId.Text = ""
        labelBlotter.Text = ""
        labelSuspect.Text = ""
        labelSubmittedBy.Text = ""
        labelSubmittedOn.Text = ""
        labelBlotterDetails.Text = ""

        clickableSuspect = False
        clickableSubmittedBy = False
        suspectId = 0
        submittedById = 0
        suspect = ""
        submittedBy = ""

        Panel12.VerticalScroll.Value = 0
        panelParent.VerticalScroll.Value = 0

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
    Private Sub txtSuspect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSuspect.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtSubmittedBy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubmittedBy.KeyPress
        checkInputCharactersOnly(e)
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuspect.KeyDown, txtSubmittedBy.KeyDown, txtBlotter.KeyDown
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