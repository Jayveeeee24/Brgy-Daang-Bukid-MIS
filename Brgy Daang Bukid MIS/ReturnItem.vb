Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ReturnItem
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Private Sub ReturnItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadDatagrid()
    End Sub
    Private Sub ReturnItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        Main_Form.btnInventory.PerformClick()
    End Sub

    Public Sub loadDatagrid()
        txtSearchBorrowedItems.Select()

        datagridBorrowed.Rows.Clear()

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

        cmd.CommandText = "SELECT * from item_borrowed " & If(txtSearchBorrowedItems.Text.Trim = "" Or txtSearchBorrowedItems.Text.Trim = "Search by item name or borrower", "", " where item_id LIKE @itemid or borrowed_by like @borrowedby ") & " order by return_date desc"
        cmd.Parameters.AddWithValue("@itemid", getIdByItemName(txtSearchBorrowedItems.Text.Trim) & "%")
        cmd.Parameters.AddWithValue("@borrowedby", txtSearchBorrowedItems.Text.Trim & "%")
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim date1 As Date = mySQLReader!borrowed_date
                Dim date2 As Date = mySQLReader!return_date
                datagridBorrowed.Rows.Add(New String() {mySQLReader!id, mySQLReader!item_id, getItemNameById(mySQLReader!item_id), mySQLReader!quantity, date1.ToString("MMMM d, yyyy"), date2.ToString("MMMM d, yyyy"), mySQLReader!borrowed_by, mySQLReader!reason})
            End While
        End If
        datagridBorrowed.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()

    End Sub
    Private Sub txtSearchBorrowedItems_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchBorrowedItems.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearchBorrowedItem.PerformClick()
        End If
    End Sub
    Private Sub btnSearchBorrowedItem_Click(sender As Object, e As EventArgs) Handles btnSearchBorrowedItem.Click
        loadDatagrid()
    End Sub
    Private Sub btnReturnItem_Click(sender As Object, e As EventArgs) Handles btnReturnItem.Click
        ProceedReturn.ShowDialog()
    End Sub
    Private Sub datagridBorrowed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridBorrowed.CellClick
        If e.RowIndex >= 0 Then
            btnReturnItem.Enabled = True
            ProceedReturn.id = datagridBorrowed.Rows(e.RowIndex).Cells(0).Value
            ProceedReturn.itemId = datagridBorrowed.Rows(e.RowIndex).Cells(1).Value
            ProceedReturn.txtItemName.Text = datagridBorrowed.Rows(e.RowIndex).Cells(2).Value
            ProceedReturn.quantity = datagridBorrowed.Rows(e.RowIndex).Cells(3).Value
            ProceedReturn.dateBorrowed = datagridBorrowed.Rows(e.RowIndex).Cells(4).Value
            ProceedReturn.txtTransactionBy.Text = datagridBorrowed.Rows(e.RowIndex).Cells(6).Value
            ProceedReturn.txtReason.Text = datagridBorrowed.Rows(e.RowIndex).Cells(7).Value
        End If
    End Sub
    Private Sub txtSearchBorrowedItems_Click(sender As Object, e As EventArgs) Handles txtSearchBorrowedItems.Click
        If txtSearchBorrowedItems.Text.Trim = "Search by item name or borrower" Then
            txtSearchBorrowedItems.Clear()
        End If
    End Sub





    '' ''''''''''''''''FUNCTION HELPERS ''''''''''''''''''''''''
    Public Function getIdByItemName(ByVal name As String) As Integer

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

        cmd.CommandText = "SELECT item_id from item_list WHERE item_name like @name "
        cmd.Parameters.AddWithValue("@name", name & "%")

        Dim id As Integer
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                id = mySQLReader!item_id
                Exit While
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return id
    End Function
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

End Class