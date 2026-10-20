Imports System.Collections.Generic

' ============================================================
'  ProfessorPortal: the main window a PROFESSOR sees after login.
'
'  From the login form later:
'      Dim portal As New ProfessorPortal(loggedInProfessor)
'      AddHandler portal.LogoutRequested, AddressOf BackToLogin
'      portal.Show()
' ============================================================
Public Class ucProfessor

    Public Event LogoutRequested As EventHandler

    Private _prof As ProfessorInfo
    Private _slots As List(Of TimeSlotItem)
    Private _requests As List(Of ConsultItem)
    Private _upcoming As List(Of ConsultItem)
    Private _history As List(Of HistoryItem)
    Private _current As Control

    Public Sub New()
        InitializeComponent()
        Setup(ProfSampleData.GetProfessor())
    End Sub

    Public Sub New(prof As ProfessorInfo)
        InitializeComponent()
        Setup(prof)
    End Sub

    Private Sub Setup(prof As ProfessorInfo)
        _prof = prof

        ' TODO: replace these with data loaded from MySQL
        _slots = ProfSampleData.GetSlots()
        _requests = ProfSampleData.GetRequests()
        _upcoming = ProfSampleData.GetUpcoming()
        _history = ProfSampleData.GetHistory()

        lblName.Text = prof.FullName
        lblRole.Text = prof.RoleText
        picAvatar.Photo = prof.Photo
        ShowPage("dashboard")
    End Sub

    ' ---------- navigation ----------
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPage("dashboard")
    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        ShowPage("consultation")
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ShowPage("history")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Logout",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RaiseEvent LogoutRequested(Me, EventArgs.Empty)
            Close()
        End If
    End Sub

    Private Sub ShowPage(key As String)
        btnDashboard.Active = (key = "dashboard")
        btnConsultation.Active = (key = "consultation" OrElse key = "cancel")
        btnHistory.Active = (key = "history")
        pnlLogo.Visible = (key = "dashboard")      ' the StudentConnect logo only appears on the Dashboard

        If _current IsNot Nothing Then
            pnlContent.Controls.Remove(_current)
            _current.Dispose()
        End If

        Select Case key
            Case "dashboard"
                lblTitle.Text = "Dashboard"
                Dim page As New ProfDashboardPage()
                page.Bind(_requests, _upcoming, _history)
                AddHandler page.ViewConsultationsClicked, Sub() ShowPage("cancel")
                _current = page

            Case "consultation"
                lblTitle.Text = "Consultation"
                Dim page As New ProfConsultationPage()
                page.Bind(_slots, _requests, _upcoming, _history)
                AddHandler page.CancelModeRequested, Sub() ShowPage("cancel")
                _current = page

            Case "cancel"
                lblTitle.Text = "Consultation"
                Dim page As New ProfCancelPage()
                page.Bind(_upcoming, _history)
                _current = page

            Case "history"
                lblTitle.Text = "Consultation History"
                Dim page As New ProfHistoryPage()
                page.Bind(_history)
                _current = page
        End Select

        _current.Dock = DockStyle.Fill
        pnlContent.Controls.Add(_current)
    End Sub

    ' ---------- keep the logo on the right and Logout at the bottom ----------
    Private Sub pnlHeader_Resize(sender As Object, e As EventArgs) Handles pnlHeader.Resize
        If pnlLogo Is Nothing Then Return
        pnlLogo.Left = pnlHeader.Width - pnlLogo.Width - 30
    End Sub

    Private Sub pnlSidebar_Resize(sender As Object, e As EventArgs) Handles pnlSidebar.Resize
        If btnLogout Is Nothing Then Return
        btnLogout.Top = pnlSidebar.Height - btnLogout.Height - 25
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class
