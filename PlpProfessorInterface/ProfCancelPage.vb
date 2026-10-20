Imports System.Collections.Generic

' Professor > Consultations list with a red Cancel button on each row.
' Cancel -> reason pop-up -> "Are you sure?" (Yes/No) -> "Consultation Cancelled" / "Action aborted"
Public Class ProfCancelPage

    Private _upcoming As List(Of ConsultItem)
    Private _history As List(Of HistoryItem)

    Public Sub Bind(upcoming As List(Of ConsultItem), history As List(Of HistoryItem))
        _upcoming = upcoming
        _history = history
        RefreshList()
    End Sub

    Private Sub RefreshList()
        flowList.SuspendLayout()
        flowList.Controls.Clear()          ' removes the design-time sample card
        For Each c In _upcoming
            Dim card As New ConsultCard()
            card.Bind(c, True)
            AddHandler card.RejectClicked, AddressOf OnCancelClicked
            flowList.Controls.Add(card)
        Next
        flowList.ResumeLayout()
        ResizeCards()
    End Sub

    Private Sub ResizeCards()
        For Each c As Control In flowList.Controls
            c.Width = Math.Max(600, flowList.ClientSize.Width - 8)
        Next
    End Sub

    Private Sub flowList_ClientSizeChanged(sender As Object, e As EventArgs) Handles flowList.ClientSizeChanged
        ResizeCards()
    End Sub

    Private Sub OnCancelClicked(card As ConsultCard)
        Dim item As ConsultItem = card.Item
        Dim owner As Form = FindForm()

        ' 1) reason / message
        Dim reason As String
        Using dlg As New CancelReasonDialog()
            dlg.Setup(item)
            If dlg.ShowDialog(owner) <> DialogResult.OK Then Return
            reason = dlg.Reason
        End Using

        ' 2) are you sure?
        Dim sure As DialogResult
        Using ask As New MessageDialog()
            ask.SetupYesNo("Are you sure you want to cancel this Consultation?")
            sure = ask.ShowDialog(owner)
        End Using

        If sure <> DialogResult.Yes Then
            ShowOk(owner, "Action aborted")
            Return
        End If

        ' 3) cancel it
        item.Status = "Cancelled"          ' TODO: UPDATE the consultation in the database and notify the student with `reason`
        _upcoming.Remove(item)
        _history.Add(item.ToHistory("Canceled"))
        ShowOk(owner, "Consultation Cancelled")
        RefreshList()
    End Sub

    Private Sub ShowOk(owner As Form, message As String)
        Using info As New MessageDialog()
            info.SetupOk(message)
            info.ShowDialog(owner)
        End Using
    End Sub
End Class
