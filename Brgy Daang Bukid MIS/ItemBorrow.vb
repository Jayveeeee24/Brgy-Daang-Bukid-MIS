Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class ItemBorrow
    Public mySqlConn As String = My.Resources.constring

    Public action As String
    Public itemId As Integer
    Dim isSaved As Boolean = False
    Private Sub ItemBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        datePickerBorrowed.Format = DateTimePickerFormat.Custom
        datePickerBorrowed.CustomFormat = "MMMM d, yyyy"

        dateReturn.Format = DateTimePickerFormat.Custom
        dateReturn.CustomFormat = "MMMM d, yyyy"
    End Sub
    Private Sub ItemBorrow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        Main_Form.btnInventory.PerformClick()
    End Sub
    Private Sub ItemBorrow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isSaved = False Then
            If txtStockItemName.Text.Trim <> "" Or txtQuantity.Text.Trim <> "" Or txtReason.Text.Trim <> "" Or txtTransactionBy.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnSearchTransactionBy_Click(sender As Object, e As EventArgs) Handles btnSearchTransactionBy.Click
        Search_Residents.origin = "transactBy"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnBorrowItem_Click(sender As Object, e As EventArgs) Handles btnBorrowItem.Click
        If itemId = 0 Or txtStockItemName.Text.Trim = "" Then
            MsgBox("Please select a valid item!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtQuantity.Text.Trim = "" Or txtQuantity.Text = "0" Then
            MsgBox("Please provide a valid quantity!", vbCritical, "Warning")
            Exit Sub
        End If
        If txtTransactionBy.Text.Trim = "" Then
            MsgBox("Please provide a provide a valid person transacted!", vbCritical, "Warning")
            Exit Sub
        End If
        If datePickerBorrowed.Value.Date > Date.Now.Date Then
            MsgBox("Please provide a valid borrowed date!", vbCritical, "Warning")
            Exit Sub
        End If
        If dateReturn.Value.Date < Date.Now.Date Then
            MsgBox("Please provide a valid return date!", vbCritical, "Warning")
            Exit Sub
        End If

        Dim newStocks As Integer
        Dim status As String
        Dim remainingStocks As Integer = getStockItems()
        newStocks = remainingStocks - CInt(txtQuantity.Text)
        If remainingStocks < CInt(txtQuantity.Text) Then
            MsgBox("You can't borrow items more than the remaining stocks!", vbCritical, "Warning")
            Exit Sub
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
        cmd.Parameters.AddWithValue("@transactiontype", "Borrowed")
        cmd.Parameters.AddWithValue("@itemstate", "Good")
        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text)
        cmd.Parameters.AddWithValue("@transactionby", txtTransactionBy.Text)
        cmd.Parameters.AddWithValue("@date", dateReturn.Value.Date)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        updateStock(status, newStocks)
        updateBorrowedItems()

        MsgBox("Item Borrowed!", vbInformation, "Information")
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

        cmd.CommandText = "UPDATE item_list SET item_stock = @itemstock, item_status = @itemstatus, item_borrowed = @itemborrowed where item_id = @itemid"

        cmd.Parameters.AddWithValue("@itemid", itemId)
        cmd.Parameters.AddWithValue("@itemstock", stock)
        cmd.Parameters.AddWithValue("@itemstatus", status)
        cmd.Parameters.AddWithValue("@itemborrowed", getItemNumbers("borrowed") + CInt(txtQuantity.Text))


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
        cmd.CommandText = "INSERT INTO item_borrowed (item_id, quantity, borrowed_date, return_date, borrowed_by, reason) values (@itemid, @quantity, @borroweddate, @returndate, @borrowedby, @reason)"

        cmd.Parameters.AddWithValue("@itemid", itemId)
        cmd.Parameters.AddWithValue("@quantity", CInt(txtQuantity.Text))
        cmd.Parameters.AddWithValue("@borroweddate", datePickerBorrowed.Value.Date)
        cmd.Parameters.AddWithValue("@returndate", dateReturn.Value.Date)
        cmd.Parameters.AddWithValue("@borrowedby", txtTransactionBy.Text)
        cmd.Parameters.AddWithValue("@reason", txtReason.Text)

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

        addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Lend item [" & txtStockItemName.Text & "] quantity [" & txtQuantity.Text & "] to [" & txtTransactionBy.Text & "]")
    End Sub


End Class