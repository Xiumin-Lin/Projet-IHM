<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInscripInfoCandidat
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresse = New System.Windows.Forms.TextBox()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.LabelInfoAge = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.TextBoxVille = New System.Windows.Forms.TextBox()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.ButtonSuivant = New System.Windows.Forms.Button()
        Me.Timer1min = New System.Windows.Forms.Timer(Me.components)
        Me.LabelAgeMin = New System.Windows.Forms.Label()
        Me.LabelAgeMax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(13, 24)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(766, 46)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Renseignements du Candidat"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(28, 108)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 20)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Nom :"
        Me.LabelNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNom.Location = New System.Drawing.Point(113, 104)
        Me.TextBoxNom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxNom.MaxLength = 15
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(245, 27)
        Me.TextBoxNom.TabIndex = 2
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(28, 156)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(77, 20)
        Me.LabelPrenom.TabIndex = 3
        Me.LabelPrenom.Text = "Prénom :"
        Me.LabelPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresse.Location = New System.Drawing.Point(385, 107)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(81, 20)
        Me.LabelAdresse.TabIndex = 8
        Me.LabelAdresse.Text = "Adresse :"
        Me.LabelAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = True
        Me.LabelCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCP.Location = New System.Drawing.Point(385, 156)
        Me.LabelCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(110, 20)
        Me.LabelCP.TabIndex = 10
        Me.LabelCP.Text = "Code Postal :"
        Me.LabelCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(28, 201)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(48, 20)
        Me.LabelAge.TabIndex = 5
        Me.LabelAge.Text = "Age :"
        Me.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenom.Location = New System.Drawing.Point(113, 153)
        Me.TextBoxPrenom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxPrenom.MaxLength = 20
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(245, 27)
        Me.TextBoxPrenom.TabIndex = 4
        '
        'TextBoxAdresse
        '
        Me.TextBoxAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresse.Location = New System.Drawing.Point(506, 105)
        Me.TextBoxAdresse.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxAdresse.MaxLength = 30
        Me.TextBoxAdresse.Name = "TextBoxAdresse"
        Me.TextBoxAdresse.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxAdresse.TabIndex = 9
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCP.Location = New System.Drawing.Point(506, 153)
        Me.TextBoxCP.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxCP.MaxLength = 5
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxCP.TabIndex = 10
        '
        'LabelInfoAge
        '
        Me.LabelInfoAge.AutoSize = True
        Me.LabelInfoAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoAge.Location = New System.Drawing.Point(109, 205)
        Me.LabelInfoAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoAge.Name = "LabelInfoAge"
        Me.LabelInfoAge.Size = New System.Drawing.Size(36, 20)
        Me.LabelInfoAge.TabIndex = 6
        Me.LabelInfoAge.Text = "???"
        Me.LabelInfoAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(91, 262)
        Me.HScrollBar1.Maximum = 55
        Me.HScrollBar1.Minimum = 18
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(615, 31)
        Me.HScrollBar1.TabIndex = 7
        Me.HScrollBar1.Value = 18
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVille.Location = New System.Drawing.Point(385, 201)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(51, 20)
        Me.LabelVille.TabIndex = 12
        Me.LabelVille.Text = "Ville :"
        Me.LabelVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVille
        '
        Me.TextBoxVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVille.Location = New System.Drawing.Point(506, 198)
        Me.TextBoxVille.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxVille.MaxLength = 15
        Me.TextBoxVille.Name = "TextBoxVille"
        Me.TextBoxVille.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxVille.TabIndex = 13
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbandon.Location = New System.Drawing.Point(207, 325)
        Me.ButtonAbandon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(151, 54)
        Me.ButtonAbandon.TabIndex = 14
        Me.ButtonAbandon.Text = "Abandonner"
        Me.ButtonAbandon.UseVisualStyleBackColor = True
        '
        'ButtonSuivant
        '
        Me.ButtonSuivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuivant.Location = New System.Drawing.Point(475, 325)
        Me.ButtonSuivant.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ButtonSuivant.Name = "ButtonSuivant"
        Me.ButtonSuivant.Size = New System.Drawing.Size(151, 54)
        Me.ButtonSuivant.TabIndex = 15
        Me.ButtonSuivant.Text = "Suivant"
        Me.ButtonSuivant.UseVisualStyleBackColor = True
        '
        'Timer1min
        '
        '
        'LabelAgeMin
        '
        Me.LabelAgeMin.AutoSize = True
        Me.LabelAgeMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgeMin.Location = New System.Drawing.Point(22, 262)
        Me.LabelAgeMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAgeMin.Name = "LabelAgeMin"
        Me.LabelAgeMin.Size = New System.Drawing.Size(65, 20)
        Me.LabelAgeMin.TabIndex = 17
        Me.LabelAgeMin.Text = "AgeMin"
        Me.LabelAgeMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAgeMax
        '
        Me.LabelAgeMax.AutoSize = True
        Me.LabelAgeMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgeMax.Location = New System.Drawing.Point(710, 262)
        Me.LabelAgeMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAgeMax.Name = "LabelAgeMax"
        Me.LabelAgeMax.Size = New System.Drawing.Size(69, 20)
        Me.LabelAgeMax.TabIndex = 18
        Me.LabelAgeMax.Text = "AgeMax"
        Me.LabelAgeMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormInscripInfoCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 408)
        Me.Controls.Add(Me.LabelAgeMax)
        Me.Controls.Add(Me.LabelAgeMin)
        Me.Controls.Add(Me.ButtonSuivant)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.TextBoxVille)
        Me.Controls.Add(Me.LabelVille)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.LabelInfoAge)
        Me.Controls.Add(Me.TextBoxCP)
        Me.Controls.Add(Me.TextBoxAdresse)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.LabelCP)
        Me.Controls.Add(Me.LabelAdresse)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelTitre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInscripInfoCandidat"
        Me.Text = "Formulaire d'inscription : Renseignements du candidat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelCP As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents TextBoxAdresse As TextBox
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents LabelInfoAge As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents LabelVille As Label
    Friend WithEvents TextBoxVille As TextBox
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents ButtonSuivant As Button
    Friend WithEvents Timer1min As Timer
    Friend WithEvents LabelAgeMin As Label
    Friend WithEvents LabelAgeMax As Label
End Class
