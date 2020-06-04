<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEtat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelEtatActuel = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelEE = New System.Windows.Forms.Label()
        Me.ListBoxID = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.ListBoxEE = New System.Windows.Forms.ListBox()
        Me.LabelEO = New System.Windows.Forms.Label()
        Me.ListBoxEO = New System.Windows.Forms.ListBox()
        Me.ListBoxEOF = New System.Windows.Forms.ListBox()
        Me.LabelEOF = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.LabelNbCand = New System.Windows.Forms.Label()
        Me.LabelInfoCand = New System.Windows.Forms.Label()
        Me.PanelListBox = New System.Windows.Forms.Panel()
        Me.PanelListBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelEtatActuel
        '
        Me.LabelEtatActuel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEtatActuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!)
        Me.LabelEtatActuel.Location = New System.Drawing.Point(12, 22)
        Me.LabelEtatActuel.Name = "LabelEtatActuel"
        Me.LabelEtatActuel.Size = New System.Drawing.Size(1190, 42)
        Me.LabelEtatActuel.TabIndex = 0
        Me.LabelEtatActuel.Text = "Etat Actuel des Inscriptions"
        Me.LabelEtatActuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelID.Location = New System.Drawing.Point(23, 119)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(123, 20)
        Me.LabelID.TabIndex = 5
        Me.LabelID.Text = "N° d'inscription"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNom.Location = New System.Drawing.Point(152, 119)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(44, 20)
        Me.LabelNom.TabIndex = 7
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelPrenom.Location = New System.Drawing.Point(365, 119)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(67, 20)
        Me.LabelPrenom.TabIndex = 9
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelEE
        '
        Me.LabelEE.AutoSize = True
        Me.LabelEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEE.Location = New System.Drawing.Point(648, 119)
        Me.LabelEE.Name = "LabelEE"
        Me.LabelEE.Size = New System.Drawing.Size(137, 20)
        Me.LabelEE.TabIndex = 11
        Me.LabelEE.Text = "Epreuves Ecrites"
        '
        'ListBoxID
        '
        Me.ListBoxID.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.ItemHeight = 20
        Me.ListBoxID.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(90, 204)
        Me.ListBoxID.TabIndex = 6
        '
        'ListBoxNom
        '
        Me.ListBoxNom.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 20
        Me.ListBoxNom.Location = New System.Drawing.Point(99, 3)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(215, 204)
        Me.ListBoxNom.TabIndex = 8
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 20
        Me.ListBoxPrenom.Location = New System.Drawing.Point(320, 3)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(277, 204)
        Me.ListBoxPrenom.TabIndex = 10
        '
        'ListBoxEE
        '
        Me.ListBoxEE.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEE.FormattingEnabled = True
        Me.ListBoxEE.ItemHeight = 20
        Me.ListBoxEE.Location = New System.Drawing.Point(603, 3)
        Me.ListBoxEE.Name = "ListBoxEE"
        Me.ListBoxEE.Size = New System.Drawing.Size(247, 204)
        Me.ListBoxEE.TabIndex = 12
        '
        'LabelEO
        '
        Me.LabelEO.AutoSize = True
        Me.LabelEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEO.Location = New System.Drawing.Point(901, 119)
        Me.LabelEO.Name = "LabelEO"
        Me.LabelEO.Size = New System.Drawing.Size(134, 20)
        Me.LabelEO.TabIndex = 13
        Me.LabelEO.Text = "Epreuves Orales"
        '
        'ListBoxEO
        '
        Me.ListBoxEO.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEO.FormattingEnabled = True
        Me.ListBoxEO.ItemHeight = 20
        Me.ListBoxEO.Location = New System.Drawing.Point(856, 3)
        Me.ListBoxEO.Name = "ListBoxEO"
        Me.ListBoxEO.Size = New System.Drawing.Size(185, 204)
        Me.ListBoxEO.TabIndex = 14
        '
        'ListBoxEOF
        '
        Me.ListBoxEOF.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxEOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEOF.FormattingEnabled = True
        Me.ListBoxEOF.ItemHeight = 20
        Me.ListBoxEOF.Location = New System.Drawing.Point(1047, 3)
        Me.ListBoxEOF.Name = "ListBoxEOF"
        Me.ListBoxEOF.Size = New System.Drawing.Size(79, 204)
        Me.ListBoxEOF.TabIndex = 16
        '
        'LabelEOF
        '
        Me.LabelEOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEOF.Location = New System.Drawing.Point(1080, 95)
        Me.LabelEOF.Name = "LabelEOF"
        Me.LabelEOF.Size = New System.Drawing.Size(122, 44)
        Me.LabelEOF.TabIndex = 15
        Me.LabelEOF.Text = "Epreuve Oral Facultative"
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Azure
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonBack.Location = New System.Drawing.Point(512, 362)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(180, 45)
        Me.ButtonBack.TabIndex = 17
        Me.ButtonBack.Text = "Retour"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'LabelNbCand
        '
        Me.LabelNbCand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNbCand.Location = New System.Drawing.Point(45, 38)
        Me.LabelNbCand.Name = "LabelNbCand"
        Me.LabelNbCand.Size = New System.Drawing.Size(87, 44)
        Me.LabelNbCand.TabIndex = 18
        Me.LabelNbCand.Text = "Nb de candidat :"
        '
        'LabelInfoCand
        '
        Me.LabelInfoCand.AutoSize = True
        Me.LabelInfoCand.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelInfoCand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoCand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelInfoCand.Location = New System.Drawing.Point(138, 42)
        Me.LabelInfoCand.Name = "LabelInfoCand"
        Me.LabelInfoCand.Size = New System.Drawing.Size(38, 22)
        Me.LabelInfoCand.TabIndex = 19
        Me.LabelInfoCand.Text = "???"
        '
        'PanelListBox
        '
        Me.PanelListBox.Controls.Add(Me.ListBoxID)
        Me.PanelListBox.Controls.Add(Me.ListBoxPrenom)
        Me.PanelListBox.Controls.Add(Me.ListBoxNom)
        Me.PanelListBox.Controls.Add(Me.ListBoxEE)
        Me.PanelListBox.Controls.Add(Me.ListBoxEOF)
        Me.PanelListBox.Controls.Add(Me.ListBoxEO)
        Me.PanelListBox.Location = New System.Drawing.Point(49, 142)
        Me.PanelListBox.Name = "PanelListBox"
        Me.PanelListBox.Size = New System.Drawing.Size(1130, 214)
        Me.PanelListBox.TabIndex = 16
        '
        'FormEtat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1214, 429)
        Me.Controls.Add(Me.PanelListBox)
        Me.Controls.Add(Me.LabelInfoCand)
        Me.Controls.Add(Me.LabelNbCand)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.LabelEOF)
        Me.Controls.Add(Me.LabelEO)
        Me.Controls.Add(Me.LabelEE)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelEtatActuel)
        Me.Name = "FormEtat"
        Me.Text = "Etat Actuel"
        Me.PanelListBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEtatActuel As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelEE As Label
    Friend WithEvents ListBoxID As ListBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxPrenom As ListBox
    Friend WithEvents ListBoxEE As ListBox
    Friend WithEvents LabelEO As Label
    Friend WithEvents ListBoxEO As ListBox
    Friend WithEvents ListBoxEOF As ListBox
    Friend WithEvents LabelEOF As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents LabelNbCand As Label
    Friend WithEvents LabelInfoCand As Label
    Friend WithEvents PanelListBox As Panel
End Class
