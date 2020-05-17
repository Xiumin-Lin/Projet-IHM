<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.ButtonInscription = New System.Windows.Forms.Button()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.ButtonSupp = New System.Windows.Forms.Button()
        Me.LabelAccueil = New System.Windows.Forms.Label()
        Me.ButtonEtat = New System.Windows.Forms.Button()
        Me.BilanProv = New System.Windows.Forms.Button()
        Me.ButtonFinInscription = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonInscription
        '
        Me.ButtonInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInscription.Location = New System.Drawing.Point(68, 138)
        Me.ButtonInscription.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonInscription.Name = "ButtonInscription"
        Me.ButtonInscription.Size = New System.Drawing.Size(149, 71)
        Me.ButtonInscription.TabIndex = 0
        Me.ButtonInscription.Text = "Inscription"
        Me.ButtonInscription.UseVisualStyleBackColor = True
        '
        'ButtonModif
        '
        Me.ButtonModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModif.Location = New System.Drawing.Point(284, 138)
        Me.ButtonModif.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(149, 71)
        Me.ButtonModif.TabIndex = 1
        Me.ButtonModif.Text = "Modification"
        Me.ButtonModif.UseVisualStyleBackColor = True
        '
        'ButtonSupp
        '
        Me.ButtonSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupp.Location = New System.Drawing.Point(496, 138)
        Me.ButtonSupp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonSupp.Name = "ButtonSupp"
        Me.ButtonSupp.Size = New System.Drawing.Size(149, 72)
        Me.ButtonSupp.TabIndex = 2
        Me.ButtonSupp.Text = "Suppression"
        Me.ButtonSupp.UseVisualStyleBackColor = True
        '
        'LabelAccueil
        '
        Me.LabelAccueil.AutoSize = True
        Me.LabelAccueil.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccueil.Location = New System.Drawing.Point(291, 42)
        Me.LabelAccueil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAccueil.Name = "LabelAccueil"
        Me.LabelAccueil.Size = New System.Drawing.Size(128, 39)
        Me.LabelAccueil.TabIndex = 3
        Me.LabelAccueil.Text = "Accueil"
        '
        'ButtonEtat
        '
        Me.ButtonEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEtat.Location = New System.Drawing.Point(68, 242)
        Me.ButtonEtat.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonEtat.Name = "ButtonEtat"
        Me.ButtonEtat.Size = New System.Drawing.Size(149, 70)
        Me.ButtonEtat.TabIndex = 4
        Me.ButtonEtat.Text = "Etat Actuel"
        Me.ButtonEtat.UseVisualStyleBackColor = True
        '
        'BilanProv
        '
        Me.BilanProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BilanProv.Location = New System.Drawing.Point(284, 242)
        Me.BilanProv.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BilanProv.Name = "BilanProv"
        Me.BilanProv.Size = New System.Drawing.Size(149, 71)
        Me.BilanProv.TabIndex = 5
        Me.BilanProv.Text = "Bilan Provisoire"
        Me.BilanProv.UseVisualStyleBackColor = True
        '
        'ButtonFinInscription
        '
        Me.ButtonFinInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFinInscription.Location = New System.Drawing.Point(496, 242)
        Me.ButtonFinInscription.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonFinInscription.Name = "ButtonFinInscription"
        Me.ButtonFinInscription.Size = New System.Drawing.Size(149, 72)
        Me.ButtonFinInscription.TabIndex = 6
        Me.ButtonFinInscription.Text = "Fin Inscription"
        Me.ButtonFinInscription.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 369)
        Me.Controls.Add(Me.ButtonFinInscription)
        Me.Controls.Add(Me.BilanProv)
        Me.Controls.Add(Me.ButtonEtat)
        Me.Controls.Add(Me.LabelAccueil)
        Me.Controls.Add(Me.ButtonSupp)
        Me.Controls.Add(Me.ButtonModif)
        Me.Controls.Add(Me.ButtonInscription)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonInscription As Button
    Friend WithEvents ButtonModif As Button
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents LabelAccueil As Label
    Friend WithEvents ButtonEtat As Button
    Friend WithEvents BilanProv As Button
    Friend WithEvents ButtonFinInscription As Button
End Class
