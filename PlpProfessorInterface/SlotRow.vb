Imports System.Drawing

' One line of the "Consultation Schedule" table
Public Class SlotRow

    Public Event DeleteClicked(row As SlotRow)

    Private _editing As Boolean

    Public Sub Bind(slot As TimeSlotItem)
        Tag = slot
        txtTime.Text = slot.TimeText
        cmbDept.Text = slot.Department
        ShowStatus(slot.Status)
        SetEditing(False)
    End Sub

    Public Sub BeginEdit()
        SetEditing(True)
    End Sub

    Private Sub ShowStatus(status As String)
        lblStatus.Text = status
        If status = "Booked" Then
            lblStatus.BackColor = Color.FromArgb(130, 190, 245)
            lblStatus.ForeColor = Color.FromArgb(20, 70, 160)
        Else
            lblStatus.BackColor = Color.FromArgb(178, 242, 187)
            lblStatus.ForeColor = Color.FromArgb(14, 94, 69)
        End If
    End Sub

    Private Sub SetEditing(isEditing As Boolean)
        _editing = isEditing
        txtTime.ReadOnly = Not isEditing
        btnEdit.Text = If(isEditing, "Save", "Edit")
        If isEditing Then txtTime.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim slot = TryCast(Tag, TimeSlotItem)
        If _editing Then
            If txtTime.Text.Trim() = "" Then
                MessageBox.Show("Please enter a time slot, e.g. 9:00AM - 10:00AM.", "Time Slot",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If slot IsNot Nothing Then slot.TimeText = txtTime.Text.Trim()   ' TODO: UPDATE in the database
            SetEditing(False)
        Else
            SetEditing(True)
        End If
    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged
        Dim slot = TryCast(Tag, TimeSlotItem)
        If slot IsNot Nothing Then slot.Department = cmbDept.Text
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent DeleteClicked(Me)
    End Sub
End Class
