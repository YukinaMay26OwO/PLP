Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfCancelPage
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
        Me.flowList = New System.Windows.Forms.FlowLayoutPanel()
        Me.sampleCard = New ConsultCard()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        Me.flowList.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlCard.Controls.Add(Me.flowList)
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Padding = New System.Windows.Forms.Padding(22, 10, 22, 15)
        Me.pnlCard.Size = New System.Drawing.Size(950, 610)
        '
        'flowList
        '
        Me.flowList.AutoScroll = True
        Me.flowList.BackColor = System.Drawing.Color.White
        Me.flowList.Controls.Add(Me.sampleCard)
        Me.flowList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowList.Location = New System.Drawing.Point(22, 65)
        Me.flowList.Name = "flowList"
        Me.flowList.Size = New System.Drawing.Size(906, 530)
        Me.flowList.WrapContents = False
        '
        'sampleCard
        '
        Me.sampleCard.Location = New System.Drawing.Point(0, 0)
        Me.sampleCard.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.sampleCard.Name = "sampleCard"
        Me.sampleCard.Size = New System.Drawing.Size(880, 74)
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblTitle.Location = New System.Drawing.Point(22, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(906, 55)
        Me.lblTitle.Text = "Consultations"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProfCancelPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlCard)
        Me.Name = "ProfCancelPage"
        Me.Size = New System.Drawing.Size(950, 610)
        Me.pnlCard.ResumeLayout(False)
        Me.flowList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents flowList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents sampleCard As ConsultCard
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
