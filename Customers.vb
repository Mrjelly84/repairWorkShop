Imports System.Diagnostics.Eventing.Reader

Public Class Customers
    Private adapter As New RepairServicesDataSetTableAdapters.CustomersTableAdapter
    Public Shared LastError As String
    Dim origCustomerRow As RepairServicesDataSet.CustomersRow

    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property

    Public ReadOnly Property NextCustomerID As Short
        Get
            Dim lastCustId As Short = adapter.GetlastCustId()
            Const INCREMENT_VALUE As Short = 10
            If lastCustId = 0 Then
                Return 1000
            Else
                Return lastCustId + INCREMENT_VALUE
            End If

        End Get
    End Property
End Class
