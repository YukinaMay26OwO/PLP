Public Class ucStudent
    Private Sub Home1_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub
    Private Sub ucStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each b As Button In {btnHome}
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.BackColor = Color.Transparent
        Next
        LoadPage(New ucDashboard(), btnDashboard)
    End Sub
End Class


