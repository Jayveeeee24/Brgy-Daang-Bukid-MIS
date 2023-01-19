Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Linq.Expressions
Imports System.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class Certificate_Setup


    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public action As String
    Public residentid As Integer
    Public residentName As String
    Public residentAddress As String
    Public complainantId1, complainantId2, respondentId1, respondentId2 As Integer
    Public complainant1, complainant2, respondent1, respondent2 As String

    Dim images As Image()
    Dim startPageIndex As Integer
    Dim endPageIndex As Integer
    Public fileName As String = ""
    Public filePath As String = ""

    Private Sub Certificate_Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)
        txtResidentName.Select()
        mainTabControl.SelectedIndex = 0
        datePickerSummon.Format = DateTimePickerFormat.Custom
        datePickerSummon.CustomFormat = "MMMM d, yyyy"
        comboTime.SelectedIndex = 12

        txtYearsResidency.Hide()
        labelYears.Hide()
        If action = "residency" Then
            labelCertificateType.Text = "BARANGAY RESIDENCY"
            txtYearsResidency.Show()
            labelYears.Show()
        ElseIf action = "summon" Then
            labelCertificateType.Text = "BARANGAY SUMMON"
            mainTabControl.SelectedIndex = 1
        ElseIf action = "clearance" Then
            labelCertificateType.Text = "BARANGAY CLEARANCE"
        ElseIf action = "indigency" Then
            labelCertificateType.Text = "BARANGAY INDIGENCY"

        End If
    End Sub
    Private Sub Certificate_Setup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        clearEverything()
    End Sub


    Private Sub clearEverything()
        action = ""
        residentid = 0
        residentAddress = ""
        residentName = ""
        txtResidentName.Clear()
        txtResidentPurpose.Clear()
        txtYearsResidency.Clear()
        txtComplainant1.Clear()
        txtComplainant2.Clear()
        txtRespondent1.Clear()
        txtRespondent2.Clear()
        txtCaseNo.Clear()
        datePickerSummon.Value = Date.Now
        complainantId1 = 0
        complainantId2 = 0
        respondentId1 = 0
        respondentId2 = 0
        complainant1 = ""
        complainant2 = ""
        respondent1 = ""
        respondent2 = ""
        comboTime.SelectedIndex = 12
        filePath = ""
        fileName = ""
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Barangay Documents"
        If Directory.Exists(s) Then
            System.IO.Directory.Delete(s, True)
        End If
    End Sub
    Private Sub btnSearchResident_Click(sender As Object, e As EventArgs) Handles btnSearchResident.Click
        Search_Residents.origin = "certificates"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnConfirmProcess_Click(sender As Object, e As EventArgs) Handles btnConfirmProcess.Click
        If residentid = 0 Then
            MsgBox("Please select a valid resident!", vbCritical, "Warning")
            Exit Sub
        End If
        Dim document As WordDocument = Nothing
        If action = "residency" Then
            If CInt(If(txtYearsResidency.Text = "", 0, txtYearsResidency.Text)) > 120 Then
                MsgBox("Please fill a valid year of residency!", vbCritical, "Warning")
                Exit Sub
            ElseIf txtYearsResidency.Text.Trim = "" Or txtResidentPurpose.Text.Trim = "" Then
                MsgBox("Please fill out the required fields!", vbCritical, "Warning")
                Exit Sub
            End If
            fileName = "Residency.docx"
            Dim documentFinal As New WordDocument(fileName)
            document = documentFinal
            document.Replace("[YEARS]", txtYearsResidency.Text, False, True)
        ElseIf action = "clearance" Then
            fileName = "Clearance.docx"
            Dim documentFinal As New WordDocument(fileName)
            document = documentFinal
        ElseIf action = "indigency" Then
            fileName = "Indigency.docx"
            Dim documentFinal As New WordDocument(fileName)
            document = documentFinal
        End If
        Dim monthNames() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim month As Integer = Date.Now.Month

        document.Replace("[FULL NAME]", residentName.ToString, False, True)
        document.Replace("[ADDRESS]", residentAddress.ToString, False, True)
        document.Replace("[PURPOSE]", txtResidentPurpose.Text, False, True)
        document.Replace("[DAY]", Date.Now.Day.ToString, False, True)
        document.Replace("[MONTH, YEAR]", monthNames(month - 1) & ", " & Date.Now.Year.ToString, False, True)

        document.Replace("[BARANGAY CAPTAIN]", getCaptainNameById(getBrgyCaptId).ToUpper, False, True)

        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Barangay Documents"
        If Not Directory.Exists(s) Then
            Directory.CreateDirectory(s)
        End If
        fileName = residentName.ToString & " " & fileName
        filePath = s & "\" & fileName
        document.Save(filePath)
        document.Close()
        CertificateChooseAction.ShowDialog()
        Me.Close()
    End Sub
    Private Function getCaptainNameById(ByVal captainId As Integer) As String

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

        Dim captainName As String = ""
        cmd.CommandText = "SELECT first_name, middle_name, last_name, ext_name from residents where resident_id = @searchvalue"
        cmd.Parameters.AddWithValue("@searchvalue", captainId)
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                Dim middle, ext As String
                If mySQLReader!middle_name = Nothing Then
                    middle = ""
                Else
                    middle = mySQLReader!middle_name + " "
                End If
                captainName = mySQLReader!first_name + " " + middle + mySQLReader!last_name + " " + mySQLReader!ext_name
            End While
        End If

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return captainName
    End Function
    Private Function getBrgyCaptId() As Integer

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

        Dim captainId As Integer
        cmd.CommandText = "SELECT official_name from brgyofficials where official_position = 'Barangay Captain'"
        mySQLReader = cmd.ExecuteReader
        If mySQLReader.HasRows Then
            While mySQLReader.Read
                captainId = mySQLReader!official_name
            End While
        End If


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        Return captainId
    End Function

    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtResidentPurpose.KeyDown, txtResidentName.KeyDown, txtRespondent2.KeyDown, txtRespondent1.KeyDown, txtComplainant2.KeyDown, txtComplainant1.KeyDown, txtCaseNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYearsResidency.KeyPress
        checkInputNumbersOnly(e)
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

    Private Sub btnConfirmSummon_Click(sender As Object, e As EventArgs) Handles btnConfirmSummon.Click
        If txtCaseNo.Text.Trim = "" Then
            MsgBox("Please fill a valid case no!", vbCritical, "Warning")
            Exit Sub
        ElseIf complainantId1 = 0 Or respondentId1 = 0 Then
            MsgBox("Please select a valid main complainant and respondent!", vbCritical, "Warning")
            Exit Sub
        ElseIf complainantId2 = 0 And txtComplainant2.Text.Trim <> "" Then
            MsgBox("Please select a valid second complainant!", vbCritical, "Warning")
            Exit Sub
        ElseIf respondentId2 = 0 And txtRespondent2.Text.Trim <> "" Then
            MsgBox("Please select a valid second respondent!", vbCritical, "Warning")
            Exit Sub
        ElseIf datePickerSummon.Value < Date.Now.Date Then
            MsgBox("Please select a valid date!", vbCritical, "Warning")
            Exit Sub
        End If
        Dim document As New WordDocument("Summon.docx")

        Dim monthNames() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim month As Integer = Date.Now.Month

        document.Replace("[CASE NO]", txtCaseNo.Text, False, True)
        document.Replace("[COMPLAINANT 1]", complainant1, False, True)
        document.Replace("[COMPLAINANT 2]", If(complainant2 = "", "", complainant2), False, True)
        document.Replace("[RESPONDENT 1]", respondent1, False, True)
        document.Replace("[RESPONDENT 2]", If(respondent2 = "", "", respondent2), False, True)
        Dim dateSummon As Date = datePickerSummon.Value
        document.Replace("[DAY SUMMON]", dateSummon.Day.ToString, False, True)
        document.Replace("[MONTH, YEAR SUMMON]", monthNames(dateSummon.Month - 1) & ", " & dateSummon.Year.ToString, False, True)
        document.Replace("[TIME]", comboTime.Text, False, True)

        document.Replace("[DAY]", Date.Now.Day.ToString, False, True)
        document.Replace("[MONTH, YEAR]", monthNames(month - 1) & ", " & Date.Now.Year.ToString, False, True)

        document.Replace("[BARANGAY CAPTAIN]", getCaptainNameById(getBrgyCaptId).ToUpper, False, True)

        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Barangay Documents"
        If Not Directory.Exists(s) Then
            Directory.CreateDirectory(s)
        End If
        fileName = "Case No. " & txtCaseNo.Text & " Summon.docx"
        filePath = s & "\" & fileName
        document.Save(filePath)
        document.Close()
        CertificateChooseAction.ShowDialog()
        Me.Close()
    End Sub

    Public Sub openingWordDocument(ByVal filePath As String)
        Dim oWord As Application
        Dim oDoc As Document
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add(filePath)
    End Sub

    Public Sub convertDocToImage(ByVal filePath As String)
        'Loads an existing Word document into DocIO instance
        Dim document As New WordDocument(filePath)
        images = document.RenderAsImages(ImageType.Metafile)
        'Closes the Word Document
        document.Close()

        endPageIndex = images.Length
        'Creates new PrintDialog instance
        Dim printDialog As New System.Windows.Forms.PrintDialog()
        'Sets new PrintDocument instance to print dialog
        printDialog.Document = New PrintDocument()
        'Enables the print current page option
        printDialog.AllowCurrentPage = True
        'Enables the print selected pages option
        printDialog.AllowSomePages = True
        'Sets the start and end page index
        printDialog.PrinterSettings.FromPage = 1
        printDialog.PrinterSettings.ToPage = images.Length
        'Opens the print dialog box
        If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'Checks whether the selected page range is valid or not
            If printDialog.PrinterSettings.FromPage > 0 AndAlso printDialog.PrinterSettings.ToPage <= images.Length Then
                'Updates the start page of the document to print
                startPageIndex = printDialog.PrinterSettings.FromPage - 1
                'Updates the end page of the document to print
                endPageIndex = printDialog.PrinterSettings.ToPage
                'Hooks the PrintPage event to handle the drawing pages for printing
                AddHandler printDialog.Document.PrintPage, New PrintPageEventHandler(AddressOf PrintPageMethod)
                'Prints the document
                printDialog.Document.Print()
            End If
        End If
    End Sub

    Private Sub PrintPageMethod(sender As Object, e As PrintPageEventArgs)
        'Gets the print start page width
        Dim currentPageWidth As Integer = images(startPageIndex).Width
        'Gets the print start page height
        Dim currentPageHeight As Integer = images(startPageIndex).Height
        'Gets the visible bounds width for print
        Dim visibleClipBoundsWidth As Integer = CInt(e.Graphics.VisibleClipBounds.Width)
        'Gets the visible bounds height for print
        Dim visibleClipBoundsHeight As Integer = CInt(e.Graphics.VisibleClipBounds.Height)
        'Checks whether the page layout is landscape or portrait
        If currentPageWidth > currentPageHeight Then
            'Translates the position
            e.Graphics.TranslateTransform(0, visibleClipBoundsHeight)
            'Rotates the object at 270 degrees
            e.Graphics.RotateTransform(270.0F)
            'Draws the current page image
            e.Graphics.DrawImage(images(startPageIndex), New System.Drawing.Rectangle(0, 0, currentPageWidth, currentPageHeight))
        Else
            'Draws the current page image
            e.Graphics.DrawImage(images(startPageIndex), New System.Drawing.Rectangle(0, 0, visibleClipBoundsWidth, visibleClipBoundsHeight))
        End If
        'Disposes the current page image after drawing
        images(startPageIndex).Dispose()
        'Increments the start page index
        startPageIndex += 1
        'Updates whether the document contains some more pages to print
        If startPageIndex < endPageIndex Then
            e.HasMorePages = True
        Else
            startPageIndex = 0
        End If
    End Sub

    Private Sub btnSearchComplainant1_Click(sender As Object, e As EventArgs) Handles btnSearchComplainant1.Click
        Search_Residents.origin = "complainant1"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchComplainant2_Click(sender As Object, e As EventArgs) Handles btnSearchComplainant2.Click
        Search_Residents.origin = "complainant2"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchRespondent1_Click(sender As Object, e As EventArgs) Handles btnSearchRespondent1.Click
        Search_Residents.origin = "respondent1"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchRespondent2_Click(sender As Object, e As EventArgs) Handles btnSearchRespondent2.Click
        Search_Residents.origin = "respondent2"
        Search_Residents.ShowDialog()
    End Sub
End Class