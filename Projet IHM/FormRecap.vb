Public Class FormRecap
    Dim numCandidat As Integer = FormInscripInfoCandidat.numCandidat
    Private Sub FormRecap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With listCandidat(numCandidat)
            LabelInfoNom.Text = .Nom
            LabelInfoPrenom.Text = .Prenom
            LabelInfoAge.Text = .Age
            LabelInfoAdresse.Text = .Adresse
            LabelInfoCP.Text = .CP
            LabelInfoVille.Text = .Ville
            LabelInfoRegion.Text = .Region
            LabelEOF.Text = .EOF
            Dim cpt As Integer = 0
            For Each l As Label In GroupBoxInfoEEcrites.Controls
                l.Text = .EE(cpt)
                cpt += 1
            Next
            cpt = 0
            For Each l As Label In GroupBoxInfoEOrales.Controls
                l.Text = .EO(cpt)
                cpt += 1
            Next
        End With
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormInscripInfoCandidat.Close()
        FormInscripChoixEpreuves.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Me.Close()
        FormInscripInfoCandidat.Timer1min.Start()
        FormInscripInfoCandidat.numCandidat = numCandidat
        FormInscripInfoCandidat.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        'Enregistrer l'inscription
        If numCandidat = NumAutoCandidat Then
            MsgBox("La Candidature a bien été enregistré. Le numéro d'incription du candidat enregistré est " + numCandidat.ToString,
                   MsgBoxStyle.Information, "Confirmation de l'enregistrement")
            NumAutoCandidat += 1
        Else
            MsgBox("La Candidature du candidat n° " + numCandidat.ToString + " bien été modifié",
               MsgBoxStyle.Information, "Confirmation de l'enregistrement")
        End If

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