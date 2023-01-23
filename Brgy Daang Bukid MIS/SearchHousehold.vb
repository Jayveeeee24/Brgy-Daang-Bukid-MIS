Imports System.Linq.Expressions
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common


Public Class SearchHousehold

    Public mySqlConn As String = "server=192.168.1.2; user id=user; password=qwer; database=mis"
    Private Sub SearchHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridHousehold.Rows.Clear()
        txtSearchHousehold.Text = "Search by household id, house no or street name"
    End Sub
    Private Sub SearchHousehold_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub


    Private Sub txtSearchHousehold_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchHousehold.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchHousehold.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearchHousehold_TextChanged(sender As Object, e As EventArgs) Handles txtSearchHousehold.TextChanged
        btnSearchHousehold.PerformClick()
    End Sub
    Private Sub btnSearchHousehold_Click(sender As Object, e As EventArgs) Handles btnSearchHousehold.Click
        datagridHousehold.Rows.Clear()

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

        cmd.CommandText = "SELECT household.household_id, household.bldg_no, household.street_name, residents.first_name, residents.middle_name, residents.last_name, residents.ext_name from household LEFT JOIN residents on household.household_id = residents.household_id AND (residents.household_role = 'Head') where household.household_id LIKE @searchvalue or household.bldg_no like @searchvalue or household.street_name like @searchvalue order by household.household_id asc limit 10"

        cmd.Parameters.AddWithValue("@searchvalue", txtSearchHousehold.Text.Trim & "%")
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim middle, ext As String
                If mySQLReader!middle_name = Nothing Then
                    middle = ""
                Else
                    middle = mySQLReader!middle_name + " "
                End If
                datagridHousehold.Rows.Add(New String() {mySQLReader!household_id, (mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name), mySQLReader!bldg_no, mySQLReader!street_name})
            End While
        End If
        datagridHousehold.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub


    Private Sub txtSearchHousehold_Click(sender As Object, e As EventArgs) Handles txtSearchHousehold.Click
        If txtSearchHousehold.Text = "Search by household id, house no or street name" Then
            txtSearchHousehold.Clear()
        End If
    End Sub

    Private Sub datagridHousehold_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridHousehold.CellClick
        If e.RowIndex >= 0 Then
            ViewResident.comboHouseholdId.SelectedIndex = ViewResident.comboHouseholdId.FindStringExact(datagridHousehold.Rows(e.RowIndex).Cells(0).Value)
        End If
        Me.Close()
    End Sub
End Class