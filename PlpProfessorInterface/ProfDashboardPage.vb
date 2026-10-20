Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq

' Professor > Dashboard: banner + "Consultation Overview"
Public Class ProfDashboardPage

    Public Event ViewConsultationsClicked()

    Public Sub Bind(requests As List(Of ConsultItem), upcoming As List(Of ConsultItem), history As List(Of HistoryItem))
        Dim pending As List(Of ConsultItem) = requests.Where(Function(r) r.Status = "Pending").ToList()
        Dim doneCount As Integer = history.Where(Function(h) h.Status = "Done").Count()

        lblTotal.Text = "Total Consultation : " & (pending.Count + upcoming.Count + doneCount)
        lblPending.Text = "Pending : " & pending.Count
        lblCompleted.Text = "Completed : " & doneCount
        lblUpcoming.Text = "Upcoming : " & upcoming.Count

        ' newest items first: pending requests, then finished ones
        Dim recent As New List(Of String())
        For Each r In pending
            recent.Add(New String() {r.StudentName, "Pending", r.Scheduled.ToString("MMMM d; h:mm tt", CultureInfo.InvariantCulture)})
        Next
        For Each h In history.OrderByDescending(Function(x) x.Scheduled)
            recent.Add(New String() {h.StudentName, If(h.Status = "Done", "Completed", h.Status),
                                     h.Scheduled.ToString("MMMM d; h:mm tt", CultureInfo.InvariantCulture)})
        Next

        Dim names As Label() = {lblName1, lblName2}
        Dim states As Label() = {lblState1, lblState2}
        Dim dates As Label() = {lblDate1, lblDate2}
        For i As Integer = 0 To 1
            If i < recent.Count Then
                names(i).Text = recent(i)(0)
                states(i).Text = recent(i)(1)
                dates(i).Text = recent(i)(2)
            Else
                names(i).Text = ""
                states(i).Text = ""
                dates(i).Text = ""
            End If
        Next
    End Sub

    Private Sub lblView_Click(sender As Object, e As EventArgs) Handles lblView.Click
        RaiseEvent ViewConsultationsClicked()
    End Sub
End Class
