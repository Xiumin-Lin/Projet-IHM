Public Class FormEtat
    Private Sub FormEtat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelInfoCand.Text = listCandidat.Count
        If listCandidat.Count > 0 Then
            Dim listCandClassé As List(Of String) = New List(Of String)
            For Each kval As KeyValuePair(Of Integer, Candidat) In listCandidat
                listCandClassé.Add(kval.Value.Nom + " " + kval.Value.Prenom + kval.Key.ToString)
            Next
            listCandClassé.Sort()
            For Each c As String In listCandClassé
                Dim cpt As Integer = 1
                While IsNumeric(Strings.Right(c, cpt))  'Comme les nombres ne sont pas autorisé dans le nom et le prénom 
                    cpt += 1                            'cette boucle s'arrete forcément à un moment
                End While
                If Not String.IsNullOrEmpty(Strings.Right(c, cpt - 1)) Then
                    Dim idxCand As Integer = Integer.Parse(Strings.Right(c, cpt - 1))
                    With listCandidat(idxCand)
                        ListBoxID.Items.Add(idxCand)
                        ListBoxNom.Items.Add(.Nom)
                        ListBoxPrenom.Items.Add(.Prenom)
                        Dim s As String = ""
                        For Each ee As String In .EE
                            s += Matiere_abreger(ee) + " ; "
                        Next
                        ListBoxEE.Items.Add(s)
                        s = ""
                        For Each eo As String In .EO
                            s += Matiere_abreger(eo) + " ; "
                        Next
                        ListBoxEO.Items.Add(s)
                        ListBoxEOF.Items.Add(Matiere_abreger(.EOF))
                    End With
                End If
            Next
        End If

        'Mise en place des évènements ListBox.SelectedIndexChanged
        For Each lb As ListBox In PanelListBox.Controls
            AddHandler lb.SelectedIndexChanged, AddressOf Synchronisation_ListBox
        Next
    End Sub

    Private Sub Synchronisation_ListBox(sender As Object, e As EventArgs)
        Dim idx As Integer = sender.SelectedIndex
        ListBoxID.SelectedIndex = idx
        ListBoxNom.SelectedIndex = idx
        ListBoxPrenom.SelectedIndex = idx
        ListBoxEE.SelectedIndex = idx
        ListBoxEO.SelectedIndex = idx
        ListBoxEOF.SelectedIndex = idx
    End Sub

    Private Function Matiere_abreger(ByRef matiere As String) As String
        Select Case matiere
            Case "Programmation Web"
                Return "WEB"
            Case "Base de données"
                Return "BDD"
            Case "Langage C"
                Return "LGC"
            Case "Langage Java"
                Return "LGJ"
            Case "Visual Basic .NET"
                Return "VBN"
            Case Else
                Return Strings.Left(matiere.ToUpper, 3)
        End Select
        Return matiere
    End Function

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormAccueil.Show()
    End Sub
End Class