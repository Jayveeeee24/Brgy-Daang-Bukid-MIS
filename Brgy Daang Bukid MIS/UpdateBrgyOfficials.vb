
Imports MySql.Data.MySqlClient

Public Class UpdateBrgyOfficials

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public officialId As Integer
    Public residentId As Integer

    Private Sub UpdateBrgyOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
        If isBrgyOfficialsAvailable() = False Then
            btnElectOfficials.Enabled = True
        Else
            btnElectOfficials.Enabled = False
        End If
    End Sub

    Public Sub loadDatagrid()
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


        mySQLCommand.CommandText = "SELECT id, official_position, official_name FROM brgyOfficials ORDER BY id ASC"
        mySQLReader = mySQLCommand.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                dataGridBrgyOfficials.Rows.Add(New String() {mySQLReader!id, getResidentNameById(mySQLReader!official_name), mySQLReader!official_position})
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
        Using form As New AppointOfficial
            AppointOfficial.ShowDialog()
        End Using
    End Sub

    Private Sub btnDismissOfficial_Click(sender As Object, e As EventArgs) Handles btnDismissOfficial.Click
        If MsgBox("Are you sure to dismiss this official?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            ConfirmAccess.originForm = "DismissBrgyOfficial"
            ConfirmAccess.Show()
        End If
    End Sub


    Public Sub dismissOfficial()
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

        cmd.CommandText = "DELETE FROM brgyofficials WHERE id = @officialid"
        cmd.Parameters.AddWithValue("@officialid", officialId)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Official Dismissed!", vbInformation, "Information")
        loadDatagrid()
        officialId = 0
        btnDismissOfficial.Enabled = False
        dataGridBrgyOfficials.ClearSelection()
    End Sub


    Private Sub UpdateBrgyOfficials_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub dataGridBrgyOfficials_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridBrgyOfficials.CellClick
        If e.RowIndex >= 0 Then
            btnDismissOfficial.Enabled = True
            officialId = dataGridBrgyOfficials.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub btnElectOfficials_Click(sender As Object, e As EventArgs) Handles btnElectOfficials.Click
        ElectOfficials.ShowDialog()
    End Sub

    Private Function isBrgyOfficialsAvailable() As Boolean
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
        cmd.CommandText = "SELECT count(*) FROM brgyofficials"
        If cmd.ExecuteScalar() = 0 Then
            Return False
        Else
            Return True
        End If
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function
End Class