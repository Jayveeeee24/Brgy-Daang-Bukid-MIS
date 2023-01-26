﻿Imports System.Linq.Expressions
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Search_Residents

    Public mySqlConn As String = My.Resources.constring
    Public origin As String
    Private Sub Search_Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridResident.Rows.Clear()
        txtSearchResidents.Text = "Search by resident name"
        btnSearchResidents.PerformClick()
    End Sub
    Private Sub Search_Residents_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub txtSearchResidents_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchResidents.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchResidents.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchResidents_TextChanged(sender As Object, e As EventArgs) Handles txtSearchResidents.TextChanged
        btnSearchResidents.PerformClick()
    End Sub

    Private Sub btnSearchResidents_Click(sender As Object, e As EventArgs) Handles btnSearchResidents.Click
        datagridResident.Rows.Clear()

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
            If origin = "incident" Then
                ViewIncidents.reportedById = datagridResident.Rows(e.RowIndex).Cells(0).Value
                ViewIncidents.reportedByName = datagridResident.Rows(e.RowIndex).Cells(2).Value
                ViewIncidents.txtIncidentReportedBy.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "complainant" Then
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
                Main_Form.certificateResidentId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Main_Form.txtCertificateResident.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateResidentName = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateResidentAddress = datagridResident.Rows(e.RowIndex).Cells(3).Value
                Main_Form.txtCertificateAddress.Text = datagridResident.Rows(e.RowIndex).Cells(3).Value
            ElseIf origin = "complainant1" Then
                If Main_Form.certificateComplainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Main_Form.certificateComplainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Main_Form.txtComplainant1.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateComplainant1 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "complainant2" Then
                If Main_Form.certificateComplainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Main_Form.certificateComplainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Main_Form.txtComplainant2.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateComplainant2 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "respondent1" Then
                If Main_Form.certificateComplainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateComplainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Main_Form.certificateRespondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Main_Form.txtRespondent1.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateRespondent1 = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "respondent2" Then
                If Main_Form.certificateComplainantId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateComplainantId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value Or Main_Form.certificateRespondentId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value Then
                    MsgBox("You cannot choose the same person for each field!", vbCritical, "Warning")
                    Exit Sub
                End If
                Main_Form.certificateRespondentId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                Main_Form.txtRespondent2.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Main_Form.certificateRespondent2 = datagridResident.Rows(e.RowIndex).Cells(2).Value

            ElseIf origin = "transactBy" Then
                ItemBorrow.txtTransactionBy.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
            ElseIf origin = "Official" Then
                AppointOfficial.residentId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                AppointOfficial.txtOfficialName.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                AppointOfficial.residentName = datagridResident.Rows(e.RowIndex).Cells(2).Value



            ElseIf origin = "captain" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.brgyCaptainId = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.brgyCaptain = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtBarangayCaptain.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If


            ElseIf origin = "kagawad1" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId1 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad1 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad1.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad2" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId2 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad2 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad2.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad3" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId3 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad3 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad3.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad4" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId4 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad4 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad4.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad5" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId5 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad5 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad5.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad6" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad7 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If

                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId6 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad6 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad6.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf origin = "kagawad7" Then
                If datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.brgyCaptain Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad1 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad2 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad3 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad4 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad5 Or datagridResident.Rows(e.RowIndex).Cells(2).Value = ElectOfficials.kagawad6 Then
                    MsgBox("You already picked this resident!", vbCritical, "Warning")
                    Exit Sub
                End If
                If isOfficial(datagridResident.Rows(e.RowIndex).Cells(0).Value) = False Then
                    ElectOfficials.kagawadId7 = datagridResident.Rows(e.RowIndex).Cells(0).Value
                    ElectOfficials.kagawad7 = datagridResident.Rows(e.RowIndex).Cells(2).Value
                    ElectOfficials.txtKagawad7.Text = datagridResident.Rows(e.RowIndex).Cells(2).Value
                Else
                    MsgBox("This resident already has a position!", vbCritical, "Warning")
                    Exit Sub
                End If


            End If


        End If
        Me.Close()
    End Sub

    Private Function isOfficial(ByVal residentId As Integer) As Boolean
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
        cmd.CommandText = "SELECT count(*) FROM brgyofficials where official_name = @officialname"
        cmd.Parameters.AddWithValue("@officialname", residentId)
        If cmd.ExecuteScalar() = 0 Then
            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
            Return False
        Else
            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
            Return True
        End If
    End Function

    Private Sub txtSearchResidents_Click(sender As Object, e As EventArgs) Handles txtSearchResidents.Click
        If txtSearchResidents.Text = "Search by resident name" Then
            txtSearchResidents.Clear()
        End If
    End Sub

End Class