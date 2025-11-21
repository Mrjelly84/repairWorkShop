Public Class frmCustomer


    Private cust As New Customers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepairServicesDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.RepairServicesDataSet.Customers)

    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        If dgvCustomers.SelectedRows.count = 0 Then
            lblStatus.Text = "Please select a row to edit"
            Return
        End If

        Dim frm As New
    End Sub
End Class
