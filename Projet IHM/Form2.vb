Public Class FormInscripInfoCandidat

    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        'Verif Condition avant
        FormInscripChoixEpreuves.Show()
        Me.Hide()
    End Sub
End Class