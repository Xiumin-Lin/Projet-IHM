<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBilan
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
        Me.LabelBilan = New System.Windows.Forms.Label()
        Me.LabelCand = New System.Windows.Forms.Label()
        Me.LabelNbCand = New System.Windows.Forms.Label()
        Me.LabelIndividuel = New System.Windows.Forms.Label()
        Me.ComboBoxNomPrenom = New System.Windows.Forms.ComboBox()
        Me.ButtonShowCand = New System.Windows.Forms.Button()
        Me.ButtonShowMatiere = New System.Windows.Forms.Button()
        Me.ComboBoxMatiere = New System.Windows.Forms.ComboBox()
        Me.LabelMatiere = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonCloseApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelBilan
        '
        Me.LabelBilan.AutoSize = True
        Me.LabelBilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!)
        Me.LabelBilan.Location = New System.Drawing.Point(51, 41)
        Me.LabelBilan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBilan.Name = "LabelBilan"
        Me.LabelBilan.Size = New System.Drawing.Size(89, 38)
        Me.LabelBilan.TabIndex = 4
        Me.LabelBilan.Text = "Bilan"
        '
        'LabelCand
        '
        Me.LabelCand.AutoSize = True
        Me.LabelCand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelCand.Location = New System.Drawing.Point(55, 105)
        Me.LabelCand.Name = "LabelCand"
        Me.LabelCand.Size = New System.Drawing.Size(173, 20)
        Me.LabelCand.TabIndex = 5
        Me.LabelCand.Text = "Nombre d'inscription :"
        '
        'LabelNbCand
        '
        Me.LabelNbCand.AutoSize = True
        Me.LabelNbCand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNbCand.Location = New System.Drawing.Point(255, 105)
        Me.LabelNbCand.Name = "LabelNbCand"
        Me.LabelNbCand.Size = New System.Drawing.Size(36, 20)
        Me.LabelNbCand.TabIndex = 6
        Me.LabelNbCand.Text = "???"
        '
        'LabelIndividuel
        '
        Me.LabelIndividuel.AutoSize = True
        Me.LabelIndividuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelIndividuel.Location = New System.Drawing.Point(55, 158)
        Me.LabelIndividuel.Name = "LabelIndividuel"
        Me.LabelIndividuel.Size = New System.Drawing.Size(268, 20)
        Me.LabelIndividuel.TabIndex = 7
        Me.LabelIndividuel.Text = "Bilan Individuel d'une candidature :"
        '
        'ComboBoxNomPrenom
        '
        Me.ComboBoxNomPrenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxNomPrenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNomPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ComboBoxNomPrenom.FormattingEnabled = True
        Me.ComboBoxNomPrenom.Location = New System.Drawing.Point(58, 185)
        Me.ComboBoxNomPrenom.Name = "ComboBoxNomPrenom"
        Me.ComboBoxNomPrenom.Size = New System.Drawing.Size(363, 28)
        Me.ComboBoxNomPrenom.TabIndex = 8
        '
        'ButtonShowCand
        '
        Me.ButtonShowCand.BackColor = System.Drawing.Color.Azure
        Me.ButtonShowCand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonShowCand.Location = New System.Drawing.Point(472, 170)
        Me.ButtonShowCand.Name = "ButtonShowCand"
        Me.ButtonShowCand.Size = New System.Drawing.Size(130, 57)
        Me.ButtonShowCand.TabIndex = 9
        Me.ButtonShowCand.Text = "Afficher Candidat"
        Me.ButtonShowCand.UseVisualStyleBackColor = False
        '
        'ButtonShowMatiere
        '
        Me.ButtonShowMatiere.BackColor = System.Drawing.Color.Azure
        Me.ButtonShowMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonShowMatiere.Location = New System.Drawing.Point(472, 264)
        Me.ButtonShowMatiere.Name = "ButtonShowMatiere"
        Me.ButtonShowMatiere.Size = New System.Drawing.Size(130, 57)
        Me.ButtonShowMatiere.TabIndex = 12
        Me.ButtonShowMatiere.Text = "Afficher Matière"
        Me.ButtonShowMatiere.UseVisualStyleBackColor = False
        '
        'ComboBoxMatiere
        '
        Me.ComboBoxMatiere.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxMatiere.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ComboBoxMatiere.FormattingEnabled = True
        Me.ComboBoxMatiere.Location = New System.Drawing.Point(58, 279)
        Me.ComboBoxMatiere.Name = "ComboBoxMatiere"
        Me.ComboBoxMatiere.Size = New System.Drawing.Size(363, 28)
        Me.ComboBoxMatiere.TabIndex = 11
        '
        'LabelMatiere
        '
        Me.LabelMatiere.AutoSize = True
        Me.LabelMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelMatiere.Location = New System.Drawing.Point(55, 252)
        Me.LabelMatiere.Name = "LabelMatiere"
        Me.LabelMatiere.Size = New System.Drawing.Size(314, 20)
        Me.LabelMatiere.TabIndex = 10
        Me.LabelMatiere.Text = "Bilan des Inscriptions dans une matière :"
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Azure
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonBack.Location = New System.Drawing.Point(59, 360)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(130, 39)
        Me.ButtonBack.TabIndex = 13
        Me.ButtonBack.Text = "Retour"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'ButtonCloseApp
        '
        Me.ButtonCloseApp.BackColor = System.Drawing.Color.Azure
        Me.ButtonCloseApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonCloseApp.Location = New System.Drawing.Point(250, 350)
        Me.ButtonCloseApp.Name = "ButtonCloseApp"
        Me.ButtonCloseApp.Size = New System.Drawing.Size(130, 59)
        Me.ButtonCloseApp.TabIndex = 14
        Me.ButtonCloseApp.Text = "Fermez l'application"
        Me.ButtonCloseApp.UseVisualStyleBackColor = False
        Me.ButtonCloseApp.Visible = False
        '
        'FormBilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(649, 452)
        Me.Controls.Add(Me.ButtonCloseApp)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonShowMatiere)
        Me.Controls.Add(Me.ComboBoxMatiere)
        Me.Controls.Add(Me.LabelMatiere)
        Me.Controls.Add(Me.ButtonShowCand)
        Me.Controls.Add(Me.ComboBoxNomPrenom)
        Me.Controls.Add(Me.LabelIndividuel)
        Me.Controls.Add(Me.LabelNbCand)
        Me.Controls.Add(Me.LabelCand)
        Me.Controls.Add(Me.LabelBilan)
        Me.Name = "FormBilan"
        Me.Text = "Bilan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBilan As Label
    Friend WithEvents LabelCand As Label
    Friend WithEvents LabelNbCand As Label
    Friend WithEvents LabelIndividuel As Label
    Friend WithEvents ComboBoxNomPrenom As ComboBox
    Friend WithEvents ButtonShowCand As Button
    Friend WithEvents ButtonShowMatiere As Button
    Friend WithEvents ComboBoxMatiere As ComboBox
    Friend WithEvents LabelMatiere As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonCloseApp As Button
End Class
