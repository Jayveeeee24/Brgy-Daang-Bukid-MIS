Imports System.ComponentModel
Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class AppointOfficial

    Public mySqlConn As String = My.Resources.constring
    Public residentId As Integer
    Public residentName As String
    Dim limit As Integer
    Private Sub AppointOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelPositionWarning.Hide()
    End Sub

    Private Sub txtOfficialName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOfficialName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtOfficialName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOfficialName.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnAppointOfficial_Click(sender As Object, e As EventArgs) Handles btnAppointOfficial.Click
        If residentId = 0 Or txtOfficialName.Text <> residentName Then
            MsgBox("Invalid Resident to Appoint!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboOfficialPosition.SelectedIndex = -1 Then
            MsgBox("Please select a valid position!", vbCritical, "Warning")
            Exit Sub
        End If
        If checkIfOfficial() = True Then
            MsgBox("Resident already has a position!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboOfficialPosition.SelectedIndex <= 5 Then
            If checkPositionAvailability() = False Then
                MsgBox("Position is already taken!", vbCritical, "Warning")
                Exit Sub
            End If
        Else
            If checkKagawad() = False Then
                MsgBox("You exceeded the number of " + comboOfficialPosition.Text + " you can appoint!", vbCritical, "Warning")
                Exit Sub
            End If
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
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        If comboOfficialPosition.SelectedIndex <= 5 Then
            cmd.CommandText = "INSERT INTO brgyofficials (id, official_name, official_position) VALUES (@id, @officialname, @officialposition)"
            cmd.Parameters.AddWithValue("@id", comboOfficialPosition.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@officialname", residentId)
            cmd.Parameters.AddWithValue("@officialposition", comboOfficialPosition.Text)
        Else
            cmd.CommandText = "INSERT INTO brgyofficials (official_name, official_position) VALUES (@officialname, @officialposition)"
            cmd.Parameters.AddWithValue("@officialname", residentId)
            cmd.Parameters.AddWithValue("@officialposition", comboOfficialPosition.Text)
        End If

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        MsgBox("Resident " + txtOfficialName.Text + " is now appointed as " + comboOfficialPosition.Text, vbInformation, "Information")
        Me.Close()
        UpdateBrgyOfficials.loadDatagrid()

    End Sub

    Private Function checkIfOfficial() As Boolean
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

    Private Function checkPositionAvailability() As Boolean
        If comboOfficialPosition.SelectedIndex <= 5 Then
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
            cmd.CommandText = "SELECT count(*) FROM brgyofficials where official_position = @officialposition"
            cmd.Parameters.AddWithValue("@officialposition", comboOfficialPosition.Text)
            If cmd.ExecuteScalar() = 0 Then
                cmd.Dispose()
                mySql.Close()
                mySql.Dispose()
                Return True
            Else
                cmd.Dispose()
                mySql.Close()
                mySql.Dispose()
                Return False
            End If
        End If
    End Function

    Private Function checkKagawad() As Boolean
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
        cmd.CommandText = "SELECT count(*) FROM brgyofficials where official_position = @officialposition"
        cmd.Parameters.AddWithValue("@officialposition", comboOfficialPosition.Text)
        If cmd.ExecuteScalar() >= 7 Then
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
    Private Sub comboOfficialPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboOfficialPosition.SelectedIndexChanged
        If checkPositionAvailability() = False And comboOfficialPosition.SelectedIndex <= 5 Then
            labelPositionWarning.Show()
        Else
            labelPositionWarning.Hide()
        End If
    End Sub

    Private Sub btnSearchOfficial_Click(sender As Object, e As EventArgs) Handles btnSearchOfficial.Click
        Search_Residents.origin = "Official"
        Search_Residents.ShowDialog()
    End Sub

    Private Sub AppointOfficial_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtOfficialName.Clear()
        residentId = 0
        residentName = ""
        comboOfficialPosition.SelectedIndex = -1
    End Sub
End Class