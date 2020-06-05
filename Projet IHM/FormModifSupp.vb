Public Class FormModifSupp
    'Le formulaire FormModifSupp réunis 2 formulaires en 1, le formulaire de modification des données d'un candidat 
    'et le formulaire de suppression d'un candidat. 
    'Le passage d'un formulaire à un autre est indiqué par l'attribut etatModif :
    ' Si True alors le formulaire est en mode modification
    ' Sinon le formulaire est en mode suppression

    Public etatModif As Boolean = True 'Par défautl, le formulaire est en mode modification
    Private Sub FormModifSupp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If listCandidat.Count <> 0 Then
            For Each kval As KeyValuePair(Of Integer, Candidat) In listCandidat
                ComboBoxIdCand.Items.Add(kval.Value.Nom + " " + kval.Value.Prenom + " | n°" + kval.Key.ToString)
            Next
        Else
            MsgBox("Il y a aucun candidat inscrit ! Le bouton 'Valider' est désactiver", MsgBoxStyle.Exclamation)
            ButtonValider.Enabled = False
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNumCand.CheckedChanged, RadioButtonIDCand.CheckedChanged
        If RadioButtonNumCand.Checked Then
            PanelNum.Enabled = True
            PanelID.Enabled = False
        Else
            PanelNum.Enabled = False
            PanelID.Enabled = True
        End If
    End Sub

    Private Sub TextBoxNumCand_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNumCand.KeyPress
        If e.KeyChar = vbBack Then Exit Sub 'Seul les chiffres sont autorisés
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        If Not RadioButtonNumCand.Checked And Not RadioButtonIDCand.Checked Then
            MsgBox("Veuillez choisir le moyen d'acccès aux données d'un candidat", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If RadioButtonNumCand.Checked Then 'acces par num du candidat
            If TextBoxNumCand.Text = "" Then
                LabelNumCandidat.ForeColor = Color.Red
                Exit Sub
            End If

            If listCandidat.ContainsKey(Integer.Parse(TextBoxNumCand.Text)) Then
                If etatModif Then 'Formulaire en mode modification
                    FormInscripInfoCandidat.numCandidat = Integer.Parse(TextBoxNumCand.Text)
                Else 'Formulaire en mode suppression
                    FormRecap.etatSupp = True
                    FormRecap.numCandidat = Integer.Parse(TextBoxNumCand.Text)
                End If
            Else
                MsgBox("Le candidat n°" + TextBoxNumCand.Text + " n'est pas présent dans la liste des candidats enregistrés !",
                        MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        Else 'acces par identifiant du candidat
            If ComboBoxIdCand.Text = "" Or Not ComboBoxIdCand.Items.Contains(ComboBoxIdCand.Text) Then
                LabelIDCandidat.ForeColor = Color.Red
                MsgBox("Entrée Invalide ! Le candidat que vous avez saisi n'est pas présent dans la liste des candidats",
                       MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim num As Integer = ExtraireNumCandidat(ComboBoxIdCand.Text)
            If num > 0 And listCandidat.ContainsKey(num) Then
                If etatModif Then 'Formulaire en mode modification
                    FormInscripInfoCandidat.numCandidat = num
                Else 'Formulaire en mode suppression
                    FormRecap.etatSupp = True
                    FormRecap.numCandidat = num
                End If
            Else
                MsgBox("Erreur, num de candidat invalide") 'Normalement on n'arrive jamais à ce condition "else" 
                Exit Sub
            End If
        End If

        If etatModif Then
            FormInscripInfoCandidat.Show()
        Else
            FormRecap.Show()
        End If
        Me.Close()
    End Sub

    Private Sub ComboBox_TextBox_Changed(sender As Object, e As EventArgs) Handles ComboBoxIdCand.GotFocus, TextBoxNumCand.TextChanged
        LabelNumCandidat.ForeColor = Label.DefaultForeColor
        LabelIDCandidat.ForeColor = Label.DefaultForeColor
    End Sub
End Class