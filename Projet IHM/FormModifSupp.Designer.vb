<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifSupp
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
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.PanelID = New System.Windows.Forms.Panel()
        Me.ComboBoxIdCand = New System.Windows.Forms.ComboBox()
        Me.LabelIDCandidat = New System.Windows.Forms.Label()
        Me.PanelNum = New System.Windows.Forms.Panel()
        Me.TextBoxNumCand = New System.Windows.Forms.TextBox()
        Me.LabelNumCandidat = New System.Windows.Forms.Label()
        Me.RadioButtonIDCand = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNumCand = New System.Windows.Forms.RadioButton()
        Me.LabelOu = New System.Windows.Forms.Label()
        Me.LabelIndication = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.PanelID.SuspendLayout()
        Me.PanelNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.BackColor = System.Drawing.Color.Azure
        Me.ButtonAnnuler.Location = New System.Drawing.Point(107, 331)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 45)
        Me.ButtonAnnuler.TabIndex = 10
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = False
        '
        'ButtonValider
        '
        Me.ButtonValider.BackColor = System.Drawing.Color.Azure
        Me.ButtonValider.Location = New System.Drawing.Point(402, 331)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(112, 45)
        Me.ButtonValider.TabIndex = 9
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = False
        '
        'PanelID
        '
        Me.PanelID.BackColor = System.Drawing.SystemColors.Control
        Me.PanelID.Controls.Add(Me.ComboBoxIdCand)
        Me.PanelID.Controls.Add(Me.LabelIDCandidat)
        Me.PanelID.Enabled = False
        Me.PanelID.Location = New System.Drawing.Point(107, 237)
        Me.PanelID.Name = "PanelID"
        Me.PanelID.Size = New System.Drawing.Size(407, 74)
        Me.PanelID.TabIndex = 6
        '
        'ComboBoxIdCand
        '
        Me.ComboBoxIdCand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxIdCand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxIdCand.FormattingEnabled = True
        Me.ComboBoxIdCand.Location = New System.Drawing.Point(9, 34)
        Me.ComboBoxIdCand.Name = "ComboBoxIdCand"
        Me.ComboBoxIdCand.Size = New System.Drawing.Size(388, 28)
        Me.ComboBoxIdCand.TabIndex = 9
        '
        'LabelIDCandidat
        '
        Me.LabelIDCandidat.AutoSize = True
        Me.LabelIDCandidat.Location = New System.Drawing.Point(7, 11)
        Me.LabelIDCandidat.Name = "LabelIDCandidat"
        Me.LabelIDCandidat.Size = New System.Drawing.Size(196, 20)
        Me.LabelIDCandidat.TabIndex = 1
        Me.LabelIDCandidat.Text = "L'identifiant du candidat :"
        '
        'PanelNum
        '
        Me.PanelNum.BackColor = System.Drawing.SystemColors.Control
        Me.PanelNum.Controls.Add(Me.TextBoxNumCand)
        Me.PanelNum.Controls.Add(Me.LabelNumCandidat)
        Me.PanelNum.Enabled = False
        Me.PanelNum.Location = New System.Drawing.Point(107, 138)
        Me.PanelNum.Name = "PanelNum"
        Me.PanelNum.Size = New System.Drawing.Size(407, 75)
        Me.PanelNum.TabIndex = 3
        '
        'TextBoxNumCand
        '
        Me.TextBoxNumCand.Location = New System.Drawing.Point(11, 36)
        Me.TextBoxNumCand.Name = "TextBoxNumCand"
        Me.TextBoxNumCand.Size = New System.Drawing.Size(386, 27)
        Me.TextBoxNumCand.TabIndex = 10
        '
        'LabelNumCandidat
        '
        Me.LabelNumCandidat.AutoSize = True
        Me.LabelNumCandidat.Location = New System.Drawing.Point(7, 13)
        Me.LabelNumCandidat.Name = "LabelNumCandidat"
        Me.LabelNumCandidat.Size = New System.Drawing.Size(264, 20)
        Me.LabelNumCandidat.TabIndex = 0
        Me.LabelNumCandidat.Text = "Numéro d'inscription du candidat :"
        '
        'RadioButtonIDCand
        '
        Me.RadioButtonIDCand.AutoSize = True
        Me.RadioButtonIDCand.Location = New System.Drawing.Point(63, 276)
        Me.RadioButtonIDCand.Name = "RadioButtonIDCand"
        Me.RadioButtonIDCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonIDCand.TabIndex = 5
        Me.RadioButtonIDCand.TabStop = True
        Me.RadioButtonIDCand.UseVisualStyleBackColor = True
        '
        'RadioButtonNumCand
        '
        Me.RadioButtonNumCand.AutoSize = True
        Me.RadioButtonNumCand.Location = New System.Drawing.Point(63, 164)
        Me.RadioButtonNumCand.Name = "RadioButtonNumCand"
        Me.RadioButtonNumCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonNumCand.TabIndex = 2
        Me.RadioButtonNumCand.TabStop = True
        Me.RadioButtonNumCand.UseVisualStyleBackColor = True
        '
        'LabelOu
        '
        Me.LabelOu.Location = New System.Drawing.Point(107, 216)
        Me.LabelOu.Name = "LabelOu"
        Me.LabelOu.Size = New System.Drawing.Size(400, 18)
        Me.LabelOu.TabIndex = 4
        Me.LabelOu.Text = "OU"
        Me.LabelOu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelIndication
        '
        Me.LabelIndication.AutoSize = True
        Me.LabelIndication.Location = New System.Drawing.Point(59, 103)
        Me.LabelIndication.Name = "LabelIndication"
        Me.LabelIndication.Size = New System.Drawing.Size(500, 20)
        Me.LabelIndication.TabIndex = 1
        Me.LabelIndication.Text = "Veuillez entrer le numéro d'inscription ou l'identifiant du candidat :"
        '
        'LabelTitre
        '
        Me.LabelTitre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(12, 24)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(586, 62)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Modification/Suppression"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormModifSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(610, 416)
        Me.Controls.Add(Me.PanelID)
        Me.Controls.Add(Me.PanelNum)
        Me.Controls.Add(Me.RadioButtonIDCand)
        Me.Controls.Add(Me.RadioButtonNumCand)
        Me.Controls.Add(Me.LabelOu)
        Me.Controls.Add(Me.LabelIndication)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormModifSupp"
        Me.Text = "Modif/Supp un candidat"
        Me.PanelID.ResumeLayout(False)
        Me.PanelID.PerformLayout()
        Me.PanelNum.ResumeLayout(False)
        Me.PanelNum.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonValider As Button
    Friend WithEvents PanelID As Panel
    Friend WithEvents ComboBoxIdCand As ComboBox
    Friend WithEvents LabelIDCandidat As Label
    Friend WithEvents PanelNum As Panel
    Friend WithEvents TextBoxNumCand As TextBox
    Friend WithEvents LabelNumCandidat As Label
    Friend WithEvents RadioButtonIDCand As RadioButton
    Friend WithEvents RadioButtonNumCand As RadioButton
    Friend WithEvents LabelOu As Label
    Friend WithEvents LabelIndication As Label
    Friend WithEvents LabelTitre As Label
End Class
