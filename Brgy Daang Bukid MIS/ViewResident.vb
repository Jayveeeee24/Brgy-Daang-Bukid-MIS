Imports MySql.Data.MySqlClient

Public Class ViewResident

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public resident_id As Integer
    Public viewChoice As String

    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)


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

        If viewChoice = "Archived" Then
            panelArchiveDetails.Show()
            cmd.CommandText = "SELECT * FROM archived_residents WHERE resident_id = @residentId"
        Else
            panelArchiveDetails.Dispose()
            cmd.CommandText = "SELECT * FROM residents WHERE resident_id = @residentId"
        End If

        cmd.Parameters.AddWithValue("@residentId", resident_id)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then

            While mySQLReader.Read
                labelFirst.Text = mySQLReader!first_name
                labelMiddle.Text = mySQLReader!middle_name
                labelLast.Text = mySQLReader!last_name
                labelExtension.Text = mySQLReader!ext_name
                labelBirthdate.Text = mySQLReader!birthdate
                labelAge.Text = mySQLReader!age
                labelBirthPlace.Text = mySQLReader!birthplace
                labelCivilStatus.Text = mySQLReader!civil_status
                labelSex.Text = mySQLReader!sex
                labelReligion.Text = mySQLReader!religion
                labelContactNo.Text = mySQLReader!contact_no
                labelPwd.Text = mySQLReader!is_pwd
                labelVoter.Text = mySQLReader!is_voter
                labelOccupation.Text = mySQLReader!occupation
                If mySQLReader!household_head = "Yes" Then
                    panelHouseholdHead.Show()
                Else
                    panelHouseholdHead.Dispose()
                End If
                labelDateRegistered.Text = dateFormatter(mySQLReader!month, mySQLReader!day, mySQLReader!year)
                labelRegisteredBy.Text = mySQLReader!registered_by

            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()


    End Sub

    Private Function dateFormatter(ByVal month As String, ByVal day As String, ByVal year As String) As String
        Return month + day + ", " + year
    End Function

    Private Sub btnModifyResident_Click(sender As Object, e As EventArgs) Handles btnModifyResident.Click
        mainTabControl.SelectedTab = pageAddModify
    End Sub

End Class