Imports System.Globalization
Imports Microsoft.SqlServer.Server
Imports MySql.Data.MySqlClient

Public Class ViewInventory
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"

    Public action As String
    Public itemId As Integer

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        'clearEverything()

        'loadInitialData()
    End Sub
    Private Sub ViewInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'clearEverything()
    End Sub
    Private Sub ViewInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If action = "add" Then
            If txtItemName.Text.Trim <> "" Or txtItemStock.Text.Trim <> "" Or txtRemarks.Text.Trim <> "" Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        ElseIf action = "stock" Then
            If txtStockItemName.Text.Trim <> "" Or txtQuantity.Text.Trim <> "" Or txtReason.Text.Trim <> "" Or txtTransactionBy.Text.Trim <> Then
                If MsgBox("Your current progress will not be saved!", MsgBoxStyle.OkCancel, "Are you sure to exit?") = MsgBoxResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub


    'Private Sub loadInitialData()
    '    txtCaseName.Select()
    '    mainTabControl.SelectedIndex = 0


    '    If action = "add" Then
    '        mainTabControl.SelectedIndex = 1
    '        txtCaseId.Hide()
    '        labelId.Hide()
    '    End If

    '    If mainTabControl.SelectedIndex = 0 Then
    '        Dim mySql As MySqlConnection
    '        mySql = New MySqlConnection(mySqlConn)
    '        On Error Resume Next
    '        mySql.Open()

    '        Select Case Err.Number
    '            Case 0
    '            Case Else
    '                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
    '        End Select

    '        Dim cmd As MySqlCommand
    '        Dim mySQLReader As MySqlDataReader
    '        cmd = mySql.CreateCommand()
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandText = "SELECT * FROM vawc where case_id = @caseid"
    '        cmd.Parameters.AddWithValue("@caseid", caseId)
    '        mySQLReader = cmd.ExecuteReader

    '        If mySQLReader.HasRows Then
    '            While mySQLReader.Read
    '                labelCaseId.Text = mySQLReader!case_id
    '                labelCaseName.Text = mySQLReader!case_name

    '                If IsNumeric(mySQLReader!victim) Then
    '                    victim = getResidentNameById(mySQLReader!victim)
    '                    clickableVictim = True
    '                    victimId = mySQLReader!victim
    '                    labelVictim.ForeColor = Color.Blue
    '                Else
    '                    victim = mySQLReader!victim
    '                    clickableVictim = False
    '                    labelVictim.ForeColor = Color.Black
    '                End If
    '                labelVictim.Text = victim

    '                If IsNumeric(mySQLReader!suspect) Then
    '                    suspect = getResidentNameById(mySQLReader!suspect)
    '                    clickableSuspect = True
    '                    suspectId = mySQLReader!suspect
    '                    labelSuspect.ForeColor = Color.Blue
    '                Else
    '                    suspect = mySQLReader!suspect
    '                    clickableSuspect = False
    '                    labelSuspect.ForeColor = Color.Black
    '                End If
    '                labelSuspect.Text = suspect

    '                If IsNumeric(mySQLReader!submitted_by) Then
    '                    submittedBy = getResidentNameById(mySQLReader!submitted_by)
    '                    clickableSubmittedBy = True
    '                    submittedById = mySQLReader!submitted_by
    '                    labelSubmittedBy.ForeColor = Color.Blue
    '                Else
    '                    submittedBy = mySQLReader!submitted_by
    '                    clickableSubmittedBy = False
    '                    labelSubmittedBy.ForeColor = Color.Black
    '                End If
    '                labelSubmittedBy.Text = submittedBy


    '                labelRelationship.Text = mySQLReader!relationship
    '                labelCaseStatus.Text = mySQLReader!case_status
    '                Dim date1 As Date = mySQLReader!submitted_on
    '                labelSubmittedOn.Text = date1.ToString("MMMM d, yyyy")
    '                labelCaseDetails.Text = mySQLReader!case_details


    '            End While
    '        End If


    '        cmd.Dispose()
    '        mySql.Close()
    '        mySql.Dispose()
    '    End If
    '    Dim tempdate As Date = Date.Now
    '    datePickerSubmittedOn.Value = tempdate
    '    comboCaseStatus.SelectedIndex = comboCaseStatus.FindStringExact("Ongoing")

    '    txtCaseName.Enabled = True
    '    txtVictim.Enabled = True
    '    txtSuspect.Enabled = True
    '    datePickerSubmittedOn.Enabled = True
    '    panelSearchParent.Show()
    '    btnSearchSubmittedBy.Show()


    'End Sub



End Class