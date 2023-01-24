Imports System.Data
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class HeadChange

    Public householdId As Integer
    Public mySqlConn As String = My.Resources.constring
    Dim newHeadResidentId As Integer
    Private Sub HeadChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelHouseholdId.Text = householdId

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
        cmd.CommandText = "SELECT household.bldg_no, household.street_name, residents.resident_id, residents.first_name, residents.middle_name, residents.last_name, residents.ext_name, residents.birthdate FROM household LEFT JOIN residents on household.household_id = residents.household_id AND (residents.household_role = 'Member') AND (residents.age > 20) order by age desc limit 1"
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                newHeadResidentId = mySQLReader!resident_id
                labelAddress.Text = mySQLReader!bldg_no + ", " + mySQLReader!street_name
                labelName.Text = mySQLReader!first_name + If(mySQLReader!middle_name = "", "", " " + mySQLReader!middle_name) + " " + mySQLReader!last_name + If(mySQLReader!ext_name = "", "", " " + mySQLReader!ext_name)
                Dim temp As Date = mySQLReader!birthdate
                labelBirthdate.Text = temp.ToString("MMMM d, yyyy")
            End While
        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub HeadChange_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
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
        cmd.CommandText = "UPDATE residents SET household_role = 'Head' WHERE resident_id = @residentid"
        cmd.Parameters.AddWithValue("@residentid", newHeadResidentId)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        Me.Close()
        ViewResident.archiveResident()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class