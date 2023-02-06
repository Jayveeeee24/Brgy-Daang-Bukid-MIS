Imports MySql.Data.MySqlClient

Public Class ItemDataInformation
    Public mySqlConn As String = My.Resources.constring

    Public action As String
    Public itemId As Integer
    Dim isSaved As Boolean = False
    Private Sub ItemDataInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSystemVariable(comboReason, "Stock Out Reason")

        loadInitialData()
    End Sub
    Private Sub ItemDataInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        Main_Form.btnItemDataManagement.PerformClick()
    End Sub
    Private Sub ItemDataInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If txtItemName.Text.Trim <> "" Or txtRemarks.Text.Trim <> "" Or txtItemColor.Text.Trim <> "" Or txtItemSerial.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
    Private Sub loadInitialData()
        If action = "add" Then
            txtItemId.Hide()
            labelId.Hide()
            comboItemStatus.SelectedIndex = 0
            comboReason.SelectedIndex = -1
            comboItemStatus.Enabled = False
            comboReason.Enabled = False
            datePickerAdded.Show()
            labelDateAdded.Show()
            txtItemName.Enabled = True

            txtItemColor.Enabled = True
            txtItemSerial.Enabled = True

        ElseIf action = "modify" Then
            txtItemId.Show()
            labelId.Show()
            datePickerAdded.Hide()
            labelDateAdded.Hide()
            comboItemStatus.Enabled = True

            txtItemName.Enabled = False
            txtItemColor.Enabled = False
            txtItemSerial.Enabled = False

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
            cmd.CommandText = "SELECT * FROM item_list where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    txtItemId.Text = itemId
                    txtItemName.Text = mySQLReader!item_name
                    comboItemStatus.SelectedIndex = comboItemStatus.FindStringExact(mySQLReader!item_status)

                    comboReason.SelectedIndex = If(mySQLReader!item_reason <> "", comboReason.FindStringExact(mySQLReader!item_reason), -1)


                    txtItemColor.Text = mySQLReader!item_color
                    txtItemSerial.Text = mySQLReader!serial_no
                    Dim date1 As Date = mySQLReader!added_on
                    datePickerAdded.Value = date1
                    txtRemarks.Text = mySQLReader!remarks
                End While
            End If


            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            If comboItemStatus.SelectedIndex = 1 Then
                comboReason.SelectedIndex = -1
            End If

        End If

        datePickerAdded.Format = DateTimePickerFormat.Custom
        datePickerAdded.CustomFormat = "MMMM d, yyyy"
    End Sub
    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        If txtItemName.Text.Trim = "" Then
            MsgBox("Please fill out a valid item name!", vbCritical, "Warning")
            Exit Sub
        End If
        If (comboItemStatus.SelectedIndex = 0 And comboReason.SelectedIndex = -1) And action = "modify" Then
            MsgBox("Please fill out a valid reason for unavailability!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboItemStatus.SelectedIndex = 1 And getStockItems() = 0 Then
            MsgBox("You cannot make it available if it has no stocks, Add stock first!", vbCritical, "Warning")
            Exit Sub
        End If
        If action = "modify" And (comboItemStatus.SelectedIndex = 1 And getStockItems() = 0) Then
            MsgBox("You can't make this item available without any available stocks!", vbCritical, "Warning")
            Exit Sub
        End If
        If datePickerAdded.Value.Date > Date.Now.Date Then
            MsgBox("Please fill out a valid date of adding item!", vbCritical, "Warning")
            Exit Sub
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

        If action = "modify" Then
            cmd.CommandText = "UPDATE item_list SET item_name = @itemname, item_status = @itemstatus, item_reason = @itemreason, remarks = @remarks where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            cmd.Parameters.AddWithValue("@itemname", txtItemName.Text)
            cmd.Parameters.AddWithValue("@itemreason", comboReason.Text)
            cmd.Parameters.AddWithValue("@itemstatus", comboItemStatus.Text)
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)

            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Modified Item Data [" & txtItemName.Text & "]")
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO item_list (item_name, item_status, item_stock, item_reason, item_color, item_borrowed, item_unusable, serial_no, added_by, added_on, remarks) values (@itemname, @itemstatus, 0, @itemreason, @itemcolor, 0, 0,  @itemserial, @addedby, @addedon, @remarks)"
            cmd.Parameters.AddWithValue("@itemname", txtItemName.Text)
            cmd.Parameters.AddWithValue("@itemstatus", comboItemStatus.Text)
            cmd.Parameters.AddWithValue("@itemreason", comboReason.Text)
            cmd.Parameters.AddWithValue("@itemcolor", txtItemColor.Text)
            cmd.Parameters.AddWithValue("@itemserial", txtItemSerial.Text)

            cmd.Parameters.AddWithValue("@addedby", Main_Form.account_credentials)
            cmd.Parameters.AddWithValue("@addedon", datePickerAdded.Value.Date)
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)

            cmd.ExecuteNonQuery()

            addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Add Item Data [" & txtItemName.Text & "]")
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Item Saved!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchItemData.Text = "Search by Item Name or ID"
        Main_Form.btnItemDataManagement.PerformClick()
    End Sub


    Private Sub comboItemStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboItemStatus.SelectedIndexChanged
        If comboItemStatus.SelectedIndex = 0 Then
            comboReason.SelectedIndex = 0
            comboReason.Enabled = True
        Else
            comboReason.SelectedIndex = -1
            comboReason.Enabled = False
        End If
    End Sub
    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemSerial.KeyDown, txtItemName.KeyDown, txtItemColor.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Function getStockItems() As Integer
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim remainingStocks As Integer
        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT item_stock from item_list where item_id = @itemid"
        cmd.Parameters.AddWithValue("@itemid", itemId)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                remainingStocks = mySQLReader!item_stock
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        Return remainingStocks
    End Function


End Class