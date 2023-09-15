Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text.Trim)
        TextBox1.Text = Label1.Text.Trim

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Word As String = ListBox1.Text
        If ListBox1.Items.Add(TextBox1.Text.Trim) = True Then
            MessageBox.Show("Item already exist")
        Else
            ListBox1.Items.Add(Word)

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Label1.CheckedChanged

        TextBox1.Text = Label1.Text.ToUpper
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Label2.CheckedChanged
        TextBox1.Text = Label1.Text.ToLower
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Label3.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Label4.CheckedChanged
        TextBox1.ForeColor = Color.Purple
    End Sub
End Class
