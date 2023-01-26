Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ViewInventory
    Public mySqlConn As String = My.Resources.constring

    Public action As String
    Public itemId As Integer
    Dim isSaved As Boolean = False

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

        loadInitialData()
    End Sub
    Private Sub ViewInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()
        Main_Form.btnItemDataManagement.PerformClick()
    End Sub

    Private Sub loadInitialData()
        mainTabControl.SelectedIndex = 0

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
                    labelItemStatus.Text = If(mySQLReader!item_status = "Unavailable" And mySQLReader!item_reason <> "", mySQLReader!item_status + " (" + mySQLReader!item_reason + ")", mySQLReader!item_status)
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
        getItemHistory()

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
                Dim date1 As Date = mySQLReader!date
                dataGridItemHistory.Rows.Add(New String() {getItemNameById(mySQLReader!id), If(mySQLReader!item_state <> "Good", mySQLReader!transaction_type + "(" + mySQLReader!item_state + ")", mySQLReader!transaction_type), mySQLReader!quantity, mySQLReader!transaction_by, date1.ToString("MMMM d, yyyy"), mySQLReader!reason})
            End While
        End If
        dataGridItemHistory.ClearSelection()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
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
        cmd.Parameters.AddWithValue("@itemid", itemId)
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