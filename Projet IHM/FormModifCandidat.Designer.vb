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
        Me.ComboBoxIdCand = New System.Windows.Forms.ComboBox()
        Me.TextBoxNumCand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNumCand = New System.Windows.Forms.Label()
        Me.LabelIndication = New System.Windows.Forms.Label()
        Me.LabelIdCand = New System.Windows.Forms.Label()
        Me.LabelOu = New System.Windows.Forms.Label()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxIdCand
        '
        Me.ComboBoxIdCand.FormattingEnabled = True
        Me.ComboBoxIdCand.Location = New System.Drawing.Point(113, 255)
        Me.ComboBoxIdCand.Name = "ComboBoxIdCand"
        Me.ComboBoxIdCand.Size = New System.Drawing.Size(322, 28)
        Me.ComboBoxIdCand.TabIndex = 0
        '
        'TextBoxNumCand
        '
        Me.TextBoxNumCand.Location = New System.Drawing.Point(113, 156)
        Me.TextBoxNumCand.Name = "TextBoxNumCand"
        Me.TextBoxNumCand.Size = New System.Drawing.Size(322, 27)
        Me.TextBoxNumCand.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Modification"
        '
        'LabelNumCand
        '
        Me.LabelNumCand.AutoSize = True
        Me.LabelNumCand.Location = New System.Drawing.Point(109, 133)
        Me.LabelNumCand.Name = "LabelNumCand"
        Me.LabelNumCand.Size = New System.Drawing.Size(264, 20)
        Me.LabelNumCand.TabIndex = 3
        Me.LabelNumCand.Text = "Numéro d'inscription du candidat :"
        '
        'LabelIndication
        '
        Me.LabelIndication.AutoSize = True
        Me.LabelIndication.Location = New System.Drawing.Point(26, 91)
        Me.LabelIndication.Name = "LabelIndication"
        Me.LabelIndication.Size = New System.Drawing.Size(500, 20)
        Me.LabelIndication.TabIndex = 4
        Me.LabelIndication.Text = "Veuillez entrer le numéro d'inscription ou l'identifiant du candidat :"
        '
        'LabelIdCand
        '
        Me.LabelIdCand.AutoSize = True
        Me.LabelIdCand.Location = New System.Drawing.Point(109, 232)
        Me.LabelIdCand.Name = "LabelIdCand"
        Me.LabelIdCand.Size = New System.Drawing.Size(196, 20)
        Me.LabelIdCand.TabIndex = 5
        Me.LabelIdCand.Text = "L'identifiant du candidat :"
        '
        'LabelOu
        '
        Me.LabelOu.AutoSize = True
        Me.LabelOu.Location = New System.Drawing.Point(260, 199)
        Me.LabelOu.Name = "LabelOu"
        Me.LabelOu.Size = New System.Drawing.Size(34, 20)
        Me.LabelOu.TabIndex = 6
        Me.LabelOu.Text = "OU"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(98, 325)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 45)
        Me.ButtonAnnuler.TabIndex = 7
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonValider
        '
        Me.ButtonValider.Location = New System.Drawing.Point(338, 325)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(112, 45)
        Me.ButtonValider.TabIndex = 8
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'FormModifCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 397)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.LabelOu)
        Me.Controls.Add(Me.LabelIdCand)
        Me.Controls.Add(Me.LabelIndication)
        Me.Controls.Add(Me.LabelNumCand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNumCand)
        Me.Controls.Add(Me.ComboBoxIdCand)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormModifCandidat"
        Me.Text = "Modification d'un candidat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxIdCand As ComboBox
    Friend WithEvents TextBoxNumCand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNumCand As Label
    Friend WithEvents LabelIndication As Label
    Friend WithEvents LabelIdCand As Label
    Friend WithEvents LabelOu As Label
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonValider As Button
End Class
