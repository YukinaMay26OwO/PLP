<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        pnlHost = New Panel()
        chkShow = New CheckBox()
        PictureBox4 = New PictureBox()
        txtPassword = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txtID = New TextBox()
        txtEmail = New TextBox()
        Label1 = New Label()
        btnLogin = New Button()
        pnlHost.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHost
        ' 
        pnlHost.Anchor = AnchorStyles.None
        pnlHost.BackColor = SystemColors.HighlightText
        pnlHost.Controls.Add(chkShow)
        pnlHost.Controls.Add(PictureBox4)
        pnlHost.Controls.Add(txtPassword)
        pnlHost.Controls.Add(PictureBox3)
        pnlHost.Controls.Add(PictureBox2)
        pnlHost.Controls.Add(PictureBox1)
        pnlHost.Controls.Add(txtID)
        pnlHost.Controls.Add(txtEmail)
        pnlHost.Controls.Add(Label1)
        pnlHost.Controls.Add(btnLogin)
        pnlHost.Location = New Point(397, 48)
        pnlHost.Name = "pnlHost"
        pnlHost.Size = New Size(525, 578)
        pnlHost.TabIndex = 0
        ' 
        ' chkShow
        ' 
        chkShow.AutoSize = True
        chkShow.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chkShow.ForeColor = SystemColors.ControlDarkDark
        chkShow.Location = New Point(152, 373)
        chkShow.Name = "chkShow"
        chkShow.Size = New Size(117, 24)
        chkShow.TabIndex = 9
        chkShow.Text = "See Password"
        chkShow.TextImageRelation = TextImageRelation.ImageAboveText
        chkShow.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.HighlightText
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(54, 321)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(90, 81)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Location = New Point(150, 333)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(327, 27)
        txtPassword.TabIndex = 7
        txtPassword.Tag = ""
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.HighlightText
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(54, 234)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(90, 81)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.HighlightText
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(54, 147)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(90, 81)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.HighlightText
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.Untitled_design__1__removebg_preview
        PictureBox1.Location = New Point(205, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Cursor = Cursors.IBeam
        txtID.Location = New Point(150, 258)
        txtID.Name = "txtID"
        txtID.PlaceholderText = " ID Number"
        txtID.Size = New Size(327, 27)
        txtID.TabIndex = 3
        txtID.Tag = ""
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Cursor = Cursors.IBeam
        txtEmail.Location = New Point(150, 179)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = " Email"
        txtEmail.Size = New Size(327, 27)
        txtEmail.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkOliveGreen
        btnLogin.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(97, 451)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(333, 74)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.PLP
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1306, 697)
        Controls.Add(pnlHost)
        Name = "frmLogin"
        Text = "StudentConnect"
        WindowState = FormWindowState.Maximized
        pnlHost.ResumeLayout(False)
        pnlHost.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHost As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents chkShow As CheckBox

End Class
