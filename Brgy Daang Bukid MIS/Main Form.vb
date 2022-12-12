Public Class Main_Form
    Public account_type As String
    Dim isClicked As Boolean = False

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If splitContainerMain.SplitterDistance > 60 Then
            timerOpen.Enabled = True
        Else
            timerClose.Enabled = True
        End If
    End Sub

    Private Sub timerOpen_Tick(sender As Object, e As EventArgs) Handles timerOpen.Tick
        If splitContainerMain.SplitterDistance > 60 Then
            splitContainerMain.SplitterDistance = 50
            panelLogo.Size = New Size(50, 45)
            panelLogo.Padding = New Padding(2, 5, 2, 5)
            picLogo.Size = New Size(40, 35)
        Else
            timerOpen.Enabled = False
        End If
    End Sub

    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles timerClose.Tick
        If splitContainerMain.SplitterDistance < 60 Then
            splitContainerMain.SplitterDistance = 250
            panelLogo.Size = New Size(250, 245)
            panelLogo.Padding = New Padding(20, 20, 20, 20)
            picLogo.Size = New Size(250, 245)
        Else
            timerClose.Enabled = False
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class