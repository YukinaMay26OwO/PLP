Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfHistoryPage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlCard = New RoundedPanel()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.colTopic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.pnlSearchBox = New RoundedPanel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSortTime = New System.Windows.Forms.Button()
        Me.btnSortSection = New System.Windows.Forms.Button()
        Me.btnSortName = New System.Windows.Forms.Button()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlSearchBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlCard.Controls.Add(Me.dgvHistory)
        Me.pnlCard.Controls.Add(Me.pnlToolbar)
        Me.pnlCard.Controls.Add(Me.pnlLine)
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Padding = New System.Windows.Forms.Padding(25, 10, 25, 15)
        Me.pnlCard.Size = New System.Drawing.Size(950, 610)
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.AllowUserToResizeRows = False
        Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(178, 222, 200)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(178, 222, 200)
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistory.ColumnHeadersHeight = 54
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTopic, Me.colTime, Me.colDate, Me.colSection, Me.colName, Me.colStatus})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(200, 235, 215)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False
        Me.dgvHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.EnableHeadersVisualStyles = False
        Me.dgvHistory.GridColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.dgvHistory.Location = New System.Drawing.Point(25, 145)
        Me.dgvHistory.MultiSelect = False
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowTemplate.Height = 44
        Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistory.Size = New System.Drawing.Size(900, 450)
        '
        'colTopic
        '
        Me.colTopic.FillWeight = 190.0!
        Me.colTopic.HeaderText = "Consultation Topic"
        Me.colTopic.Name = "colTopic"
        Me.colTopic.ReadOnly = True
        Me.colTopic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTime
        '
        Me.colTime.FillWeight = 90.0!
        Me.colTime.HeaderText = "Time"
        Me.colTime.Name = "colTime"
        Me.colTime.ReadOnly = True
        Me.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDate
        '
        Me.colDate.FillWeight = 120.0!
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSection
        '
        Me.colSection.FillWeight = 100.0!
        Me.colSection.HeaderText = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.ReadOnly = True
        Me.colSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colName
        '
        Me.colName.FillWeight = 230.0!
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colStatus
        '
        Me.colStatus.FillWeight = 100.0!
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.White
        Me.pnlToolbar.Controls.Add(Me.pnlSearchBox)
        Me.pnlToolbar.Controls.Add(Me.btnSortTime)
        Me.pnlToolbar.Controls.Add(Me.btnSortSection)
        Me.pnlToolbar.Controls.Add(Me.btnSortName)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(25, 75)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(900, 70)
        '
        'pnlSearchBox
        '
        Me.pnlSearchBox.BackColor = System.Drawing.Color.White
        Me.pnlSearchBox.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlSearchBox.Controls.Add(Me.txtSearch)
        Me.pnlSearchBox.Location = New System.Drawing.Point(0, 14)
        Me.pnlSearchBox.Name = "pnlSearchBox"
        Me.pnlSearchBox.Padding = New System.Windows.Forms.Padding(14, 8, 10, 0)
        Me.pnlSearchBox.Radius = 8
        Me.pnlSearchBox.Size = New System.Drawing.Size(255, 40)
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(14, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(231, 22)
        Me.txtSearch.Text = "Search"
        '
        'btnSortTime
        '
        Me.btnSortTime.BackColor = System.Drawing.Color.White
        Me.btnSortTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnSortTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortTime.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortTime.Location = New System.Drawing.Point(268, 14)
        Me.btnSortTime.Name = "btnSortTime"
        Me.btnSortTime.Size = New System.Drawing.Size(215, 40)
        Me.btnSortTime.Text = "Sort by Time/Date"
        Me.btnSortTime.UseVisualStyleBackColor = False
        '
        'btnSortSection
        '
        Me.btnSortSection.BackColor = System.Drawing.Color.White
        Me.btnSortSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnSortSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortSection.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortSection.Location = New System.Drawing.Point(493, 14)
        Me.btnSortSection.Name = "btnSortSection"
        Me.btnSortSection.Size = New System.Drawing.Size(200, 40)
        Me.btnSortSection.Text = "Sort by Section"
        Me.btnSortSection.UseVisualStyleBackColor = False
        '
        'btnSortName
        '
        Me.btnSortName.BackColor = System.Drawing.Color.White
        Me.btnSortName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortName.Location = New System.Drawing.Point(703, 14)
        Me.btnSortName.Name = "btnSortName"
        Me.btnSortName.Size = New System.Drawing.Size(190, 40)
        Me.btnSortName.Text = "Sort by Name"
        Me.btnSortName.UseVisualStyleBackColor = False
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.pnlLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLine.Location = New System.Drawing.Point(25, 72)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(900, 3)
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.lblTitle.Location = New System.Drawing.Point(25, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(900, 62)
        Me.lblTitle.Text = "Consultations"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProfHistoryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlCard)
        Me.Name = "ProfHistoryPage"
        Me.Size = New System.Drawing.Size(950, 610)
        Me.pnlCard.ResumeLayout(False)
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlSearchBox.ResumeLayout(False)
        Me.pnlSearchBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As RoundedPanel
    Friend WithEvents dgvHistory As System.Windows.Forms.DataGridView
    Friend WithEvents colTopic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSection As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
    Friend WithEvents pnlSearchBox As RoundedPanel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSortTime As System.Windows.Forms.Button
    Friend WithEvents btnSortSection As System.Windows.Forms.Button
    Friend WithEvents btnSortName As System.Windows.Forms.Button
    Friend WithEvents pnlLine As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
