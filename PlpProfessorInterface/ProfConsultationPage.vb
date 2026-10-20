Imports System.Collections.Generic

' Professor > Consultation: schedule table (time slots) + incoming requests
Public Class ProfConsultationPage

    ' The "Cancel a consultation" button asks the main window to open the cancel list
    Public Event CancelModeRequested()

    Private _slots As List(Of TimeSlotItem)
    Private _requests As List(Of ConsultItem)
    Private _upcoming As List(Of ConsultItem)
    Private _history As List(Of HistoryItem)

    Public Sub Bind(slots As List(Of TimeSlotItem), requests As List(Of ConsultItem),
                    upcoming As List(Of ConsultItem), history As List(Of HistoryItem))
        _slots = slots
        _requests = requests
        _upcoming = upcoming
        _history = history
        cmbWeek.SelectedIndex = 0          ' TODO: load the slots of the chosen week
        RefreshSlots()
        RefreshRequests()
    End Sub

    ' ---------- time slots ----------
    Private Sub RefreshSlots()
        flowSlots.SuspendLayout()
        flowSlots.Controls.Clear()         ' removes the design-time sample row
        For Each s In _slots
            Dim row As New SlotRow()
            row.Bind(s)
            AddHandler row.DeleteClicked, AddressOf OnDeleteSlot
            flowSlots.Controls.Add(row)
        Next
        flowSlots.ResumeLayout()
    End Sub

    Private Sub OnDeleteSlot(row As SlotRow)
        Dim slot = DirectCast(row.Tag, TimeSlotItem)
        If MessageBox.Show("Delete the time slot " & slot.TimeText & "?", "Delete Time Slot",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _slots.Remove(slot)            ' TODO: DELETE from the database
            RefreshSlots()
        End If
    End Sub

    Private Sub btnAddSlot_Click(sender As Object, e As EventArgs) Handles btnAddSlot.Click
        _slots.Add(New TimeSlotItem With {.TimeText = "9:00AM - 10:00AM", .Department = "CS", .Status = "Available"})
        RefreshSlots()                     ' TODO: INSERT into the database
        Dim last = TryCast(flowSlots.Controls(flowSlots.Controls.Count - 1), SlotRow)
        If last IsNot Nothing Then last.BeginEdit()
    End Sub

    Private Sub pnlTitleRow_Resize(sender As Object, e As EventArgs) Handles pnlTitleRow.Resize
        If btnAddSlot Is Nothing Then Return
        btnAddSlot.Left = pnlTitleRow.Width - btnAddSlot.Width - 6
    End Sub

    ' ---------- requests ----------
    Private Sub RefreshRequests()
        flowRequests.SuspendLayout()
        flowRequests.Controls.Clear()      ' removes the design-time sample card
        For Each r In _requests
            If r.Status = "Pending" Then
                Dim card As New ConsultCard()
                card.Bind(r, False)
                AddHandler card.ConfirmClicked, AddressOf OnConfirm
                AddHandler card.RejectClicked, AddressOf OnReject
                flowRequests.Controls.Add(card)
            End If
        Next
        flowRequests.ResumeLayout()
        ResizeCards()
    End Sub

    Private Sub ResizeCards()
        For Each c As Control In flowRequests.Controls
            c.Width = Math.Max(600, flowRequests.ClientSize.Width - 8)
        Next
    End Sub

    Private Sub flowRequests_ClientSizeChanged(sender As Object, e As EventArgs) Handles flowRequests.ClientSizeChanged
        ResizeCards()
    End Sub

    Private Sub OnConfirm(card As ConsultCard)
        Dim item = card.Item
        item.Status = "Confirmed"          ' TODO: UPDATE the request in the database
        _requests.Remove(item)
        _upcoming.Add(item)
        MessageBox.Show("Consultation with " & item.StudentName & " confirmed.", "Consultation Request",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshRequests()
    End Sub

    Private Sub OnReject(card As ConsultCard)
        Dim item = card.Item
        If MessageBox.Show("Reject the request of " & item.StudentName & "?", "Consultation Request",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            item.Status = "Rejected"       ' TODO: UPDATE the request in the database
            _requests.Remove(item)
            _history.Add(item.ToHistory("Rejected"))
            RefreshRequests()
        End If
    End Sub

    Private Sub btnCancelMode_Click(sender As Object, e As EventArgs) Handles btnCancelMode.Click
        RaiseEvent CancelModeRequested()
    End Sub
End Class
