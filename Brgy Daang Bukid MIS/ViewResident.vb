Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class ViewResident

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public resident_id As Integer
    Public viewChoice As String

    Dim firstName, middleName, lastName, extName As String
    Dim birthDate As Date
    Dim age, householdId As Integer
    Dim birthPlace, civilStatus, sex, religion,
        contactNo, pwd, disability, voter, occupation, citizenship,
        householdRole, registeredBy, dateRegistered, reasonArchived, archivedBy As String


    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

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

        For i = 0 To civilStatusArray.Length
            comboCivilStatus.Items.Add(civilStatusArray(i))
        Next i

        For i = 0 To sexArray.Length
            comboSex.Items.Add(sexArray(i))
        Next i

        For i = 0 To yesNo.Length
            comboVoter.Items.Add(yesNo(i))
            comboPwd.Items.Add(yesNo(i))
        Next i

        For i = 0 To householdRoleArray.Length
            comboHouseholdRole.Items.Add(householdRoleArray(i))
        Next i

        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact(civilStatusArray(0))
        comboSex.SelectedIndex = comboSex.FindStringExact(sexArray(0))
        comboVoter.SelectedIndex = comboVoter.FindStringExact(yesNo(1))
        comboPwd.SelectedIndex = comboPwd.FindStringExact(yesNo(1))
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact(civilStatusArray(1))

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

        cmd.CommandText = "SELECT CONCAT(bldg_no, ', ', street_name) as address FROM household WHERE household_id = @householdID"
        cmd.Parameters.AddWithValue("@householdID", householdId)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                labelAddress.Text = mySQLReader!address
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function dateFormatter(ByVal month As String, ByVal day As String, ByVal year As String) As String
        Return month + " " + day + ", " + year
    End Function

    Private Sub btnModifyResident_Click(sender As Object, e As EventArgs) Handles btnModifyResident.Click
        mainTabControl.SelectedTab = pageAddModify

        txtFirstName.Text = firstName
        txtMiddleName.Text = middleName
        txtLastName.Text = lastName
        txtExtName.Text = extName
        txtAge.Text = age
        txtBirthPlace.Text = birthPlace
        txtContactNo.Text = contactNo
        txtCitizenship.Text = citizenship
        txtDisability.Text = If(disability = "", "N/A", disability)
        txtOccupation.Text = occupation
        txtReligion.Text = religion
        pickerBirthDate.Format = DateTimePickerFormat.Custom
        pickerBirthDate.CustomFormat = "MMMM dd, yyyy"
        pickerBirthDate.Value = birthDate
        comboCivilStatus.SelectedIndex = comboCivilStatus.FindStringExact(civilStatus)
        comboSex.SelectedIndex = comboSex.FindStringExact(sex)
        comboVoter.SelectedIndex = comboVoter.FindStringExact(voter)
        comboPwd.SelectedIndex = comboPwd.FindStringExact(pwd)
        If comboPwd.SelectedItem.ToString = "Yes" Then
            labelDisability.Visible = True
            txtDisability.Visible = True
            txtDisability.Text = disability
        End If
        comboHouseholdRole.SelectedIndex = comboHouseholdRole.FindStringExact(householdRole)



    End Sub

End Class