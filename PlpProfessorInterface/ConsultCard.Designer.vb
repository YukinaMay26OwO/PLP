Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultCard
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
        Me.pnlCard = New RoundedPanel()
        Me.picAvatar = New AvatarBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblTopic = New System.Windows.Forms.Label()
        Me.btnConfirm = New RoundButton()
        Me.btnReject = New RoundButton()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlCard.Controls.Add(Me.picAvatar)
        Me.pnlCard.Controls.Add(Me.lblName)
        Me.pnlCard.Controls.Add(Me.lblDetails)
        Me.pnlCard.Controls.Add(Me.lblTopic)
        Me.pnlCard.Controls.Add(Me.btnConfirm)
        Me.pnlCard.Controls.Add(Me.btnReject)
        Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Radius = 6
        Me.pnlCard.Size = New System.Drawing.Size(800, 74)
        '
        'picAvatar
        '
        Me.picAvatar.BackColor = System.Drawing.Color.Transparent
        Me.picAvatar.Location = New System.Drawing.Point(16, 16)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(40, 40)
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lblName.Location = New System.Drawing.Point(66, 6)
        Me.lblName.Name = "lblName"
        Me.lblName.Text = "Christopher Clavecillas"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.BackColor = System.Drawing.Color.White
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDetails.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblDetails.Location = New System.Drawing.Point(68, 42)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Text = "Sept 23, 2026 (9:00am)  BSIT 2C"
        '
        'lblTopic
        '
        Me.lblTopic.AutoSize = True
        Me.lblTopic.BackColor = System.Drawing.Color.White
        Me.lblTopic.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTopic.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblTopic.Location = New System.Drawing.Point(380, 44)
        Me.lblTopic.Name = "lblTopic"
        Me.lblTopic.Text = "System Consultation"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(560, 18)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Radius = 6
        Me.btnConfirm.Size = New System.Drawing.Size(100, 36)
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(176, 0, 0)
        Me.btnReject.FlatAppearance.BorderSize = 0
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(672, 18)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Radius = 6
        Me.btnReject.Size = New System.Drawing.Size(100, 36)
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'ConsultCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.pnlCard)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Name = "ConsultCard"
        Me.Size = New System.Drawing.Size(800, 74)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents picAvatar As AvatarBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblTopic As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As RoundButton
    Friend WithEvents btnReject As RoundButton
End Class
