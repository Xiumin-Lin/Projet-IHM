Public Class FormBilan
    'Le form Bilan réunit le form Bilan Provisoire et le Bilan Final
    Private Sub FormBilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNbCand.Text = listCandidat.Count

        Dim listTrié As List(Of String) = New List(Of String)
        'Init et classe dans l'ordre alphabétique les candidats dans le ComboBox 
        For Each kval As KeyValuePair(Of Integer, Candidat) In listCandidat
            listTrié.Add(kval.Value.Nom + " " + kval.Value.Prenom + " | n°" + kval.Key.ToString)
        Next
        listTrié.Sort()
        For Each c As String In listTrié
            ComboBoxNomPrenom.Items.Add(c)
        Next

        listTrié.Clear()

        'Init et classe dans l'ordre alphabétique les matières dans le ComboBox 
        listTrié.AddRange(tabEE)
        For Each eo As String In tabEO
            If Not listTrié.Contains(eo) Then
                listTrié.Add(eo)
            End If
        Next
        listTrié.Sort()
        For Each c As String In listTrié
            ComboBoxMatiere.Items.Add(c)
        Next
    End Sub

    Private Sub ButtonShowCand_Click(sender As Object, e As EventArgs) Handles ButtonShowCand.Click
        Dim idx As Integer = ExtraireNumCandidat(ComboBoxNomPrenom.Text)
        If idx > 0 And listCandidat.ContainsKey(idx) Then
            FormRecap.numCandidat = idx
            FormRecap.Show()
        Else
            MsgBox("Entrée invalide !", MsgBoxStyle.Exclamation, "Erreur")
            LabelIndividuel.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub ButtonShowMatiere_Click(sender As Object, e As EventArgs) Handles ButtonShowMatiere.Click
        If ComboBoxMatiere.Text <> "" Then
            FormBilanMatiere.LabelMatiere.Text = ComboBoxMatiere.Text
            FormBilanMatiere.Show()
        Else
            MsgBox("Veuillez choisir la matière à afficher !", MsgBoxStyle.Exclamation, "Erreur")
            LabelMatiere.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonCloseApp_Click(sender As Object, e As EventArgs) Handles ButtonCloseApp.Click
        For Each matiere As String In ComboBoxMatiere.Items
            With FormBilanMatiere
                .LabelMatiere.Text = matiere
                .WindowState = FormWindowState.Minimized
                .Visible = False
                .Show()
                .SauvegardeBilanMatiere()
                .Close()
            End With
        Next
        MsgBox("Les fichiers listing des candidats inscrits par épreuve ont bien été crée", MsgBoxStyle.Information)
        Me.Close()
        inscriptionEnd = True
        FormAccueil.Close()
    End Sub

    Private Sub ComboBoxNom_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxNomPrenom.GotFocus
        LabelIndividuel.ForeColor = Label.DefaultForeColor
    End Sub

    Private Sub ComboBoxMatiere_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxMatiere.GotFocus
        LabelMatiere.ForeColor = Label.DefaultForeColor
    End Sub
End Class