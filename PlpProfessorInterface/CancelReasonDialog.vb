Imports System.Drawing
Imports System.Globalization

' Pop-up where the professor writes the reason before cancelling a consultation
Public Class CancelReasonDialog

    Public ReadOnly Property Reason As String
        Get
            Return txtReason.Text.Trim()
        End Get
    End Property

    Public Sub Setup(item As ConsultItem)
        lblStudent.Text = item.StudentName
        lblDate.Text = item.Scheduled.ToString("MMM d, yyyy; h:mm tt", CultureInfo.InvariantCulture)
        lblTopic.Text = item.Topic
        txtReason.Clear()
    End Sub

    Private Sub btnCancelConsult_Click(sender As Object, e As EventArgs) Handles btnCancelConsult.Click
        If Reason = "" Then
            MessageBox.Show("Please write a reason or message for the student.", "Cancellation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtReason.Focus()
            Return
        End If
        DialogResult = DialogResult.OK
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Width < 10 OrElse Height < 10 Then Return
        Using path As Drawing2D.GraphicsPath = Theme.RoundRect(New Rectangle(0, 0, Width, Height), 26)
            Region = New Region(path)
        End Using
    End Sub

    Private Sub CancelReasonDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblStudent_Click(sender As Object, e As EventArgs) Handles lblStudent.Click

    End Sub
End Class
