Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization

' ============================================================
'  Data classes for the PROFESSOR side.
'  Fill these from MySQL later; SampleData is only for preview.
' ============================================================
Public Class ProfessorInfo
    Public Property FullName As String
    Public Property RoleText As String = "PROFESSOR"
    Public Property Photo As Image            ' optional
End Class

Public Class TimeSlotItem
    Public Property TimeText As String        ' "9:00AM - 10:00AM"
    Public Property Department As String      ' "CS", "IT"
    Public Property Status As String          ' "Available" or "Booked"
End Class

Public Class ConsultItem
    Public Property StudentName As String
    Public Property Scheduled As DateTime
    Public Property Section As String         ' "BSIT 2C"
    Public Property Topic As String           ' "System Consultation"
    Public Property Status As String          ' Pending / Confirmed / Rejected / Cancelled

    Public ReadOnly Property DateText As String
        Get
            Return Scheduled.ToString("MMM d, yyyy", CultureInfo.InvariantCulture) & " (" &
                   Scheduled.ToString("h:mmtt", CultureInfo.InvariantCulture).ToLower() & ")"
        End Get
    End Property

    Public Function ToHistory(status As String) As HistoryItem
        Return New HistoryItem With {
            .Topic = Topic, .Scheduled = Scheduled, .Section = Section,
            .StudentName = StudentName, .Status = status}
    End Function
End Class

Public Class HistoryItem
    Public Property Topic As String
    Public Property Scheduled As DateTime
    Public Property Section As String
    Public Property StudentName As String
    Public Property Status As String          ' Done / Canceled / Rejected

    Public ReadOnly Property TimeText As String
        Get
            Return Scheduled.ToString("h:mm tt", CultureInfo.InvariantCulture)
        End Get
    End Property

    Public ReadOnly Property DateText As String
        Get
            Return Scheduled.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        End Get
    End Property
End Class

Public Module ProfSampleData
    Public Function GetProfessor() As ProfessorInfo
        Return New ProfessorInfo With {.FullName = "MARLON SANTIAGO"}
    End Function

    Public Function GetSlots() As List(Of TimeSlotItem)
        Return New List(Of TimeSlotItem) From {
            New TimeSlotItem With {.TimeText = "9:00AM - 10:00AM", .Department = "CS", .Status = "Available"},
            New TimeSlotItem With {.TimeText = "10:00AM - 11:00AM", .Department = "IT", .Status = "Available"},
            New TimeSlotItem With {.TimeText = "1:00PM - 2:00PM", .Department = "CS", .Status = "Booked"},
            New TimeSlotItem With {.TimeText = "2:00PM - 3:00PM", .Department = "CS", .Status = "Available"}
        }
    End Function

    Public Function GetRequests() As List(Of ConsultItem)
        Return New List(Of ConsultItem) From {
            New ConsultItem With {.StudentName = "Christopher Clavecillas", .Scheduled = New DateTime(2026, 9, 23, 9, 0, 0), .Section = "BSIT 2C", .Topic = "System Consultation", .Status = "Pending"},
            New ConsultItem With {.StudentName = "Angelo Bundalian", .Scheduled = New DateTime(2026, 9, 22, 11, 0, 0), .Section = "BSCS 2CB", .Topic = "System Consultation", .Status = "Pending"}
        }
    End Function

    Public Function GetUpcoming() As List(Of ConsultItem)
        Return New List(Of ConsultItem) From {
            New ConsultItem With {.StudentName = "Christopher Clavecillas", .Scheduled = New DateTime(2026, 9, 23, 9, 0, 0), .Section = "BSIT 2C", .Topic = "Research Consultation", .Status = "Confirmed"},
            New ConsultItem With {.StudentName = "Jolo Sorongon", .Scheduled = New DateTime(2026, 9, 22, 9, 0, 0), .Section = "BSIT 2C", .Topic = "System Consultation", .Status = "Confirmed"}
        }
    End Function

    Public Function GetHistory() As List(Of HistoryItem)
        Return New List(Of HistoryItem) From {
            New HistoryItem With {.Topic = "Project Consult", .Scheduled = New DateTime(2026, 9, 27, 8, 0, 0), .Section = "BSIT1A", .StudentName = "Christopher Clavecillas", .Status = "Done"},
            New HistoryItem With {.Topic = "Final Review", .Scheduled = New DateTime(2026, 9, 26, 10, 0, 0), .Section = "BSC2A", .StudentName = "Chelly Mae Bolico", .Status = "Canceled"},
            New HistoryItem With {.Topic = "Project Consult", .Scheduled = New DateTime(2026, 9, 26, 7, 30, 0), .Section = "BSIT3C", .StudentName = "Jade Ashly Capistrano", .Status = "Done"},
            New HistoryItem With {.Topic = "Career Pathing", .Scheduled = New DateTime(2026, 9, 27, 13, 0, 0), .Section = "BSIT4C", .StudentName = "Grace Colagbang", .Status = "Done"},
            New HistoryItem With {.Topic = "Final Review", .Scheduled = New DateTime(2026, 9, 27, 8, 0, 0), .Section = "BSIT1E", .StudentName = "Angelo Bundalian", .Status = "Canceled"}
        }
    End Function
End Module
