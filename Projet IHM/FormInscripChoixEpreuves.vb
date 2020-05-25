Public Class FormInscripChoixEpreuves
    Private ErreurValidation As Boolean = False
    Private Temps As Integer = 90
    Private Sub FormInscripChoixEpreuves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNom.Text = FormInscripInfoCandidat.TextBoxNom.Text
        LabelPrenom.Text = FormInscripInfoCandidat.TextBoxPrenom.Text
        Me.Text = "Formulaire d'inscription : Choix des épreuves | " + TimeOfDay + " | Temps Restants : " + Temps.ToString + "s"
        Timer1min30.Interval = 1000
        Timer1min30.Start()
        'ajout list des régions
        ComboBoxRegion.Items.AddRange(tabRegion)
        ComboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRegion.SelectedIndex = 0
        'ajout list des matières
        For Each m As KeyValuePair(Of String, Matiere) In listMatiere
            If m.Value.orale Then
                ComboBoxEFacultative.Items.Add(m.Value.libelle)
            End If
        Next
        ComboBoxEFacultative.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEFacultative.SelectedIndex = 0

    End Sub
    Private Sub Timer1min_Tick(sender As Object, e As EventArgs) Handles Timer1min30.Tick
        Temps -= 1
        Me.Text = "Formulaire d'inscription : Choix des épreuves | " + TimeOfDay + " | Temps Restants : " + Temps.ToString + "s"
        If Temps = 0 Then
            Timer1min30.Stop()
            MsgBox("Le temps est écoulé !", MsgBoxStyle.Critical, "Trop lent")
            ButtonAnnuler_Click(sender, e)
        End If
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        FormAccueil.Show()
        FormInscripInfoCandidat.Close()
        Me.Close()
    End Sub

    Private Sub ButtonValidChoixEp_Click(sender As Object, e As EventArgs) Handles ButtonValidChoixEp.Click
        'Verif Condition
        With FormRecap
            .ButtonAnnuler.Visible = True
            .ButtonModif.Visible = True
            .ButtonValider.Visible = True
            .ButtonSupp.Visible = False
            .ButtonClose.Visible = False
        End With
        Me.Hide()
        Timer1min30.Stop()
        FormRecap.Show()
    End Sub

    Private Sub RadioButtonYes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYes.CheckedChanged, RadioButtonNon.CheckedChanged
        If RadioButtonYes.Checked Then
            ComboBoxEFacultative.Visible = True
        Else
            ComboBoxEFacultative.Visible = False
        End If
    End Sub
End Class