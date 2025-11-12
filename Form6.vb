Public Class Form6
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim frm As New Form5
        If frm.ShowDialog() = DialogResult.OK Then
            Form5.ShowDialog()
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim frm As New Form1
        If frm.ShowDialog() = DialogResult.OK Then
            Form1.ShowDialog()
        End If
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Form1.ShowDialog()

    End Sub
End Class