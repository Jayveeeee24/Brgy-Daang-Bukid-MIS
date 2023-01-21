Imports System.Globalization
Imports System.Runtime.InteropServices
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ViewInventory
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Public action As String
    Public itemId As Integer
    Dim itemReason As String
    Dim itemStatus As String
    Dim isSaved As Boolean = False

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

        loadInitialData()
    End Sub
    Private Sub ViewInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Sub ViewInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" And isSaved = False Then
            If txtItemName.Text.Trim <> "" Or txtRemarks.Text.Trim <> "" Or txtItemColor.Text.Trim <> "" Or txtItemSerial.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        ElseIf (action = "stock" And isSaved = False) Or (action = "borrowReturn" And isSaved = False) Then
            If txtStockItemName.Text.Trim <> "" Or txtQuantity.Text.Trim <> "" Or txtReason.Text.Trim <> "" Or txtTransactionBy.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    Private Sub loadInitialData()
        txtItemName.Select()
        mainTabControl.SelectedIndex = 0

        If action = "add" Then
            mainTabControl.SelectedIndex = 1
            txtItemId.Hide()
            labelId.Hide()
            comboItemStatus.SelectedIndex = 1
            comboItemStatus.Enabled = False
        End If


        If action = "stock" Then
            itemId = 0
            mainTabControl.SelectedIndex = 2
            comboTransactionType.Items.Add("Stock In")
            comboTransactionType.Items.Add("Stock Out")

            comboTransactionType.SelectedIndex = 0

        ElseIf action = "borrowReturn" Then
            itemId = 0
            mainTabControl.SelectedIndex = 2
            comboTransactionType.Items.Add("Borrow")
            comboTransactionType.Items.Add("Return")

            comboTransactionType.SelectedIndex = 0
            labelReturnDate.Visible = True
            dateReturn.Visible = True
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
            cmd.CommandText = "SELECT * FROM item_list where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    labelItemId.Text = itemId
                    labelItemName.Text = mySQLReader!item_name
                    labelItemStatus.Text = If(mySQLReader!item_status = "Unavailable", mySQLReader!item_status + " (" + mySQLReader!item_reason + ")", mySQLReader!item_status)
                    itemReason = mySQLReader!item_reason
                    itemStatus = mySQLReader!item_status
                    labelItemColor.Text = If(mySQLReader!item_color = "", "N/A", mySQLReader!item_color)
                    labelItemSerial.Text = If(mySQLReader!serial_no = "", "N/A", mySQLReader!serial_no)
                    labelItemBorrowed.Text = mySQLReader!item_borrowed
                    labeItemUnusable.Text = mySQLReader!item_unusable
                    labelItemStock.Text = mySQLReader!item_stock

                    labelItemStock.Text = If(mySQLReader!item_stock = "", 0, mySQLReader!item_stock)
                    labelAddedBy.Text = mySQLReader!added_by
                    Dim date1 As Date = mySQLReader!added_on
                    labelAddedOn.Text = date1.ToString("MMMM d, yyyy")
                    labelRemarks.Text = mySQLReader!remarks
                End While
            End If


            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
        txtItemName.Enabled = True
        txtItemColor.Enabled = True
        txtItemSerial.Enabled = True
        comboReason.Enabled = False
        getItemHistory()

    End Sub

    Private Sub btnModifyItem_Click(sender As Object, e As EventArgs) Handles btnModifyItem.Click
        mainTabControl.SelectedIndex = 1
        action = "modify"

        txtItemId.Show()
        labelId.Show()

        txtItemName.Enabled = False

        txtItemColor.Enabled = False
        txtItemSerial.Enabled = False

        comboItemStatus.Enabled = True
        comboItemStatus.SelectedIndex = comboItemStatus.FindStringExact(itemStatus)
        comboReason.SelectedIndex = comboReason.FindStringExact(itemReason)
        txtItemId.Text = labelItemId.Text
        txtItemName.Text = labelItemName.Text
        txtItemColor.Text = If(labelItemColor.Text = "N/A", "", labelItemColor.Text)
        txtItemSerial.Text = If(labelItemSerial.Text = "N/A", "", labelItemSerial.Text)
        txtRemarks.Text = labelRemarks.Text
    End Sub
    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        If txtItemName.Text.Trim = "" Then
            MsgBox("Please fill out a valid item name!", vbCritical, "Warning")
            Exit Sub
        End If
        If comboItemStatus.SelectedIndex = 0 And comboReason.SelectedIndex = -1 Then
            MsgBox("Please fill out a valid reason for unavailability!", vbCritical, "Warning")
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
            cmd.CommandText = "UPDATE item_list SET item_name = @itemname, item_stock= @itemstock, item_status = @itemstatus, item_reason = @itemreason, remarks = @remarks where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            cmd.Parameters.AddWithValue("@itemname", txtItemName.Text)
            cmd.Parameters.AddWithValue("@itemreason", comboReason.Text)
            cmd.Parameters.AddWithValue("@itemstatus", comboItemStatus.Text)
            cmd.Parameters.AddWithValue("@itemstock", If(comboItemStatus.Text = "Unavailable", 0, getStockItems()))
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)

            cmd.ExecuteNonQuery()
        ElseIf action = "add" Then
            cmd.CommandText = "INSERT INTO item_list (item_name, item_status, item_stock, item_reason, item_color, item_borrowed, item_unusable, serial_no, added_by, added_on, remarks) values (@itemname, @itemstatus, 0, @itemreason, 0, 0, @itemcolor, @itemserial, @addedby, @addedon, @remarks)"
            cmd.Parameters.AddWithValue("@itemname", txtItemName.Text)
            cmd.Parameters.AddWithValue("@itemstatus", comboItemStatus.Text)
            cmd.Parameters.AddWithValue("@itemreason", comboReason.Text)
            cmd.Parameters.AddWithValue("@itemcolor", txtItemColor.Text)
            cmd.Parameters.AddWithValue("@itemserial", txtItemSerial.Text)

            cmd.Parameters.AddWithValue("@addedby", Main_Form.account_credentials)
            cmd.Parameters.AddWithValue("@addedon", Date.Now)
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)

            cmd.ExecuteNonQuery()
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        MsgBox("Item Saved!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchInventory.Text = "Search by Item Name or ID"
        Main_Form.btnInventory.PerformClick()
    End Sub
    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If action = "stock" Then
            If itemId = 0 Or txtStockItemName.Text.Trim = "" Then
                MsgBox("Please select a valid item!", vbCritical, "Warning")
                Exit Sub
            End If

            If txtQuantity.Text.Trim = "" Or txtQuantity.Text = "0" Then
                MsgBox("Please provide a valid quantity!", vbCritical, "Warning")
                Exit Sub
            End If


            Dim newStocks As Integer
            Dim status As String
            Dim remainingStocks As Integer = getStockItems()
            If comboTransactionType.Text = "Stock In" Then
                newStocks = remainingStocks + CInt(txtQuantity.Text)
            Else
                If remainingStocks < CInt(txtQuantity.Text) Then
                    MsgBox("Please input a valid quantity!", vbCritical, "Warning")
                    Exit Sub
                End If
                newStocks = remainingStocks - CInt(txtQuantity.Text)
            End If
            If newStocks = 0 Then
                status = "Unavailable"
            Else
                status = "Available"
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

            cmd.CommandText = "INSERT INTO item_history (item_id, transaction_type, item_state, quantity, transaction_by, date, reason) values (@itemid, @transactiontype, @itemstate, @quantity, @transactionby, @date, @reason)"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            cmd.Parameters.AddWithValue("@transactiontype", comboTransactionType.Text)
            cmd.Parameters.AddWithValue("@itemstate", comboItemState.Text)
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@transactionby", txtTransactionBy.Text)
            cmd.Parameters.AddWithValue("@date", Date.Now)
            cmd.Parameters.AddWithValue("@reason", txtReason.Text)

            cmd.ExecuteNonQuery()

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            updateStock(status, newStocks)


        ElseIf action = "borrowReturn" Then

            If itemId = 0 Or txtStockItemName.Text.Trim = "" Then
                MsgBox("Please select a valid item!", vbCritical, "Warning")
                Exit Sub
            End If
            If isItemUnavailable() = True And comboTransactionType.Text = "Borrow" Then
                MsgBox("You cannot borrow items that are unavailable!", vbCritical, "Warning")
                Exit Sub
            End If
            If txtQuantity.Text.Trim = "" Or txtQuantity.Text = "0" Then
                MsgBox("Please provide a valid quantity!", vbCritical, "Warning")
                Exit Sub
            End If
            If comboTransactionType.Text = "Return" And CInt(txtQuantity.Text) > getItemNumbers("borrowed") Then
                MsgBox("You cannot return items more than what is borrowed!" + vbCrLf + "Items borrowed: " + getItemNumbers("borrowed").ToString, vbCritical, "Warning")
                Exit Sub
            End If


            Dim newStocks As Integer
            Dim status As String
            Dim remainingStocks As Integer = getStockItems()
            If comboTransactionType.Text = "Borrow" Then
                newStocks = remainingStocks - CInt(txtQuantity.Text)

                If remainingStocks < CInt(txtQuantity.Text) Then
                    MsgBox("Please input a valid quantity!", vbCritical, "Warning")
                    Exit Sub
                End If
            ElseIf comboTransactionType.Text = "Return" And comboItemState.SelectedIndex = 0 Then
                newStocks = remainingStocks + CInt(txtQuantity.Text)
            End If
            If newStocks = 0 Then
                status = "Unavailable"
            Else
                status = "Available"
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

            cmd.CommandText = "INSERT INTO item_history (item_id, transaction_type, item_state,  quantity, transaction_by, date, reason) values (@itemid, @transactiontype, @itemstate, @quantity, @transactionby, @date, @reason)"
            cmd.Parameters.AddWithValue("@itemid", itemId)
            cmd.Parameters.AddWithValue("@transactiontype", If(comboTransactionType.SelectedIndex = 0, "Borrowed", "Returned"))
            cmd.Parameters.AddWithValue("@itemstate", comboItemState.Text)
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@transactionby", txtTransactionBy.Text)
            cmd.Parameters.AddWithValue("@date", dateReturn.Value.Date)
            cmd.Parameters.AddWithValue("@reason", txtReason.Text)

            cmd.ExecuteNonQuery()

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()

            updateStock(status, newStocks)
        End If
        MsgBox("Stock Updated!", vbInformation, "Information")
        isSaved = True
        Me.Close()
        Main_Form.txtSearchInventory.Text = "Search by Item Name or ID"
        Main_Form.btnInventory.PerformClick()
    End Sub


    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemName.KeyDown, txtStockItemName.KeyDown, txtQuantity.KeyDown, txtTransactionBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtViewNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        checkInputNumbersOnly(e)
    End Sub
    Private Sub txtStockItemName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockItemName.KeyPress
        checkInputCharactersOnly(e)
    End Sub

    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click
        SearchItems.ShowDialog()
    End Sub
    Private Sub btnSearchTransactionBy_Click(sender As Object, e As EventArgs) Handles btnSearchTransactionBy.Click
        Search_Residents.origin = "transactBy"
        Search_Residents.ShowDialog()
    End Sub

    Private Sub comboItemStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboItemStatus.SelectedIndexChanged
        comboReason.Items.Clear()
        If comboItemStatus.SelectedIndex = 0 Then
            comboReason.Enabled = True

            comboReason.Items.Add("Damaged")
            comboReason.Items.Add("Defective")
            comboReason.Items.Add("Lost")
            comboReason.Items.Add("Replaced")
        Else
            comboReason.Enabled = False

        End If
        comboReason.SelectedIndex = -1
    End Sub
    Private Sub comboTransactionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTransactionType.SelectedIndexChanged
        comboItemState.Items.Clear()

        If comboTransactionType.SelectedIndex = 0 Then
            comboItemState.Items.Add("Good")
            comboItemState.Enabled = False
        Else
            If action = "borrowReturn" Then
                comboItemState.Items.Add("Good")
            End If
            comboItemState.Items.Add("Damaged")
            comboItemState.Items.Add("Defective")
            comboItemState.Items.Add("Lost")
            comboItemState.Enabled = True

        End If
        comboItemState.SelectedIndex = 0

        If comboTransactionType.Text = "Borrow" Then
            labelReturnDate.Text = "Return Date*: "
        ElseIf comboTransactionType.Text = "Return" Then
            labelReturnDate.Text = "Date Returned*: "
        End If
    End Sub




    '' '''''''''''''''FUNCTION HELPERS''''''''''''''''''''''
    Private Sub getItemHistory()

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select
        dataGridItemHistory.Rows.Clear()


        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from item_history where item_id = @itemid order by date desc"
        cmd.Parameters.AddWithValue("@itemid", itemId)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                dataGridItemHistory.Rows.Add(New String() {mySQLReader!id, If(mySQLReader!item_state <> "Good", mySQLReader!transaction_type + "(" + mySQLReader!item_state + ")", mySQLReader!transaction_type), mySQLReader!quantity, mySQLReader!transaction_by, mySQLReader!date, mySQLReader!reason})
            End While
        End If
        dataGridItemHistory.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub checkInputNumbersOnly(e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub checkInputCharactersOnly(e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub updateStock(ByVal status As String, ByVal stock As Integer)
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

        cmd.CommandText = "UPDATE item_list SET item_stock = @itemstock, item_status = @itemstatus, item_unusable = @itemunusable, item_borrowed = @itemborrowed where item_id = @itemid"

        cmd.Parameters.AddWithValue("@itemid", itemId)
        cmd.Parameters.AddWithValue("@itemstock", stock)
        cmd.Parameters.AddWithValue("@itemstatus", status)
        cmd.Parameters.AddWithValue("@itemunusable", If((comboTransactionType.Text = "Return" And comboItemState.SelectedIndex > 0) Or comboTransactionType.Text = "Stock Out", getItemNumbers("unusable") + CInt(txtQuantity.Text), getItemNumbers("unusable")))
        If comboTransactionType.Text = "Borrow" Then
            cmd.Parameters.AddWithValue("@itemborrowed", If(comboTransactionType.SelectedIndex = 0, getItemNumbers("borrowed") + CInt(txtQuantity.Text), getItemNumbers("borrowed")))
        ElseIf comboTransactionType.Text = "Return" Then
            cmd.Parameters.AddWithValue("@itemborrowed", getItemNumbers("borrowed") - CInt(txtQuantity.Text))
        Else
            cmd.Parameters.AddWithValue("@itemborrowed", getItemNumbers("borrowed"))
        End If

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function getItemNumbers(ByVal field As String) As Integer
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim remainingItems As Integer
        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        If field = "unusable" Then
            cmd.CommandText = "SELECT item_unusable as remaining from item_list where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
        ElseIf field = "borrowed" Then
            cmd.CommandText = "SELECT item_borrowed as remaining from item_list where item_id = @itemid"
            cmd.Parameters.AddWithValue("@itemid", itemId)
        End If
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                remainingItems = mySQLReader!remaining
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        Return remainingItems
    End Function
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
    Private Function isItemUnavailable() As Boolean
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

        cmd.CommandText = "SELECT COUNT(*) from item_list WHERE item_id = @itemid and item_status = 'Unavailable'"
        cmd.Parameters.AddWithValue("@itemid", itemId)

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