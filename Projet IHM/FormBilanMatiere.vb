Public Class FormBilanMatiere
    Private ReadOnly O As String = "OUI"
    Private ReadOnly N As String = "NON"

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
                        ListBoxEE.Items.Add(O)
                    Else
                        ListBoxEE.Items.Add(N)
                    End If
                    If .EO.Contains(LabelMatiere.Text) Or .EOF.Equals(LabelMatiere.Text) Then
                        ListBoxEO.Items.Add(O)
                    Else
                        ListBoxEO.Items.Add(N)
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

    Public Sub SauvegardeBilanMatiere()
        If ListBoxRegion.Items.Count = 0 Then
            Exit Sub
        End If
        'On récup toutes les régions dispo pour cette matière
        Dim listRegionDispo As List(Of String) = New List(Of String)
        For Each region As String In ListBoxRegion.Items
            If Not listRegionDispo.Contains(region) Then
                listRegionDispo.Add(region)
            End If
        Next

        For Each region As String In listRegionDispo
            Dim listCandEE As List(Of Integer) = New List(Of Integer)
            Dim listCandEO As List(Of Integer) = New List(Of Integer)

            For idx As Integer = 0 To ListBoxID.Items.Count - 1
                ListBoxID.SelectedIndex = idx
                If listCandidat(ListBoxID.SelectedItem).Region.Equals(region) Then
                    If ListBoxEE.SelectedItem = O Then
                        listCandEE.Add(ListBoxID.SelectedItem)
                    Else
                        listCandEO.Add(ListBoxID.SelectedItem)
                    End If
                End If
            Next
            System.IO.Directory.CreateDirectory(LabelMatiere.Text)
            Dim numFile As Integer = FreeFile()
            Dim nom As String = LabelMatiere.Text + "\" + LabelMatiere.Text + " - " + region + ".txt"
            FileOpen(numFile, nom, OpenMode.Output)
            PrintLine(numFile, "Epreuve écrite :")
            If listCandEE.Count = 0 Then
                PrintLine(numFile, "< Aucun Candidat >")
            Else
                For Each numC As Integer In listCandEE
                    With listCandidat(numC)
                        PrintLine(numFile, .Nom + " " + .Prenom + " <-- n°" + numC.ToString)
                    End With
                Next
            End If

            PrintLine(numFile)
            PrintLine(numFile, "Epreuve orale :")
            If listCandEO.Count = 0 Then
                PrintLine(numFile, "< Aucun Candidat >")
            Else
                For Each numC As Integer In listCandEO
                    With listCandidat(numC)
                        PrintLine(numFile, .Nom + " " + .Prenom + " <-- n°" + numC.ToString)
                    End With
                Next
            End If
            FileClose()
        Next
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class