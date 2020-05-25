Public Class FormSuppCandidat
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        With FormRecap
            .ButtonAnnuler.Visible = False
            .ButtonModif.Visible = False
            .ButtonValider.Visible = False
            .ButtonSupp.Visible = True
            .ButtonClose.Visible = False
            .Show()
        End With
        Me.Close()
    End Sub
End Class