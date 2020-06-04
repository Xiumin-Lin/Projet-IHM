Module ModuleProjetIHM
    Public Structure Candidat 'Stock les infos d'un candidat
        Dim Nom As String
        Dim Prenom As String
        Dim Age As Integer
        Dim Adresse As String
        Dim CP As String           'Code Postal
        Dim Ville As String
        Dim Region As String
        Dim EE As List(Of String)   'Epreuves Ecrites
        Dim EO As List(Of String)   'Epreuves Orales
        Dim EOF As String           'Epreuves Orale Facultative

        Public Sub New(ByVal n As String, ByVal p As String, ByVal a As String, ByVal adr As String,
                       ByVal c As String, ByVal v As String)
            Me.Nom = n
            Prenom = p
            Age = Integer.Parse(a)
            Adresse = adr
            CP = c
            Ville = v
            Region = ""
            EE = New List(Of String)
            EO = New List(Of String)
            EOF = ""
        End Sub
    End Structure

    Public ReadOnly NB_EE_MAX As Integer = 4 'Le nb d'épreuves écrite à prendre
    Public ReadOnly NB_EO_MAX As Integer = 3 'Le nb d'épreuves orale à prendre
    Public inscriptionEnd As Boolean = False 'Indique si l'inscription est fermée ou pas

    Public candInscrit As Candidat 'stock les données d'un candidat lors de son inscription
    Public NumAutoCandidat As Integer = 1
    'List des candidats dont l'inscription ont été valider
    Public listCandidat As Dictionary(Of Integer, Candidat) = New Dictionary(Of Integer, Candidat)

    Public tabRegion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse",
        "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}

    Public tabEE() As String = {"Algorithmique", "Gestion", "Programmation Web", "Base de données", "Langage C",
               "Réseau", "Droit", "Langage Java", "Système", "Expression", "Mathématiques", "Visual Basic .NET"}

    Public tabEO() As String = {"Anglais", "Chinois", "Espagnol", "Droit", "Expression",
                                "Gestion", "Mathématiques", "Réseau", "Système"}

    Sub Main()
        Dim nomFile As String = "Sauvegarde.txt"
        If System.IO.File.Exists(nomFile) Then
            LectureSauvegarde(nomFile)
        End If

        Application.Run(FormAccueil)
        'Si les inscription ne sont pas terminé, on sauvegarde
        If Not inscriptionEnd Then
            EcrireSauvegarde(nomFile)
            MsgBox("La liste des candidats a bien été sauvegardé ! ")
        End If
    End Sub

    Private Sub LectureSauvegarde(ByRef nomFile As String)
        Dim numFile As Integer = FreeFile()

        FileOpen(numFile, nomFile, OpenMode.Input)
        While Not EOF(numFile)
            Dim numCand As Integer
            Dim c As Candidat = New Candidat("", "", "0", "", "", "")

            Input(numFile, numCand)
            Input(numFile, c.Nom)
            Input(numFile, c.Prenom)
            Input(numFile, c.Age)
            Input(numFile, c.Adresse)
            Input(numFile, c.CP)
            Input(numFile, c.Ville)
            Input(numFile, c.Region)
            For i As Integer = 1 To NB_EE_MAX
                Dim ee As String = ""
                Input(numFile, ee)
                c.EE.Add(ee)
            Next
            For i As Integer = 1 To NB_EO_MAX
                Dim eo As String = ""
                Input(numFile, eo)
                c.EO.Add(eo)
            Next
            Input(numFile, c.EOF)
            LineInput(numFile)

            listCandidat.Add(numCand, c)
            If numCand >= NumAutoCandidat Then
                NumAutoCandidat = numCand + 1
            End If
        End While
        FileClose(numFile)
    End Sub

    Private Sub EcrireSauvegarde(ByRef nomFile As String)
        Dim numFile As Integer = FreeFile()
        FileOpen(numFile, nomFile, OpenMode.Output)
        For Each kval As KeyValuePair(Of Integer, Candidat) In listCandidat
            Write(numFile, kval.Key)
            With kval.Value
                Write(numFile, .Nom)
                Write(numFile, .Prenom)
                Write(numFile, .Age)
                Write(numFile, .Adresse)
                Write(numFile, .CP)
                Write(numFile, .Ville)
                Write(numFile, .Region)
                For Each ee As String In .EE
                    Write(numFile, ee)
                Next
                For Each eo As String In .EO
                    Write(numFile, eo)
                Next
                WriteLine(numFile, .EOF)
                WriteLine(numFile)
            End With
        Next
        FileClose(numFile)
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
