Public Class frmModify
    Public Property CustomerId As Short
    Dim cust As New Customers
    Private Sub frmModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As RepairServicesDataSet.CustomersRow = cust.FindById(CustomerId)
        lblCustomerId.text = row.CustId.ToString()
        txtName.Text = row.Name
        txtPhone.Text = row.Phone

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class