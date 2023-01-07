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
                datagridResident.Rows.Add(New String() {mySQLReader!resident_id, mySQLReader!household_id, mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name})

            End While
        End If
        datagridResident.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

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