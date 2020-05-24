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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.ButtonSuivant = New System.Windows.Forms.Button()
        Me.Timer1min = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(228, 53)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(446, 38)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Renseignements du Candidat"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(55, 147)
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
        Me.TextBoxNom.Location = New System.Drawing.Point(140, 143)
        Me.TextBoxNom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxNom.MaxLength = 15
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxNom.TabIndex = 2
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(55, 195)
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
        Me.LabelAdresse.Location = New System.Drawing.Point(464, 146)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(81, 20)
        Me.LabelAdresse.TabIndex = 4
        Me.LabelAdresse.Text = "Adresse :"
        Me.LabelAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = True
        Me.LabelCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCP.Location = New System.Drawing.Point(464, 195)
        Me.LabelCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(110, 20)
        Me.LabelCP.TabIndex = 5
        Me.LabelCP.Text = "Code Postal :"
        Me.LabelCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(55, 240)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(48, 20)
        Me.LabelAge.TabIndex = 6
        Me.LabelAge.Text = "Age :"
        Me.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrenom.Location = New System.Drawing.Point(140, 192)
        Me.TextBoxPrenom.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxPrenom.MaxLength = 20
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxPrenom.TabIndex = 7
        '
        'TextBoxAdresse
        '
        Me.TextBoxAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresse.Location = New System.Drawing.Point(585, 144)
        Me.TextBoxAdresse.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBoxAdresse.MaxLength = 30
        Me.TextBoxAdresse.Name = "TextBoxAdresse"
        Me.TextBoxAdresse.Size = New System.Drawing.Size(260, 27)
        Me.TextBoxAdresse.TabIndex = 9
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCP.Location = New System.Drawing.Point(585, 192)
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
        Me.LabelInfoAge.Location = New System.Drawing.Point(136, 244)
        Me.LabelInfoAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoAge.Name = "LabelInfoAge"
        Me.LabelInfoAge.Size = New System.Drawing.Size(36, 20)
        Me.LabelInfoAge.TabIndex = 11
        Me.LabelInfoAge.Text = "???"
        Me.LabelInfoAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(59, 311)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(378, 32)
        Me.HScrollBar1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ville :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(585, 237)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 27)
        Me.TextBox1.TabIndex = 14
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbandon.Location = New System.Drawing.Point(235, 385)
        Me.ButtonAbandon.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(151, 54)
        Me.ButtonAbandon.TabIndex = 15
        Me.ButtonAbandon.Text = "Abandonner"
        Me.ButtonAbandon.UseVisualStyleBackColor = True
        '
        'ButtonSuivant
        '
        Me.ButtonSuivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuivant.Location = New System.Drawing.Point(513, 385)
        Me.ButtonSuivant.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ButtonSuivant.Name = "ButtonSuivant"
        Me.ButtonSuivant.Size = New System.Drawing.Size(151, 54)
        Me.ButtonSuivant.TabIndex = 16
        Me.ButtonSuivant.Text = "Suivant"
        Me.ButtonSuivant.UseVisualStyleBackColor = True
        '
        'FormInscripInfoCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 491)
        Me.Controls.Add(Me.ButtonSuivant)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents ButtonSuivant As Button
    Friend WithEvents Timer1min As Timer
End Class
