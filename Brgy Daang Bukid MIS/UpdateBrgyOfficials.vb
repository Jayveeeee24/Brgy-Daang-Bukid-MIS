
Imports MySql.Data.MySqlClient

Public Class UpdateBrgyOfficials

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Dim officialId As Integer

    Private Sub UpdateBrgyOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
    End Sub

    Private Sub loadDatagrid()
        dataGridBrgyOfficials.Rows.Clear()
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


        mySQLCommand.CommandText = "SELECT official_position, official_name FROM brgyOfficials"
        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                dataGridBrgyOfficials.Rows.Add(New String() {mySQLReader!official_name, getResidentNameById(mySQLReader!official_name), mySQLReader!official_position})
            End While
        End If

        mySQLCommand.Dispose()
        mySQLReader.Dispose()


        mySql.Close()
        mySql.Dispose()

        dataGridBrgyOfficials.ClearSelection()
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

    Private Sub btnAppointOfficial_Click(sender As Object, e As EventArgs) Handles btnAppointOfficial.Click

    End Sub

    Private Sub btnDismissOfficial_Click(sender As Object, e As EventArgs) Handles btnDismissOfficial.Click
        If MsgBox("Are you sure to dismiss this official?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then


            Me.Close()
            Main_Form.btnUpdateBrgyOfficials.PerformClick()
        End If
    End Sub


    Private Sub UpdateBrgyOfficials_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        officialId = 0
    End Sub
End Class