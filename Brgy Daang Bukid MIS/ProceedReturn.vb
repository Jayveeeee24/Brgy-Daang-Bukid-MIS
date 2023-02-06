Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ProceedReturn
    Public mySqlConn As String = My.Resources.constring
    Public id As Integer
    Public itemId As Integer
    Public quantity As Integer
    Public dateBorrowed As String
    Public action As String

    Private Sub ProceedReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSystemVariable(comboItemState, "Return Item State")

        dateReturned.Format = DateTimePickerFormat.Custom
        dateReturned.CustomFormat = "MMMM d, yyyy"


        comboItemState.SelectedIndex = 0


        If action = "dashboard" Then
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
            cmd.CommandText = "SELECT * from item_borrowed where id = @id"
            cmd.Parameters.AddWithValue("@id", id)
            mySQLReader = cmd.ExecuteReader

            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    itemId = mySQLReader!item_id
                    txtItemName.Text = getItemNameById(mySQLReader!item_id)
                    quantity = mySQLReader!quantity
                    Dim date1 As Date = mySQLReader!borrowed_date
                    dateBorrowed = date1.ToString("MMMM d, yyyy")
                    txtTransactionBy.Text = mySQLReader!borrowed_by
                    txtReason.Text = mySQLReader!reason
                End While
            End If

            cmd.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If
    End Sub

    Private Sub ProceedReturn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ReturnItem.btnReturnItem.Enabled = False
        ReturnItem.datagridBorrowed.ClearSelection()
        Main_Form.datagridInventoryDues.ClearSelection()
        Main_Form.datagridInventoryOverdues.ClearSelection()

        action = ""

        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub
    Private Function getItemNameById(ByVal id As Integer) As String
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
        End Select

        Dim itemName As String = ""
        Dim cmd As MySqlCommand
        Dim mySQLReader As MySqlDataReader
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT item_name from item_list where item_id = @itemid"
        cmd.Parameters.AddWithValue("@itemid", id)
        mySQLReader = cmd.ExecuteReader

        If mySQLReader.HasRows Then
            While mySQLReader.Read
                itemName = mySQLReader!item_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        Return itemName
    End Function

    Private Sub txtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTransactionBy.KeyDown, txtQuantity.KeyDown, txtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnReturnItem_Click(sender As Object, e As EventArgs) Handles btnReturnItem.Click
        If CInt(txtQuantity.Text) > quantity Then
            MsgBox("You can't return items more than what is borrowed!" + vbCrLf + "Items borrowed: " + quantity.ToString, vbCritical, "Warning")
            Exit Sub
        End If
        Dim borrowDate As Date = Date.ParseExact(dateBorrowed, "MMMM d, yyyy", CultureInfo.InvariantCulture)
        If dateReturned.Value.Date < borrowDate Then
            MsgBox("Please provide a valid return date" + quantity.ToString, vbCritical, "Warning")
            Exit Sub
        End If


        Dim newStocks As Integer
        Dim status As String
        Dim remainingStocks As Integer = getStockItems()
        If comboItemState.SelectedIndex = 0 Then
            newStocks = remainingStocks + CInt(txtQuantity.Text)
        Else
            newStocks = remainingStocks '- CInt(txtQuantity.Text)
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
        cmd.Parameters.AddWithValue("@transactiontype", "Returned")
        cmd.Parameters.AddWithValue("@itemstate", comboItemState.Text)
        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
        cmd.Parameters.AddWithValue("@transactionby", txtTransactionBy.Text)
        cmd.Parameters.AddWithValue("@date", dateReturned.Value.Date)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)

        cmd.ExecuteNonQuery()

        If newStocks = 0 Then
            status = "Unavailable"
        Else
            status = "Available"
        End If

        updateStock(status, newStocks)
        updateBorrowedItems()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Return Item [" & txtItemName.Text & "] quantity [" & txtQuantity.Text & "] to [" & txtTransactionBy.Text & "]")

        MsgBox("item Returned!", vbInformation, "Information")
        Me.Close()
        ReturnItem.txtSearchBorrowedItems.Text = "Search by item name or borrower"
        ReturnItem.btnSearchBorrowedItem.PerformClick()
        ReturnItem.btnReturnItem.Enabled = False
        ReturnItem.datagridBorrowed.ClearSelection()

        Main_Form.loadDashboardInventory(Main_Form.datagridInventoryDues, "dues")
        Main_Form.loadDashboardInventory(Main_Form.datagridInventoryOverdues, "overdues")

    End Sub


    '' '''''''''''''''''FUNCTION HELPERS'''''''''''''''''''''''''''''
    Private Sub updateBorrowedItems()
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
        Dim newQuantity = quantity - Val(txtQuantity.Text)

        If newQuantity = 0 Then
            cmd.CommandText = "DELETE FROM item_borrowed where id = @id"
        Else
            cmd.CommandText = "UPDATE item_borrowed SET quantity = @quantity where id = @id"
        End If
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@quantity", newQuantity)

        cmd.ExecuteNonQuery()


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
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
        cmd.Parameters.AddWithValue("@itemunusable", If(comboItemState.SelectedIndex > 0, getItemNumbers("unusable") + CInt(txtQuantity.Text), getItemNumbers("unusable")))
        cmd.Parameters.AddWithValue("@itemborrowed", getItemNumbers("borrowed") - CInt(txtQuantity.Text))

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
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