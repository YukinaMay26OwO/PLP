Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessageDialog
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
        lblMessage = New Label()
        btnYes = New Button()
        btnNo = New Button()
        btnOk = New Button()
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
        ' lblMessage
        ' 
        lblMessage.Font = New Font("Segoe UI", 15F)
        lblMessage.Location = New Point(35, 98)
        lblMessage.Margin = New Padding(4, 0, 4, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(700, 112)
        lblMessage.TabIndex = 1
        lblMessage.Text = "Are you sure you want to cancel this Consultation?"
        ' 
        ' btnYes
        ' 
        btnYes.BackColor = Color.Silver
        btnYes.DialogResult = DialogResult.Yes
        btnYes.FlatStyle = FlatStyle.Flat
        btnYes.Font = New Font("Segoe UI", 12F)
        btnYes.Location = New Point(188, 238)
        btnYes.Margin = New Padding(4, 4, 4, 4)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(162, 55)
        btnYes.TabIndex = 3
        btnYes.Text = "Yes"
        btnYes.UseVisualStyleBackColor = False
        ' 
        ' btnNo
        ' 
        btnNo.BackColor = Color.Silver
        btnNo.DialogResult = DialogResult.No
        btnNo.FlatStyle = FlatStyle.Flat
        btnNo.Font = New Font("Segoe UI", 12F)
        btnNo.Location = New Point(450, 238)
        btnNo.Margin = New Padding(4, 4, 4, 4)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(162, 55)
        btnNo.TabIndex = 4
        btnNo.Text = "No"
        btnNo.UseVisualStyleBackColor = False
        ' 
        ' btnOk
        ' 
        btnOk.BackColor = Color.Gainsboro
        btnOk.DialogResult = DialogResult.OK
        btnOk.FlatStyle = FlatStyle.Flat
        btnOk.Font = New Font("Segoe UI", 12F)
        btnOk.Location = New Point(319, 238)
        btnOk.Margin = New Padding(4, 4, 4, 4)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(162, 55)
        btnOk.TabIndex = 5
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = False
        btnOk.Visible = False
        ' 
        ' MessageDialog
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(825, 358)
        Controls.Add(lblTitle)
        Controls.Add(lblMessage)
        Controls.Add(btnYes)
        Controls.Add(btnNo)
        Controls.Add(btnOk)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 4, 4, 4)
        Name = "MessageDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Cancellation"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
