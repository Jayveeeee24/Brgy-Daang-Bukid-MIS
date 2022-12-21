Imports MySql.Data.MySqlClient

Public Class ViewResident

    Public mySqlConn As String = "server=localhost; user id=root; database=mis"
    Public resident_id As Integer

    Private Sub ViewResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)




    End Sub

End Class