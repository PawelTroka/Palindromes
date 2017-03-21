Imports System.Runtime.CompilerServices
Imports Words
Public Class Palui

    Private Async Sub getPalindromsButton_Click(sender As Object, e As EventArgs) Handles getPalindromsButton.Click

        Dim res As Task(Of String) = addTextBoxAsync()
        RichTextBox1.Text = "waiting..."

        RichTextBox1.Text = Await res


    End Sub



    Private Async Function AddTextBoxAsync() As Task(Of String)

        Dim res As String = ""
        Await Task.Run(Sub()
                           For Each s As String In Words.Words.GetWords()
                               If (s.IsPalindrome()) Then
                                   res += s + Environment.NewLine
                               End If
                           Next
                       End Sub)
        Return res
    End Function

End Class

Module StringExtensions
    <Extension()>
    Public Function IsPalindrome(ByVal input As String) As Boolean
        Dim s1 As String = input
        Dim s2 As String = StrReverse(s1)
        If (s1 = s2) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
