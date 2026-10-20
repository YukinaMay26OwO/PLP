Imports System.Drawing

' Rounded pop-up used for "Are you sure...?" (Yes/No) and for "Action aborted" / "Consultation Cancelled" (Ok)
Public Class MessageDialog

    Public Sub SetupYesNo(message As String)
        lblMessage.Text = message
        btnYes.Visible = True
        btnNo.Visible = True
        btnOk.Visible = False
        AcceptButton = btnNo
    End Sub

    Public Sub SetupOk(message As String)
        lblMessage.Text = message
        btnYes.Visible = False
        btnNo.Visible = False
        btnOk.Visible = True
        AcceptButton = btnOk
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Width < 10 OrElse Height < 10 Then Return
        Using path As Drawing2D.GraphicsPath = Theme.RoundRect(New Rectangle(0, 0, Width, Height), 26)
            Region = New Region(path)
        End Using
    End Sub
End Class
