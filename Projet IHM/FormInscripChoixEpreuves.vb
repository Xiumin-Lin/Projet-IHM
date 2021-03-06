﻿Public Class FormInscripChoixEpreuves
    Dim Temps As Integer = 90
    Dim nbEERestant As Integer = NB_EE_MAX
    Dim nbEORestant As Integer = NB_EO_MAX
    Dim numCandidat As Integer = FormInscripInfoCandidat.numCandidat

    Private Sub FormInscripChoixEpreuves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init le timer
        Me.Text = "Formulaire d'inscription : Choix des épreuves | " + TimeOfDay + " | Temps Restants : " + Temps.ToString + "s"
        Timer1min30.Interval = 1000
        Timer1min30.Start()
        'Ajout list des régions
        ComboBoxRegion.Items.AddRange(tabRegion)
        ComboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxRegion.SelectedIndex = 0
        'Mise en place des évènements CheckBox_CheckedChanged
        For Each chk As CheckBox In GroupBoxEcrit.Controls
            AddHandler chk.CheckedChanged, AddressOf CheckBoxEcrit_CheckedChanged
        Next

        For Each chk As CheckBox In GroupBoxOral.Controls
            AddHandler chk.CheckedChanged, AddressOf CheckBoxOral_CheckedChanged
        Next
        'Init le compteur d'épreuve restante à choisir
        LabelNbEERestant.Text = nbEERestant.ToString
        LabelNbEORestant.Text = nbEORestant.ToString

        'Init le candidat s'il existe (utilisé lors d'une modif ou supp)
        If numCandidat < NumAutoCandidat Then
            With candInscrit
                'Init la region du candidat
                For idx As Integer = 0 To ComboBoxRegion.Items.Count - 1
                    If .Region.Equals(ComboBoxRegion.Items(idx)) Then
                        ComboBoxRegion.SelectedIndex = idx
                    End If
                Next
                'Init les Epreuves écrites et orales
                For Each chk As CheckBox In GroupBoxEcrit.Controls
                    If .EE.Contains(chk.Text) Then
                        chk.Checked = True
                    End If
                Next
                For Each chk As CheckBox In GroupBoxOral.Controls
                    If .EO.Contains(chk.Text) Then
                        chk.Checked = True
                    End If
                Next
                'Init l'épreuves facultative s'il en a
                If .EOF = String.Empty Then
                    RadioButtonNon.Checked = True
                Else
                    RadioButtonYes.Checked = True
                    For idx As Integer = 0 To ComboBoxEFacultative.Items.Count - 1
                        If .EOF.Equals(ComboBoxEFacultative.Items(idx)) Then
                            ComboBoxEFacultative.SelectedIndex = idx
                        End If
                    Next
                End If
            End With
        End If
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

    Private Sub RadioButtonYes_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonYes.CheckedChanged,
                                                                                        RadioButtonNon.CheckedChanged
        If RadioButtonYes.Checked Then
            'Ajout list des matières
            SetListMatiereNonChoisi(tabEE, GroupBoxEcrit)
            SetListMatiereNonChoisi(tabEO, GroupBoxOral)
            ComboBoxEFacultative.Sorted = True
            ComboBoxEFacultative.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBoxEFacultative.SelectedIndex = 0
            ComboBoxEFacultative.Visible = True
            GroupBoxEcrit.Enabled = False
            GroupBoxOral.Enabled = False
        Else
            ComboBoxEFacultative.Items.Clear()
            ComboBoxEFacultative.Visible = False
            GroupBoxEcrit.Enabled = True
            GroupBoxOral.Enabled = True
        End If
        RadioButtonYes.ForeColor = RadioButton.DefaultForeColor
        RadioButtonNon.ForeColor = RadioButton.DefaultForeColor
    End Sub
    'Ajoute dans le ComboBoxEFacultative les matières non selectionnées d'un groupeBox de checkBox
    'tabMatiere est un tableau listant tous les matières présentes dans un groupeBox
    Private Sub SetListMatiereNonChoisi(tabMatiere As String(), gBox As GroupBox)
        For Each m As String In tabMatiere
            If Not ComboBoxEFacultative.Items.Contains(m) Then
                Dim invalide As Boolean = False
                For Each chk As CheckBox In gBox.Controls
                    If chk.Checked Or chk.Enabled = False Then
                        If m.Equals(chk.Text) Then
                            invalide = True
                            Exit For
                        End If
                    End If
                Next
                If Not invalide Then
                    ComboBoxEFacultative.Items.Add(m)
                End If
            End If
        Next
    End Sub

    Private Sub CheckBoxEcrit_CheckedChanged(sender As Object, e As EventArgs)
        If sender.Checked Then
            nbEERestant -= 1
            If nbEERestant < 0 Then
                MsgBox("Vous ne pouvez pas choisir plus de 4 matières à l'écrit")
                sender.Checked = False
            End If
        Else
            nbEERestant += 1
        End If

        CheckBox_CheckDouble(sender) 'Si un matiere à une épreuve ecrite et orale, on désative le choix de l'épreuve non coché 

        'On active le choix d'une epreuve facultative
        If nbEERestant = 0 And nbEORestant = 0 Then
            GroupBoxEFacultative.Enabled = True
        Else
            GroupBoxEFacultative.Enabled = False
        End If

        GroupBoxEcrit.ForeColor = GroupBox.DefaultForeColor
        LabelNbEERestant.Text = nbEERestant.ToString 'on actualise le nb de choix restant
    End Sub

    Private Sub CheckBoxOral_CheckedChanged(sender As Object, e As EventArgs)
        If sender.Checked Then
            nbEORestant -= 1
            If nbEORestant < 0 Then
                MsgBox("Vous ne pouvez pas choisir plus de 3 matières à l'oral")
                sender.Checked = False
            End If
        Else
            nbEORestant += 1
        End If

        CheckBox_CheckDouble(sender) 'Si un matiere à une épreuve ecrite et orale, on désactive le choix de l'épreuve non coché 
        'On active le choix d'une epreuve facultative

        If nbEERestant = 0 And nbEORestant = 0 Then
            GroupBoxEFacultative.Enabled = True
        Else
            GroupBoxEFacultative.Enabled = False
        End If

        GroupBoxOral.ForeColor = GroupBox.DefaultForeColor
        LabelNbEORestant.Text = nbEORestant.ToString 'on actualise le nb de choix restant
    End Sub

    'Si le checkBox d'une matière est coché, alors le checkBox de l'autre version de la même matière est désactivé
    Private Sub CheckBox_switchEnabled(chk1 As CheckBox, chk2 As CheckBox)
        If chk1.Checked Then
            chk2.Enabled = False
        Else
            chk2.Enabled = True
        End If
    End Sub

    'On associe le checkBox d'une matière à l'autre version du checkBox de la même matière
    Private Sub CheckBox_CheckDouble(chk As CheckBox)
        Select Case chk.Name
            Case CheckBoxDroit.Name
                CheckBox_switchEnabled(CheckBoxDroit, CheckBoxDroitO)
            Case CheckBoxDroitO.Name
                CheckBox_switchEnabled(CheckBoxDroitO, CheckBoxDroit)
            Case CheckBoxExp.Name
                CheckBox_switchEnabled(CheckBoxExp, CheckBoxExpO)
            Case CheckBoxExpO.Name
                CheckBox_switchEnabled(CheckBoxExpO, CheckBoxExp)
            Case CheckBoxGesE.Name
                CheckBox_switchEnabled(CheckBoxGesE, CheckBoxGesO)
            Case CheckBoxGesO.Name
                CheckBox_switchEnabled(CheckBoxGesO, CheckBoxGesE)
            Case CheckBoxMaths.Name
                CheckBox_switchEnabled(CheckBoxMaths, CheckBoxMathsO)
            Case CheckBoxMathsO.Name
                CheckBox_switchEnabled(CheckBoxMathsO, CheckBoxMaths)
            Case CheckBoxRes.Name
                CheckBox_switchEnabled(CheckBoxRes, CheckBoxResO)
            Case CheckBoxResO.Name
                CheckBox_switchEnabled(CheckBoxResO, CheckBoxRes)
            Case CheckBoxSys.Name
                CheckBox_switchEnabled(CheckBoxSys, CheckBoxSysO)
            Case CheckBoxSysO.Name
                CheckBox_switchEnabled(CheckBoxSysO, CheckBoxSys)
        End Select
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        FormAccueil.Show()
        FormInscripInfoCandidat.Close()
        Me.Close()
    End Sub

    Private Sub ButtonValidChoixEp_Click(sender As Object, e As EventArgs) Handles ButtonValidChoixEp.Click
        Dim ErreurValidation As Boolean = False 'Verif Condition
        Dim s As String = ""
        If nbEERestant <> 0 Then
            s = "- Vous devez obligatoirement choisir 4 épreuves écrites" + vbCrLf
            GroupBoxEcrit.ForeColor = Color.Red
            ErreurValidation = True
        End If
        If nbEORestant <> 0 Then
            s += "- Vous devez obligatoirement choisir 3 épreuves orales" + vbCrLf
            GroupBoxOral.ForeColor = Color.Red
            ErreurValidation = True
        End If
        If Not RadioButtonYes.Checked And Not RadioButtonNon.Checked Then
            s += "- Vous devez indiquer votre choix concernant le choix d'une épreuve facultative"
            RadioButtonYes.ForeColor = Color.Red
            RadioButtonNon.ForeColor = Color.Red
            ErreurValidation = True
        End If

        If ErreurValidation Then
            MsgBox(s, MsgBoxStyle.Exclamation, "Validation non autorisée")
        Else
            candInscrit.Region = ComboBoxRegion.Text
            If RadioButtonNon.Checked Then
                candInscrit.EOF = String.Empty
            Else
                candInscrit.EOF = ComboBoxEFacultative.Text
            End If

            candInscrit.EE.Clear()
            For Each chk As CheckBox In GroupBoxEcrit.Controls
                If chk.Checked Then
                    candInscrit.EE.Add(chk.Text)
                End If
            Next
            candInscrit.EO.Clear()
            For Each chk As CheckBox In GroupBoxOral.Controls
                If chk.Checked Then
                    candInscrit.EO.Add(chk.Text)
                End If
            Next

            FormRecap.etatInscription = True
            Me.Hide()
            Timer1min30.Stop()
            FormRecap.numCandidat = Me.numCandidat
            FormRecap.Show()
        End If
    End Sub
End Class