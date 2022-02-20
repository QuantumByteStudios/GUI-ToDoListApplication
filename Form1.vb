Public Class Form1

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click


        If (GetTaskInput.Text = "" Or GetTaskInput.Text = " ") Then
            MessageBox.Show("Tasks Cannot Be Empty!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TaskListbox.Items.Add(GetTaskInput.Text)
            GetTaskInput.Text = ""
            MessageBox.Show("Task Added!")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles removeSelectedBtn.Click
        TaskListbox.Items.Remove(TaskListbox.SelectedItem)
    End Sub

    Private Sub removeAllBtn_Click(sender As Object, e As EventArgs) Handles removeAllBtn.Click
        TaskListbox.Items.Clear()
    End Sub
End Class
