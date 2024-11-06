Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim connectionString As String = "Server=localhost;Database=BabyToiletriesDB;Uid=username;Pwd=password;"


        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO users (username, password) VALUES (@username, @password)"
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)  ' 

                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful!")


                Dim inventoryForm As New Form4()
                inventoryForm.Show()
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving to the database: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim mainmenu As New Form1()
        mainmenu.Show()
        Me.Close()
    End Sub
End Class
