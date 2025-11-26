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

        Dim frm As New frmModify
        frmModify.CustomerId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value)
        If frm.ShowDialog() = DialogResult.OK Then
            CustomersTableAdapter.Fill(RepairServicesDataSet.Customers)
        End If
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCustomerToolStripMenuItem.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim CustId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value)
            If cust.Delete(CustId) Then
                dgvCustomers.DataSource = cust.Items
                MessageBox.Show("Customer Deleted")
            Else
                MessageBox.Show("Customer Not Deleted")
            End If
        End If
    End Sub
End Class
