Module ModuleProjetIHM
    Public Structure Candidat
        Dim Nom As String
        Dim Prenom As String
        Dim Age As Integer
        Dim Adresse As String
        Dim CP As Integer
        Dim Ville As String
        Dim Region As String
        Dim EE As List(Of String)   'Epreuves Ecrites
        Dim EO As List(Of String)   'Epreuves Orales
        Dim EOF As String           'Epreuves Orale Facultative

        Public Sub New(ByVal n As String, ByVal p As String, ByVal a As String, ByVal adr As String,
                       ByVal c As String, ByVal v As String)
            Me.Nom = n
            Prenom = p
            Age = a
            Adresse = adr
            CP = c
            Ville = v
            Region = ""
            EE = New List(Of String)
            EO = New List(Of String)
            EOF = ""
        End Sub
    End Structure

    Public ReadOnly NB_EE_MAX As Integer = 4
    Public ReadOnly NB_EO_MAX As Integer = 3

    Public NumAutoCandidat As Integer = 1
    Public listCandidat As Dictionary(Of Integer, Candidat) = New Dictionary(Of Integer, Candidat)
    Public tabRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse",
        "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}
    Public tabEE() As String = {"Algorithmique", "Gestion", "Programmation Web", "Base de données", "Langage C",
               "Réseau", "Droit", "Langage Java", "Système", "Expression", "Mathématiques", "Visual Basic .NET"}
    Public tabEO() As String = {"Anglais", "Chinois", "Espagnol", "Droit", "Expression",
                                "Gestion", "Mathématiques", "Réseau", "Système"}

    Sub Main()
        Application.Run(FormAccueil)
    End Sub
End Module
