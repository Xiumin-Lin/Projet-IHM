Public Class FormInscripChoixEpreuves
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        FormAccueil.Show()
        FormInscripInfoCandidat.Close()
        Me.Close()
    End Sub

    Private Sub ButtonValidChoixEp_Click(sender As Object, e As EventArgs) Handles ButtonValidChoixEp.Click
        'Verif Condition
        With FormRecap
            .ButtonAnnuler.Visible = True
            .ButtonModif.Visible = True
            .ButtonValider.Visible = True
            .ButtonSupp.Visible = False
            .ButtonBack.Visible = False
        End With
        Me.Hide()
        FormRecap.Show()
    End Sub
End Class