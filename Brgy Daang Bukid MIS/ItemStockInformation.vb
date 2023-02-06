Imports MySql.Data.MySqlClient

Public Class ItemStockInformation


    Public mySqlConn As String = My.Resources.constring

    Public action As String
    Public itemId As Integer
    Dim isSaved As Boolean = False
    Dim availableStock As Integer
    Private Sub ItemStockInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getSystemVariable(comboItemState, "Return Item State")
        loadInitialData()


        dateStock.Format = DateTimePickerFormat.Custom
        dateStock.CustomFormat = "MMMM d, yyyy"
    End Sub
    Private Sub ItemStockInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        Main_Form.btnInventory.PerformClick()
    End Sub
    Private Sub ItemStockInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isSaved = False Then
            If txtQuantity.Text.Trim <> "" Or txtReason.Text.Trim <> "" Or comboItemState.SelectedIndex >= 0 Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub loadInitialData()

        txtTransactionType.Text = action

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
                txtStockItemName.Text = mySQLReader!item_name
            End While
        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        If action = "Stock In" Then
            comboItemState.Enabled = False
        ElseIf action = "Stock Out" Then
            comboItemState.Enabled = True
            comboItemState.Items.Remove("Good")
        End If
        comboItemState.SelectedIndex = 0

    End Sub
    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If itemId = 0 Or txtStockItemName.Text.Trim = "" Then
            MsgBox("Please select a valid item!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtQuantity.Text.Trim = "" Or txtQuantity.Text = "0" Then
            MsgBox("Please provide a valid quantity!", vbCritical, "Warning")
            Exit Sub
        End If
        If dateStock.Value.Date > Date.Now.Date Then
            MsgBox("Please provide a provide a stock date!", vbCritical, "Warning")
            Exit Sub
        End If

        Dim newStocks As Integer
        Dim status As String
        Dim remainingStocks As Integer = getStockItems()
        If txtTransactionType.Text = "Stock In" Then
            newStocks = remainingStocks + CInt(txtQuantity.Text)
        Else
            If remainingStocks < CInt(txtQuantity.Text) Then
                MsgBox("You can't stock out items more than the remaining stocks!", vbCritical, "Warning")
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
        cmd.Parameters.AddWithValue("@transactiontype", txtTransactionType.Text)
        cmd.Parameters.AddWithValue("@itemstate", comboItemState.Text)
        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
        cmd.Parameters.AddWithValue("@transactionby", Main_Form.account_credentials)
        cmd.Parameters.AddWithValue("@date", Date.Now)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        updateStock(status, newStocks)

        MsgBox("Stock Updated!", vbInformation, "Information")

        isSaved = True
        Me.Close()
        Main_Form.txtSearchInventory.Text = "Search by Item Name or ID"
        Main_Form.btnInventory.PerformClick()

    End Sub



    Private Sub txtQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
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

        cmd.CommandText = "UPDATE item_list SET item_stock = @itemstock, item_status = @itemstatus, item_unusable = @itemunusable where item_id = @itemid"
        cmd.Parameters.AddWithValue("@itemid", itemId)
        cmd.Parameters.AddWithValue("@itemstock", stock)
        cmd.Parameters.AddWithValue("@itemstatus", status)
        cmd.Parameters.AddWithValue("@itemunusable", If(txtTransactionType.Text = "Stock Out", getItemNumbers("unusable") + CInt(txtQuantity.Text), getItemNumbers("unusable")))

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", txtTransactionType.Text & " [" & txtStockItemName.Text & "] Quantity [" & txtQuantity.Text & "]")

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


End Class