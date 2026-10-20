Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Windows.Forms

' ============================================================
'  Theme: colors, fonts and small helpers
' ============================================================
Public Module Theme
    Public ReadOnly Green As Color = ColorTranslator.FromHtml("#1B7A5A")
    Public ReadOnly DeepGreen As Color = ColorTranslator.FromHtml("#0E5E45")
    Public ReadOnly SoftGreen As Color = ColorTranslator.FromHtml("#B2F2BB")
    Public ReadOnly Chip As Color = ColorTranslator.FromHtml("#A9E5C6")
    Public ReadOnly Field As Color = ColorTranslator.FromHtml("#CDD3DC")
    Public ReadOnly Ink As Color = ColorTranslator.FromHtml("#222222")

    Public Function F(size As Single, Optional style As FontStyle = FontStyle.Regular) As Font
        Return New Font("Segoe UI", size, style)
    End Function

    Public Function RoundRect(r As Rectangle, radius As Integer) As GraphicsPath
        radius = Math.Max(1, Math.Min(radius, Math.Min(r.Width, r.Height) \ 2))
        Dim d As Integer = radius * 2
        Dim p As New GraphicsPath()
        p.AddArc(r.X, r.Y, d, d, 180, 90)
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        p.CloseFigure()
        Return p
    End Function
End Module

' ============================================================
'  Rounded card with a green border
' ============================================================
Public Class RoundedPanel
    Inherits Panel

    Public Property Radius As Integer = 10
    Public Property BorderColor As Color = Color.FromArgb(14, 94, 69)
    Public Property BorderWidth As Single = 1.0F

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
        BackColor = Color.White
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.Clear(If(Parent IsNot Nothing, Parent.BackColor, Color.White))
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        If Width < 6 OrElse Height < 6 Then Return
        Using path As GraphicsPath = Theme.RoundRect(New Rectangle(1, 1, Width - 3, Height - 3), Radius)
            Using b As New SolidBrush(BackColor)
                e.Graphics.FillPath(b, path)
            End Using
            Using pen As New Pen(BorderColor, BorderWidth)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub
End Class

' ============================================================
'  Rounded green button
' ============================================================
Public Class RoundButton
    Inherits Button

    Public Property Radius As Integer = 22

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer, True)
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        BackColor = Color.FromArgb(27, 122, 90)
        ForeColor = Color.White
        Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.Clear(If(Parent IsNot Nothing, Parent.BackColor, Color.White))
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        If Width < 6 OrElse Height < 6 Then Return
        Using path As GraphicsPath = Theme.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Radius)
            Using b As New SolidBrush(BackColor)
                e.Graphics.FillPath(b, path)
            End Using
        End Using
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak)
    End Sub
End Class

' ============================================================
'  Sidebar background: black fading into green
' ============================================================
Public Class GradientPanel
    Inherits Panel

    Public Sub New()
        DoubleBuffered = True
        ResizeRedraw = True
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        If Height <= 0 OrElse Width <= 0 Then Return
        Using br As New LinearGradientBrush(ClientRectangle, Color.Black, Theme.Green, 90.0F)
            Dim blend As New ColorBlend(3)
            blend.Colors = New Color() {Color.Black, Color.FromArgb(5, 45, 35), Theme.Green}
            blend.Positions = New Single() {0.0F, 0.4F, 1.0F}
            br.InterpolationColors = blend
            e.Graphics.FillRectangle(br, ClientRectangle)
        End Using
    End Sub
End Class

' ============================================================
'  Sidebar navigation button (gray when active)
' ============================================================
Public Class NavButton
    Inherits Button

    Private _active As Boolean

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Active As Boolean
        Get
            Return _active
        End Get
        Set(value As Boolean)
            _active = value
            BackColor = If(value, Color.FromArgb(90, 90, 90), Color.Transparent)
        End Set
    End Property

    Public Sub New()
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 58, 58)
        ForeColor = Color.White
        Cursor = Cursors.Hand
    End Sub
End Class

' ============================================================
'  Circular profile picture (black circle + white silhouette if no photo)
' ============================================================
Public Class AvatarBox
    Inherits Control

    Private _photo As Image

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Photo As Image
        Get
            Return _photo
        End Get
        Set(value As Image)
            _photo = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If Width < 4 OrElse Height < 4 Then Return
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim rc As New Rectangle(0, 0, Width - 1, Height - 1)
        Using path As New GraphicsPath()
            path.AddEllipse(rc)
            g.SetClip(path)
            If _photo IsNot Nothing Then
                g.DrawImage(_photo, rc)
            Else
                g.FillRectangle(Brushes.Black, rc)
                g.FillEllipse(Brushes.White, CInt(Width * 0.33), CInt(Height * 0.17), CInt(Width * 0.34), CInt(Height * 0.34))
                g.FillEllipse(Brushes.White, CInt(Width * 0.17), CInt(Height * 0.58), CInt(Width * 0.66), CInt(Height * 0.6))
            End If
            g.ResetClip()
        End Using
    End Sub
End Class

' ============================================================
'  Dashboard banner: "Pamantasan ng Lungsod ng Pasig" + seal + photo mosaic
'  (placeholders for now; swap in your real images later)
' ============================================================
Public Class HeroBanner
    Inherits Control

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
        BackColor = Color.White
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.Clear(BackColor)
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim lines As String() = {"Pamantasan ng", "Lungsod ng", "Pasig"}
        Dim initialColors As Color() = {Color.FromArgb(70, 200, 60), Color.FromArgb(200, 240, 90), Color.FromArgb(70, 200, 60)}
        Dim textColor As Color = ColorTranslator.FromHtml("#3C3C3C")
        Dim y As Integer = 8
        Using f As Font = Theme.F(38, FontStyle.Bold)
            For i As Integer = 0 To lines.Length - 1
                Dim initial As String = lines(i).Substring(0, 1)
                Dim rest As String = lines(i).Substring(1)
                TextRenderer.DrawText(g, initial, f, New Point(0, y), initialColors(i), TextFormatFlags.NoPadding)
                Dim w As Integer = TextRenderer.MeasureText(g, initial, f, New Size(1000, 100), TextFormatFlags.NoPadding).Width
                TextRenderer.DrawText(g, rest, f, New Point(w, y), textColor, TextFormatFlags.NoPadding)
                y += 66
            Next
        End Using

        ' Seal placeholder
        Dim seal As New Rectangle(215, 150, 150, 150)
        Using b As New SolidBrush(Theme.Green)
            g.FillEllipse(b, seal)
        End Using
        g.FillEllipse(Brushes.White, Rectangle.Inflate(seal, -18, -18))
        TextRenderer.DrawText(g, "PLP", Theme.F(20, FontStyle.Bold), seal, Theme.Green,
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

        ' Photo mosaic placeholder (rows of 3 / 2 / 3 tiles)
        Dim x0 As Integer = 440, gap As Integer = 6
        Dim totalW As Integer = Width - x0 - 10
        If totalW < 240 Then Return
        Dim rowH As Integer = (Height - 20 - 2 * gap) \ 3
        Dim palette As Color() = {
            ColorTranslator.FromHtml("#1F8F85"), ColorTranslator.FromHtml("#8C7A1E"),
            ColorTranslator.FromHtml("#5CBF9C"), ColorTranslator.FromHtml("#2B6E8F")}
        Dim n As Integer = 0
        Dim fractions As Single()() = {New Single() {1, 1, 1}, New Single() {0.6F, 0.4F}, New Single() {1, 1, 1}}
        For r As Integer = 0 To 2
            Dim cols As Single() = fractions(r)
            Dim sum As Single = cols.Sum()
            Dim cx As Single = x0
            For Each fr As Single In cols
                Dim tw As Single = (totalW - gap * (cols.Length - 1)) * fr / sum
                Using b As New SolidBrush(palette(n Mod palette.Length))
                    g.FillRectangle(b, cx, 10 + r * (rowH + gap), tw, rowH)
                End Using
                cx += tw + gap
                n += 1
            Next
        Next
    End Sub
End Class
