Public Class Filter
    Public filterModule As String


    Private Sub Filter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        mainTabControl.ItemSize = New Size(0, 1)

        If filterModule = "Household" Then
            mainTabControl.SelectedTab = pageFilterHousehold
        End If


    End Sub

End Class