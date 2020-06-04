<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonInscrip = New System.Windows.Forms.Button()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.ButtonSupp = New System.Windows.Forms.Button()
        Me.LabelAccueil = New System.Windows.Forms.Label()
        Me.ButtonEtat = New System.Windows.Forms.Button()
        Me.ButtonBilanProv = New System.Windows.Forms.Button()
        Me.ButtonFinInscrip = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonInscrip
        '
        Me.ButtonInscrip.BackColor = System.Drawing.Color.Azure
        Me.ButtonInscrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInscrip.Location = New System.Drawing.Point(74, 117)
        Me.ButtonInscrip.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonInscrip.Name = "ButtonInscrip"
        Me.ButtonInscrip.Size = New System.Drawing.Size(149, 71)
        Me.ButtonInscrip.TabIndex = 0
        Me.ButtonInscrip.Text = "Inscription"
        Me.ButtonInscrip.UseVisualStyleBackColor = False
        '
        'ButtonModif
        '
        Me.ButtonModif.BackColor = System.Drawing.Color.Azure
        Me.ButtonModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModif.Location = New System.Drawing.Point(265, 117)
        Me.ButtonModif.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(149, 71)
        Me.ButtonModif.TabIndex = 1
        Me.ButtonModif.Text = "Modification"
        Me.ButtonModif.UseVisualStyleBackColor = False
        '
        'ButtonSupp
        '
        Me.ButtonSupp.BackColor = System.Drawing.Color.Azure
        Me.ButtonSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupp.Location = New System.Drawing.Point(461, 117)
        Me.ButtonSupp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonSupp.Name = "ButtonSupp"
        Me.ButtonSupp.Size = New System.Drawing.Size(149, 71)
        Me.ButtonSupp.TabIndex = 2
        Me.ButtonSupp.Text = "Suppression"
        Me.ButtonSupp.UseVisualStyleBackColor = False
        '
        'LabelAccueil
        '
        Me.LabelAccueil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAccueil.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!)
        Me.LabelAccueil.Location = New System.Drawing.Point(11, 29)
        Me.LabelAccueil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAccueil.Name = "LabelAccueil"
        Me.LabelAccueil.Size = New System.Drawing.Size(663, 64)
        Me.LabelAccueil.TabIndex = 3
        Me.LabelAccueil.Text = "Accueil"
        Me.LabelAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonEtat
        '
        Me.ButtonEtat.BackColor = System.Drawing.Color.Azure
        Me.ButtonEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEtat.Location = New System.Drawing.Point(74, 219)
        Me.ButtonEtat.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonEtat.Name = "ButtonEtat"
        Me.ButtonEtat.Size = New System.Drawing.Size(149, 72)
        Me.ButtonEtat.TabIndex = 4
        Me.ButtonEtat.Text = "Etat Actuel"
        Me.ButtonEtat.UseVisualStyleBackColor = False
        '
        'ButtonBilanProv
        '
        Me.ButtonBilanProv.BackColor = System.Drawing.Color.Azure
        Me.ButtonBilanProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBilanProv.Location = New System.Drawing.Point(265, 219)
        Me.ButtonBilanProv.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonBilanProv.Name = "ButtonBilanProv"
        Me.ButtonBilanProv.Size = New System.Drawing.Size(149, 72)
        Me.ButtonBilanProv.TabIndex = 5
        Me.ButtonBilanProv.Text = "Bilan Provisoire"
        Me.ButtonBilanProv.UseVisualStyleBackColor = False
        '
        'ButtonFinInscrip
        '
        Me.ButtonFinInscrip.BackColor = System.Drawing.Color.Azure
        Me.ButtonFinInscrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFinInscrip.Location = New System.Drawing.Point(461, 219)
        Me.ButtonFinInscrip.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ButtonFinInscrip.Name = "ButtonFinInscrip"
        Me.ButtonFinInscrip.Size = New System.Drawing.Size(149, 72)
        Me.ButtonFinInscrip.TabIndex = 6
        Me.ButtonFinInscrip.Text = "Fin Inscription"
        Me.ButtonFinInscrip.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Azure
        Me.ButtonClose.Location = New System.Drawing.Point(297, 328)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(85, 42)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Fermer"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(685, 382)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonFinInscrip)
        Me.Controls.Add(Me.ButtonBilanProv)
        Me.Controls.Add(Me.ButtonEtat)
        Me.Controls.Add(Me.LabelAccueil)
        Me.Controls.Add(Me.ButtonSupp)
        Me.Controls.Add(Me.ButtonModif)
        Me.Controls.Add(Me.ButtonInscrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonInscrip As Button
    Friend WithEvents ButtonModif As Button
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents LabelAccueil As Label
    Friend WithEvents ButtonEtat As Button
    Friend WithEvents ButtonBilanProv As Button
    Friend WithEvents ButtonFinInscrip As Button
    Friend WithEvents ButtonClose As Button
End Class
