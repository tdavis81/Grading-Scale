Public Class Form1
    Dim box As Integer
    Dim score As String
    Dim Grade As Char
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        box = TextBox1.Text
        If box <= 99 Then
            Label3.Text = "A"
            If box <= 92 Then
                Label3.Text = "B"
                If box <= 84 Then
                    Label3.Text = "C"
                    If box <= 77 Then
                        Label3.Text = "D"
                        If box <= 70 Then
                            Label3.Text = "F"
                            If box = 70 Then
                                MsgBox("You are failing, please get your grade up")

                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
