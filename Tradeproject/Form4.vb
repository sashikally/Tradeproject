Imports MySql.Data.MySqlClient

Public Class Form4

    Dim connectionString As String = "Server=localhost;Database=BabyToiletriesDB;Uid=username;Pwd=password;"


    Private Sub LoadInventoryData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM inventory"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()


                adapter.Fill(table)
                dgvinventory.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                For Each row As DataGridViewRow In dgvinventory.Rows
                    If row.IsNewRow Then
                        Continue For
                    End If


                    Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
                    Dim itemName As String = Convert.ToString(row.Cells("item_name").Value)
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)
                    Dim price As Decimal = Convert.ToDecimal(row.Cells("price").Value)


                    Dim query As String = "UPDATE inventory SET item_name = @item_name, quantity = @quantity, price = @price WHERE id = @id"
                    Using command As New MySqlCommand(query, connection)

                        command.Parameters.AddWithValue("@id", id)
                        command.Parameters.AddWithValue("@item_name", itemName)
                        command.Parameters.AddWithValue("@quantity", quantity)
                        command.Parameters.AddWithValue("@price", price)

                        command.ExecuteNonQuery()
                    End Using
                Next

                MessageBox.Show("Inventory updated successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating inventory: " & ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
