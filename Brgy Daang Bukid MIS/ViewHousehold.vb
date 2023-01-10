Imports MySql.Data.MySqlClient

Public Class ViewHousehold
    Public householdId As Integer
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String

    Dim added As Date
    Dim headFirstName, headMiddleName, headLastName, headExtName, residenceType, houseType, waterSource, electricitySource, bldgNo, streetName, dateAdded As String
    Dim headResidentId As Integer

    Private Sub ViewHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

        loadInitialData()

    End Sub
    Private Sub ViewHousehold_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub

    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWaterSource.KeyDown, txtElectricitySource.KeyDown, txtBldgNo.KeyDown, txtHouseholdId.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnSaveHousehold_Click(sender As Object, e As EventArgs) Handles btnSaveHousehold.Click

        If txtHouseholdId.Text.Trim = "" Then
            MsgBox("Please Fill out a valid Household Id", vbCritical, "Warning")
            panelParent.CreateGraphics.DrawRectangle(Pens.Red, txtHouseholdId.Left - 1, txtHouseholdId.Top - 1, txtHouseholdId.Width + 1, txtHouseholdId.Height + 1)
            If checkHouseholdId(txtHouseholdId) = True And action = "add" Then
                MsgBox("Household Id already exists!", vbCritical, "Warning")
            End If
            Exit Sub
        ElseIf txtBldgNo.Text.Trim = "" Or comboStreetName.Text.Trim = "" Or comboHouseType.Text.Trim = "" Or comboResidenceType.Text.Trim = "" Then
            MsgBox("Please Fill out all the required fields!", vbCritical, "Warning")
            checkTextBox(txtBldgNo)
            checkComboBox(comboStreetName)

            checkComboBox(comboResidenceType)
            checkComboBox(comboHouseType)
        Else
            saveHousehold()
            MsgBox("Household Saved!", vbInformation, "Information")
            clearEverything()
            Me.Close()
            Main_Form.txtSearchHousehold.Text = "Type in your search"
            Main_Form.btnHouseholdInfo.PerformClick()
        End If

    End Sub

    Private Sub panelParent_Paint(sender As Object, e As PaintEventArgs) Handles panelParent.Paint
        setComboBoxColor(comboResidenceType)
        setComboBoxColor(comboHouseType)

        setTextBoxColor(txtBldgNo)
        setComboBoxColor(comboStreetName)
        setTextBoxColor(txtWaterSource)
        setTextBoxColor(txtElectricitySource)
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
        txtWaterSource.Text = waterSource
        txtElectricitySource.Text = electricitySource
        comboHouseholdHead.SelectedIndex = comboHouseholdHead.FindStringExact(headFirstName + " " + If(headMiddleName = Nothing Or headMiddleName = "N/A", "", headMiddleName + " ") + headLastName + If(headExtName = Nothing Or headExtName = "N/A", "", headExtName))
        If comboHouseholdHead.Items.Count = 0 Then
            comboHouseholdHead.Visible = False
            labelHouseholdHead.Visible = False
        Else
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

    End Sub

    Private Function checkHouseholdId(txtView As TextBox) As Boolean
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

        cmd.CommandText = "SELECT household_id from household where household_id = @householdid"
        cmd.Parameters.Add("@householdid", txtView.Text.Trim)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
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
    Private Sub clearEverything()
        labelHouseholdId.Text = ""
        labelHeadFirstName.Text = ""
        labelHeadMiddleName.Text = ""
        labelHeadLastName.Text = ""
        labelHeadExtName.Text = ""
        labelBldgNo.Text = ""
        labelStreetName.Text = ""
        labelResidenceType.Text = ""
        labelHousetype.Text = ""
        labelWaterSource.Text = ""
        labelElectricitySource.Text = ""
        labelDateAdded.Text = ""
        datagridViewHousehold.Rows.Clear()
        comboHouseholdHead.Items.Clear()


        householdId = 0
        headResidentId = 0
        headFirstName = ""
        headMiddleName = ""
        headLastName = ""
        headExtName = ""
        bldgNo = ""
        streetName = ""
        residenceType = ""
        houseType = ""
        waterSource = ""
        electricitySource = ""
        dateAdded = ""

        txtHouseholdId.Clear()
        comboResidenceType.SelectedIndex = 0
        comboHouseType.SelectedIndex = 0
        txtBldgNo.Clear()
        comboStreetName.SelectedIndex = 0
        txtWaterSource.Clear()
        txtElectricitySource.Clear()
        comboHouseholdHead.Items.Clear()
        comboResidentId.Items.Clear()

        action = ""
        Panel1.VerticalScroll.Value = 0

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
            cmd.Parameters.AddWithValue("@electricitysource", txtElectricitySource.Text.Trim)
            cmd.Parameters.AddWithValue("@watersource", txtWaterSource.Text.Trim)

            cmd.ExecuteNonQuery()

            setHouseholdHead()
            setHouseholdMember()
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO household (household_id, bldg_no, street_name, residence_type, house_type, water_source, electricity_source, month_added, day_added, year_added, added_by) values (@householdid, @bldgno, @streetname, @residencetype, @housetype, @watersource, @electricitysource, @month, @day, @year, @addedby)"
            cmd.Parameters.AddWithValue("@householdid", txtHouseholdId.Text.Trim)
            cmd.Parameters.AddWithValue("@bldgno", txtBldgNo.Text.Trim)
            cmd.Parameters.AddWithValue("@streetname", comboStreetName.Text.Trim)
            cmd.Parameters.AddWithValue("@residencetype", comboResidenceType.Text.Trim)
            cmd.Parameters.AddWithValue("@housetype", comboHouseType.Text.Trim)
            cmd.Parameters.AddWithValue("@electricitysource", txtElectricitySource.Text.Trim)
            cmd.Parameters.AddWithValue("@watersource", txtWaterSource.Text.Trim)

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
    End Sub
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
    End Sub


    '' '''''''''''''' TEXTBOX AND COMBO BOX CHECKER''''''''''''''''''''''''
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
    Private Sub checkComboBox(comboView As ComboBox)
        If comboView.Text.Trim = "" Or comboView.FindStringExact(comboView.Text) = -1 Then
            panelParent.CreateGraphics.DrawRectangle(Pens.Red, comboView.Left - 1, comboView.Top - 1, comboView.Width + 1, comboView.Height + 1)
        Else
            panelParent.CreateGraphics.DrawRectangle(Pens.Black, comboView.Left - 1, comboView.Top - 1, comboView.Width + 1, comboView.Height + 1)
        End If
    End Sub
    Private Sub setComboBoxColor(comboView As ComboBox)
        panelParent.CreateGraphics.DrawRectangle(Pens.Black, comboView.Left - 1, comboView.Top - 1, comboView.Width + 1, comboView.Height + 1)
    End Sub
End Class