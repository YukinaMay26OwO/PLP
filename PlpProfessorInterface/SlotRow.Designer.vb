Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SlotRow
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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnEdit = New RoundButton()
        Me.btnDelete = New RoundButton()
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.White
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTime.Location = New System.Drawing.Point(15, 11)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(234, 27)
        Me.txtTime.Text = "9:00AM - 10:00AM"
        '
        'cmbDept
        '
        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Items.AddRange(New Object() {"CS", "IT", "IS"})
        Me.cmbDept.Location = New System.Drawing.Point(270, 11)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(150, 28)
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(178, 242, 187)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(14, 94, 69)
        Me.lblStatus.Location = New System.Drawing.Point(560, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 32)
        Me.lblStatus.Text = "Available"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(27, 122, 90)
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(770, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Radius = 6
        Me.btnEdit.Size = New System.Drawing.Size(60, 34)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(176, 0, 0)
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(838, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Radius = 6
        Me.btnDelete.Size = New System.Drawing.Size(64, 34)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'SlotRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.Name = "SlotRow"
        Me.Size = New System.Drawing.Size(910, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnEdit As RoundButton
    Friend WithEvents btnDelete As RoundButton
End Class
