Imports System.Collections.Generic
Imports System.Linq

' Professor > Consultation History: search + sortable table
Public Class ProfHistoryPage

    Private _all As List(Of HistoryItem)
    Private _sortKey As String = ""
    Private _ascending As Boolean = True

    Public Sub Bind(history As List(Of HistoryItem))
        txtSearch.Clear()                  ' the designer shows the word "Search"; start empty at runtime
        _all = history
        ShowRows()
    End Sub

    Private Sub ShowRows()
        If _all Is Nothing Then Return
        Dim q As String = txtSearch.Text.Trim().ToLower()

        Dim rows As List(Of HistoryItem) = _all.Where(Function(h) q = "" OrElse
            h.Topic.ToLower().Contains(q) OrElse h.Section.ToLower().Contains(q) OrElse
            h.StudentName.ToLower().Contains(q) OrElse h.Status.ToLower().Contains(q)).ToList()

        Select Case _sortKey
            Case "time"
                rows = If(_ascending, rows.OrderBy(Function(h) h.Scheduled), rows.OrderByDescending(Function(h) h.Scheduled)).ToList()
            Case "section"
                rows = If(_ascending, rows.OrderBy(Function(h) h.Section), rows.OrderByDescending(Function(h) h.Section)).ToList()
            Case "name"
                rows = If(_ascending, rows.OrderBy(Function(h) h.StudentName), rows.OrderByDescending(Function(h) h.StudentName)).ToList()
        End Select

        dgvHistory.Rows.Clear()
        For Each h In rows
            dgvHistory.Rows.Add(h.Topic, h.TimeText, h.DateText, h.Section, h.StudentName, h.Status)
        Next
    End Sub

    Private Sub SortBy(key As String)
        If _sortKey = key Then
            _ascending = Not _ascending
        Else
            _sortKey = key
            _ascending = True
        End If

        Dim arrow As String = If(_ascending, " " & ChrW(&H2191), " " & ChrW(&H2193))
        btnSortTime.Text = "Sort by Time/Date" & If(key = "time", arrow, "")
        btnSortSection.Text = "Sort by Section" & If(key = "section", arrow, "")
        btnSortName.Text = "Sort by Name" & If(key = "name", arrow, "")
        ShowRows()
    End Sub

    Private Sub btnSortTime_Click(sender As Object, e As EventArgs) Handles btnSortTime.Click
        SortBy("time")
    End Sub

    Private Sub btnSortSection_Click(sender As Object, e As EventArgs) Handles btnSortSection.Click
        SortBy("section")
    End Sub

    Private Sub btnSortName_Click(sender As Object, e As EventArgs) Handles btnSortName.Click
        SortBy("name")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ShowRows()
    End Sub
End Class
