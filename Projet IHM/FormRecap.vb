Public Class FormRecap
    'Ce formulaire récapitule les infos d'un candidat
    'Les boutons permettant de naviguer entre les autres form diffère selon l'état du form
    '- A l'état d'inscription, seuls les boutons annuler (retour à l'accueil), modifier et valider sont dispo
    '- A l'état de suppression, seul le bouton validant la suppression est present
    '- Si on est ni a l'état inscription ni à la supression, le form est alors à l'état Bilan, seuls le bouton fermer sera dispo (sans retour a l'accueil)
    Public etatInscription As Boolean = False
    Public etatSupp As Boolean = False
    Public numCandidat As Integer
    Private Sub FormRecap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If etatInscription = False Then
            candInscrit = listCandidat(numCandidat)
        End If
        'Init Info Candidat
        With candInscrit
            LabelInfoNum.Text = numCandidat.ToString
            LabelInfoNom.Text = .Nom
            LabelInfoPrenom.Text = .Prenom
            LabelInfoAge.Text = .Age
            LabelInfoAdresse.Text = .Adresse
            LabelInfoCP.Text = .CP
            LabelInfoVille.Text = .Ville
            LabelInfoRegion.Text = .Region
            If .EOF <> "" Then
                GroupBoxInfoEOF.Visible = True
                LabelEOF.Text = .EOF
            End If
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
        'Gestion des boutons
        If etatInscription Then 'l'état modifer affiche les même boutons que l'inscription
            AfficheButtonsInscrip()
        ElseIf etatSupp Then
            AfficheButtonsSupp()
        Else 'Si ni inscription ni suppression, on est alors dans l'état Bilan
            AfficheButtonsBilan()
        End If
    End Sub
    'Les boutons sont par défauts invisivle (visible = false)
    Private Sub AfficheButtonsInscrip()
        ButtonAnnuler.Visible = True
        ButtonModif.Visible = True
        ButtonValider.Visible = True
        GroupBoxNum.Visible = False
    End Sub
    Private Sub AfficheButtonsSupp()
        ButtonAnnuler.Visible = True
        ButtonSupp.Visible = True
    End Sub
    Private Sub AfficheButtonsBilan()
        ButtonAnnuler.Visible = True
        ButtonAnnuler.Text = "Fermer"
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        If etatInscription Or etatSupp Then
            FormInscripInfoCandidat.Close()
            FormInscripChoixEpreuves.Close()
            FormAccueil.Show()
        End If
        Me.Close() 'Si on est à l'état bilan (provisoire ou final), seule la dernière instruction se déclenche
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Me.Close()
        FormInscripInfoCandidat.Timer1min.Start()
        FormInscripInfoCandidat.numCandidat = Me.numCandidat
        FormInscripInfoCandidat.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        'Enregistrer officiel de l'inscription
        listCandidat(numCandidat) = candInscrit
        If numCandidat = NumAutoCandidat Then 'Le cas d'un nouveau candidat
            MsgBox("La candidature a bien été enregistré." + vbCrLf + "Voici le numéro d'incription du candidat enregistré : " + numCandidat.ToString,
                   MsgBoxStyle.Information, "Confirmation de l'enregistrement")
            NumAutoCandidat += 1
        Else 'Le cas d'une mise à jour des infos d'un candidat
            MsgBox("La candidature du candidat n° " + numCandidat.ToString + " bien été modifié",
               MsgBoxStyle.Information, "Confirmation de l'enregistrement")
        End If

        Me.Close()
        FormInscripInfoCandidat.Close()
        FormInscripChoixEpreuves.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        'Supprimer le candidat
        Dim choix As Integer = MsgBox("Supprimer le candidat n°" + numCandidat.ToString + " ?",
                                       MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question,
                                       "Demande de Confirmation de suppression")
        If choix = MsgBoxResult.Yes Then
            listCandidat.Remove(numCandidat)
            MsgBox("Le candidat n°" + numCandidat.ToString + " a bien été supprimé",
                           MsgBoxStyle.Information, "Confirmation de la suppression")
            Me.Close()
            FormAccueil.Show()
        End If
    End Sub
End Class