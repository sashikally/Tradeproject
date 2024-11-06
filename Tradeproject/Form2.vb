Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim connectionString As String = "Server=localhost;Database=BabyToiletriesDB;Uid=username;Pwd=password;"


        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If result > 0 Then
                        MessageBox.Show("Login successful!")
                        Dim mainForm As New Form4()
                        mainForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim mainmenu As New Form1()
        mainmenu.Show()
        Me.Close()
    End Sub
End Class
