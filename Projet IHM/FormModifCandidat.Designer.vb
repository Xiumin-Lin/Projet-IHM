<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifCandidat
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
        Me.LabelModif = New System.Windows.Forms.Label()
        Me.PanelID.SuspendLayout()
        Me.PanelNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(107, 317)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 45)
        Me.ButtonAnnuler.TabIndex = 7
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonValider
        '
        Me.ButtonValider.Location = New System.Drawing.Point(351, 317)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(112, 45)
        Me.ButtonValider.TabIndex = 8
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'PanelID
        '
        Me.PanelID.Controls.Add(Me.ComboBoxIdCand)
        Me.PanelID.Controls.Add(Me.LabelIDCandidat)
        Me.PanelID.Location = New System.Drawing.Point(107, 237)
        Me.PanelID.Name = "PanelID"
        Me.PanelID.Size = New System.Drawing.Size(356, 74)
        Me.PanelID.TabIndex = 28
        '
        'ComboBoxIdCand
        '
        Me.ComboBoxIdCand.FormattingEnabled = True
        Me.ComboBoxIdCand.Location = New System.Drawing.Point(9, 34)
        Me.ComboBoxIdCand.Name = "ComboBoxIdCand"
        Me.ComboBoxIdCand.Size = New System.Drawing.Size(331, 28)
        Me.ComboBoxIdCand.TabIndex = 9
        '
        'LabelIDCandidat
        '
        Me.LabelIDCandidat.AutoSize = True
        Me.LabelIDCandidat.Location = New System.Drawing.Point(7, 11)
        Me.LabelIDCandidat.Name = "LabelIDCandidat"
        Me.LabelIDCandidat.Size = New System.Drawing.Size(196, 20)
        Me.LabelIDCandidat.TabIndex = 14
        Me.LabelIDCandidat.Text = "L'identifiant du candidat :"
        '
        'PanelNum
        '
        Me.PanelNum.Controls.Add(Me.TextBoxNumCand)
        Me.PanelNum.Controls.Add(Me.LabelNumCandidat)
        Me.PanelNum.Location = New System.Drawing.Point(107, 138)
        Me.PanelNum.Name = "PanelNum"
        Me.PanelNum.Size = New System.Drawing.Size(356, 75)
        Me.PanelNum.TabIndex = 27
        '
        'TextBoxNumCand
        '
        Me.TextBoxNumCand.Location = New System.Drawing.Point(11, 36)
        Me.TextBoxNumCand.Name = "TextBoxNumCand"
        Me.TextBoxNumCand.Size = New System.Drawing.Size(329, 27)
        Me.TextBoxNumCand.TabIndex = 10
        '
        'LabelNumCandidat
        '
        Me.LabelNumCandidat.AutoSize = True
        Me.LabelNumCandidat.Location = New System.Drawing.Point(7, 13)
        Me.LabelNumCandidat.Name = "LabelNumCandidat"
        Me.LabelNumCandidat.Size = New System.Drawing.Size(264, 20)
        Me.LabelNumCandidat.TabIndex = 12
        Me.LabelNumCandidat.Text = "Numéro d'inscription du candidat :"
        '
        'RadioButtonIDCand
        '
        Me.RadioButtonIDCand.AutoSize = True
        Me.RadioButtonIDCand.Location = New System.Drawing.Point(63, 276)
        Me.RadioButtonIDCand.Name = "RadioButtonIDCand"
        Me.RadioButtonIDCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonIDCand.TabIndex = 26
        Me.RadioButtonIDCand.TabStop = True
        Me.RadioButtonIDCand.UseVisualStyleBackColor = True
        '
        'RadioButtonNumCand
        '
        Me.RadioButtonNumCand.AutoSize = True
        Me.RadioButtonNumCand.Location = New System.Drawing.Point(63, 179)
        Me.RadioButtonNumCand.Name = "RadioButtonNumCand"
        Me.RadioButtonNumCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonNumCand.TabIndex = 25
        Me.RadioButtonNumCand.TabStop = True
        Me.RadioButtonNumCand.UseVisualStyleBackColor = True
        '
        'LabelOu
        '
        Me.LabelOu.Location = New System.Drawing.Point(107, 216)
        Me.LabelOu.Name = "LabelOu"
        Me.LabelOu.Size = New System.Drawing.Size(356, 18)
        Me.LabelOu.TabIndex = 24
        Me.LabelOu.Text = "OU"
        Me.LabelOu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelIndication
        '
        Me.LabelIndication.AutoSize = True
        Me.LabelIndication.Location = New System.Drawing.Point(37, 107)
        Me.LabelIndication.Name = "LabelIndication"
        Me.LabelIndication.Size = New System.Drawing.Size(500, 20)
        Me.LabelIndication.TabIndex = 23
        Me.LabelIndication.Text = "Veuillez entrer le numéro d'inscription ou l'identifiant du candidat :"
        '
        'LabelModif
        '
        Me.LabelModif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModif.Location = New System.Drawing.Point(12, 24)
        Me.LabelModif.Name = "LabelModif"
        Me.LabelModif.Size = New System.Drawing.Size(549, 57)
        Me.LabelModif.TabIndex = 22
        Me.LabelModif.Text = "Modification"
        Me.LabelModif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormModifCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 402)
        Me.Controls.Add(Me.PanelID)
        Me.Controls.Add(Me.PanelNum)
        Me.Controls.Add(Me.RadioButtonIDCand)
        Me.Controls.Add(Me.RadioButtonNumCand)
        Me.Controls.Add(Me.LabelOu)
        Me.Controls.Add(Me.LabelIndication)
        Me.Controls.Add(Me.LabelModif)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormModifCandidat"
        Me.Text = "Modification d'un candidat"
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
    Friend WithEvents LabelModif As Label
End Class
