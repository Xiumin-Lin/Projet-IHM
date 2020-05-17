Public Class FormModifCandidat
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Me.Close()
        FormInscripInfoCandidat.Show()
    End Sub
End Class