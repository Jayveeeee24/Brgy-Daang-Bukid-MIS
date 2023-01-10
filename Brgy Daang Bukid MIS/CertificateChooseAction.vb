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

Public Class CertificateChooseAction

    Private Sub CertificateChooseAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelFilePath.Text = Certificate_Setup.filePath
        labelFileName.Text = Certificate_Setup.fileName
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Certificate_Setup.openingWordDocument(Certificate_Setup.filePath)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Certificate_Setup.convertDocToImage(Certificate_Setup.filePath)
        Me.Close()
    End Sub

    Private Sub CertificateChooseAction_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Barangay Documents"
        If Directory.Exists(s) Then
            My.Computer.FileSystem.DeleteFile(s)
        End If
    End Sub
End Class