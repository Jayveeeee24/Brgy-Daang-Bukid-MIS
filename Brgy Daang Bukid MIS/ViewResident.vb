Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class ViewResident

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public resident_id As Integer
    Public viewChoice As String
    Public action As String

    Dim firstName, middleName, lastName, extName As String
    Dim birthDate As Date
    Dim age, householdId As Integer
    Dim birthPlace, civilStatus, sex, religion,
        contactNo, pwd, disability, voter, occupation, citizenship,
        householdRole, registeredBy, dateRegistered, reasonArchived, archivedBy As String

    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        comboHouseholdId.Select()



        If action = "view" Then
            mainTabControl.SelectedTab = pageView
        ElseIf action = "add" Then
            mainTabControl.SelectedTab = pageAddModify
        End If

        If mainTabControl.SelectedIndex = 0 Then
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
                cmd.CommandText = "SELECT * FROM archived_residents WHERE resident_id = @residentId"
            Else
                labelArchive1.Hide()
                labelArchive2.Hide()
                labelArchive3.Hide()
                labelDateArchived.Hide()
                labelReasonArchived.Hide()
                labelArchivedBy.Hide()

                cmd.CommandText = "SELECT * FROM residents WHERE resident_id = @residentId"
            End If

            cmd.Parameters.AddWithValue("@residentId", resident_id)
            mySQLReader = cmd.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    firstName = mySQLReader!first_name
                    middleName = mySQLReader!middle_name
                    lastName = mySQLReader!last_name
                    extName = mySQLReader!ext_name

                    birthDate = mySQLReader!birthdate
                    age = mySQLReader!age
                    birthPlace = mySQLReader!birthplace
                    civilStatus = mySQLReader!civil_status
                    citizenship = mySQLReader!citizenship
                    sex = mySQLReader!sex
                    religion = mySQLReader!religion
                    contactNo = mySQLReader!contact_no
                    pwd = mySQLReader!is_pwd
                    disability = mySQLReader!disability
                    voter = mySQLReader!is_voter
                    occupation = mySQLReader!occupation
                    householdRole = mySQLReader!household_role
                    dateRegistered = dateFormatter(mySQLReader!month_registered, mySQLReader!day_registered, mySQLReader!year_registered)

                    registeredBy = mySQLReader!registered_by
                    householdId = mySQLReader!household_id

                    If viewChoice = "Archived" Then
                        Dim dateArchived As Date = mySQLReader!date_archived
                        labelDateArchived.Text = If(viewChoice = "Archived", dateArchived.ToString("MMMM dd, yyyy"), "")
                        labelReasonArchived.Text = mySQLReader!reason_archived
                        labelArchivedBy.Text = mySQLReader!archived_by
                    End If
                End While
            End If

            labelFirst.Text = firstName
            labelMiddle.Text = If(middleName = "", "N/A", middleName)
            labelLast.Text = lastName
            labelExtension.Text = If(extName = "", "N/A", extName)
            labelAge.Text = age
            labelSeniorCitizen.Text = If(age >= 60, "Yes", "No")
            labelBirthPlace.Text = birthPlace
            labelCivilStatus.Text = civilStatus
            labelSex.Text = sex
            labelReligion.Text = religion
            labelContactNo.Text = contactNo
            labelPwd.Text = If(pwd.ToLower = "yes", pwd + " [" + disability + "]", pwd)
            labelVoter.Text = voter
            labelOccupation.Text = occupation
            labelHouseholdRole.Text = householdRole
            labelDateRegistered.Text = dateRegistered
            labelRegisteredBy.Text = registeredBy
            labelBirthdate.Text = birthDate.ToString("MMMM dd, yyyy")

            retrieveAddress(householdId)

                cmd.Dispose()
                mySql.Close()
                mySql.Dispose()
            End If

            Dim civilStatusArray() As String = {"Single", "Married", "Divorced", "Separated", "Widowed"}
        Dim sexArray() As String = {"Male", "Female"}
        Dim yesNo() As String = {"Yes", "No"}
        Dim householdRoleArray() As String = {"Head", "Member"}

        For i = 0 To civilStatusArray.Length - 1
            comboCivilStatus.Items.Add(civilStatusArray(i))
        Next i

        For i = 0 To sexArray.Length - 1
            comboSex.Items.Add(sexArray(i))
        Next i

        For i = 0 To yesNo.Length - 1
            comboVoter.Items.Add(yesNo(i))
            comboPwd.Items.Add(yesNo(i))
        Next i

        For i = 0 To householdRoleArray.Length - 1
            comboHouseholdRole.Items.Add(householdRoleArray(i))
        Next i

        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact(civilStatusArray(0))
        comboSex.SelectedIndex = comboSex.FindStringExact(sexArray(0))
        comboVoter.SelectedIndex = comboVoter.FindStringExact(yesNo(1))
        comboPwd.SelectedIndex = comboPwd.FindStringExact(yesNo(1))

        pickerBirthDate.Format = DateTimePickerFormat.Custom
        pickerBirthDate.CustomFormat = "MMMM dd, yyyy"
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact(householdRoleArray(1))

        setComboHouseholdID()

    End Sub

    Private Sub ViewResident_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If txtFirstName.Text.Trim <> "" Or txtLastName.Text.Trim <> "" Or txtBirthPlace.Text.Trim <> "" Or txtContactNo.Text.Trim <> "" Or txtDisability.Text.Trim <> "" Or comboHouseholdId.Text.Trim <> "" Then
            If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub comboPwd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPwd.SelectedIndexChanged
        If comboPwd.SelectedIndex = 0 Then
            txtDisability.Enabled = True
        Else
            txtDisability.Enabled = False
            txtDisability.Clear()
        End If
    End Sub
    Private Sub setComboHouseholdID()
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

        cmd.CommandText = "SELECT household_id from household"
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                comboHouseholdId.Items.Add(mySQLReader!household_id)
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub pickerBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles pickerBirthDate.ValueChanged
        Dim date1, date2 As Date
        date1 = pickerBirthDate.Value.ToShortDateString
        date2 = Date.Now.ToShortDateString
        Dim timeSpan As TimeSpan = date2 - date1
        Dim diff As Integer = If(Int(timeSpan.Days / 365) = -1, 0, Int(timeSpan.Days / 365))

        txtAge.Text = Str(diff)
    End Sub
    Private Sub ViewResident_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        labelFirst.Text = ""
        labelMiddle.Text = ""
        labelLast.Text = ""
        labelExtension.Text = ""
        labelAge.Text = ""
        labelBirthPlace.Text = ""
        labelCivilStatus.Text = ""
        labelSex.Text = ""
        labelReligion.Text = ""
        labelContactNo.Text = ""
        labelPwd.Text = ""
        labelVoter.Text = ""
        labelOccupation.Text = ""
        labelHouseholdRole.Text = ""
        labelDateRegistered.Text = ""
        labelRegisteredBy.Text = ""
        labelBirthdate.Text = ""
        labelAddress.Text = ""
        birthDate = Nothing

        comboCivilStatus.Items.Clear()
        comboSex.Items.Clear()
        comboVoter.Items.Clear()
        comboPwd.Items.Clear()
        comboHouseholdRole.Items.Clear()
        comboHouseholdId.Items.Clear()
        comboHouseholdId.Text = ""

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtName.Clear()
        txtAge.Clear()
        txtBirthPlace.Clear()
        txtContactNo.Clear()
        txtCitizenship.Clear()
        txtDisability.Clear()
        txtOccupation.Clear()
        txtReligion.Clear()

        pickerBirthDate.Value = Date.Now

        firstName = ""
        middleName = ""
        lastName = ""
        extName = ""
        age = 0
        birthPlace = ""
        civilStatus = ""
        sex = ""
        religion = ""
        contactNo = ""
        pwd = ""
        disability = ""
        voter = ""
        occupation = ""
        householdRole = ""
        registeredBy = ""
        dateRegistered = ""
    End Sub
    Private Sub retrieveAddress(ByVal householdID As Integer)
        Dim MySql As MySqlConnection
        MySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        MySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = MySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT CONCAT(bldg_no, ', ', street_name) as address FROM household WHERE household_id = @householdID"
        cmd.Parameters.AddWithValue("@householdID", householdID)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                labelAddress.Text = mySQLReader!address
            End While
        End If

        cmd.Dispose()
        MySql.Close()
        MySql.Dispose()
    End Sub
    Private Function dateFormatter(ByVal month As String, ByVal day As String, ByVal year As String) As String
        Return month + " " + day + ", " + year
    End Function
    Private Sub btnModifyResident_Click(sender As Object, e As EventArgs) Handles btnModifyResident.Click
        mainTabControl.SelectedTab = pageAddModify
        action = "modify"

        txtFirstName.Text = firstName
        txtMiddleName.Text = middleName
        txtLastName.Text = lastName
        txtExtName.Text = extName
        txtAge.Text = age
        txtBirthPlace.Text = birthPlace
        txtContactNo.Text = contactNo
        txtCitizenship.Text = citizenship
        txtDisability.Text = disability
        txtOccupation.Text = occupation
        txtReligion.Text = religion

        pickerBirthDate.Value = birthDate

        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact(civilStatus)
        comboSex.SelectedIndex = comboSex.FindStringExact(sex)
        comboVoter.SelectedIndex = comboVoter.FindStringExact(voter)
        comboPwd.SelectedIndex = comboPwd.FindStringExact(pwd)
        If comboPwd.SelectedIndex = 0 Then
            txtDisability.Enabled = True
            txtDisability.Text = disability
        End If
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact(householdRole)
        comboHouseholdId.SelectedIndex = comboHouseholdId.FindStringExact(householdId)

    End Sub

    Private Sub btnSaveResident_Click(sender As Object, e As EventArgs) Handles btnSaveResident.Click
        If comboHouseholdId.Text.Trim = "" Or comboHouseholdId.FindStringExact(comboHouseholdId.Text) = -1 Then
            MsgBox("Please Fill out a valid Household Id", vbCritical, "Warning")

        Else
            If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtBirthPlace.Text.Trim = "" Or txtContactNo.Text.Trim = "" Or (comboPwd.SelectedItem = "Yes" AndAlso txtDisability.Text.Trim = "") Then
                MsgBox("Please Fill out all the required fields!", vbCritical, "Warning")

            Else

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

                If action = "modify" Then
                    cmd.CommandText = "UPDATE residents SET household_id = @householdid" & If(txtFirstName.Text = firstName, "", ", first_name = @firsname") & If(txtMiddleName.Text = middleName, "", ", middle_name = @middlename") & If(txtLastName.Text = lastName, "", ", last_name = @lastname") & If(txtExtName.Text = extName, "", ", ext_name = @extname") & If(birthDate.ToString("MMMM dd, yyyy") = pickerBirthDate.Value.ToString("MMMM dd, yyyy"), "", ", birthdate = @birthdate") & If(txtAge.Text = age, "", ", age = @age") & If(txtBirthPlace.Text = birthPlace, "", ", birthplace = @birthplace") & If(comboCivilStatus.Text = civilStatus, "", ", civil_status = civilstatus") & If(txtCitizenship.Text = citizenship, "", ", citizenship = @citizenship") & If(comboSex.Text = sex, "", ", sex = @sex") & If(txtReligion.Text = religion, "", ", religion = @religion") & If(txtContactNo.Text = contactNo, "", ", contact_no = @contactno") & If(comboPwd.Text = pwd, "", ", is_pwd = @pwd") & If(txtDisability.Text = disability, "", ", disability = @disability") & If(comboVoter.Text = voter, "", ", is_voter = @voter") & If(txtOccupation.Text = occupation, "", ", occupation = @occupation") & If(comboHouseholdRole.Text = householdRole, "", ", household_role = @householdrole") & " WHERE resident_id = @residentid"

                    cmd.Parameters.Add("@householdid", MySqlDbType.Int64).Value = comboHouseholdId
                    cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = txtFirstName.Text
                    cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = txtMiddleName.Text
                    cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = txtLastName.Text
                    cmd.Parameters.Add("@extname", MySqlDbType.VarChar).Value = txtExtName.Text
                    cmd.Parameters.Add("@birthdate", MySqlDbType.Date).Value = pickerBirthDate.Value
                    cmd.Parameters.Add("@age", MySqlDbType.Int64).Value = txtAge.Text
                    cmd.Parameters.Add("@birthplace", MySqlDbType.VarChar).Value = txtBirthPlace.Text
                    cmd.Parameters.Add("@civilstatus", MySqlDbType.VarChar).Value = comboCivilStatus.Text
                    cmd.Parameters.Add("@citizenship", MySqlDbType.VarChar).Value = txtCitizenship.Text
                    cmd.Parameters.Add("@sex", MySqlDbType.VarChar).Value = comboSex.Text
                    cmd.Parameters.Add("@religion", MySqlDbType.VarChar).Value = txtReligion.Text
                    cmd.Parameters.Add("@contactno", MySqlDbType.VarChar).Value = txtContactNo.Text
                    cmd.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = comboPwd.Text
                    cmd.Parameters.Add("@disability", MySqlDbType.VarChar).Value = txtDisability.Text
                    cmd.Parameters.Add("@voter", MySqlDbType.VarChar).Value = comboVoter.Text
                    cmd.Parameters.Add("@religion", MySqlDbType.VarChar).Value = txtReligion.Text
                    cmd.Parameters.Add("@occupation", MySqlDbType.VarChar).Value = txtOccupation.Text
                    cmd.Parameters.Add("@householdrole", MySqlDbType.VarChar).Value = comboHouseholdRole.Text
                    cmd.Parameters.Add("@residentid", MySqlDbType.VarChar).Value = resident_id
                    MsgBox(cmd.CommandText)
                ElseIf action = "add" Then

                End If

                cmd.ExecuteNonQuery()

                cmd.Dispose()
                mySql.Close()
                mySql.Dispose()

                MsgBox("Resident Saved!", vbInformation, "Information")
            End If
        End If

    End Sub

End Class