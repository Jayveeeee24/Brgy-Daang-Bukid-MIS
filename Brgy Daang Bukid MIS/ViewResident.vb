Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Messaging
Imports Microsoft.Office.Interop.Word
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class ViewResident

    Public mySqlConn As String = My.Resources.constring
    Public resident_id As Integer
    Public viewChoice As String
    Public action As String
    Public grantAccess As Boolean
    Public reasonForArchive As String

    Dim isSaved As Boolean = False
    Dim firstName, middleName, lastName, extName As String
    Dim birthDate As Date
    Dim age, householdId, dayRegistered, yearRegistered As Integer
    Dim birthPlace, civilStatus, sex, religion,
        contactNo, pwd, disability, voter, occupation, citizenship,
        householdRole, registeredBy, dateRegistered, reasonArchived, archivedBy, monthRegistered As String

    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)

        getSystemVariable(comboBirthPlace, "Birthplace")
        getSystemVariable(comboCitizenship, "Citizenship")
        getSystemVariable(comboCivilStatus, "Civil Status")
        getSystemVariable(comboReligion, "Religion")

        checkPriveledges()
        loadInitialData()
    End Sub

    Private Sub checkPriveledges()
        Dim userlevel As String = Main_Form.user_level

        btnModifyResident.Show()
        btnArchiveResident.Show()
        If userlevel = "Staff" Then
            btnArchiveResident.Hide()
        ElseIf viewChoice = "Archived" Then
            btnModifyResident.Hide()
            btnArchiveResident.Hide()
        End If

    End Sub
    Private Sub ViewResident_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If comboHouseholdId.Text.Trim <> "" Or txtFirstName.Text.Trim <> "" Or txtLastName.Text.Trim <> "" Or comboBirthPlace.Text.Trim <> "" Or txtContactNo.Text.Trim <> "" Or txtDisability.Text.Trim <> "" Or comboBirthPlace.Text.Trim <> "" Or txtOccupation.Text.Trim <> "" Or comboReligion.Text.Trim <> "" Then
                If mainTabControl.SelectedIndex = 1 Then
                    If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ViewResident_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    '' '''''''''''SYSTEM CALLS''''''''''''''''''''''
    Private Sub comboHouseholdId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHouseholdId.SelectedIndexChanged
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid AND household_role = 'HEAD'"
        cmd.Parameters.AddWithValue("@householdid", comboHouseholdId.Text)
        Dim count As Integer = Int(Convert.ToString(cmd.ExecuteScalar()))

        If count > 0 Then
            comboHouseholdRole.SelectedIndex = 1
            comboHouseholdRole.Enabled = False
        Else
            comboHouseholdRole.Enabled = True
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub btnSearchHouseholdId_Click(sender As Object, e As EventArgs) Handles btnSearchHouseholdId.Click
        SearchHousehold.ShowDialog()
    End Sub
    Private Sub txtView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherCitizenship.KeyPress, txtOccupation.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub comboPwd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPwd.SelectedIndexChanged
        txtDisability.Clear()
        If comboPwd.SelectedIndex = 0 Then
            txtDisability.Enabled = True
        Else
            txtDisability.Enabled = False
        End If
    End Sub
    Private Sub comboCitizenship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCitizenship.SelectedIndexChanged
        txtOtherCitizenship.Clear()
        If comboCitizenship.Text = "Dual Citizenship" Then
            txtOtherCitizenship.Enabled = True
        Else
            txtOtherCitizenship.Enabled = False
        End If
    End Sub
    Private Sub pickerBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles pickerBirthDate.ValueChanged
        Dim date1, date2 As Date
        date1 = pickerBirthDate.Value.ToShortDateString
        date2 = Date.Now.ToShortDateString
        Dim timeSpan As TimeSpan = date2 - date1
        Dim diff As Integer = If(Int(timeSpan.Days / 365) = -1, 0, Int(timeSpan.Days / 365))

        txtAge.Text = Str(diff)
    End Sub
    Private Sub btnModifyResident_Click(sender As Object, e As EventArgs) Handles btnModifyResident.Click
        mainTabControl.SelectedTab = pageAddModify
        action = "modify"

        txtFirstName.Text = firstName
        txtMiddleName.Text = middleName
        txtLastName.Text = lastName
        txtExtName.Text = extName
        txtAge.Text = age
        If comboBirthPlace.FindStringExact(birthPlace) >= 0 Then
            comboBirthPlace.SelectedIndex = comboBirthPlace.FindStringExact(birthPlace)
        Else
            comboBirthPlace.Text = birthPlace
        End If

        txtContactNo.Text = contactNo

        comboCitizenship.SelectedIndex = If(comboCitizenship.FindStringExact(citizenship) = -1, 2, comboCitizenship.FindStringExact(citizenship))
        If comboCitizenship.SelectedIndex >= 2 Then
            txtOtherCitizenship.Enabled = True
            txtOtherCitizenship.Text = citizenship
        End If

        txtDisability.Text = disability
        txtOccupation.Text = occupation
        comboReligion.SelectedIndex = comboReligion.FindStringExact(religion)

        pickerBirthDate.Value = birthDate

        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact(civilStatus)
        comboSex.SelectedIndex = comboSex.FindStringExact(sex)
        comboVoter.SelectedIndex = comboVoter.FindStringExact(voter)
        comboPwd.SelectedIndex = comboPwd.FindStringExact(pwd)
        If comboPwd.SelectedIndex = 0 Then
            txtDisability.Visible = True
            labelDisability.Visible = True
            txtDisability.Enabled = True
            txtDisability.Text = disability
        End If
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact(householdRole)
        comboHouseholdId.SelectedIndex = comboHouseholdId.FindStringExact(householdId)

    End Sub
    Private Sub btnSaveResident_Click(sender As Object, e As EventArgs) Handles btnSaveResident.Click
        If comboHouseholdId.Text.Trim = "" Or comboHouseholdId.FindStringExact(comboHouseholdId.Text) = -1 Then
            MsgBox("Please Fill out a valid Household Id", vbCritical, "Warning")
            Exit Sub
        End If
        If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Then
            MsgBox("Please enter a valid name!", vbCritical, "Warning")
            Exit Sub
        End If
        If pickerBirthDate.Value > Date.Now Or pickerBirthDate.Value < New Date(1900, 1, 1) Then
            MsgBox("Please enter a valid date of birth!", vbCritical, "Warning")
            Exit Sub
        End If
        If CInt(txtAge.Text) < 20 And comboHouseholdRole.Text = "Head" Then
            MsgBox("Please input valid age as a household head!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboBirthPlace.Text.Trim = "" Then
            MsgBox("Please enter a birthplace!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtContactNo.Text.Trim = "" Then
            MsgBox("Please enter a valid contact number!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboCitizenship.SelectedIndex >= 2 And txtOtherCitizenship.Text.Trim = "" Then
            MsgBox("Please enter a valid citizenship!", vbCritical, "Warning")
            Exit Sub
        End If
        If (comboPwd.SelectedItem = "Yes" AndAlso txtDisability.Text.Trim = "") Then
            MsgBox("Please enter a valid disability!", vbCritical, "Warning")
            Exit Sub
        End If


        If action = "add" Then
            If (isResidentDuplicate() = True) Then
                MsgBox("RESIDENT INFORMATION FOR [" & txtFirstName.Text & If(txtMiddleName.Text = "", "", " " & txtMiddleName.Text) & " " & txtLastName.Text & If(txtExtName.Text = "", "", " " & txtExtName.Text) & "] WITH BIRTHDATE [" & pickerBirthDate.Value.Date.ToString("MMMM d, yyyy") & "] ALREADY EXISTS]", vbCritical, "WARNING: DUPLICATE DATA")
                Exit Sub
            Else
                If MsgBox("Wish to add resident information for [" & txtFirstName.Text & If(txtMiddleName.Text = "", "", " " & txtMiddleName.Text) & " " & txtLastName.Text & If(txtExtName.Text = "", "", " " & txtExtName.Text) & "]?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        Else
            If (isResidentDuplicate(resident_id) = True) Then
                MsgBox("RESIDENT INFORMATION FOR [" & txtFirstName.Text & If(txtMiddleName.Text = "", "", " " & txtMiddleName.Text) & " " & txtLastName.Text & If(txtExtName.Text = "", "", " " & txtExtName.Text) & "] WITH BIRTHDATE [" & pickerBirthDate.Value.Date.ToString("MMMM d, yyyy") & "] ALREADY EXISTS]", vbCritical, "WARNING: DUPLICATE DATA")
                Exit Sub
            End If
        End If

        saveResident()
        MsgBox("Resident Saved!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.btnResidentInfo.PerformClick()
    End Sub
    Private Sub txtViewKeydown(sender As Object, e As KeyEventArgs) Handles txtOccupation.KeyDown, txtMiddleName.KeyDown, txtLastName.KeyDown, txtFirstName.KeyDown, txtExtName.KeyDown, txtOtherCitizenship.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnArchiveResident_Click(sender As Object, e As EventArgs) Handles btnArchiveResident.Click
        ConfirmAccess.txtPassword.Clear()
        ConfirmAccess.originForm = "Archive"
        ConfirmAccess.Show()
    End Sub



    '' '''''''''''''FUNCTION HELPERS'''''''''''''''''''''''''''
    Private Sub loadInitialData()
        comboHouseholdId.Select()
        mainTabControl.SelectedIndex = 0

        If action = "add" Then
            mainTabControl.SelectedIndex = 1
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

                labelArchive1.Show()
                labelArchive2.Show()
                labelArchive3.Show()
                labelDateArchived.Show()
                labelReasonArchived.Show()
                labelArchivedBy.Show()
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
                    dayRegistered = mySQLReader!day_registered
                    monthRegistered = mySQLReader!month_registered
                    yearRegistered = mySQLReader!year_registered
                    dateRegistered = dateFormatter(monthRegistered, dayRegistered, yearRegistered)

                    registeredBy = mySQLReader!registered_by
                    householdId = mySQLReader!household_id

                    If viewChoice = "Archived" Then
                        Dim dateArchived As Date = mySQLReader!date_archived
                        labelDateArchived.Text = If(viewChoice = "Archived", dateArchived.ToString("MMMM d, yyyy"), "")
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
            labelDateRegistered.Text = If(dateRegistered = " 0, 0", "", dateRegistered)
            labelRegisteredBy.Text = registeredBy
            labelBirthdate.Text = If(birthDate.ToString("MMMM d, yyyy") = "January 1, 0001", "", birthDate.ToString("MMMM d, yyyy"))

            retrieveAddress(householdId)

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If

        comboCitizenship.SelectedIndex = 0
        comboReligion.SelectedIndex = 0
        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact("Single")
        comboSex.SelectedIndex = comboSex.FindStringExact("Male")
        comboVoter.SelectedIndex = comboVoter.FindStringExact("No")
        comboPwd.SelectedIndex = comboPwd.FindStringExact("No")

        pickerBirthDate.Format = DateTimePickerFormat.Custom
        pickerBirthDate.CustomFormat = "MMMM d, yyyy"
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact("Member")

        setComboHouseholdID()

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
    Private Sub saveResident()
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
            cmd.CommandText = "UPDATE residents SET household_id = @householdid" & If(txtFirstName.Text = firstName, "", ", first_name = @firstname") & If(txtMiddleName.Text = middleName, "", ", middle_name = @middlename") & If(txtLastName.Text = lastName, "", ", last_name = @lastname") & If(txtExtName.Text = extName, "", ", ext_name = @extname") & If(birthDate.ToString("MMMM dd, yyyy") = pickerBirthDate.Value.ToString("MMMM dd, yyyy"), "", ", birthdate = @birthdate") & If(txtAge.Text = age, "", ", age = @age") & If(comboBirthPlace.Text.Trim = birthPlace, "", ", birthplace = @birthplace") & If(comboCivilStatus.Text = civilStatus, "", ", civil_status = @civilstatus ") & If(comboCitizenship.Text = citizenship Or txtOtherCitizenship.Text = citizenship, "", ", citizenship = @citizenship") & If(comboSex.Text = sex, "", ", sex = @sex") & If(comboReligion.Text = religion, "", ", religion = @religion") & If(txtContactNo.Text = contactNo, "", ", contact_no = @contactno ") & If(comboPwd.Text = pwd, "", ", is_pwd = @pwd") & If(txtDisability.Text = disability, "", ", disability = @disability") & If(comboVoter.Text = voter, "", ", is_voter = @voter") & If(txtOccupation.Text = occupation, "", ", occupation = @occupation") & If(comboHouseholdRole.Text = householdRole, "", ", household_role = @householdrole") & " WHERE resident_id = @residentid"

            cmd.Parameters.AddWithValue("@householdid", comboHouseholdId.Text)
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@extname", txtExtName.Text)
            cmd.Parameters.AddWithValue("@birthdate", pickerBirthDate.Value)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@birthplace", comboBirthPlace.Text)
            cmd.Parameters.AddWithValue("@civilstatus", comboCivilStatus.Text)
            cmd.Parameters.AddWithValue("@citizenship", If(comboCitizenship.SelectedIndex = 2, txtOtherCitizenship.Text, comboCitizenship.Text))
            cmd.Parameters.AddWithValue("@sex", comboSex.Text)
            cmd.Parameters.AddWithValue("@religion", comboReligion.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@pwd", comboPwd.Text)
            cmd.Parameters.AddWithValue("@disability", txtDisability.Text)
            cmd.Parameters.AddWithValue("@voter", comboVoter.Text)
            cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text)
            cmd.Parameters.AddWithValue("@householdrole", comboHouseholdRole.Text)
            cmd.Parameters.AddWithValue("@residentid", resident_id)

            cmd.ExecuteNonQuery()

        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO residents (household_id, first_name, middle_name, last_name, ext_name, birthdate, age, birthplace, civil_status, citizenship, sex, religion, contact_no, is_pwd, disability, is_voter, occupation, household_role, month_registered, day_registered, year_registered, registered_by) VALUES (@householdid, @firstname, @middlename, @lastname, @extname, @birthdate, @age, @birthplace, @civilstatus, @citizenship, @sex, @religion, @contactno, @pwd, @disability, @voter, @occupation, @householdrole, @month, @day, @year, @registered_by)"

            cmd.Parameters.AddWithValue("@householdid", comboHouseholdId.Text)
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@extname", txtExtName.Text)
            cmd.Parameters.AddWithValue("@birthdate", pickerBirthDate.Value)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@birthplace", comboBirthPlace.Text)
            cmd.Parameters.AddWithValue("@civilstatus", comboCivilStatus.Text)
            cmd.Parameters.AddWithValue("@citizenship", If(comboCitizenship.SelectedIndex = 2, txtOtherCitizenship.Text, comboCitizenship.Text))
            cmd.Parameters.AddWithValue("@sex", comboSex.Text)
            cmd.Parameters.AddWithValue("@religion", comboReligion.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@pwd", comboPwd.Text)
            cmd.Parameters.AddWithValue("@disability", txtDisability.Text)
            cmd.Parameters.AddWithValue("@voter", comboVoter.Text)
            cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text)
            cmd.Parameters.AddWithValue("@householdrole", comboHouseholdRole.Text)

            Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
            Dim dateToday As Date = Date.Now
            Dim monthNo As Integer = Int(dateToday.Month.ToString) - 1
            Dim monthNow As String = months(monthNo)
            Dim dayNow As String = dateToday.Day.ToString
            Dim yearNow As String = dateToday.Year.ToString

            cmd.Parameters.AddWithValue("@month", monthNow)
            cmd.Parameters.AddWithValue("@day", dayNow)
            cmd.Parameters.AddWithValue("@year", yearNow)
            cmd.Parameters.AddWithValue("@registered_by", Main_Form.account_credentials)

            cmd.ExecuteNonQuery()
        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Public Sub checkIfHead()
        If isResidentHead() = True Then
            If isThereOtherMembers() = True Then
                HeadChange.householdId = householdId
                HeadChange.ShowDialog()
                Exit Sub
            Else
                If MsgBox("ARE YOU SURE TO ARCHIVE THIS RESIDENT? " & vbCrLf & "THERE ARE NO OTHER LEGAL AGED MEMBER TO PASS THE HOUSEHOLD HEAD! PROCEED?", MsgBoxStyle.YesNo, "PROCEED WITH CAUTION!") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If
        archiveResident()
    End Sub
    Private Function isThereOtherMembers() As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE household_id = @householdid and household_role = 'Member' and age > 20"
        cmd.Parameters.AddWithValue("@householdid", householdId)

        If cmd.ExecuteScalar = 0 Then
            Return False
        Else
            Return True
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function
    Private Function isResidentHead() As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE resident_id = @residentid and household_role = 'Head'"
        cmd.Parameters.AddWithValue("@residentid", resident_id)

        If cmd.ExecuteScalar = 0 Then
            Return False
        Else
            Return True
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Function

    Public Sub archiveResident()

        ConfirmAccess.originForm = ""

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

        '' '''''''''adding into archived residents
        cmd.CommandText = "INSERT INTO archived_residents (resident_id, household_id, first_name, middle_name, last_name, ext_name, birthdate, age, birthplace, civil_status, citizenship, sex, religion, contact_no, is_pwd, disability, is_voter, occupation, household_role, month_registered, day_registered, year_registered, registered_by, date_archived, archived_by, reason_archived) VALUES (@residentid, @householdid, @firstname, @middlename, @lastname, @extname, @birthdate, @age, @birthplace, @civilstatus, @citizenship, @sex, @religion, @contactno, @pwd, @disability, @voter, @occupation, @householdrole, @month, @day, @year, @registered_by, @datearchived, @archivedby, @reasonarchived)"

        cmd.Parameters.AddWithValue("@residentid", resident_id)
        cmd.Parameters.AddWithValue("@householdid", householdId)
        cmd.Parameters.AddWithValue("@firstname", firstName)
        cmd.Parameters.AddWithValue("@middlename", middleName)
        cmd.Parameters.AddWithValue("@lastname", lastName)
        cmd.Parameters.AddWithValue("@extname", extName)
        cmd.Parameters.AddWithValue("@birthdate", birthDate)
        cmd.Parameters.AddWithValue("@age", age)
        cmd.Parameters.AddWithValue("@birthplace", birthPlace)
        cmd.Parameters.AddWithValue("@civilstatus", civilStatus)
        cmd.Parameters.AddWithValue("@citizenship", citizenship)
        cmd.Parameters.AddWithValue("@sex", sex)
        cmd.Parameters.AddWithValue("@religion", religion)
        cmd.Parameters.AddWithValue("@contactno", contactNo)
        cmd.Parameters.AddWithValue("@pwd", pwd)
        cmd.Parameters.AddWithValue("@disability", disability)
        cmd.Parameters.AddWithValue("@voter", voter)
        cmd.Parameters.AddWithValue("@occupation", occupation)
        cmd.Parameters.AddWithValue("@householdrole", householdRole)

        cmd.Parameters.AddWithValue("@month", monthRegistered)
        cmd.Parameters.AddWithValue("@day", dayRegistered)
        cmd.Parameters.AddWithValue("@year", yearRegistered)
        cmd.Parameters.AddWithValue("@registered_by", registeredBy)
        cmd.Parameters.AddWithValue("@datearchived", Date.Now)
        cmd.Parameters.AddWithValue("@archivedby", Main_Form.account_credentials)

        cmd.Parameters.AddWithValue("@reasonarchived", reasonForArchive)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "DELETE FROM residents WHERE resident_id = @residentid "
        cmd.Parameters.AddWithValue("@residentid", resident_id)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "DELETE FROM brgyofficials WHERE official_name = @residentid "
        cmd.Parameters.AddWithValue("@residentid", resident_id)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Resident Archived Successfully!", vbInformation, "Information")
        Me.Close()
        Main_Form.btnResidentInfo.PerformClick()

    End Sub
    Private Function isResidentDuplicate() As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE first_name = @firstname and middle_name = @middlename and last_name = @lastname and ext_name = @extname and birthdate = @birthdate"
        cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
        cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
        cmd.Parameters.AddWithValue("@extname", txtExtName.Text)
        cmd.Parameters.AddWithValue("@birthdate", pickerBirthDate.Value.Date)

        If cmd.ExecuteScalar = 0 Then
            Return False
        Else
            Return True
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Function
    Private Function isResidentDuplicate(ByVal id As Integer) As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE resident_id <> @residentid and first_name = @firstname and middle_name = @middlename and last_name = @lastname and ext_name = @extname and birthdate = @birthdate"
        cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@residentid", resident_id)
        cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
        cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
        cmd.Parameters.AddWithValue("@extname", txtExtName.Text)
        cmd.Parameters.AddWithValue("@birthdate", pickerBirthDate.Value.Date)

        If cmd.ExecuteScalar = 0 Then
            Return False
        Else
            Return True
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Function



End Class