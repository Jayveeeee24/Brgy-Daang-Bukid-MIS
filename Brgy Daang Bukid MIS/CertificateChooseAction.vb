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
        labelFileName.Text = "File Name: " & Certificate_Setup.fileName
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Certificate_Setup.openingWordDocument(Certificate_Setup.filePath)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Certificate_Setup.convertDocToImage(Certificate_Setup.filePath)
    End Sub

End Class