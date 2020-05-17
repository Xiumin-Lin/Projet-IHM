Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonInscription_Click(sender As Object, e As EventArgs) Handles ButtonInscription.Click
        FormInscripInfoCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        FormModifCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        FormSuppCandidat.Show()
        Me.Hide()
    End Sub
End Class