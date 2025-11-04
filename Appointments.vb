Public Class Appointments
    Private adapter As New RepairServicesDataSetTableAdapters.AppointmentListTableAdapter
    Public Shared LastError As String
    Dim origAppointment As RepairServicesDataSet.AppointmentListRow

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function GetByCustomerId(custId As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "CustId = " & custId
        Return table
    End Function
End Class
