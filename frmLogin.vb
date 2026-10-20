Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShow.Checked
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text.Trim = "" Or txtEmail.Text.Trim = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New MySqlConnection(ConnStr)
            conn.Open()
            Dim sql As String = "SELECT u.role, COALESCE(s.first_name,p.first_name,a.first_name) AS fn, COALESCE(s.last_name,p.last_name,a.last_name) AS ln FROM users u LEFT JOIN students s ON s.student_id=u.student_id LEFT JOIN professors p ON p.professor_id=u.professor_id LEFT JOIN admins a ON a.admin_id=u.admin_id WHERE u.email=@em AND u.password=@pw AND COALESCE(s.id_number,p.id_number,a.id_number)=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", txtID.Text.Trim)
                cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim)
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text)
                Using rd As MySqlDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        CurrentID = txtID.Text.Trim
                        CurrentName = rd("fn").ToString & " " & rd("ln").ToString
                        CurrentRole = rd("role").ToString
                        OpenByRole()
                    Else
                        MessageBox.Show("Invalid ID, email, or password.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub OpenByRole()
        Dim page As UserControl
        Select Case CurrentRole
            Case "Student"
                page = New ucStudent()
            Case "Professor"
                page = New ucProfessor()
            Case "Admin"
                page = New ucAdmin()
            Case Else
                Return
        End Select
        ShowPage(page)
    End Sub
    Public Sub ShowPage(page As UserControl)
        pnlHost.Controls.Clear()
        page.Dock = DockStyle.Fill
        pnlHost.Controls.Add(page)
        pnlHost.Visible = True
        pnlHost.BringToFront()
    End Sub

    Public Sub ShowLogin()
        pnlHost.Controls.Clear()
        pnlHost.Visible = False
        txtID.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
