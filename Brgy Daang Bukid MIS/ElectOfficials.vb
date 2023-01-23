

Imports MySql.Data.MySqlClient

Public Class ElectOfficials
    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public brgyCaptainId, kagawadId1, kagawadId2, kagawadId3, kagawadId4, kagawadId5, kagawadId6, kagawadId7 As Integer
    Public brgyCaptain, kagawad1, kagawad2, kagawad3, kagawad4, kagawad5, kagawad6, kagawad7 As String

    Private Sub ElectOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ElectOfficials_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Controls.Clear()
        Me.InitializeComponent()

        brgyCaptainId = 0
        kagawadId1 = 0
        kagawadId2 = 0
        kagawadId3 = 0
        kagawadId4 = 0
        kagawadId5 = 0
        kagawadId6 = 0
        kagawadId7 = 0

        brgyCaptain = ""
        kagawad1 = ""
        kagawad2 = ""
        kagawad3 = ""
        kagawad4 = ""
        kagawad5 = ""
        kagawad6 = ""
        kagawad7 = ""
    End Sub

    Private Sub txtView_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKagawad7.KeyDown, txtKagawad6.KeyDown, txtKagawad5.KeyDown, txtKagawad4.KeyDown, txtKagawad3.KeyDown, txtKagawad2.KeyDown, txtKagawad1.KeyDown, txtBarangayCaptain.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKagawad7.KeyPress, txtKagawad6.KeyPress, txtKagawad5.KeyPress, txtKagawad4.KeyPress, txtKagawad3.KeyPress, txtKagawad2.KeyPress, txtKagawad1.KeyPress, txtBarangayCaptain.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnAppointOfficial_Click(sender As Object, e As EventArgs) Handles btnAppointOfficial.Click
        If brgyCaptainId = 0 Or txtBarangayCaptain.Text.Trim <> brgyCaptain Then
            MsgBox("Please provide a valid resident as Barangay Captain!", vbCritical, "Warning")
            Exit Sub
        End If
        If kagawadId1 = 0 Or txtKagawad1.Text.Trim <> kagawad1 Or kagawadId2 = 0 Or txtKagawad2.Text.Trim <> kagawad2 Or kagawadId3 = 0 Or txtKagawad3.Text.Trim <> kagawad3 Or kagawadId4 = 0 Or txtKagawad4.Text.Trim <> kagawad4 Or kagawadId5 = 0 Or txtKagawad5.Text.Trim <> kagawad5 Or kagawadId6 = 0 Or txtKagawad6.Text.Trim <> kagawad6 Or kagawadId7 = 0 Or txtKagawad7.Text.Trim <> kagawad7 Then
            MsgBox("Please provide a valid resident as Barangay Kagawad!", vbCritical, "Warning")
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

        cmd.CommandText = "INSERT INTO brgyofficials (id, official_name, official_position) VALUES (@id, @officialname, @officialposition)"
        cmd.Parameters.AddWithValue("@id", 1)
        cmd.Parameters.AddWithValue("@officialname", brgyCaptainId)
        cmd.Parameters.AddWithValue("@officialposition", "Barangay Captain")

        cmd.ExecuteNonQuery()


        electKagawad(7, kagawadId1)
        electKagawad(8, kagawadId2)
        electKagawad(9, kagawadId3)
        electKagawad(10, kagawadId4)
        electKagawad(11, kagawadId5)
        electKagawad(12, kagawadId6)
        electKagawad(13, kagawadId7)


        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
        MsgBox("Officials Elected!")
        Me.Close()
        UpdateBrgyOfficials.btnElectOfficials.Enabled = False
        UpdateBrgyOfficials.loadDatagrid()

    End Sub
    Private Sub electKagawad(ByVal id As Integer, ByVal officialName As Integer)
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

        cmd.CommandText = "INSERT INTO brgyofficials (id, official_name, official_position) VALUES (@id, @officialname, @officialposition)"
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@officialname", officialName)
        cmd.Parameters.AddWithValue("@officialposition", "Barangay Kagawad")
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub

    Private Sub btnSearchCaptain_Click(sender As Object, e As EventArgs) Handles btnSearchCaptain.Click
        Search_Residents.origin = "captain"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad1_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad1.Click
        Search_Residents.origin = "kagawad1"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad2_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad2.Click
        Search_Residents.origin = "kagawad2"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad3_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad3.Click
        Search_Residents.origin = "kagawad3"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad4_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad4.Click
        Search_Residents.origin = "kagawad4"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad5_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad5.Click
        Search_Residents.origin = "kagawad5"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad6_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad6.Click
        Search_Residents.origin = "kagawad6"
        Search_Residents.ShowDialog()
    End Sub
    Private Sub btnSearchKagawad7_Click(sender As Object, e As EventArgs) Handles btnSearchKagawad7.Click
        Search_Residents.origin = "kagawad7"
        Search_Residents.ShowDialog()
    End Sub


End Class