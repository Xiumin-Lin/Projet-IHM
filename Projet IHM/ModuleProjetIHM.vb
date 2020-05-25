Module ModuleProjetIHM
    Public Structure Candidat
        Dim Num As Integer
        Dim Nom As String
        Dim Prenom As String
        Dim Age As Integer
        Dim Adresse As String
        Dim CP As Integer
        Dim Ville As String
        Dim Region As String
        Dim EE() As List(Of String)
        Dim EO() As List(Of String)
        Dim EOF As String
    End Structure

    Public Structure Matiere
        Dim libelle As String
        Dim ecrit As Boolean
        Dim orale As Boolean
        Dim abrege As String
        Sub New(ByVal libe As String, ByVal e As Boolean, ByVal o As Boolean)
            libelle = libe
            ecrit = e
            orale = o
        End Sub
    End Structure

    Public listCandidat As List(Of Candidat)
    Public listMatiere As Dictionary(Of String, Matiere)
    Public tabRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse",
        "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}

    Sub Main()
        listCandidat = New List(Of Candidat)
        listMatiere = New Dictionary(Of String, Matiere)
        With listMatiere
            .Add("ALG", New Matiere("Algorithmique", True, False))
            .Add("GES", New Matiere("Gestion", True, True))
            .Add("WEB", New Matiere("Programmation Web", True, False))
            .Add("BAS", New Matiere("Base de données", True, False))
            .Add("LGC", New Matiere("Langage C", True, False))
            .Add("RES", New Matiere("Réseau", True, True))
            .Add("DRO", New Matiere("Droit", True, True))
            .Add("LGJ", New Matiere("Langage Java", True, False))
            .Add("SYS", New Matiere("Système", True, True))
            .Add("EXP", New Matiere("Expression", True, True))
            .Add("MAT", New Matiere("Mathématiques", True, True))
            .Add("NET", New Matiere("Visual Basic .NET", True, False))
            .Add("ANG", New Matiere("Anglais", False, True))
            .Add("CHI", New Matiere("Chinois", False, True))
            .Add("ESP", New Matiere("Espagnol", False, True))
        End With
        Application.Run(FormAccueil)
    End Sub
End Module
