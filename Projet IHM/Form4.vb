Public Class FormInscripRecap
    Private Sub LabelInfoAdresse_Click(sender As Object, e As EventArgs) Handles LabelInfoAdresse.Click

    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormInscripInfoCandidat.Close()
        FormInscripChoixEpreuves.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Me.Close()
        FormInscripInfoCandidat.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        MsgBox("Inscription bien enregistré. Le numéro d'incription du candidat enregistré est ",
               MsgBoxStyle.Information, "Confirmation de l'inscription")
        Me.Close()
        FormAccueil.Show()
    End Sub
End Class