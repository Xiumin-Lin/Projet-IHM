Public Class FormInscripInfoCandidat
    Dim ErreurValidation As Boolean = False
    Dim Temps As Integer = 60
    ReadOnly AgeMin As Integer = 18
    ReadOnly AgeMax As Integer = 55
    Public numCandidat As Integer = NumAutoCandidat
    Private Sub FormInscripInfoCandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Formulaire d'inscription : Renseignements du candidat | " + TimeOfDay + " | Temps Restants : " + Temps.ToString + "s"
        'Init CANDIDAT 
        If numCandidat < NumAutoCandidat Then
            If listCandidat.ContainsKey(numCandidat) Then
                With listCandidat(numCandidat)
                    TextBoxNom.Text = .Nom
                    TextBoxPrenom.Text = .Prenom
                    LabelInfoAge.Text = .Age
                    TextBoxAdresse.Text = .Adresse
                    TextBoxCP.Text = .CP
                    TextBoxVille.Text = .Ville
                End With
            Else
                MsgBox("Le num du candidat demandé n'existe pas. Il a peut-être était supprimé.")
            End If
        End If
        'Init le ScrollBar pour l'age
        LabelAgeMin.Text = AgeMin.ToString + " ans"
        LabelAgeMax.Text = AgeMax.ToString + " ans"
        HScrollBar1.Minimum = AgeMin
        HScrollBar1.Maximum = AgeMax
        'Init le timer
        Timer1min.Interval = 1000
        Timer1min.Start()
    End Sub

    Private Sub Timer1min_Tick(sender As Object, e As EventArgs) Handles Timer1min.Tick
        Temps -= 1
        Me.Text = "Formulaire d'inscription : Renseignements du candidat | " + TimeOfDay + " | Temps Restants : " + Temps.ToString + "s"
        If Temps = 0 Then
            Timer1min.Stop()
            MsgBox("Le temps est écoulé !", MsgBoxStyle.Critical, "Trop lent")
            ButtonAbandon_Click(sender, e)
        End If
    End Sub

    Private Sub TxtBox_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNom.KeyPress, TextBoxPrenom.KeyPress, TextBoxVille.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.KeyChar = Chr(0) 'Si on entre un chiffre, le caractère est refusé et remplacé par le caractère nul
        End If
    End Sub

    Private Sub TextBoxCP_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCP.KeyPress
        If e.KeyChar = vbBack Then Exit Sub 'Seul les chiffres sont autorisés dans le textbox du code postale
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBox_LostFocus(sender As Object, e As EventArgs) Handles TextBoxNom.LostFocus, TextBoxPrenom.LostFocus, TextBoxVille.LostFocus
        'Quand le TxtBox perd le focus, les textes à l'interieurs sont convertit de façon à ce que la 1ère lettre soit en Maj et le reste en minuscule
        sender.Text = StrConv(LCase(sender.Text), VbStrConv.ProperCase)
    End Sub

    Private Sub TextBoxNom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNom.TextChanged
        LabelNom.ForeColor = Label.DefaultForeColor
    End Sub
    Private Sub TextBoxPrenom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrenom.TextChanged
        LabelPrenom.ForeColor = Label.DefaultForeColor
    End Sub
    Private Sub TextBoxAdresse_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAdresse.TextChanged
        LabelAdresse.ForeColor = Label.DefaultForeColor
    End Sub
    Private Sub TextBoxCP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCP.TextChanged
        LabelCP.ForeColor = Label.DefaultForeColor
    End Sub
    Private Sub TextBoxVille_TextChanged(sender As Object, e As EventArgs) Handles TextBoxVille.TextChanged
        LabelVille.ForeColor = Label.DefaultForeColor
    End Sub

    Private Sub TextBoxAge_TextChanged(sender As Object, e As EventArgs) Handles LabelInfoAge.TextChanged
        LabelAge.ForeColor = Label.DefaultForeColor
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        LabelInfoAge.Text = HScrollBar1.Value
    End Sub

    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        'Verif Condition avant
        ErreurValidation = False
        TextBox_testValidation(TextBoxNom, LabelNom)
        TextBox_testValidation(TextBoxPrenom, LabelPrenom)
        TextBox_testValidation(TextBoxAdresse, LabelAdresse)
        TextBox_testValidation(TextBoxVille, LabelVille)
        TextBox_testValidation(TextBoxCP, LabelCP)

        If TextBoxCP.TextLength = TextBoxCP.MaxLength Then 'Ici MaxLength = 5
            If TextBoxCP.Text.ElementAt(0) = "0" Or TextBoxCP.Text.ElementAt(1) = "0" Then
                LabelCP.ForeColor = Color.Red
                ErreurValidation = True
            End If
        Else
            LabelCP.ForeColor = Color.Red
            ErreurValidation = True
        End If
        Dim age As Integer
        If Not Integer.TryParse(LabelInfoAge.Text, age) Then
            LabelAge.ForeColor = Color.Red 'On vérifie que l'age soit bien un nombre
            ErreurValidation = True
        End If

        If Not ErreurValidation Then
            candInscrit = New Candidat(TextBoxNom.Text, TextBoxPrenom.Text, LabelInfoAge.Text,
                                         TextBoxAdresse.Text, TextBoxCP.Text, TextBoxVille.Text)

            If listCandidat.ContainsKey(numCandidat) Then 'Si le candidat existe déjà
                With candInscrit 'On prend une copie des lists 
                    For Each ee As String In listCandidat(numCandidat).EE
                        .EE.Add(ee)
                    Next
                    For Each eo As String In listCandidat(numCandidat).EO
                        .EO.Add(eo)
                    Next
                    .EOF = listCandidat(numCandidat).EOF
                    .Region = listCandidat(numCandidat).Region
                End With
            End If

            With FormInscripChoixEpreuves
                .Timer1min30.Start()
                .LabelNom.Text = TextBoxNom.Text
                .LabelPrenom.Text = TextBoxPrenom.Text
                .Show()
            End With
            Timer1min.Stop()
            Me.Hide()

        End If
    End Sub
    Private Sub TextBox_testValidation(tBox As TextBox, lab As Label)
        If tBox.Text = "" Then 'On vérifie que les textBox ne sont pas vide
            lab.ForeColor = Color.Red
            ErreurValidation = True
        End If
    End Sub
End Class