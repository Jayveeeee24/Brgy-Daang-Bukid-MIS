Imports MySql.Data.MySqlClient

Public Class ViewHousehold
    Public householdId As Integer
    Public mySqlConn As String = My.Resources.constring
    Public action As String

    Dim isSaved As Boolean = False
    Dim added As Date
    Dim headFirstName, headMiddleName, headLastName, headExtName, residenceType, houseType, waterSource, electricitySource, bldgNo, streetName, dateAdded As String
    Dim headResidentId As Integer

    Private Sub ViewHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainTabControl.ItemSize = New Size(0, 1)

        getSystemVariable(comboStreetName, "Street Name")
        getSystemVariable(comboResidenceType, "Residence Type")
        getSystemVariable(comboHouseType, "House Type")
        getSystemVariable(comboWaterSource, "Water Source")
        getSystemVariable(comboElectricitySource, "Electricity Source")


        loadInitialData()
    End Sub
    Private Sub ViewHousehold_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If txtHouseholdId.Text.Trim <> "" Or txtBldgNo.Text.Trim <> "" Or comboStreetName.Text.Trim <> "" Then
                If mainTabControl.SelectedIndex = 1 Then
                    If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ViewHousehold_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub



    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBldgNo.KeyDown, txtHouseholdId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSaveHousehold_Click(sender As Object, e As EventArgs) Handles btnSaveHousehold.Click

        If txtHouseholdId.Text.Trim = "" Then
            MsgBox("Please fill out a valid Household Id!", vbCritical, "Warning")
            Exit Sub
        End If
        If isHouseholdIdAvailable() = False And action = "add" Then
            MsgBox("Household Id already exists!", vbCritical, "Warning")
            Exit Sub
        End If

        If checkAge(CInt(comboResidentId.Text)) = False And action = "modify" Then
            MsgBox("Resident's age is not applicable to be a head!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtBldgNo.Text.Trim = "" Then
            MsgBox("Please fill out a valid house number!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboStreetName.Text.Trim = "" Then
            MsgBox("Please fill out a valid street name!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboHouseType.Text.Trim = "" Then
            MsgBox("Please fill out a valid house type!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboResidenceType.Text.Trim = "" Then
            MsgBox("Please fill out a valid residence type!", vbCritical, "Warning")
            Exit Sub
        End If


        saveHousehold()
        MsgBox("Household Saved!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.btnHouseholdInfo.PerformClick()
    End Sub

    Private Sub btnModifyHousehold_Click(sender As Object, e As EventArgs) Handles btnModifyHousehold.Click
        mainTabControl.SelectedIndex = 1
        action = "modify"

        txtHouseholdId.Text = householdId
        txtHouseholdId.Enabled = False
        comboHouseType.SelectedIndex = comboHouseType.FindStringExact(houseType)
        comboResidenceType.SelectedIndex = comboResidenceType.FindStringExact(residenceType)
        txtBldgNo.Text = bldgNo
        comboStreetName.SelectedIndex = If(comboStreetName.FindStringExact(streetName) = -1, comboStreetName.Text = "", comboStreetName.FindStringExact(streetName))
        If comboWaterSource.FindStringExact(waterSource) >= 0 Then
            comboWaterSource.SelectedIndex = comboWaterSource.FindStringExact(waterSource)
        Else
            comboWaterSource.Text = waterSource
        End If

        If comboElectricitySource.FindStringExact(waterSource) >= 0 Then
            comboWaterSource.SelectedIndex = comboElectricitySource.FindStringExact(waterSource)
        Else
            comboElectricitySource.Text = electricitySource
        End If

        'comboHouseholdHead.SelectedIndex = comboHouseholdHead.FindStringExact(headFirstName + " " + If(headMiddleName = Nothing Or headMiddleName = "N/A", "", headMiddleName + " ") + headLastName + If(headExtName = Nothing Or headExtName = "N/A", "", headExtName))
        If comboHouseholdHead.Items.Count = 0 Then
            comboHouseholdHead.Visible = False
            labelHouseholdHead.Visible = False
        Else
            comboHouseholdHead.SelectedIndex = 0
            comboHouseholdHead.Visible = True
            labelHouseholdHead.Visible = True
        End If
    End Sub
    Private Sub txtHouseholdId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHouseholdId.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub comboHouseholdHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHouseholdHead.SelectedIndexChanged
        comboResidentId.SelectedIndex = comboHouseholdHead.FindStringExact(comboHouseholdHead.Text)
    End Sub



    '' '''''''''''FUNCTIONS FOR ACCESSS ''''''''''''''''''''''''''''''''''''
    Private Sub loadInitialData()
        txtHouseholdId.Select()
        mainTabControl.SelectedIndex = 0
        txtHouseholdId.Enabled = True
        comboResidentId.Hide()

        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            labelHouseholdHead.Visible = False
            comboHouseholdHead.Visible = False
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
            cmd.CommandText = "SELECT * FROM household where household_id = @householdid"
            cmd.Parameters.AddWithValue("@householdid", householdId)
            mySQLReader = cmd.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    bldgNo = mySQLReader!bldg_no
                    streetName = mySQLReader!street_name
                    residenceType = mySQLReader!residence_type
                    houseType = mySQLReader!house_type
                    waterSource = mySQLReader!water_source
                    electricitySource = mySQLReader!electricity_source
                    added = mySQLReader!date_added
                    dateAdded = added.ToString("MMMM dd, yyyy")
                End While
            End If
            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            getHouseholdMembers()
        End If

        comboHouseType.SelectedIndex = comboHouseType.FindStringExact("Wood")
        comboResidenceType.SelectedIndex = comboResidenceType.FindStringExact("Owned")
        comboWaterSource.SelectedIndex = 0
        comboElectricitySource.SelectedIndex = 0

    End Sub
    Private Function isHouseholdIdAvailable() As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from household WHERE household_id = '" & CInt(txtHouseholdId.Text.Trim) & "'"

        If cmd.ExecuteScalar = 0 Then
            Return True
        Else
            Return False
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function

    Private Function checkAge(ByVal id As Integer) As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from residents WHERE resident_id = @residentid and age <= 20"
        cmd.Parameters.AddWithValue("@residentid", id)

        If cmd.ExecuteScalar = 0 Then
            Return True
        Else
            Return False
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function
    Private Sub getHouseholdMembers()

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select
        datagridViewHousehold.Rows.Clear()


        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT resident_id, first_name, middle_name, last_name, ext_name, contact_no, household_role FROM residents where household_id = @householdid order by household_role asc"
        cmd.Parameters.AddWithValue("@householdid", householdId)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                If mySQLReader!household_role = "Head" Then
                    headFirstName = mySQLReader!first_name + " "
                    headMiddleName = If(mySQLReader!middle_name = Nothing Or mySQLReader!middle_name = "", "N/A", mySQLReader!middle_name)
                    headLastName = mySQLReader!last_name
                    headExtName = If(mySQLReader!ext_name = Nothing Or mySQLReader!ext_name = "", "N/A", " " + mySQLReader!ext_name)
                    headResidentId = mySQLReader!resident_id
                End If
                comboResidentId.Items.Add(mySQLReader!resident_id)
                datagridViewHousehold.Rows.Add(New String() {mySQLReader!first_name + " " + If(mySQLReader!middle_name = Nothing Or mySQLReader!middle_name = "", "", mySQLReader!middle_name + " ") + mySQLReader!last_name + mySQLReader!ext_name, mySQLReader!contact_no, mySQLReader!household_role})
                comboHouseholdHead.Items.Add(mySQLReader!first_name + " " + If(mySQLReader!middle_name = Nothing Or mySQLReader!middle_name = "", "", mySQLReader!middle_name + " ") + mySQLReader!last_name + mySQLReader!ext_name)
            End While
        End If

        labelHouseholdId.Text = householdId
        labelBldgNo.Text = bldgNo
        labelStreetName.Text = streetName
        labelResidenceType.Text = If(residenceType = "", "No Data", residenceType)
        labelHousetype.Text = If(houseType = "", "No Data", houseType)
        labelWaterSource.Text = If(waterSource = "", "No Data", waterSource)
        labelElectricitySource.Text = If(electricitySource = "", "No Data", electricitySource)
        labelDateAdded.Text = dateAdded
        labelHeadFirstName.Text = If(headFirstName = "", "No Data", headFirstName)
        labelHeadMiddleName.Text = If(headMiddleName = "", "No Data", headMiddleName)
        labelHeadLastName.Text = If(headLastName = "", "No Data", headLastName)
        labelHeadExtName.Text = If(headExtName = "", "No Data", headExtName)


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub


    Private Sub saveHousehold()
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
            cmd.CommandText = "UPDATE household SET bldg_no = @bldgno, street_name = @streetname, residence_type = @residencetype, house_type = @housetype, water_source = @watersource, electricity_source = @electricitysource WHERE household_id = @householdid"
            cmd.Parameters.AddWithValue("@householdid", txtHouseholdId.Text.Trim)
            cmd.Parameters.AddWithValue("@bldgno", txtBldgNo.Text.Trim)
            cmd.Parameters.AddWithValue("@streetname", comboStreetName.Text.Trim)
            cmd.Parameters.AddWithValue("@residencetype", comboResidenceType.Text.Trim)
            cmd.Parameters.AddWithValue("@housetype", comboHouseType.Text.Trim)
            cmd.Parameters.AddWithValue("@electricitysource", comboElectricitySource.Text.Trim)
            cmd.Parameters.AddWithValue("@watersource", comboWaterSource.Text.Trim)

            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Updated Household Information for [" & txtHouseholdId.Text & "]")

            setHouseholdHead()
            setHouseholdMember()
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO household (household_id, bldg_no, street_name, residence_type, house_type, water_source, electricity_source, month_added, day_added, year_added, added_by) values (@householdid, @bldgno, @streetname, @residencetype, @housetype, @watersource, @electricitysource, @month, @day, @year, @addedby)"
            cmd.Parameters.AddWithValue("@householdid", txtHouseholdId.Text.Trim)
            cmd.Parameters.AddWithValue("@bldgno", txtBldgNo.Text.Trim)
            cmd.Parameters.AddWithValue("@streetname", comboStreetName.Text.Trim)
            cmd.Parameters.AddWithValue("@residencetype", comboResidenceType.Text.Trim)
            cmd.Parameters.AddWithValue("@housetype", comboHouseType.Text.Trim)
            cmd.Parameters.AddWithValue("@electricitysource", comboElectricitySource.Text.Trim)
            cmd.Parameters.AddWithValue("@watersource", comboWaterSource.Text.Trim)

            Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
            Dim dateToday As Date = Date.Now
            Dim monthNo As Integer = Int(dateToday.Month.ToString) - 1
            Dim monthNow As String = months(monthNo)
            Dim dayNow As String = dateToday.Day.ToString
            Dim yearNow As String = dateToday.Year.ToString

            cmd.Parameters.AddWithValue("@month", monthNow)
            cmd.Parameters.AddWithValue("@day", dayNow)
            cmd.Parameters.AddWithValue("@year", yearNow)
            cmd.Parameters.AddWithValue("@addedby", Main_Form.account_credentials)
            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Added Household Information for [" & txtHouseholdId.Text & "]")

        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub setHouseholdHead()
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
        cmd.Parameters.AddWithValue("@residentid", comboResidentId.Text)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "[" & getResidentNameById(CInt(comboResidentId.Text)) & "] set as household head")
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
    Private Sub setHouseholdMember()
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


        cmd.CommandText = "UPDATE residents SET household_role = 'Member' where resident_id = @residentid"
        cmd.Parameters.AddWithValue("@residentid", headResidentId)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "[" & getResidentNameById(CInt(headResidentId)) & "] removed as household head")

    End Sub
End Class