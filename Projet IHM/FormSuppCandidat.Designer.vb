<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuppCandidat
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
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.LabelOu = New System.Windows.Forms.Label()
        Me.LabelIDCandidat = New System.Windows.Forms.Label()
        Me.LabelIndication = New System.Windows.Forms.Label()
        Me.LabelNumCandidat = New System.Windows.Forms.Label()
        Me.LabelSupp = New System.Windows.Forms.Label()
        Me.TextBoxNumCand = New System.Windows.Forms.TextBox()
        Me.ComboBoxIdCand = New System.Windows.Forms.ComboBox()
        Me.RadioButtonNumCand = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIDCand = New System.Windows.Forms.RadioButton()
        Me.PanelNum = New System.Windows.Forms.Panel()
        Me.PanelID = New System.Windows.Forms.Panel()
        Me.PanelNum.SuspendLayout()
        Me.PanelID.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonValider
        '
        Me.ButtonValider.Location = New System.Drawing.Point(366, 346)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(112, 40)
        Me.ButtonValider.TabIndex = 17
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(122, 346)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 40)
        Me.ButtonAnnuler.TabIndex = 16
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelOu
        '
        Me.LabelOu.Location = New System.Drawing.Point(122, 230)
        Me.LabelOu.Name = "LabelOu"
        Me.LabelOu.Size = New System.Drawing.Size(356, 20)
        Me.LabelOu.TabIndex = 15
        Me.LabelOu.Text = "OU"
        Me.LabelOu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'LabelIndication
        '
        Me.LabelIndication.AutoSize = True
        Me.LabelIndication.Location = New System.Drawing.Point(52, 111)
        Me.LabelIndication.Name = "LabelIndication"
        Me.LabelIndication.Size = New System.Drawing.Size(500, 20)
        Me.LabelIndication.TabIndex = 13
        Me.LabelIndication.Text = "Veuillez entrer le numéro d'inscription ou l'identifiant du candidat :"
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
        'LabelSupp
        '
        Me.LabelSupp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupp.Location = New System.Drawing.Point(12, 9)
        Me.LabelSupp.Name = "LabelSupp"
        Me.LabelSupp.Size = New System.Drawing.Size(565, 89)
        Me.LabelSupp.TabIndex = 11
        Me.LabelSupp.Text = "Suppression"
        Me.LabelSupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNumCand
        '
        Me.TextBoxNumCand.Location = New System.Drawing.Point(11, 36)
        Me.TextBoxNumCand.Name = "TextBoxNumCand"
        Me.TextBoxNumCand.Size = New System.Drawing.Size(329, 27)
        Me.TextBoxNumCand.TabIndex = 10
        '
        'ComboBoxIdCand
        '
        Me.ComboBoxIdCand.FormattingEnabled = True
        Me.ComboBoxIdCand.Location = New System.Drawing.Point(9, 34)
        Me.ComboBoxIdCand.Name = "ComboBoxIdCand"
        Me.ComboBoxIdCand.Size = New System.Drawing.Size(331, 28)
        Me.ComboBoxIdCand.TabIndex = 9
        '
        'RadioButtonNumCand
        '
        Me.RadioButtonNumCand.AutoSize = True
        Me.RadioButtonNumCand.Location = New System.Drawing.Point(78, 193)
        Me.RadioButtonNumCand.Name = "RadioButtonNumCand"
        Me.RadioButtonNumCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonNumCand.TabIndex = 18
        Me.RadioButtonNumCand.TabStop = True
        Me.RadioButtonNumCand.UseVisualStyleBackColor = True
        '
        'RadioButtonIDCand
        '
        Me.RadioButtonIDCand.AutoSize = True
        Me.RadioButtonIDCand.Location = New System.Drawing.Point(78, 292)
        Me.RadioButtonIDCand.Name = "RadioButtonIDCand"
        Me.RadioButtonIDCand.Size = New System.Drawing.Size(17, 16)
        Me.RadioButtonIDCand.TabIndex = 19
        Me.RadioButtonIDCand.TabStop = True
        Me.RadioButtonIDCand.UseVisualStyleBackColor = True
        '
        'PanelNum
        '
        Me.PanelNum.Controls.Add(Me.TextBoxNumCand)
        Me.PanelNum.Controls.Add(Me.LabelNumCandidat)
        Me.PanelNum.Location = New System.Drawing.Point(122, 152)
        Me.PanelNum.Name = "PanelNum"
        Me.PanelNum.Size = New System.Drawing.Size(356, 75)
        Me.PanelNum.TabIndex = 20
        '
        'PanelID
        '
        Me.PanelID.Controls.Add(Me.ComboBoxIdCand)
        Me.PanelID.Controls.Add(Me.LabelIDCandidat)
        Me.PanelID.Location = New System.Drawing.Point(122, 253)
        Me.PanelID.Name = "PanelID"
        Me.PanelID.Size = New System.Drawing.Size(356, 74)
        Me.PanelID.TabIndex = 21
        '
        'FormSuppCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 425)
        Me.Controls.Add(Me.PanelID)
        Me.Controls.Add(Me.PanelNum)
        Me.Controls.Add(Me.RadioButtonIDCand)
        Me.Controls.Add(Me.RadioButtonNumCand)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.LabelOu)
        Me.Controls.Add(Me.LabelIndication)
        Me.Controls.Add(Me.LabelSupp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSuppCandidat"
        Me.Text = "Suppression d'un candidat"
        Me.PanelNum.ResumeLayout(False)
        Me.PanelNum.PerformLayout()
        Me.PanelID.ResumeLayout(False)
        Me.PanelID.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonValider As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents LabelOu As Label
    Friend WithEvents LabelIDCandidat As Label
    Friend WithEvents LabelIndication As Label
    Friend WithEvents LabelNumCandidat As Label
    Friend WithEvents LabelSupp As Label
    Friend WithEvents TextBoxNumCand As TextBox
    Friend WithEvents ComboBoxIdCand As ComboBox
    Friend WithEvents RadioButtonNumCand As RadioButton
    Friend WithEvents RadioButtonIDCand As RadioButton
    Friend WithEvents PanelNum As Panel
    Friend WithEvents PanelID As Panel
End Class
