Public Class Form1

    Private Function toplam(ByVal a As Integer) As Integer
        If (a = 0) Then
            Return 0
        Else
            Return a + toplam(a - 1)
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deger As Integer
        deger = Val(TextBox1.Text)

        Try
            If TextBox1.Text <> " " Or TextBox1.Text <> 0 Then
                TextBox1.Text = toplam(deger)
            End If
        Catch ex As Exception
            MessageBox.Show("Lütfen boşluğu doldurunuz", "Değer Yok", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
