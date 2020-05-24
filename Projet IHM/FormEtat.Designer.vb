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
        Me.SuspendLayout()
        '
        'LabelEtatActuel
        '
        Me.LabelEtatActuel.AutoSize = True
        Me.LabelEtatActuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!)
        Me.LabelEtatActuel.Location = New System.Drawing.Point(278, 45)
        Me.LabelEtatActuel.Name = "LabelEtatActuel"
        Me.LabelEtatActuel.Size = New System.Drawing.Size(411, 38)
        Me.LabelEtatActuel.TabIndex = 0
        Me.LabelEtatActuel.Text = "Etat Actuel des Inscriptions"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelID.Location = New System.Drawing.Point(12, 135)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(123, 20)
        Me.LabelID.TabIndex = 5
        Me.LabelID.Text = "N° d'inscription"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNom.Location = New System.Drawing.Point(158, 135)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(44, 20)
        Me.LabelNom.TabIndex = 7
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelPrenom.Location = New System.Drawing.Point(333, 135)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(67, 20)
        Me.LabelPrenom.TabIndex = 9
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelEE
        '
        Me.LabelEE.AutoSize = True
        Me.LabelEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEE.Location = New System.Drawing.Point(504, 135)
        Me.LabelEE.Name = "LabelEE"
        Me.LabelEE.Size = New System.Drawing.Size(137, 20)
        Me.LabelEE.TabIndex = 11
        Me.LabelEE.Text = "Epreuves Ecrites"
        '
        'ListBoxID
        '
        Me.ListBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.ItemHeight = 20
        Me.ListBoxID.Location = New System.Drawing.Point(45, 178)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(90, 184)
        Me.ListBoxID.TabIndex = 6
        '
        'ListBoxNom
        '
        Me.ListBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 20
        Me.ListBoxNom.Location = New System.Drawing.Point(161, 178)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(155, 184)
        Me.ListBoxNom.TabIndex = 8
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 20
        Me.ListBoxPrenom.Location = New System.Drawing.Point(336, 178)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(146, 184)
        Me.ListBoxPrenom.TabIndex = 10
        '
        'ListBoxEE
        '
        Me.ListBoxEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEE.FormattingEnabled = True
        Me.ListBoxEE.ItemHeight = 20
        Me.ListBoxEE.Location = New System.Drawing.Point(508, 178)
        Me.ListBoxEE.Name = "ListBoxEE"
        Me.ListBoxEE.Size = New System.Drawing.Size(152, 184)
        Me.ListBoxEE.TabIndex = 12
        '
        'LabelEO
        '
        Me.LabelEO.AutoSize = True
        Me.LabelEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEO.Location = New System.Drawing.Point(677, 135)
        Me.LabelEO.Name = "LabelEO"
        Me.LabelEO.Size = New System.Drawing.Size(134, 20)
        Me.LabelEO.TabIndex = 13
        Me.LabelEO.Text = "Epreuves Orales"
        '
        'ListBoxEO
        '
        Me.ListBoxEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEO.FormattingEnabled = True
        Me.ListBoxEO.ItemHeight = 20
        Me.ListBoxEO.Location = New System.Drawing.Point(680, 178)
        Me.ListBoxEO.Name = "ListBoxEO"
        Me.ListBoxEO.Size = New System.Drawing.Size(153, 184)
        Me.ListBoxEO.TabIndex = 14
        '
        'ListBoxEOF
        '
        Me.ListBoxEOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ListBoxEOF.FormattingEnabled = True
        Me.ListBoxEOF.ItemHeight = 20
        Me.ListBoxEOF.Location = New System.Drawing.Point(851, 178)
        Me.ListBoxEOF.Name = "ListBoxEOF"
        Me.ListBoxEOF.Size = New System.Drawing.Size(109, 184)
        Me.ListBoxEOF.TabIndex = 16
        '
        'LabelEOF
        '
        Me.LabelEOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEOF.Location = New System.Drawing.Point(848, 135)
        Me.LabelEOF.Name = "LabelEOF"
        Me.LabelEOF.Size = New System.Drawing.Size(112, 40)
        Me.LabelEOF.TabIndex = 15
        Me.LabelEOF.Text = "Epreuve Oral Facultative"
        '
        'ButtonBack
        '
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonBack.Location = New System.Drawing.Point(388, 395)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(180, 45)
        Me.ButtonBack.TabIndex = 17
        Me.ButtonBack.Text = "Retour"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'FormEtat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 471)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ListBoxEOF)
        Me.Controls.Add(Me.LabelEOF)
        Me.Controls.Add(Me.ListBoxEO)
        Me.Controls.Add(Me.LabelEO)
        Me.Controls.Add(Me.ListBoxEE)
        Me.Controls.Add(Me.ListBoxPrenom)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.ListBoxID)
        Me.Controls.Add(Me.LabelEE)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelEtatActuel)
        Me.Name = "FormEtat"
        Me.Text = "Etat Actuel"
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
End Class
