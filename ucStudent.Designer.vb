<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LinkLabel1 = New LinkLabel()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(312, 323)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(92, 38)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.White
        btnHome.Cursor = Cursors.Hand
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatAppearance.MouseDownBackColor = Color.DarkGray
        btnHome.FlatAppearance.MouseOverBackColor = Color.DarkGray
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHome.Location = New Point(0, 177)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(239, 78)
        btnHome.TabIndex = 1
        btnHome.Text = "Home"
        btnHome.UseMnemonic = False
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' ucStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.Copy_of_System
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(btnHome)
        Controls.Add(LinkLabel1)
        Name = "ucStudent"
        Size = New Size(1316, 686)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnHome As Button

End Class
