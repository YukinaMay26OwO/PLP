Imports System.ComponentModel

' One student row. Request mode: Confirm + Reject buttons. Cancel mode: a single red Cancel button.
Public Class ConsultCard

    Public Event ConfirmClicked(card As ConsultCard)
    Public Event RejectClicked(card As ConsultCard)    ' also raised by the "Cancel" button in cancel mode

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Item As ConsultItem

    Public Sub Bind(c As ConsultItem, cancelMode As Boolean)
        Item = c
        lblName.Text = c.StudentName
        lblDetails.Text = c.DateText & "  " & c.Section
        lblTopic.Text = c.Topic
        btnConfirm.Visible = Not cancelMode
        btnReject.Text = If(cancelMode, "Cancel", "Reject")
        PositionButtons()
    End Sub

    Private Sub PositionButtons()
        If pnlCard Is Nothing OrElse btnReject Is Nothing OrElse btnConfirm Is Nothing Then Return
        btnReject.Left = pnlCard.Width - btnReject.Width - 18
        btnConfirm.Left = btnReject.Left - btnConfirm.Width - 12
    End Sub

    Private Sub ConsultCard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PositionButtons()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        RaiseEvent ConfirmClicked(Me)
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        RaiseEvent RejectClicked(Me)
    End Sub
End Class
