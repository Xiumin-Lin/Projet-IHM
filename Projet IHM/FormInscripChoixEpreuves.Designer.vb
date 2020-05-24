<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInscripChoixEpreuves
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.ComboBoxRegion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxCandidat = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMaths = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExp = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSys = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVBNET = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDroit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxJava = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPW = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGesE = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAlgo = New System.Windows.Forms.CheckBox()
        Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMathsO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExpO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSysO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGesO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDroitO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxResO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEsp = New System.Windows.Forms.CheckBox()
        Me.CheckBoxChi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAng = New System.Windows.Forms.CheckBox()
        Me.RadioButtonYes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNon = New System.Windows.Forms.RadioButton()
        Me.LabelInfoEFacultative = New System.Windows.Forms.Label()
        Me.ComboBoxEFacultative = New System.Windows.Forms.ComboBox()
        Me.GroupBoxEFacultative = New System.Windows.Forms.GroupBox()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonValidChoixEp = New System.Windows.Forms.Button()
        Me.Timer1min30 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxCandidat.SuspendLayout()
        Me.GroupBoxEcrit.SuspendLayout()
        Me.GroupBoxOral.SuspendLayout()
        Me.GroupBoxEFacultative.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(31, 33)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(44, 20)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choix des Epreuves"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(31, 62)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(67, 20)
        Me.LabelPrenom.TabIndex = 1
        Me.LabelPrenom.Text = "Prénom"
        '
        'ComboBoxRegion
        '
        Me.ComboBoxRegion.FormattingEnabled = True
        Me.ComboBoxRegion.Location = New System.Drawing.Point(436, 101)
        Me.ComboBoxRegion.Name = "ComboBoxRegion"
        Me.ComboBoxRegion.Size = New System.Drawing.Size(224, 28)
        Me.ComboBoxRegion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Région :"
        '
        'GroupBoxCandidat
        '
        Me.GroupBoxCandidat.Controls.Add(Me.LabelNom)
        Me.GroupBoxCandidat.Controls.Add(Me.LabelPrenom)
        Me.GroupBoxCandidat.Location = New System.Drawing.Point(30, 29)
        Me.GroupBoxCandidat.Name = "GroupBoxCandidat"
        Me.GroupBoxCandidat.Size = New System.Drawing.Size(213, 100)
        Me.GroupBoxCandidat.TabIndex = 5
        Me.GroupBoxCandidat.TabStop = False
        Me.GroupBoxCandidat.Text = "Candidat"
        '
        'GroupBoxEcrit
        '
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxMaths)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxExp)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxSys)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxVBNET)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxDroit)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxJava)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxRes)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxPW)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxC)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxGesE)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxBD)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxAlgo)
        Me.GroupBoxEcrit.Location = New System.Drawing.Point(50, 154)
        Me.GroupBoxEcrit.Name = "GroupBoxEcrit"
        Me.GroupBoxEcrit.Size = New System.Drawing.Size(921, 168)
        Me.GroupBoxEcrit.TabIndex = 6
        Me.GroupBoxEcrit.TabStop = False
        Me.GroupBoxEcrit.Text = "Epreuves Ecrites Disponibles"
        '
        'CheckBoxMaths
        '
        Me.CheckBoxMaths.AutoSize = True
        Me.CheckBoxMaths.Location = New System.Drawing.Point(676, 74)
        Me.CheckBoxMaths.Name = "CheckBoxMaths"
        Me.CheckBoxMaths.Size = New System.Drawing.Size(145, 24)
        Me.CheckBoxMaths.TabIndex = 10
        Me.CheckBoxMaths.Text = "Mathématiques"
        Me.CheckBoxMaths.UseVisualStyleBackColor = True
        '
        'CheckBoxExp
        '
        Me.CheckBoxExp.AutoSize = True
        Me.CheckBoxExp.Location = New System.Drawing.Point(676, 39)
        Me.CheckBoxExp.Name = "CheckBoxExp"
        Me.CheckBoxExp.Size = New System.Drawing.Size(114, 24)
        Me.CheckBoxExp.TabIndex = 9
        Me.CheckBoxExp.Text = "Expression"
        Me.CheckBoxExp.UseVisualStyleBackColor = True
        '
        'CheckBoxSys
        '
        Me.CheckBoxSys.AutoSize = True
        Me.CheckBoxSys.Location = New System.Drawing.Point(494, 114)
        Me.CheckBoxSys.Name = "CheckBoxSys"
        Me.CheckBoxSys.Size = New System.Drawing.Size(96, 24)
        Me.CheckBoxSys.TabIndex = 8
        Me.CheckBoxSys.Text = "Système"
        Me.CheckBoxSys.UseVisualStyleBackColor = True
        '
        'CheckBoxVBNET
        '
        Me.CheckBoxVBNET.AutoSize = True
        Me.CheckBoxVBNET.Location = New System.Drawing.Point(676, 114)
        Me.CheckBoxVBNET.Name = "CheckBoxVBNET"
        Me.CheckBoxVBNET.Size = New System.Drawing.Size(160, 24)
        Me.CheckBoxVBNET.TabIndex = 11
        Me.CheckBoxVBNET.Text = "Visual Basic .Net"
        Me.CheckBoxVBNET.UseVisualStyleBackColor = True
        '
        'CheckBoxDroit
        '
        Me.CheckBoxDroit.AutoSize = True
        Me.CheckBoxDroit.Location = New System.Drawing.Point(494, 39)
        Me.CheckBoxDroit.Name = "CheckBoxDroit"
        Me.CheckBoxDroit.Size = New System.Drawing.Size(68, 24)
        Me.CheckBoxDroit.TabIndex = 6
        Me.CheckBoxDroit.Text = "Droit"
        Me.CheckBoxDroit.UseVisualStyleBackColor = True
        '
        'CheckBoxJava
        '
        Me.CheckBoxJava.AutoSize = True
        Me.CheckBoxJava.Location = New System.Drawing.Point(494, 74)
        Me.CheckBoxJava.Name = "CheckBoxJava"
        Me.CheckBoxJava.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxJava.TabIndex = 7
        Me.CheckBoxJava.Text = "Langage Java"
        Me.CheckBoxJava.UseVisualStyleBackColor = True
        '
        'CheckBoxRes
        '
        Me.CheckBoxRes.AutoSize = True
        Me.CheckBoxRes.Location = New System.Drawing.Point(284, 114)
        Me.CheckBoxRes.Name = "CheckBoxRes"
        Me.CheckBoxRes.Size = New System.Drawing.Size(88, 24)
        Me.CheckBoxRes.TabIndex = 5
        Me.CheckBoxRes.Text = "Réseau"
        Me.CheckBoxRes.UseVisualStyleBackColor = True
        '
        'CheckBoxPW
        '
        Me.CheckBoxPW.AutoSize = True
        Me.CheckBoxPW.Location = New System.Drawing.Point(50, 116)
        Me.CheckBoxPW.Name = "CheckBoxPW"
        Me.CheckBoxPW.Size = New System.Drawing.Size(184, 24)
        Me.CheckBoxPW.TabIndex = 2
        Me.CheckBoxPW.Text = "Programmation Web"
        Me.CheckBoxPW.UseVisualStyleBackColor = True
        '
        'CheckBoxC
        '
        Me.CheckBoxC.AutoSize = True
        Me.CheckBoxC.Location = New System.Drawing.Point(284, 74)
        Me.CheckBoxC.Name = "CheckBoxC"
        Me.CheckBoxC.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxC.TabIndex = 4
        Me.CheckBoxC.Text = "Langage C"
        Me.CheckBoxC.UseVisualStyleBackColor = True
        '
        'CheckBoxGesE
        '
        Me.CheckBoxGesE.AutoSize = True
        Me.CheckBoxGesE.Location = New System.Drawing.Point(50, 76)
        Me.CheckBoxGesE.Name = "CheckBoxGesE"
        Me.CheckBoxGesE.Size = New System.Drawing.Size(89, 24)
        Me.CheckBoxGesE.TabIndex = 1
        Me.CheckBoxGesE.Text = "Gestion"
        Me.CheckBoxGesE.UseVisualStyleBackColor = True
        '
        'CheckBoxBD
        '
        Me.CheckBoxBD.AutoSize = True
        Me.CheckBoxBD.Location = New System.Drawing.Point(284, 39)
        Me.CheckBoxBD.Name = "CheckBoxBD"
        Me.CheckBoxBD.Size = New System.Drawing.Size(161, 24)
        Me.CheckBoxBD.TabIndex = 3
        Me.CheckBoxBD.Text = "Base de données"
        Me.CheckBoxBD.UseVisualStyleBackColor = True
        '
        'CheckBoxAlgo
        '
        Me.CheckBoxAlgo.AutoSize = True
        Me.CheckBoxAlgo.Location = New System.Drawing.Point(50, 39)
        Me.CheckBoxAlgo.Name = "CheckBoxAlgo"
        Me.CheckBoxAlgo.Size = New System.Drawing.Size(133, 24)
        Me.CheckBoxAlgo.TabIndex = 0
        Me.CheckBoxAlgo.Text = "Algorithmique"
        Me.CheckBoxAlgo.UseVisualStyleBackColor = True
        '
        'GroupBoxOral
        '
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxMathsO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxExpO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxSysO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxGesO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxDroitO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxResO)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxEsp)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxChi)
        Me.GroupBoxOral.Controls.Add(Me.CheckBoxAng)
        Me.GroupBoxOral.Location = New System.Drawing.Point(50, 338)
        Me.GroupBoxOral.Name = "GroupBoxOral"
        Me.GroupBoxOral.Size = New System.Drawing.Size(490, 165)
        Me.GroupBoxOral.TabIndex = 7
        Me.GroupBoxOral.TabStop = False
        Me.GroupBoxOral.Text = "Epreuves Orales Disponibles"
        '
        'CheckBoxMathsO
        '
        Me.CheckBoxMathsO.AutoSize = True
        Me.CheckBoxMathsO.Location = New System.Drawing.Point(324, 122)
        Me.CheckBoxMathsO.Name = "CheckBoxMathsO"
        Me.CheckBoxMathsO.Size = New System.Drawing.Size(145, 24)
        Me.CheckBoxMathsO.TabIndex = 8
        Me.CheckBoxMathsO.Text = "Mathématiques"
        Me.CheckBoxMathsO.UseVisualStyleBackColor = True
        '
        'CheckBoxExpO
        '
        Me.CheckBoxExpO.AutoSize = True
        Me.CheckBoxExpO.Location = New System.Drawing.Point(324, 80)
        Me.CheckBoxExpO.Name = "CheckBoxExpO"
        Me.CheckBoxExpO.Size = New System.Drawing.Size(114, 24)
        Me.CheckBoxExpO.TabIndex = 7
        Me.CheckBoxExpO.Text = "Expression"
        Me.CheckBoxExpO.UseVisualStyleBackColor = True
        '
        'CheckBoxSysO
        '
        Me.CheckBoxSysO.AutoSize = True
        Me.CheckBoxSysO.Location = New System.Drawing.Point(324, 44)
        Me.CheckBoxSysO.Name = "CheckBoxSysO"
        Me.CheckBoxSysO.Size = New System.Drawing.Size(96, 24)
        Me.CheckBoxSysO.TabIndex = 6
        Me.CheckBoxSysO.Text = "Système"
        Me.CheckBoxSysO.UseVisualStyleBackColor = True
        '
        'CheckBoxGesO
        '
        Me.CheckBoxGesO.AutoSize = True
        Me.CheckBoxGesO.Location = New System.Drawing.Point(177, 122)
        Me.CheckBoxGesO.Name = "CheckBoxGesO"
        Me.CheckBoxGesO.Size = New System.Drawing.Size(89, 24)
        Me.CheckBoxGesO.TabIndex = 5
        Me.CheckBoxGesO.Text = "Gestion"
        Me.CheckBoxGesO.UseVisualStyleBackColor = True
        '
        'CheckBoxDroitO
        '
        Me.CheckBoxDroitO.AutoSize = True
        Me.CheckBoxDroitO.Location = New System.Drawing.Point(177, 80)
        Me.CheckBoxDroitO.Name = "CheckBoxDroitO"
        Me.CheckBoxDroitO.Size = New System.Drawing.Size(68, 24)
        Me.CheckBoxDroitO.TabIndex = 4
        Me.CheckBoxDroitO.Text = "Droit"
        Me.CheckBoxDroitO.UseVisualStyleBackColor = True
        '
        'CheckBoxResO
        '
        Me.CheckBoxResO.AutoSize = True
        Me.CheckBoxResO.Location = New System.Drawing.Point(177, 44)
        Me.CheckBoxResO.Name = "CheckBoxResO"
        Me.CheckBoxResO.Size = New System.Drawing.Size(88, 24)
        Me.CheckBoxResO.TabIndex = 3
        Me.CheckBoxResO.Text = "Réseau"
        Me.CheckBoxResO.UseVisualStyleBackColor = True
        '
        'CheckBoxEsp
        '
        Me.CheckBoxEsp.AutoSize = True
        Me.CheckBoxEsp.Location = New System.Drawing.Point(30, 122)
        Me.CheckBoxEsp.Name = "CheckBoxEsp"
        Me.CheckBoxEsp.Size = New System.Drawing.Size(100, 24)
        Me.CheckBoxEsp.TabIndex = 2
        Me.CheckBoxEsp.Text = "Espagnol"
        Me.CheckBoxEsp.UseVisualStyleBackColor = True
        '
        'CheckBoxChi
        '
        Me.CheckBoxChi.AutoSize = True
        Me.CheckBoxChi.Location = New System.Drawing.Point(30, 80)
        Me.CheckBoxChi.Name = "CheckBoxChi"
        Me.CheckBoxChi.Size = New System.Drawing.Size(87, 24)
        Me.CheckBoxChi.TabIndex = 1
        Me.CheckBoxChi.Text = "Chinois"
        Me.CheckBoxChi.UseVisualStyleBackColor = True
        '
        'CheckBoxAng
        '
        Me.CheckBoxAng.AutoSize = True
        Me.CheckBoxAng.Location = New System.Drawing.Point(30, 44)
        Me.CheckBoxAng.Name = "CheckBoxAng"
        Me.CheckBoxAng.Size = New System.Drawing.Size(86, 24)
        Me.CheckBoxAng.TabIndex = 0
        Me.CheckBoxAng.Text = "Anglais"
        Me.CheckBoxAng.UseVisualStyleBackColor = True
        '
        'RadioButtonYes
        '
        Me.RadioButtonYes.AutoSize = True
        Me.RadioButtonYes.Location = New System.Drawing.Point(49, 76)
        Me.RadioButtonYes.Name = "RadioButtonYes"
        Me.RadioButtonYes.Size = New System.Drawing.Size(56, 24)
        Me.RadioButtonYes.TabIndex = 1
        Me.RadioButtonYes.TabStop = True
        Me.RadioButtonYes.Text = "Oui"
        Me.RadioButtonYes.UseVisualStyleBackColor = True
        '
        'RadioButtonNon
        '
        Me.RadioButtonNon.AutoSize = True
        Me.RadioButtonNon.Location = New System.Drawing.Point(49, 122)
        Me.RadioButtonNon.Name = "RadioButtonNon"
        Me.RadioButtonNon.Size = New System.Drawing.Size(60, 24)
        Me.RadioButtonNon.TabIndex = 3
        Me.RadioButtonNon.TabStop = True
        Me.RadioButtonNon.Text = "Non"
        Me.RadioButtonNon.UseVisualStyleBackColor = True
        '
        'LabelInfoEFacultative
        '
        Me.LabelInfoEFacultative.AutoSize = True
        Me.LabelInfoEFacultative.Location = New System.Drawing.Point(23, 34)
        Me.LabelInfoEFacultative.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoEFacultative.Name = "LabelInfoEFacultative"
        Me.LabelInfoEFacultative.Size = New System.Drawing.Size(369, 20)
        Me.LabelInfoEFacultative.TabIndex = 0
        Me.LabelInfoEFacultative.Text = "Souhaitez vous choisir une épreuve facultative ?"
        '
        'ComboBoxEFacultative
        '
        Me.ComboBoxEFacultative.FormattingEnabled = True
        Me.ComboBoxEFacultative.Location = New System.Drawing.Point(120, 76)
        Me.ComboBoxEFacultative.Name = "ComboBoxEFacultative"
        Me.ComboBoxEFacultative.Size = New System.Drawing.Size(255, 28)
        Me.ComboBoxEFacultative.TabIndex = 2
        Me.ComboBoxEFacultative.Visible = False
        '
        'GroupBoxEFacultative
        '
        Me.GroupBoxEFacultative.Controls.Add(Me.LabelInfoEFacultative)
        Me.GroupBoxEFacultative.Controls.Add(Me.ComboBoxEFacultative)
        Me.GroupBoxEFacultative.Controls.Add(Me.RadioButtonNon)
        Me.GroupBoxEFacultative.Controls.Add(Me.RadioButtonYes)
        Me.GroupBoxEFacultative.Enabled = False
        Me.GroupBoxEFacultative.Location = New System.Drawing.Point(560, 338)
        Me.GroupBoxEFacultative.Name = "GroupBoxEFacultative"
        Me.GroupBoxEFacultative.Size = New System.Drawing.Size(411, 165)
        Me.GroupBoxEFacultative.TabIndex = 8
        Me.GroupBoxEFacultative.TabStop = False
        Me.GroupBoxEFacultative.Text = "Epreuve Facultative"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(267, 525)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(179, 59)
        Me.ButtonAnnuler.TabIndex = 9
        Me.ButtonAnnuler.Text = "Abandonner"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonValidChoixEp
        '
        Me.ButtonValidChoixEp.Location = New System.Drawing.Point(609, 525)
        Me.ButtonValidChoixEp.Name = "ButtonValidChoixEp"
        Me.ButtonValidChoixEp.Size = New System.Drawing.Size(179, 59)
        Me.ButtonValidChoixEp.TabIndex = 10
        Me.ButtonValidChoixEp.Text = "Valider Enregistrement"
        Me.ButtonValidChoixEp.UseVisualStyleBackColor = True
        '
        'FormInscripChoixEpreuves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 619)
        Me.Controls.Add(Me.ButtonValidChoixEp)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.GroupBoxOral)
        Me.Controls.Add(Me.GroupBoxEFacultative)
        Me.Controls.Add(Me.GroupBoxEcrit)
        Me.Controls.Add(Me.GroupBoxCandidat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxRegion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInscripChoixEpreuves"
        Me.Text = "Formulaire d'inscription : Choix des épreuves"
        Me.GroupBoxCandidat.ResumeLayout(False)
        Me.GroupBoxCandidat.PerformLayout()
        Me.GroupBoxEcrit.ResumeLayout(False)
        Me.GroupBoxEcrit.PerformLayout()
        Me.GroupBoxOral.ResumeLayout(False)
        Me.GroupBoxOral.PerformLayout()
        Me.GroupBoxEFacultative.ResumeLayout(False)
        Me.GroupBoxEFacultative.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents ComboBoxRegion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxCandidat As GroupBox
    Friend WithEvents GroupBoxEcrit As GroupBox
    Friend WithEvents GroupBoxOral As GroupBox
    Friend WithEvents RadioButtonYes As RadioButton
    Friend WithEvents RadioButtonNon As RadioButton
    Friend WithEvents LabelInfoEFacultative As Label
    Friend WithEvents ComboBoxEFacultative As ComboBox
    Friend WithEvents GroupBoxEFacultative As GroupBox
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonValidChoixEp As Button
    Friend WithEvents CheckBoxMaths As CheckBox
    Friend WithEvents CheckBoxExp As CheckBox
    Friend WithEvents CheckBoxSys As CheckBox
    Friend WithEvents CheckBoxVBNET As CheckBox
    Friend WithEvents CheckBoxDroit As CheckBox
    Friend WithEvents CheckBoxJava As CheckBox
    Friend WithEvents CheckBoxRes As CheckBox
    Friend WithEvents CheckBoxPW As CheckBox
    Friend WithEvents CheckBoxC As CheckBox
    Friend WithEvents CheckBoxGesE As CheckBox
    Friend WithEvents CheckBoxBD As CheckBox
    Friend WithEvents CheckBoxAlgo As CheckBox
    Friend WithEvents CheckBoxGesO As CheckBox
    Friend WithEvents CheckBoxDroitO As CheckBox
    Friend WithEvents CheckBoxResO As CheckBox
    Friend WithEvents CheckBoxEsp As CheckBox
    Friend WithEvents CheckBoxChi As CheckBox
    Friend WithEvents CheckBoxAng As CheckBox
    Friend WithEvents Timer1min30 As Timer
    Friend WithEvents CheckBoxExpO As CheckBox
    Friend WithEvents CheckBoxSysO As CheckBox
    Friend WithEvents CheckBoxMathsO As CheckBox
End Class
