Public Class FormInscripChoixEpreuves
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Verif Condition
        Me.Hide()
        FormInscripRecap.Show()
    End Sub
End Class