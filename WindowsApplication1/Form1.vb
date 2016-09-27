Public Class Form1

    Private taskName As String = ""


    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

        If String.IsNullOrEmpty(taskName) Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.DodgerBlue
        End If
        Debug.WriteLine("Enter")

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        taskName = TextBox1.Text

        If String.IsNullOrEmpty(taskName) Then
            TextBox1.Text = "¿Que planes para hoy?"
            TextBox1.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not cbTask1.Visible Then
            cbTask1.Visible = True
            lblTask1.Visible = True
            lblTask1.Text = TextBox1.Text
            TextBox1.Text = "¿Que planes para hoy?"
            TextBox1.ForeColor = Color.Silver
            taskName = ""
            Exit Sub
        End If

        If Not cbTask2.Visible Then
            cbTask2.Visible = True
            lblTask2.Visible = True
            lblTask2.Text = TextBox1.Text
            TextBox1.Text = "¿Que planes para hoy?"
            TextBox1.ForeColor = Color.Silver
            taskName = ""
            Exit Sub
        End If

        If Not cbTask3.Visible Then
            cbTask3.Visible = True
            lblTask3.Visible = True
            lblTask3.Text = TextBox1.Text
            TextBox1.Text = "¿Que planes para hoy?"
            TextBox1.ForeColor = Color.Silver
            taskName = ""
            Exit Sub
        End If

        If Not cbTask4.Visible Then
            cbTask4.Visible = True
            lblTask4.Visible = True
            lblTask4.Text = TextBox1.Text
            TextBox1.Text = "¿Que planes para hoy?"
            TextBox1.ForeColor = Color.Silver
            taskName = ""
            Exit Sub
        End If

    End Sub
End Class
