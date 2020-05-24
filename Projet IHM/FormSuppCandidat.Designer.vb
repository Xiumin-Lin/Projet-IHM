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
        Me.SuspendLayout()
        '
        'ButtonValider
        '
        Me.ButtonValider.Location = New System.Drawing.Point(340, 326)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(112, 45)
        Me.ButtonValider.TabIndex = 17
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(96, 326)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 45)
        Me.ButtonAnnuler.TabIndex = 16
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelOu
        '
        Me.LabelOu.AutoSize = True
        Me.LabelOu.Location = New System.Drawing.Point(258, 200)
        Me.LabelOu.Name = "LabelOu"
        Me.LabelOu.Size = New System.Drawing.Size(34, 20)
        Me.LabelOu.TabIndex = 15
        Me.LabelOu.Text = "OU"
        '
        'LabelIDCandidat
        '
        Me.LabelIDCandidat.AutoSize = True
        Me.LabelIDCandidat.Location = New System.Drawing.Point(107, 233)
        Me.LabelIDCandidat.Name = "LabelIDCandidat"
        Me.LabelIDCandidat.Size = New System.Drawing.Size(196, 20)
        Me.LabelIDCandidat.TabIndex = 14
        Me.LabelIDCandidat.Text = "L'identifiant du candidat :"
        '
        'LabelIndication
        '
        Me.LabelIndication.AutoSize = True
        Me.LabelIndication.Location = New System.Drawing.Point(24, 92)
        Me.LabelIndication.Name = "LabelIndication"
        Me.LabelIndication.Size = New System.Drawing.Size(500, 20)
        Me.LabelIndication.TabIndex = 13
        Me.LabelIndication.Text = "Veuillez entrer le numéro d'inscription ou l'identifiant du candidat :"
        '
        'LabelNumCandidat
        '
        Me.LabelNumCandidat.AutoSize = True
        Me.LabelNumCandidat.Location = New System.Drawing.Point(107, 134)
        Me.LabelNumCandidat.Name = "LabelNumCandidat"
        Me.LabelNumCandidat.Size = New System.Drawing.Size(264, 20)
        Me.LabelNumCandidat.TabIndex = 12
        Me.LabelNumCandidat.Text = "Numéro d'inscription du candidat :"
        '
        'LabelSupp
        '
        Me.LabelSupp.AutoSize = True
        Me.LabelSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupp.Location = New System.Drawing.Point(172, 27)
        Me.LabelSupp.Name = "LabelSupp"
        Me.LabelSupp.Size = New System.Drawing.Size(199, 38)
        Me.LabelSupp.TabIndex = 11
        Me.LabelSupp.Text = "Suppression"
        '
        'TextBoxNumCand
        '
        Me.TextBoxNumCand.Location = New System.Drawing.Point(111, 157)
        Me.TextBoxNumCand.Name = "TextBoxNumCand"
        Me.TextBoxNumCand.Size = New System.Drawing.Size(322, 27)
        Me.TextBoxNumCand.TabIndex = 10
        '
        'ComboBoxIdCand
        '
        Me.ComboBoxIdCand.FormattingEnabled = True
        Me.ComboBoxIdCand.Location = New System.Drawing.Point(111, 256)
        Me.ComboBoxIdCand.Name = "ComboBoxIdCand"
        Me.ComboBoxIdCand.Size = New System.Drawing.Size(322, 28)
        Me.ComboBoxIdCand.TabIndex = 9
        '
        'FormSuppCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 397)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.LabelOu)
        Me.Controls.Add(Me.LabelIDCandidat)
        Me.Controls.Add(Me.LabelIndication)
        Me.Controls.Add(Me.LabelNumCandidat)
        Me.Controls.Add(Me.LabelSupp)
        Me.Controls.Add(Me.TextBoxNumCand)
        Me.Controls.Add(Me.ComboBoxIdCand)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSuppCandidat"
        Me.Text = "Suppression d'un candidat"
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
End Class
