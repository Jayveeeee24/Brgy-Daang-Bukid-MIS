Imports System.Data
Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class ArchivedResidents

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Private Sub ArchivedResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
    End Sub

    Private Sub txtSearchResident_Click(sender As Object, e As EventArgs) Handles txtSearchResident.Click
        If txtSearchResident.Text = "Search by first or last name" Then
            txtSearchResident.Clear()
        End If
    End Sub
    Private Sub txtSearchResident_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchResident.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchResident.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnSearchResident_Click(sender As Object, e As EventArgs) Handles btnSearchResident.Click
        loadDatagrid()
    End Sub
    Private Sub datagridResident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridResident.CellClick
        If e.RowIndex >= 0 Then
            ViewResident.resident_id = datagridResident.Rows(e.RowIndex).Cells(0).Value
            ViewResident.viewChoice = "Archived"
            ViewResident.ShowDialog()
        End If
    End Sub

    Private Sub loadDatagrid()

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

        Dim mySQLCommand As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        mySQLCommand = mySql.CreateCommand()
        mySQLCommand.CommandType = CommandType.Text


        mySQLCommand.CommandText = "SELECT * from archived_residents WHERE resident_id > 0 " & (If(txtSearchResident.Text.Trim = "" Or txtSearchResident.Text = "Search by first or last name", " ", " AND (first_name LIKE @resident_name OR last_name LIKE @resident_name)")) & " order by first_name asc"
        mySQLCommand.Parameters.AddWithValue("@resident_name", txtSearchResident.Text.Trim & "%")

        mySQLReader = mySQLCommand.ExecuteReader


        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim middle, ext As String
                If mySQLReader!middle_name = Nothing Then
                    middle = ""
                Else
                    middle = mySQLReader!middle_name + " "
                End If

                datagridResident.Rows.Add(New String() {mySQLReader!resident_id, (mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name), mySQLReader!sex, mySQLReader!contact_no})

            End While
        End If

        mySQLCommand.Dispose()
        mySQLReader.Dispose()


        mySql.Close()
        mySql.Dispose()

        datagridResident.ClearSelection()
    End Sub
End Class