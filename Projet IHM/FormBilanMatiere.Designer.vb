<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBilanMatiere
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
        Me.LabelBilanMatiere = New System.Windows.Forms.Label()
        Me.LabelMatiere = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.ListBoxID = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.ListBoxEE = New System.Windows.Forms.ListBox()
        Me.LabelEcrit = New System.Windows.Forms.Label()
        Me.ListBoxEO = New System.Windows.Forms.ListBox()
        Me.LabelOral = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ListBoxRegion = New System.Windows.Forms.ListBox()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.PanelListBox = New System.Windows.Forms.Panel()
        Me.PanelListBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBilanMatiere
        '
        Me.LabelBilanMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!)
        Me.LabelBilanMatiere.Location = New System.Drawing.Point(118, 16)
        Me.LabelBilanMatiere.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBilanMatiere.Name = "LabelBilanMatiere"
        Me.LabelBilanMatiere.Size = New System.Drawing.Size(720, 68)
        Me.LabelBilanMatiere.TabIndex = 5
        Me.LabelBilanMatiere.Text = "Bilan des inscription par matière"
        Me.LabelBilanMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMatiere
        '
        Me.LabelMatiere.BackColor = System.Drawing.Color.Honeydew
        Me.LabelMatiere.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.2!)
        Me.LabelMatiere.Location = New System.Drawing.Point(290, 84)
        Me.LabelMatiere.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMatiere.Name = "LabelMatiere"
        Me.LabelMatiere.Size = New System.Drawing.Size(174, 43)
        Me.LabelMatiere.TabIndex = 6
        Me.LabelMatiere.Text = "Matière : ???"
        Me.LabelMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelID.Location = New System.Drawing.Point(207, 151)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(28, 20)
        Me.LabelID.TabIndex = 7
        Me.LabelID.Text = "N°"
        '
        'ListBoxID
        '
        Me.ListBoxID.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.ItemHeight = 20
        Me.ListBoxID.Location = New System.Drawing.Point(167, 3)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(73, 224)
        Me.ListBoxID.TabIndex = 8
        '
        'ListBoxNom
        '
        Me.ListBoxNom.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 20
        Me.ListBoxNom.Location = New System.Drawing.Point(246, 3)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(190, 224)
        Me.ListBoxNom.TabIndex = 10
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNom.Location = New System.Drawing.Point(286, 151)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(44, 20)
        Me.LabelNom.TabIndex = 9
        Me.LabelNom.Text = "Nom"
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 20
        Me.ListBoxPrenom.Location = New System.Drawing.Point(442, 3)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(215, 224)
        Me.ListBoxPrenom.TabIndex = 12
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelPrenom.Location = New System.Drawing.Point(482, 151)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(67, 20)
        Me.LabelPrenom.TabIndex = 11
        Me.LabelPrenom.Text = "Prénom"
        '
        'ListBoxEE
        '
        Me.ListBoxEE.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxEE.FormattingEnabled = True
        Me.ListBoxEE.ItemHeight = 20
        Me.ListBoxEE.Location = New System.Drawing.Point(664, 3)
        Me.ListBoxEE.Name = "ListBoxEE"
        Me.ListBoxEE.Size = New System.Drawing.Size(73, 224)
        Me.ListBoxEE.TabIndex = 14
        '
        'LabelEcrit
        '
        Me.LabelEcrit.AutoSize = True
        Me.LabelEcrit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelEcrit.Location = New System.Drawing.Point(704, 152)
        Me.LabelEcrit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEcrit.Name = "LabelEcrit"
        Me.LabelEcrit.Size = New System.Drawing.Size(58, 20)
        Me.LabelEcrit.TabIndex = 13
        Me.LabelEcrit.Text = "Ecrit ?"
        '
        'ListBoxEO
        '
        Me.ListBoxEO.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxEO.FormattingEnabled = True
        Me.ListBoxEO.ItemHeight = 20
        Me.ListBoxEO.Location = New System.Drawing.Point(743, 3)
        Me.ListBoxEO.Name = "ListBoxEO"
        Me.ListBoxEO.Size = New System.Drawing.Size(75, 224)
        Me.ListBoxEO.TabIndex = 16
        '
        'LabelOral
        '
        Me.LabelOral.AutoSize = True
        Me.LabelOral.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelOral.Location = New System.Drawing.Point(783, 151)
        Me.LabelOral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelOral.Name = "LabelOral"
        Me.LabelOral.Size = New System.Drawing.Size(55, 20)
        Me.LabelOral.TabIndex = 15
        Me.LabelOral.Text = "Oral ?"
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Azure
        Me.ButtonClose.Location = New System.Drawing.Point(397, 415)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(152, 46)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Fermer"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ListBoxRegion
        '
        Me.ListBoxRegion.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBoxRegion.FormattingEnabled = True
        Me.ListBoxRegion.ItemHeight = 20
        Me.ListBoxRegion.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxRegion.Name = "ListBoxRegion"
        Me.ListBoxRegion.Size = New System.Drawing.Size(158, 224)
        Me.ListBoxRegion.TabIndex = 19
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = True
        Me.LabelRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelRegion.Location = New System.Drawing.Point(40, 151)
        Me.LabelRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(61, 20)
        Me.LabelRegion.TabIndex = 18
        Me.LabelRegion.Text = "Région"
        '
        'PanelListBox
        '
        Me.PanelListBox.Controls.Add(Me.ListBoxRegion)
        Me.PanelListBox.Controls.Add(Me.ListBoxID)
        Me.PanelListBox.Controls.Add(Me.ListBoxNom)
        Me.PanelListBox.Controls.Add(Me.ListBoxPrenom)
        Me.PanelListBox.Controls.Add(Me.ListBoxEO)
        Me.PanelListBox.Controls.Add(Me.ListBoxEE)
        Me.PanelListBox.Location = New System.Drawing.Point(44, 175)
        Me.PanelListBox.Name = "PanelListBox"
        Me.PanelListBox.Size = New System.Drawing.Size(830, 234)
        Me.PanelListBox.TabIndex = 20
        '
        'FormBilanMatiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(924, 479)
        Me.Controls.Add(Me.PanelListBox)
        Me.Controls.Add(Me.LabelRegion)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.LabelOral)
        Me.Controls.Add(Me.LabelEcrit)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelMatiere)
        Me.Controls.Add(Me.LabelBilanMatiere)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBilanMatiere"
        Me.Text = "Bilan Matière"
        Me.PanelListBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBilanMatiere As Label
    Friend WithEvents LabelMatiere As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents ListBoxID As ListBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents ListBoxPrenom As ListBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents ListBoxEE As ListBox
    Friend WithEvents LabelEcrit As Label
    Friend WithEvents ListBoxEO As ListBox
    Friend WithEvents LabelOral As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ListBoxRegion As ListBox
    Friend WithEvents LabelRegion As Label
    Friend WithEvents PanelListBox As Panel
End Class
