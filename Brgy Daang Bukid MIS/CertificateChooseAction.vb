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
        labelFileName.Text = "File Name: " & Main_Form.fileName
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Main_Form.openingWordDocument(Main_Form.filePath)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Main_Form.convertDocToImage(Main_Form.filePath)
    End Sub

End Class