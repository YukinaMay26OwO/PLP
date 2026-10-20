Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfConsultationPage
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
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlRequests = New RoundedPanel()
        Me.flowRequests = New System.Windows.Forms.FlowLayoutPanel()
        Me.sampleCard = New ConsultCard()
        Me.lblReqTitle = New System.Windows.Forms.Label()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnCancelMode = New RoundButton()
        Me.pnlGap = New System.Windows.Forms.Panel()
        Me.pnlSchedule = New RoundedPanel()
        Me.flowSlots = New System.Windows.Forms.FlowLayoutPanel()
        Me.sampleSlot = New SlotRow()
        Me.pnlHeaderBar = New System.Windows.Forms.Panel()
        Me.lblH1 = New System.Windows.Forms.Label()
        Me.lblH2 = New System.Windows.Forms.Label()
        Me.lblH3 = New System.Windows.Forms.Label()
        Me.lblH4 = New System.Windows.Forms.Label()
        Me.pnlTitleRow = New System.Windows.Forms.Panel()
        Me.lblSchedTitle = New System.Windows.Forms.Label()
        Me.cmbWeek = New System.Windows.Forms.ComboBox()
        Me.btnAddSlot = New RoundButton()
        Me.pnlBottom.SuspendLayout()
        Me.pnlRequests.SuspendLayout()
        Me.flowRequests.SuspendLayout()
        Me.pnlSide.SuspendLayout()
        Me.pnlSchedule.SuspendLayout()
        Me.flowSlots.SuspendLayout()
        Me.pnlHeaderBar.SuspendLayout()
        Me.pnlTitleRow.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.White
        Me.pnlBottom.Controls.Add(Me.pnlRequests)
        Me.pnlBottom.Controls.Add(Me.pnlSide)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBottom.Location = New System.Drawing.Point(0, 348)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(950, 262)
        '
        'pnlRequests
        '
        Me.pnlRequests.BackColor = System.Drawing.Color.White
        Me.pnlRequests.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlRequests.Controls.Add(Me.flowRequests)
        Me.pnlRequests.Controls.Add(Me.lblReqTitle)
        Me.pnlRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRequests.Location = New System.Drawing.Point(0, 0)
        Me.pnlRequests.Name = "pnlRequests"
        Me.pnlRequests.Padding = New System.Windows.Forms.Padding(20, 8, 10, 10)
        Me.pnlRequests.Size = New System.Drawing.Size(750, 262)
        '
        'flowRequests
        '
        Me.flowRequests.AutoScroll = True
        Me.flowRequests.BackColor = System.Drawing.Color.White
        Me.flowRequests.Controls.Add(Me.sampleCard)
        Me.flowRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowRequests.Location = New System.Drawing.Point(20, 58)
        Me.flowRequests.Name = "flowRequests"
        Me.flowRequests.Size = New System.Drawing.Size(720, 194)
        Me.flowRequests.WrapContents = False
        '
        'sampleCard
        '
        Me.sampleCard.Location = New System.Drawing.Point(0, 0)
        Me.sampleCard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.sampleCard.Name = "sampleCard"
        Me.sampleCard.Size = New System.Drawing.Size(690, 74)
        '
        'lblReqTitle
        '
        Me.lblReqTitle.BackColor = System.Drawing.Color.White
        Me.lblReqTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReqTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblReqTitle.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblReqTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblReqTitle.Name = "lblReqTitle"
        Me.lblReqTitle.Size = New System.Drawing.Size(720, 50)
        Me.lblReqTitle.Text = "Consultation Request"
        Me.lblReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.White
        Me.pnlSide.Controls.Add(Me.btnCancelMode)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSide.Location = New System.Drawing.Point(750, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(200, 262)
        '
        'btnCancelMode
        '
        Me.btnCancelMode.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnCancelMode.FlatAppearance.BorderSize = 0
        Me.btnCancelMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelMode.ForeColor = System.Drawing.Color.White
        Me.btnCancelMode.Location = New System.Drawing.Point(14, 110)
        Me.btnCancelMode.Name = "btnCancelMode"
        Me.btnCancelMode.Radius = 8
        Me.btnCancelMode.Size = New System.Drawing.Size(176, 62)
        Me.btnCancelMode.Text = "Cancel a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "consultation"
        Me.btnCancelMode.UseVisualStyleBackColor = False
        '
        'pnlGap
        '
        Me.pnlGap.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGap.Location = New System.Drawing.Point(0, 336)
        Me.pnlGap.Name = "pnlGap"
        Me.pnlGap.Size = New System.Drawing.Size(950, 12)
        '
        'pnlSchedule
        '
        Me.pnlSchedule.BackColor = System.Drawing.Color.White
        Me.pnlSchedule.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlSchedule.Controls.Add(Me.flowSlots)
        Me.pnlSchedule.Controls.Add(Me.pnlHeaderBar)
        Me.pnlSchedule.Controls.Add(Me.pnlTitleRow)
        Me.pnlSchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSchedule.Location = New System.Drawing.Point(0, 0)
        Me.pnlSchedule.Name = "pnlSchedule"
        Me.pnlSchedule.Padding = New System.Windows.Forms.Padding(12, 8, 12, 10)
        Me.pnlSchedule.Size = New System.Drawing.Size(950, 336)
        '
        'flowSlots
        '
        Me.flowSlots.AutoScroll = True
        Me.flowSlots.BackColor = System.Drawing.Color.White
        Me.flowSlots.Controls.Add(Me.sampleSlot)
        Me.flowSlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowSlots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowSlots.Location = New System.Drawing.Point(12, 106)
        Me.flowSlots.Name = "flowSlots"
        Me.flowSlots.Size = New System.Drawing.Size(926, 220)
        Me.flowSlots.WrapContents = False
        '
        'sampleSlot
        '
        Me.sampleSlot.BackColor = System.Drawing.Color.White
        Me.sampleSlot.Location = New System.Drawing.Point(0, 0)
        Me.sampleSlot.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.sampleSlot.Name = "sampleSlot"
        Me.sampleSlot.Size = New System.Drawing.Size(910, 50)
        '
        'pnlHeaderBar
        '
        Me.pnlHeaderBar.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlHeaderBar.Controls.Add(Me.lblH1)
        Me.pnlHeaderBar.Controls.Add(Me.lblH2)
        Me.pnlHeaderBar.Controls.Add(Me.lblH3)
        Me.pnlHeaderBar.Controls.Add(Me.lblH4)
        Me.pnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderBar.Location = New System.Drawing.Point(12, 72)
        Me.pnlHeaderBar.Name = "pnlHeaderBar"
        Me.pnlHeaderBar.Size = New System.Drawing.Size(926, 34)
        '
        'lblH1
        '
        Me.lblH1.AutoSize = True
        Me.lblH1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblH1.ForeColor = System.Drawing.Color.White
        Me.lblH1.Location = New System.Drawing.Point(24, 6)
        Me.lblH1.Name = "lblH1"
        Me.lblH1.Text = "TIME SLOT"
        '
        'lblH2
        '
        Me.lblH2.AutoSize = True
        Me.lblH2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblH2.ForeColor = System.Drawing.Color.White
        Me.lblH2.Location = New System.Drawing.Point(280, 6)
        Me.lblH2.Name = "lblH2"
        Me.lblH2.Text = "DEPARTMENT"
        '
        'lblH3
        '
        Me.lblH3.AutoSize = True
        Me.lblH3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblH3.ForeColor = System.Drawing.Color.White
        Me.lblH3.Location = New System.Drawing.Point(580, 6)
        Me.lblH3.Name = "lblH3"
        Me.lblH3.Text = "STATUS"
        '
        'lblH4
        '
        Me.lblH4.AutoSize = True
        Me.lblH4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblH4.ForeColor = System.Drawing.Color.White
        Me.lblH4.Location = New System.Drawing.Point(790, 6)
        Me.lblH4.Name = "lblH4"
        Me.lblH4.Text = "ACTIONS"
        '
        'pnlTitleRow
        '
        Me.pnlTitleRow.BackColor = System.Drawing.Color.White
        Me.pnlTitleRow.Controls.Add(Me.lblSchedTitle)
        Me.pnlTitleRow.Controls.Add(Me.cmbWeek)
        Me.pnlTitleRow.Controls.Add(Me.btnAddSlot)
        Me.pnlTitleRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleRow.Location = New System.Drawing.Point(12, 16)
        Me.pnlTitleRow.Name = "pnlTitleRow"
        Me.pnlTitleRow.Size = New System.Drawing.Size(926, 56)
        '
        'lblSchedTitle
        '
        Me.lblSchedTitle.AutoSize = True
        Me.lblSchedTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSchedTitle.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblSchedTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblSchedTitle.Name = "lblSchedTitle"
        Me.lblSchedTitle.Text = "Consultation Schedule"
        '
        'cmbWeek
        '
        Me.cmbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWeek.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbWeek.FormattingEnabled = True
        Me.cmbWeek.Items.AddRange(New Object() {"Sep 14 - 19", "Sep 21 - 26", "Sep 28 - Oct 3"})
        Me.cmbWeek.Location = New System.Drawing.Point(330, 10)
        Me.cmbWeek.Name = "cmbWeek"
        Me.cmbWeek.Size = New System.Drawing.Size(180, 33)
        '
        'btnAddSlot
        '
        Me.btnAddSlot.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnAddSlot.FlatAppearance.BorderSize = 0
        Me.btnAddSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSlot.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddSlot.ForeColor = System.Drawing.Color.White
        Me.btnAddSlot.Location = New System.Drawing.Point(760, 12)
        Me.btnAddSlot.Name = "btnAddSlot"
        Me.btnAddSlot.Radius = 8
        Me.btnAddSlot.Size = New System.Drawing.Size(160, 34)
        Me.btnAddSlot.Text = "+ Add Time Slot"
        Me.btnAddSlot.UseVisualStyleBackColor = False
        '
        'ProfConsultationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlGap)
        Me.Controls.Add(Me.pnlSchedule)
        Me.Name = "ProfConsultationPage"
        Me.Size = New System.Drawing.Size(950, 610)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlRequests.ResumeLayout(False)
        Me.flowRequests.ResumeLayout(False)
        Me.pnlSide.ResumeLayout(False)
        Me.pnlSchedule.ResumeLayout(False)
        Me.flowSlots.ResumeLayout(False)
        Me.pnlHeaderBar.ResumeLayout(False)
        Me.pnlHeaderBar.PerformLayout()
        Me.pnlTitleRow.ResumeLayout(False)
        Me.pnlTitleRow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlRequests As RoundedPanel
    Friend WithEvents flowRequests As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents sampleCard As ConsultCard
    Friend WithEvents lblReqTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents btnCancelMode As RoundButton
    Friend WithEvents pnlGap As System.Windows.Forms.Panel
    Friend WithEvents pnlSchedule As RoundedPanel
    Friend WithEvents flowSlots As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents sampleSlot As SlotRow
    Friend WithEvents pnlHeaderBar As System.Windows.Forms.Panel
    Friend WithEvents lblH1 As System.Windows.Forms.Label
    Friend WithEvents lblH2 As System.Windows.Forms.Label
    Friend WithEvents lblH3 As System.Windows.Forms.Label
    Friend WithEvents lblH4 As System.Windows.Forms.Label
    Friend WithEvents pnlTitleRow As System.Windows.Forms.Panel
    Friend WithEvents lblSchedTitle As System.Windows.Forms.Label
    Friend WithEvents cmbWeek As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSlot As RoundButton
End Class
