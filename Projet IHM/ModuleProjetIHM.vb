Module ModuleProjetIHM
    Public Structure Candidat
        Dim Nom As String
        Dim Prenom As String
        Dim Age As Integer
        Dim Adresse As String
        Dim CP As Integer           'Code Postal
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

    Public candInscrit As Candidat 'stock les données d'un candidat lors de son inscription
    Public NumAutoCandidat As Integer = 1
    Public listCandidat As Dictionary(Of Integer, Candidat) = New Dictionary(Of Integer, Candidat)

    Public tabRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse",
        "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}

    Public tabEE() As String = {"Algorithmique", "Gestion", "Programmation Web", "Base de données", "Langage C",
               "Réseau", "Droit", "Langage Java", "Système", "Expression", "Mathématiques", "Visual Basic .NET"}

    Public tabEO() As String = {"Anglais", "Chinois", "Espagnol", "Droit", "Expression",
                                "Gestion", "Mathématiques", "Réseau", "Système"}

    Sub Main()
        Dim c As Candidat
        Dim numFile As Integer = FreeFile()
        Dim inscriptionEnd As Boolean = False
        Application.Run(FormAccueil)
        If Not inscriptionEnd Then

        End If
    End Sub

    Public Function ExtraireNumCandidat(ByRef s As String) As Integer
        'Permet d'extraire le num du candidat d'après une chaîne de forme "Nom Prenom Num"
        'Exemple avec : "Jean Louis 19" la fonction extrait et retourne le nombre 19
        'Le num du candidat doit être obligatoirement être les dernière caractère de la phrase 
        'Si la chaîne de caractère ne respecte pas la forme demandé, la fonction retourne 0
        Dim cpt As Integer = 1
        While IsNumeric(Strings.Right(s, cpt))
            cpt += 1
            If s.Length = cpt Then
                Exit While
            End If
        End While
        If Strings.Right(s, cpt - 1) <> "" Then
            Return Integer.Parse(Strings.Right(s, cpt - 1))
        End If
        Return 0
    End Function
End Module
