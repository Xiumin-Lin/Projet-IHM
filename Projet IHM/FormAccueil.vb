Public Class FormAccueil

    Private Sub ButtonInscription_Click(sender As Object, e As EventArgs) Handles ButtonInscrip.Click
        FormInscripInfoCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        FormModifCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        FormSuppCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonEtat_Click(sender As Object, e As EventArgs) Handles ButtonEtat.Click
        FormEtat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBilanProv_Click(sender As Object, e As EventArgs) Handles ButtonBilanProv.Click
        With FormBilan
            .LabelBilan.Text = "Bilan Provisoire"
            .ButtonBack.Visible = True
            .ButtonCloseApp.Visible = False
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub ButtonFinInscrip_Click(sender As Object, e As EventArgs) Handles ButtonFinInscrip.Click
        With FormBilan
            .LabelBilan.Text = "Bilan Final"
            .ButtonBack.Visible = False
            .ButtonCloseApp.Visible = True
            .Show()
        End With
        Me.Hide()
    End Sub
End Class