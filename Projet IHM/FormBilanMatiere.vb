Public Class FormBilanMatiere

    Private Sub FormBilanMatiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listEluTrié As List(Of String) = New List(Of String)

        For Each kval As KeyValuePair(Of Integer, Candidat) In listCandidat
            If kval.Value.EOF.Equals(LabelMatiere.Text) Or kval.Value.EE.Contains(LabelMatiere.Text) Or kval.Value.EO.Contains(LabelMatiere.Text) Then
                listEluTrié.Add(kval.Value.Region + kval.Value.Nom + kval.Value.Prenom + kval.Key.ToString)
            End If
        Next
        listEluTrié.Sort()

        'On ajoute les données des candidats dans les différentes ListBox
        For Each c As String In listEluTrié
            Dim num As Integer = ExtraireNumCandidat(c)
            If num > 0 Then
                With listCandidat(num)
                    ListBoxRegion.Items.Add(.Region)
                    ListBoxID.Items.Add(num)
                    ListBoxNom.Items.Add(.Nom)
                    ListBoxPrenom.Items.Add(.Prenom)
                    If .EE.Contains(LabelMatiere.Text) Then
                        ListBoxEE.Items.Add("OUI")
                    Else
                        ListBoxEE.Items.Add("NON")
                    End If
                    If .EO.Contains(LabelMatiere.Text) Or .EOF.Equals(LabelMatiere.Text) Then
                        ListBoxEO.Items.Add("OUI")
                    Else
                        ListBoxEO.Items.Add("NON")
                    End If
                End With
            End If
        Next

        'Mise en place des évènements ListBox.SelectedIndexChanged
        For Each lb As ListBox In PanelListBox.Controls
            AddHandler lb.SelectedIndexChanged, AddressOf Synchronisation_ListBox
        Next
    End Sub

    Private Sub Synchronisation_ListBox(sender As Object, e As EventArgs)
        Dim idx As Integer = sender.SelectedIndex
        ListBoxRegion.SelectedIndex = idx
        ListBoxID.SelectedIndex = idx
        ListBoxNom.SelectedIndex = idx
        ListBoxPrenom.SelectedIndex = idx
        ListBoxEE.SelectedIndex = idx
        ListBoxEO.SelectedIndex = idx
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class