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

    Public Shared Function CombineDateTime(aDate As DateTime, aTime As DateTime) As DateTime
        Dim ts As New TimeSpan(aTime.Hour, aTime.Minute, 0)
        Return aDate.Add(ts)
    End Function

    Public Function Insert(typeId As Short, description As String, licensed As Boolean, custId As Short,
                           scheduled As DateTime) As Boolean

        Try
            adapter.Insert(typeId, description, licensed, custId, scheduled)
            Return True
        Catch ex As Exception
            LastError = "Failed To Insert New Customer. Reason: " & ex.Message
            Return False
        End Try


    End Function

End Class
