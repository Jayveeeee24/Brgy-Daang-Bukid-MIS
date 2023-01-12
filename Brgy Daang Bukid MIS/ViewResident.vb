Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class ViewResident

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public resident_id As Integer
    Public viewChoice As String
    Public action As String
    Public grantAccess As Boolean

    Dim firstName, middleName, lastName, extName As String
    Dim birthDate As Date
    Dim age, householdId, dayRegistered, yearRegistered As Integer
    Dim birthPlace, civilStatus, sex, religion,
        contactNo, pwd, disability, voter, occupation, citizenship,
        householdRole, registeredBy, dateRegistered, reasonArchived, archivedBy, monthRegistered As String

    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

        checkPriveledges()
        loadInitialData()
    End Sub

    Private Sub checkPriveledges()
        Dim id = Main_Form.account_id

        btnModifyResident.Show()
        btnArchiveResident.Show()
        If id = 2 Then
            btnArchiveResident.Hide()
        ElseIf id = 3 Then
            btnModifyResident.Hide()
            btnArchiveResident.Hide()
        ElseIf viewChoice = "Archived" Then
            btnModifyResident.Hide()
            btnArchiveResident.Hide()
        End If

    End Sub


    Private Sub ViewResident_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If txtFirstName.Text.Trim <> "" Or txtLastName.Text.Trim <> "" Or comboBirthPlace.Text.Trim <> "" Or txtContactNo.Text.Trim <> "" Or txtDisability.Text.Trim <> "" Then
            If mainTabControl.SelectedIndex = 1 Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub ViewResident_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
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
    Private Sub comboPwd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPwd.SelectedIndexChanged
        If comboPwd.SelectedIndex = 0 Then
            txtDisability.Visible = True
            labelDisability.Visible = True
            txtDisability.Enabled = True
        Else
            txtDisability.Visible = False
            labelDisability.Visible = False
            txtDisability.Enabled = False
            txtDisability.Clear()
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
    Private Sub panelParent_Paint(sender As Object, e As PaintEventArgs) Handles panelParent.Paint
        setComboBoxColor(comboCivilStatus)
        setComboBoxColor(comboSex)
        setComboBoxColor(comboVoter)
        setComboBoxColor(comboPwd)
        setComboBoxColor(comboHouseholdRole)
        setComboBoxColor(comboHouseholdId)

        setTextBoxColor(txtFirstName)
        setTextBoxColor(txtMiddleName)
        setTextBoxColor(txtLastName)
        setTextBoxColor(txtExtName)
        setTextBoxColor(txtAge)
        setTextBoxColor(txtContactNo)
        setTextBoxColor(txtCitizenship)
        setTextBoxColor(txtDisability)
        setTextBoxColor(txtOccupation)
        setTextBoxColor(txtReligion)
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
            checkComboHouseholdId()
        Else
            If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or comboBirthPlace.Text.Trim = "" Or txtContactNo.Text.Trim = "" Or (comboPwd.SelectedItem = "Yes" AndAlso txtDisability.Text.Trim = "") Or pickerBirthDate.Value > Date.Now Then
                MsgBox("Please Fill out all the required fields!", vbCritical, "Warning")
                checkTextBox(txtFirstName)
                checkTextBox(txtLastName)
                checkTextBox(txtContactNo)
                checkTextBox(txtCitizenship)
                checkTextBox(txtDisability)
            ElseIf CInt(txtAge.Text) < 20 And comboHouseholdRole.Text = "Head" Then
                MsgBox("Please input valid age as a household head!", vbCritical, "Warning")
            Else
                saveResident()
                MsgBox("Resident Saved!", vbInformation, "Information")
                If action = "add" Then
                    clearEverything()
                    setComboHouseholdID()
                    If MsgBox("Add another resident?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
                        Me.Close()
                        Main_Form.btnResidentInfo.PerformClick()
                    End If
                Else
                    clearEverything()
                    Me.Close()
                    Main_Form.btnResidentInfo.PerformClick()
                End If
            End If
        End If
    End Sub
    Private Sub txtViewKeydown(sender As Object, e As KeyEventArgs) Handles txtReligion.KeyDown, txtOccupation.KeyDown, txtMiddleName.KeyDown, txtLastName.KeyDown, txtFirstName.KeyDown, txtExtName.KeyDown, txtDisability.KeyDown, txtContactNo.KeyDown, txtCitizenship.KeyDown
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

        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact("Single")
        comboSex.SelectedIndex = comboSex.FindStringExact("Male")
        comboVoter.SelectedIndex = comboVoter.FindStringExact("No")
        comboPwd.SelectedIndex = comboPwd.FindStringExact("No")

        pickerBirthDate.Format = DateTimePickerFormat.Custom
        pickerBirthDate.CustomFormat = "MMMM d, yyyy"
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact("Member")

        setComboHouseholdID()

    End Sub
    Private Sub clearEverything()
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
        comboHouseholdRole.Enabled = True

        comboHouseholdId.Items.Clear()
        comboHouseholdId.Text = ""

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtName.Clear()
        txtAge.Clear()
        comboBirthPlace.SelectedIndex = -1
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
        resident_id = 0

        action = ""

        panelParent.VerticalScroll.Value = 0
        Panel12.VerticalScroll.Value = 0
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
            cmd.CommandText = "UPDATE residents SET household_id = @householdid" & If(txtFirstName.Text = firstName, "", ", first_name = @firstname") & If(txtMiddleName.Text = middleName, "", ", middle_name = @middlename") & If(txtLastName.Text = lastName, "", ", last_name = @lastname") & If(txtExtName.Text = extName, "", ", ext_name = @extname") & If(birthDate.ToString("MMMM dd, yyyy") = pickerBirthDate.Value.ToString("MMMM dd, yyyy"), "", ", birthdate = @birthdate") & If(txtAge.Text = age, "", ", age = @age") & If(comboBirthPlace.Text.Trim = birthPlace, "", ", birthplace = @birthplace") & If(comboCivilStatus.Text = civilStatus, "", ", civil_status = @civilstatus ") & If(txtCitizenship.Text = citizenship, "", ", citizenship = @citizenship") & If(comboSex.Text = sex, "", ", sex = @sex") & If(txtReligion.Text = religion, "", ", religion = @religion") & If(txtContactNo.Text = contactNo, "", ", contact_no = @contactno ") & If(comboPwd.Text = pwd, "", ", is_pwd = @pwd") & If(txtDisability.Text = disability, "", ", disability = @disability") & If(comboVoter.Text = voter, "", ", is_voter = @voter") & If(txtOccupation.Text = occupation, "", ", occupation = @occupation") & If(comboHouseholdRole.Text = householdRole, "", ", household_role = @householdrole") & " WHERE resident_id = @residentid"

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
            cmd.Parameters.AddWithValue("@citizenship", txtCitizenship.Text)
            cmd.Parameters.AddWithValue("@sex", comboSex.Text)
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text)
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
            cmd.Parameters.AddWithValue("@citizenship", txtCitizenship.Text)
            cmd.Parameters.AddWithValue("@sex", comboSex.Text)
            cmd.Parameters.AddWithValue("@religion", txtReligion.Text)
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
        cmd.Parameters.AddWithValue("@reasonarchived", ConfirmAccess.reasonForArchived)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "DELETE FROM residents WHERE resident_id = @residentid "
        cmd.Parameters.AddWithValue("@residentid", resident_id)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Resident Archived Successfully!", vbInformation, "Information")
        clearEverything()
        Me.Close()
        Main_Form.btnResidentInfo.PerformClick()

    End Sub

    '' '''''''''''''TEXTBOX AND COMBO BOX CHECKER '''''''''''''''''''''''''
    Private Sub checkTextBox(txtView As TextBox)
        If txtView.Text.Trim = "" Then
            panelParent.CreateGraphics.DrawRectangle(Pens.Red, txtView.Left - 1, txtView.Top - 1, txtView.Width + 1, txtView.Height + 1)
        Else
            panelParent.CreateGraphics.DrawRectangle(Pens.Black, txtView.Left - 1, txtView.Top - 1, txtView.Width + 1, txtView.Height + 1)
        End If
    End Sub
    Private Sub setTextBoxColor(txtView As TextBox)
        panelParent.CreateGraphics.DrawRectangle(Pens.Black, txtView.Left - 1, txtView.Top - 1, txtView.Width + 1, txtView.Height + 1)
    End Sub
    Private Sub checkComboHouseholdId()
        If comboHouseholdId.Text.Trim = "" Or comboHouseholdId.FindStringExact(comboHouseholdId.Text) = -1 Then
            panelParent.CreateGraphics.DrawRectangle(Pens.Red, comboHouseholdId.Left - 1, comboHouseholdId.Top - 1, comboHouseholdId.Width + 1, comboHouseholdId.Height + 1)
        Else
            panelParent.CreateGraphics.DrawRectangle(Pens.Black, comboHouseholdId.Left - 1, comboHouseholdId.Top - 1, comboHouseholdId.Width + 1, comboHouseholdId.Height + 1)
        End If
    End Sub
    Private Sub setComboBoxColor(comboView As ComboBox)
        panelParent.CreateGraphics.DrawRectangle(Pens.Black, comboView.Left - 1, comboView.Top - 1, comboView.Width + 1, comboView.Height + 1)
    End Sub


End Class