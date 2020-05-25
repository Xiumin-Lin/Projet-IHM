Public Class FormRecap

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
        'Enregistrer l'inscription
        MsgBox("Inscription bien enregistré. Le numéro d'incription du candidat enregistré est ",
               MsgBoxStyle.Information, "Confirmation de l'inscription")
        Me.Close()
        FormInscripInfoCandidat.Close()
        FormInscripChoixEpreuves.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        'Supprimer le candidat
        MsgBox("Le candidat numéro ... a bien été supprimer",
               MsgBoxStyle.Information, "Confirmation de la suppression")
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class