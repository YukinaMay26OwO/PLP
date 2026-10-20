Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfDashboardPage
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
        Me.hero = New HeroBanner()
        Me.pnlOverview = New RoundedPanel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.lblUpcoming = New System.Windows.Forms.Label()
        Me.pnlVDivider = New System.Windows.Forms.Panel()
        Me.lblHStudent = New System.Windows.Forms.Label()
        Me.lblHStatus = New System.Windows.Forms.Label()
        Me.lblHDate = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblState1 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblState2 = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblView = New System.Windows.Forms.Label()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.lblOverviewTitle = New System.Windows.Forms.Label()
        Me.pnlOverview.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'hero
        '
        Me.hero.BackColor = System.Drawing.Color.White
        Me.hero.Dock = System.Windows.Forms.DockStyle.Top
        Me.hero.Location = New System.Drawing.Point(0, 0)
        Me.hero.Name = "hero"
        Me.hero.Size = New System.Drawing.Size(950, 330)
        '
        'pnlOverview
        '
        Me.pnlOverview.BackColor = System.Drawing.Color.White
        Me.pnlOverview.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlOverview.Controls.Add(Me.pnlBody)
        Me.pnlOverview.Controls.Add(Me.pnlLine)
        Me.pnlOverview.Controls.Add(Me.lblOverviewTitle)
        Me.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverview.Location = New System.Drawing.Point(0, 330)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Padding = New System.Windows.Forms.Padding(40, 10, 40, 10)
        Me.pnlOverview.Size = New System.Drawing.Size(950, 280)
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblTotal)
        Me.pnlBody.Controls.Add(Me.lblPending)
        Me.pnlBody.Controls.Add(Me.lblCompleted)
        Me.pnlBody.Controls.Add(Me.lblUpcoming)
        Me.pnlBody.Controls.Add(Me.pnlVDivider)
        Me.pnlBody.Controls.Add(Me.lblHStudent)
        Me.pnlBody.Controls.Add(Me.lblHStatus)
        Me.pnlBody.Controls.Add(Me.lblHDate)
        Me.pnlBody.Controls.Add(Me.lblName1)
        Me.pnlBody.Controls.Add(Me.lblState1)
        Me.pnlBody.Controls.Add(Me.lblDate1)
        Me.pnlBody.Controls.Add(Me.lblName2)
        Me.pnlBody.Controls.Add(Me.lblState2)
        Me.pnlBody.Controls.Add(Me.lblDate2)
        Me.pnlBody.Controls.Add(Me.lblView)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(40, 53)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(870, 217)
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblTotal.Location = New System.Drawing.Point(8, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Text = "Total Consultation : 12"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPending.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblPending.Location = New System.Drawing.Point(8, 54)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Text = "Pending : 4"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblCompleted.Location = New System.Drawing.Point(8, 84)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Text = "Completed : 8"
        '
        'lblUpcoming
        '
        Me.lblUpcoming.AutoSize = True
        Me.lblUpcoming.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUpcoming.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblUpcoming.Location = New System.Drawing.Point(8, 114)
        Me.lblUpcoming.Name = "lblUpcoming"
        Me.lblUpcoming.Text = "Upcoming : 2"
        '
        'pnlVDivider
        '
        Me.pnlVDivider.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlVDivider.Location = New System.Drawing.Point(270, 14)
        Me.pnlVDivider.Name = "pnlVDivider"
        Me.pnlVDivider.Size = New System.Drawing.Size(2, 150)
        '
        'lblHStudent
        '
        Me.lblHStudent.AutoSize = True
        Me.lblHStudent.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHStudent.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblHStudent.Location = New System.Drawing.Point(296, 8)
        Me.lblHStudent.Name = "lblHStudent"
        Me.lblHStudent.Text = "Student"
        '
        'lblHStatus
        '
        Me.lblHStatus.AutoSize = True
        Me.lblHStatus.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHStatus.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblHStatus.Location = New System.Drawing.Point(500, 8)
        Me.lblHStatus.Name = "lblHStatus"
        Me.lblHStatus.Text = "Status"
        '
        'lblHDate
        '
        Me.lblHDate.AutoSize = True
        Me.lblHDate.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHDate.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblHDate.Location = New System.Drawing.Point(640, 8)
        Me.lblHDate.Name = "lblHDate"
        Me.lblHDate.Text = "Date"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblName1.Location = New System.Drawing.Point(298, 52)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Text = "Lyca Gairanod"
        '
        'lblState1
        '
        Me.lblState1.AutoSize = True
        Me.lblState1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblState1.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblState1.Location = New System.Drawing.Point(500, 52)
        Me.lblState1.Name = "lblState1"
        Me.lblState1.Text = "Pending"
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblDate1.Location = New System.Drawing.Point(640, 54)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Text = "September 19; 1:00 PM"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblName2.Location = New System.Drawing.Point(298, 88)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Text = "Angelo Bundalian"
        '
        'lblState2
        '
        Me.lblState2.AutoSize = True
        Me.lblState2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.lblState2.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblState2.Location = New System.Drawing.Point(500, 88)
        Me.lblState2.Name = "lblState2"
        Me.lblState2.Text = "Completed"
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblDate2.Location = New System.Drawing.Point(640, 90)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Text = "September 18; 8:00 AM"
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblView.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblView.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblView.Location = New System.Drawing.Point(340, 138)
        Me.lblView.Name = "lblView"
        Me.lblView.Text = "view consultations"
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLine.Location = New System.Drawing.Point(40, 50)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(870, 3)
        '
        'lblOverviewTitle
        '
        Me.lblOverviewTitle.BackColor = System.Drawing.Color.White
        Me.lblOverviewTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOverviewTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblOverviewTitle.Location = New System.Drawing.Point(40, 10)
        Me.lblOverviewTitle.Name = "lblOverviewTitle"
        Me.lblOverviewTitle.Size = New System.Drawing.Size(870, 40)
        Me.lblOverviewTitle.Text = "Consultation Overview"
        Me.lblOverviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProfDashboardPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlOverview)
        Me.Controls.Add(Me.hero)
        Me.Name = "ProfDashboardPage"
        Me.Size = New System.Drawing.Size(950, 610)
        Me.pnlOverview.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents hero As HeroBanner
    Friend WithEvents pnlOverview As RoundedPanel
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPending As System.Windows.Forms.Label
    Friend WithEvents lblCompleted As System.Windows.Forms.Label
    Friend WithEvents lblUpcoming As System.Windows.Forms.Label
    Friend WithEvents pnlVDivider As System.Windows.Forms.Panel
    Friend WithEvents lblHStudent As System.Windows.Forms.Label
    Friend WithEvents lblHStatus As System.Windows.Forms.Label
    Friend WithEvents lblHDate As System.Windows.Forms.Label
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents lblState1 As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblState2 As System.Windows.Forms.Label
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents lblView As System.Windows.Forms.Label
    Friend WithEvents pnlLine As System.Windows.Forms.Panel
    Friend WithEvents lblOverviewTitle As System.Windows.Forms.Label
End Class
