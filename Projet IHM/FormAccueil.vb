Public Class FormAccueil

    Private Sub ButtonInscription_Click(sender As Object, e As EventArgs) Handles ButtonInscrip.Click
        FormInscripInfoCandidat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        FormModifSupp.Text = "Modification d'un candidat"
        FormModifSupp.LabelTitre.Text = "Modification"
        FormModifSupp.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        With FormModifSupp
            .Text = "Suppression d'un candidat"
            .LabelTitre.Text = "Suppression"
            .etatModif = False 'Le formulaire sera ouvert en mode suppression
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub ButtonEtat_Click(sender As Object, e As EventArgs) Handles ButtonEtat.Click
        FormEtat.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBilanProv_Click(sender As Object, e As EventArgs) Handles ButtonBilanProv.Click
        With FormBilan
            .LabelBilan.Text = "Bilan Provisoire"
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

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class