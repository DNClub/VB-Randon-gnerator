Imports System.Text

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hello it ooded by me. (new)")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = RandomString(10, 50)
    End Sub

    Function RandomString(minCharacters As Integer, maxCharacters As Integer)
        Dim s As String = My.Resources.stringrasdfsddsg
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function


End Class
