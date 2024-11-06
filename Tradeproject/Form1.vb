Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginform As New Form2()
        loginform.Show()
        Me.Hide()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Registerform As New Form3()
        Registerform.Show()
        Me.Hide()
    End Sub
End Class
