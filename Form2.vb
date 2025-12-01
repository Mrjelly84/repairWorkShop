Public Class Form2
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cust As New Customers
        Dim custId As Short = cust.NextCustomerID

        If cust.PhoneNumberDuplicate(custId, txtPhone.Text) Then
            errProvider.SetError(txtPhone, "This phone number belongs to anther customer. Please enter another number.")
        Else
            errProvider.set(txtPhone, "")
            If cust.Insert(custId, txtName.Text, txtPhone.Text) Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End If
    End Sub
End Class