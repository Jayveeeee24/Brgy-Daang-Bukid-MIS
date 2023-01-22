Imports System.Linq.Expressions
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class SearchItems

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Private Sub SearchItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridItems.Rows.Clear()
        txtSearchitems.Text = "Search by item name"
        btnSearchItems.PerformClick()
    End Sub
    Private Sub SearchItems_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        datagridItems.Rows.Clear()
    End Sub
    Private Sub txtSearchitems_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchitems.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchItems.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtSearchitems_Click(sender As Object, e As EventArgs) Handles txtSearchitems.Click
        If txtSearchitems.Text = "Search by item name" Then
            txtSearchitems.Clear()
        End If
    End Sub

    Private Sub btnSearchItems_Click(sender As Object, e As EventArgs) Handles btnSearchItems.Click
        datagridItems.Rows.Clear()


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
        If action = "borrow" Or action = "Stock Out" Then
            cmd.CommandText = "SELECT item_id, item_name, item_status, item_stock from item_list where item_stock <> 0 AND item_name LIKE @searchvalue order by item_name asc limit 10"
        Else
            cmd.CommandText = "SELECT item_id, item_name, item_status, item_stock from item_list where item_name LIKE @searchvalue order by item_name asc limit 10"
        End If
        cmd.Parameters.AddWithValue("@searchvalue", txtSearchitems.Text.Trim & "%")
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                datagridItems.Rows.Add(New String() {mySQLReader!item_id, mySQLReader!item_name, mySQLReader!item_stock, mySQLReader!item_status})
            End While
        End If
        datagridItems.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub datagridItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridItems.CellClick
        If e.RowIndex >= 0 Then
            ViewInventory.itemId = datagridItems.Rows(e.RowIndex).Cells(0).Value
            ViewInventory.txtStockItemName.Text = datagridItems.Rows(e.RowIndex).Cells(1).Value
            Me.Close()
        End If
    End Sub

    Private Sub txtSearchitems_TextChanged(sender As Object, e As EventArgs) Handles txtSearchitems.TextChanged
        btnSearchItems.PerformClick()
    End Sub
End Class