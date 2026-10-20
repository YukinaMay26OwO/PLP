Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucProfessor
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlSidebar = New GradientPanel()
        picAvatar = New AvatarBox()
        lblName = New Label()
        lblRole = New Label()
        btnDashboard = New NavButton()
        btnConsultation = New NavButton()
        btnHistory = New NavButton()
        btnLogout = New NavButton()
        pnlHost = New Panel()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        lblTitle = New Label()
        pnlLogo = New RoundedPanel()
        lblLogo = New Label()
        pnlSidebar.SuspendLayout()
        pnlHost.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(picAvatar)
        pnlSidebar.Controls.Add(lblName)
        pnlSidebar.Controls.Add(lblRole)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(btnConsultation)
        pnlSidebar.Controls.Add(btnHistory)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(4, 4, 4, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(338, 900)
        pnlSidebar.TabIndex = 1
        ' 
        ' picAvatar
        ' 
        picAvatar.BackColor = Color.Transparent
        picAvatar.Location = New Point(100, 52)
        picAvatar.Margin = New Padding(4, 4, 4, 4)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(138, 138)
        picAvatar.TabIndex = 0
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Underline)
        lblName.ForeColor = Color.White
        lblName.Location = New Point(0, 206)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(338, 35)
        lblName.TabIndex = 1
        lblName.Text = "MARLON SANTIAGO"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRole
        ' 
        lblRole.BackColor = Color.Transparent
        lblRole.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblRole.ForeColor = Color.White
        lblRole.Location = New Point(0, 241)
        lblRole.Margin = New Padding(4, 0, 4, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(338, 32)
        lblRole.TabIndex = 2
        lblRole.Text = "PROFESSOR"
        lblRole.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 11.0F)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(0, 290)
        btnDashboard.Margin = New Padding(4, 4, 4, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(100, 0, 0, 0)
        btnDashboard.Size = New Size(338, 58)
        btnDashboard.TabIndex = 3
        btnDashboard.Text = "DASHBOARD"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnConsultation
        ' 
        btnConsultation.BackColor = Color.Transparent
        btnConsultation.FlatAppearance.BorderSize = 0
        btnConsultation.FlatStyle = FlatStyle.Flat
        btnConsultation.Font = New Font("Segoe UI", 11.0F)
        btnConsultation.ForeColor = Color.White
        btnConsultation.Location = New Point(0, 352)
        btnConsultation.Margin = New Padding(4, 4, 4, 4)
        btnConsultation.Name = "btnConsultation"
        btnConsultation.Padding = New Padding(100, 0, 0, 0)
        btnConsultation.Size = New Size(338, 58)
        btnConsultation.TabIndex = 4
        btnConsultation.Text = "CONSULTATION"
        btnConsultation.TextAlign = ContentAlignment.MiddleLeft
        btnConsultation.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.Transparent
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI", 11.0F)
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(0, 415)
        btnHistory.Margin = New Padding(4, 4, 4, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Padding = New Padding(100, 0, 0, 0)
        btnHistory.Size = New Size(338, 58)
        btnHistory.TabIndex = 5
        btnHistory.Text = "HISTORY"
        btnHistory.TextAlign = ContentAlignment.MiddleLeft
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 11.0F)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 811)
        btnLogout.Margin = New Padding(4, 4, 4, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(100, 0, 0, 0)
        btnLogout.Size = New Size(338, 58)
        btnLogout.TabIndex = 6
        btnLogout.Text = "LOGOUT"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlHost
        ' 
        pnlHost.BackColor = Color.White
        pnlHost.Controls.Add(pnlContent)
        pnlHost.Controls.Add(pnlHeader)
        pnlHost.Dock = DockStyle.Fill
        pnlHost.Location = New Point(338, 0)
        pnlHost.Margin = New Padding(4, 4, 4, 4)
        pnlHost.Name = "pnlHost"
        pnlHost.Size = New Size(1262, 900)
        pnlHost.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.White
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 112)
        pnlContent.Margin = New Padding(4, 4, 4, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(38, 0, 38, 25)
        pnlContent.Size = New Size(1262, 788)
        pnlContent.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(pnlLogo)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 4, 4, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1262, 112)
        pnlHeader.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblTitle.Location = New Point(38, 22)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(267, 62)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Dashboard"
        ' 
        ' pnlLogo
        ' 
        pnlLogo.BackColor = Color.White
        pnlLogo.BorderColor = Color.FromArgb(CByte(14), CByte(94), CByte(69))
        pnlLogo.BorderWidth = 1.0F
        pnlLogo.Controls.Add(lblLogo)
        pnlLogo.Location = New Point(888, 16)
        pnlLogo.Margin = New Padding(4, 4, 4, 4)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Radius = 30
        pnlLogo.Size = New Size(338, 80)
        pnlLogo.TabIndex = 1
        ' 
        ' lblLogo
        ' 
        lblLogo.BackColor = Color.White
        lblLogo.Dock = DockStyle.Fill
        lblLogo.Font = New Font("Segoe UI", 19.0F, FontStyle.Bold Or FontStyle.Italic)
        lblLogo.ForeColor = Color.FromArgb(CByte(27), CByte(122), CByte(90))
        lblLogo.Location = New Point(0, 0)
        lblLogo.Margin = New Padding(4, 0, 4, 0)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(338, 80)
        lblLogo.TabIndex = 0
        lblLogo.Text = "StudentConnect"
        lblLogo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProfessorPortal
        ' 
        AutoScaleDimensions = New SizeF(120.0F, 120.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(1600, 900)
        Controls.Add(pnlHost)
        Controls.Add(pnlSidebar)
        Margin = New Padding(4, 4, 4, 4)
        MinimumSize = New Size(1496, 838)
        Name = "ucProfessorPortal"
        'StartPosition = FormStartPosition.CenterScreen
        'Text = "StudentConnect - Professor"
        pnlSidebar.ResumeLayout(False)
        pnlHost.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLogo.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As GradientPanel
    Friend WithEvents picAvatar As AvatarBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As NavButton
    Friend WithEvents btnConsultation As NavButton
    Friend WithEvents btnHistory As NavButton
    Friend WithEvents btnLogout As NavButton
    Friend WithEvents pnlHost As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLogo As RoundedPanel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
End Class
