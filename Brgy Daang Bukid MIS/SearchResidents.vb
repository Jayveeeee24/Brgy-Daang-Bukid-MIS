Imports System.Linq.Expressions
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Search_Residents

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public origin As String
    Private Sub Search_Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridResident.Rows.Clear()
        txtSearchResidents.Text = "Search by resident id or name"
    End Sub
    Private Sub Search_Residents_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        datagridResident.Rows.Clear()
        origin = ""
    End Sub
    Private Sub txtSearchResidents_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchResidents.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchResidents.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSearchResidents_Click(sender As Object, e As EventArgs) Handles btnSearchResidents.Click
        datagridResident.Rows.Clear()
        If txtSearchResidents.Text.Trim = "" Then
            txtSearchResidents.Text = "Search by resident id or name"
            datagridResident.Rows.Clear()
            txtSearchResidents.Select()
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
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT resident_id, household_id, first_name, middle_name, last_name, ext_name from residents where household_id LIKE @searchvalue or first_name like @searchvalue or middle_name like @searchvalue or last_name like @searchvalue order by first_name asc limit 10"
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchResidents.Text.Trim & "%")
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim middle, ext As String
                If mySQLReader!middle_name = Nothing Then
                    middle = ""
                Else
                    middle = mySQLReader!middle_name + " "
                End If
                datagridResident.Rows.Add(New String() {mySQLReader!resident_id, mySQLReader!household_id, mySQLReader!first_name + " " + middle + mySQLReader!last_name + If(mySQLReader!ext_name = "", "", " " + mySQLReader!ext_name), getAddressByHouseholdId(mySQLReader!household_id)})
            End While
        End If
        datagridResident.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function getAddressByHouseholdId(ByVal householdid As Integer) As String

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
        cmd.CommandText = "SELECT bldg_no, street_name from household where household_id  = @householdid"
        cmd.Parameters.AddWithValue("@householdid", householdid)
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

    Private Sub datagridResident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridResident.CellClick
        If e.RowIndex >= 0 Then
            If origin = "complainant" Then
                If ViewComplaints.defendantId = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Complainant and Defendant cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewComplaints.complainantId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewComplaints.complainant = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewComplaints.txtComplainant.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "defendant" Then
                If ViewComplaints.complainantId = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Complainant and Defendant cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewComplaints.defendantId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewComplaints.defendant = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewComplaints.txtDefendant.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "suspect" Then
                If ViewBlotters.submittedById = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Suspect and Plaintiff cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewBlotters.suspectId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewBlotters.suspect = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewBlotters.txtSuspect.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "submittedBy" Then
                If ViewBlotters.suspectId = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Suspect and Plaintiff cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewBlotters.submittedById = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewBlotters.submittedBy = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewBlotters.txtSubmittedBy.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "VawcVictim" Then
                If ViewVawc.suspectId = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Victim and Suspect cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewVawc.victimId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewVawc.victim = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewVawc.txtVictim.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "VawcSuspect" Then
                If ViewVawc.victimId = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("Victim and Suspect cannot be the same!", vbCritical, "Warning")
                    Exit Sub
                End If
                ViewVawc.suspectId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewVawc.suspect = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewVawc.txtSuspect.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "VawcSubmittedBy" Then
                ViewVawc.submittedById = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewVawc.submittedBy = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewVawc.txtSubmittedBy.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value


            ElseIf origin = "certificates" Then
                Certificate_Setup.residentid = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Certificate_Setup.txtResidentName.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.residentName = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.residentAddress = datagridResident.Rows(e.RowIndex).Cells(3).Value
            ElseIf origin = "complainant1" Then
                If Certificate_Setup.complainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Certificate_Setup.complainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Certificate_Setup.txtComplainant1.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.complainant1 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "complainant2" Then
                If Certificate_Setup.complainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Certificate_Setup.complainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Certificate_Setup.txtComplainant2.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.complainant2 = datagridResident.Rows(e.RowIndex).Cells(2).Value


            ElseIf origin = "respondent1" Then
                If Certificate_Setup.complainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.complainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Certificate_Setup.respondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Certificate_Setup.txtRespondent1.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.respondent1 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "respondent2" Then
                If Certificate_Setup.complainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.complainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Certificate_Setup.respondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Certificate_Setup.respondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Certificate_Setup.txtRespondent2.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Certificate_Setup.respondent2 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "Official" Then
                AppointOfficial.residentId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                AppointOfficial.txtOfficialName.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                AppointOfficial.residentName = datagridResident.Rows(e.RowIndex).Cells(2).Value
            End If
        End If
        Me.Close()
    End Sub

    Private Sub txtSearchResidents_Click(sender As Object, e As EventArgs) Handles txtSearchResidents.Click
        If txtSearchResidents.Text = "Search by resident id or name" Then
            txtSearchResidents.Clear()
        End If
    End Sub


End Class