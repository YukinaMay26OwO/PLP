Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CancelReasonDialog
    Inherits System.Windows.Forms.Form

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
        lblTitle = New Label()
        lblStudent = New Label()
        lblDate = New Label()
        lblTopic = New Label()
        pnlDivider = New Panel()
        lblReason = New Label()
        txtReason = New TextBox()
        btnCancelConsult = New RoundButton()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTitle.Location = New Point(30, 18)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Cancellation"
        ' 
        ' lblStudent
        ' 
        lblStudent.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblStudent.ForeColor = Color.FromArgb(CByte(27), CByte(122), CByte(90))
        lblStudent.Location = New Point(32, 95)
        lblStudent.Margin = New Padding(4, 0, 4, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(331, 42)
        lblStudent.TabIndex = 1
        lblStudent.Text = "Christopher Clavecillas"
        ' 
        ' lblDate
        ' 
        lblDate.Font = New Font("Segoe UI", 12F)
        lblDate.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblDate.Location = New Point(32, 145)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(331, 35)
        lblDate.TabIndex = 2
        lblDate.Text = "Sep 23, 2026; 9:00 AM"
        ' 
        ' lblTopic
        ' 
        lblTopic.Font = New Font("Segoe UI", 13F)
        lblTopic.ForeColor = Color.FromArgb(CByte(27), CByte(122), CByte(90))
        lblTopic.Location = New Point(32, 188)
        lblTopic.Margin = New Padding(4, 0, 4, 0)
        lblTopic.Name = "lblTopic"
        lblTopic.Size = New Size(331, 38)
        lblTopic.TabIndex = 3
        lblTopic.Text = "Research Consultation"
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(27), CByte(122), CByte(90))
        pnlDivider.Location = New Point(372, 22)
        pnlDivider.Margin = New Padding(4)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(2, 292)
        pnlDivider.TabIndex = 4
        ' 
        ' lblReason
        ' 
        lblReason.AutoSize = True
        lblReason.Font = New Font("Segoe UI", 14F)
        lblReason.Location = New Point(390, 20)
        lblReason.Margin = New Padding(4, 0, 4, 0)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(193, 32)
        lblReason.TabIndex = 5
        lblReason.Text = "Reason/Message"
        ' 
        ' txtReason
        ' 
        txtReason.BackColor = Color.FromArgb(CByte(205), CByte(211), CByte(220))
        txtReason.BorderStyle = BorderStyle.None
        txtReason.Font = New Font("Segoe UI", 11F)
        txtReason.Location = New Point(390, 65)
        txtReason.Margin = New Padding(4)
        txtReason.Multiline = True
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(370, 140)
        txtReason.TabIndex = 6
        txtReason.Text = "The student did not appear on time"
        ' 
        ' btnCancelConsult
        ' 
        btnCancelConsult.BackColor = Color.FromArgb(CByte(176), CByte(0), CByte(0))
        btnCancelConsult.FlatAppearance.BorderSize = 0
        btnCancelConsult.FlatStyle = FlatStyle.Flat
        btnCancelConsult.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelConsult.ForeColor = Color.White
        btnCancelConsult.Location = New Point(442, 238)
        btnCancelConsult.Margin = New Padding(4)
        btnCancelConsult.Name = "btnCancelConsult"
        btnCancelConsult.Radius = 6
        btnCancelConsult.Size = New Size(268, 55)
        btnCancelConsult.TabIndex = 7
        btnCancelConsult.Text = "Cancel Consultation"
        btnCancelConsult.UseVisualStyleBackColor = False
        ' 
        ' CancelReasonDialog
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(800, 338)
        Controls.Add(lblTitle)
        Controls.Add(lblStudent)
        Controls.Add(lblDate)
        Controls.Add(lblTopic)
        Controls.Add(pnlDivider)
        Controls.Add(lblReason)
        Controls.Add(txtReason)
        Controls.Add(btnCancelConsult)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        Name = "CancelReasonDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Cancellation"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTopic As System.Windows.Forms.Label
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelConsult As RoundButton
End Class
