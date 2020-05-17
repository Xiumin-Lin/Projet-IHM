Public Class FormSuppCandidat
    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Me.Close()

        'FormInscripRecap.LabelEE1.Text = "deded"
        'FormInscripRecap.LabelEE2.Text = "dededdeed"
        'FormInscripRecap.LabelEE3.Text = "dededvvfgv"
        'FormInscripRecap.ButtonValider.Visible = False
        FormInscripRecap.Show()
    End Sub
End Class