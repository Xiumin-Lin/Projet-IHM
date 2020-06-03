<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecap
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
        Me.LabelRecap = New System.Windows.Forms.Label()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelInfoNom = New System.Windows.Forms.Label()
        Me.LabelInfoPrenom = New System.Windows.Forms.Label()
        Me.LabelInfoAdresse = New System.Windows.Forms.Label()
        Me.LabelInfoCP = New System.Windows.Forms.Label()
        Me.LabelInfoVille = New System.Windows.Forms.Label()
        Me.LabelInfoAge = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.GroupBoxInfoCandidat = New System.Windows.Forms.GroupBox()
        Me.GroupBoxInfoEEcrites = New System.Windows.Forms.GroupBox()
        Me.LabelEE4 = New System.Windows.Forms.Label()
        Me.LabelEE3 = New System.Windows.Forms.Label()
        Me.LabelEE2 = New System.Windows.Forms.Label()
        Me.LabelEE1 = New System.Windows.Forms.Label()
        Me.GroupBoxInfoEOrales = New System.Windows.Forms.GroupBox()
        Me.LabelEO3 = New System.Windows.Forms.Label()
        Me.LabelEO2 = New System.Windows.Forms.Label()
        Me.LabelEO1 = New System.Windows.Forms.Label()
        Me.GroupBoxInfoEOF = New System.Windows.Forms.GroupBox()
        Me.LabelEOF = New System.Windows.Forms.Label()
        Me.ButtonSupp = New System.Windows.Forms.Button()
        Me.LabelInfoRegion = New System.Windows.Forms.Label()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxNum = New System.Windows.Forms.GroupBox()
        Me.LabelInfoNum = New System.Windows.Forms.Label()
        Me.GroupBoxInfoCandidat.SuspendLayout()
        Me.GroupBoxInfoEEcrites.SuspendLayout()
        Me.GroupBoxInfoEOrales.SuspendLayout()
        Me.GroupBoxInfoEOF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelRecap
        '
        Me.LabelRecap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRecap.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecap.Location = New System.Drawing.Point(186, 27)
        Me.LabelRecap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRecap.Name = "LabelRecap"
        Me.LabelRecap.Size = New System.Drawing.Size(452, 42)
        Me.LabelRecap.TabIndex = 0
        Me.LabelRecap.Text = "Récapitulatif du Candidat"
        Me.LabelRecap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonValider
        '
        Me.ButtonValider.BackColor = System.Drawing.Color.Azure
        Me.ButtonValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValider.Location = New System.Drawing.Point(442, 497)
        Me.ButtonValider.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(133, 68)
        Me.ButtonValider.TabIndex = 7
        Me.ButtonValider.Text = "Valider "
        Me.ButtonValider.UseVisualStyleBackColor = False
        Me.ButtonValider.Visible = False
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.BackColor = System.Drawing.Color.Azure
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(77, 497)
        Me.ButtonAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(133, 68)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = False
        Me.ButtonAnnuler.Visible = False
        '
        'ButtonModif
        '
        Me.ButtonModif.BackColor = System.Drawing.Color.Azure
        Me.ButtonModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModif.Location = New System.Drawing.Point(253, 497)
        Me.ButtonModif.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(133, 68)
        Me.ButtonModif.TabIndex = 6
        Me.ButtonModif.Text = "Modifier"
        Me.ButtonModif.UseVisualStyleBackColor = False
        Me.ButtonModif.Visible = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(21, 41)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 20)
        Me.LabelNom.TabIndex = 4
        Me.LabelNom.Text = "Nom :"
        Me.LabelNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVille.Location = New System.Drawing.Point(21, 270)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(51, 20)
        Me.LabelVille.TabIndex = 9
        Me.LabelVille.Text = "Ville :"
        Me.LabelVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = True
        Me.LabelCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCP.Location = New System.Drawing.Point(21, 237)
        Me.LabelCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(110, 20)
        Me.LabelCP.TabIndex = 8
        Me.LabelCP.Text = "Code Postal :"
        Me.LabelCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresse.Location = New System.Drawing.Point(21, 152)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(81, 20)
        Me.LabelAdresse.TabIndex = 7
        Me.LabelAdresse.Text = "Adresse :"
        Me.LabelAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(21, 72)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(77, 20)
        Me.LabelPrenom.TabIndex = 5
        Me.LabelPrenom.Text = "Prénom :"
        Me.LabelPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfoNom
        '
        Me.LabelInfoNom.AutoSize = True
        Me.LabelInfoNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoNom.Location = New System.Drawing.Point(110, 40)
        Me.LabelInfoNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoNom.Name = "LabelInfoNom"
        Me.LabelInfoNom.Size = New System.Drawing.Size(46, 22)
        Me.LabelInfoNom.TabIndex = 10
        Me.LabelInfoNom.Text = "Nom"
        Me.LabelInfoNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfoPrenom
        '
        Me.LabelInfoPrenom.AutoSize = True
        Me.LabelInfoPrenom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoPrenom.Location = New System.Drawing.Point(110, 72)
        Me.LabelInfoPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoPrenom.Name = "LabelInfoPrenom"
        Me.LabelInfoPrenom.Size = New System.Drawing.Size(69, 22)
        Me.LabelInfoPrenom.TabIndex = 11
        Me.LabelInfoPrenom.Text = "Prénom"
        Me.LabelInfoPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfoAdresse
        '
        Me.LabelInfoAdresse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoAdresse.Location = New System.Drawing.Point(110, 152)
        Me.LabelInfoAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoAdresse.Name = "LabelInfoAdresse"
        Me.LabelInfoAdresse.Size = New System.Drawing.Size(171, 63)
        Me.LabelInfoAdresse.TabIndex = 20
        Me.LabelInfoAdresse.Text = "Adresse"
        '
        'LabelInfoCP
        '
        Me.LabelInfoCP.AutoSize = True
        Me.LabelInfoCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoCP.Location = New System.Drawing.Point(141, 237)
        Me.LabelInfoCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoCP.Name = "LabelInfoCP"
        Me.LabelInfoCP.Size = New System.Drawing.Size(34, 22)
        Me.LabelInfoCP.TabIndex = 21
        Me.LabelInfoCP.Text = "CP"
        Me.LabelInfoCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfoVille
        '
        Me.LabelInfoVille.AutoSize = True
        Me.LabelInfoVille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoVille.Location = New System.Drawing.Point(141, 270)
        Me.LabelInfoVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoVille.Name = "LabelInfoVille"
        Me.LabelInfoVille.Size = New System.Drawing.Size(43, 22)
        Me.LabelInfoVille.TabIndex = 22
        Me.LabelInfoVille.Text = "Ville"
        Me.LabelInfoVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelInfoAge
        '
        Me.LabelInfoAge.AutoSize = True
        Me.LabelInfoAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoAge.Location = New System.Drawing.Point(110, 110)
        Me.LabelInfoAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoAge.Name = "LabelInfoAge"
        Me.LabelInfoAge.Size = New System.Drawing.Size(40, 22)
        Me.LabelInfoAge.TabIndex = 12
        Me.LabelInfoAge.Text = "Age"
        Me.LabelInfoAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.Location = New System.Drawing.Point(21, 110)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(48, 20)
        Me.LabelAge.TabIndex = 6
        Me.LabelAge.Text = "Age :"
        Me.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxInfoCandidat
        '
        Me.GroupBoxInfoCandidat.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelNom)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelAge)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelPrenom)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoAge)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelAdresse)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoVille)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelCP)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoCP)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelVille)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoAdresse)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoNom)
        Me.GroupBoxInfoCandidat.Controls.Add(Me.LabelInfoPrenom)
        Me.GroupBoxInfoCandidat.Location = New System.Drawing.Point(52, 147)
        Me.GroupBoxInfoCandidat.Name = "GroupBoxInfoCandidat"
        Me.GroupBoxInfoCandidat.Size = New System.Drawing.Size(334, 317)
        Me.GroupBoxInfoCandidat.TabIndex = 1
        Me.GroupBoxInfoCandidat.TabStop = False
        Me.GroupBoxInfoCandidat.Text = "Information"
        '
        'GroupBoxInfoEEcrites
        '
        Me.GroupBoxInfoEEcrites.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxInfoEEcrites.Controls.Add(Me.LabelEE4)
        Me.GroupBoxInfoEEcrites.Controls.Add(Me.LabelEE3)
        Me.GroupBoxInfoEEcrites.Controls.Add(Me.LabelEE2)
        Me.GroupBoxInfoEEcrites.Controls.Add(Me.LabelEE1)
        Me.GroupBoxInfoEEcrites.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBoxInfoEEcrites.Location = New System.Drawing.Point(410, 147)
        Me.GroupBoxInfoEEcrites.Name = "GroupBoxInfoEEcrites"
        Me.GroupBoxInfoEEcrites.Size = New System.Drawing.Size(369, 119)
        Me.GroupBoxInfoEEcrites.TabIndex = 2
        Me.GroupBoxInfoEEcrites.TabStop = False
        Me.GroupBoxInfoEEcrites.Text = "Epreuves Ecrites Sélectionnées"
        '
        'LabelEE4
        '
        Me.LabelEE4.AutoSize = True
        Me.LabelEE4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEE4.Location = New System.Drawing.Point(186, 81)
        Me.LabelEE4.Name = "LabelEE4"
        Me.LabelEE4.Size = New System.Drawing.Size(42, 22)
        Me.LabelEE4.TabIndex = 3
        Me.LabelEE4.Text = "EE4"
        '
        'LabelEE3
        '
        Me.LabelEE3.AutoSize = True
        Me.LabelEE3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEE3.Location = New System.Drawing.Point(186, 40)
        Me.LabelEE3.Name = "LabelEE3"
        Me.LabelEE3.Size = New System.Drawing.Size(42, 22)
        Me.LabelEE3.TabIndex = 2
        Me.LabelEE3.Text = "EE3"
        '
        'LabelEE2
        '
        Me.LabelEE2.AutoSize = True
        Me.LabelEE2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEE2.Location = New System.Drawing.Point(22, 81)
        Me.LabelEE2.Name = "LabelEE2"
        Me.LabelEE2.Size = New System.Drawing.Size(42, 22)
        Me.LabelEE2.TabIndex = 1
        Me.LabelEE2.Text = "EE2"
        '
        'LabelEE1
        '
        Me.LabelEE1.AutoSize = True
        Me.LabelEE1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEE1.Location = New System.Drawing.Point(22, 40)
        Me.LabelEE1.Name = "LabelEE1"
        Me.LabelEE1.Size = New System.Drawing.Size(42, 22)
        Me.LabelEE1.TabIndex = 0
        Me.LabelEE1.Text = "EE1"
        '
        'GroupBoxInfoEOrales
        '
        Me.GroupBoxInfoEOrales.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxInfoEOrales.Controls.Add(Me.LabelEO3)
        Me.GroupBoxInfoEOrales.Controls.Add(Me.LabelEO2)
        Me.GroupBoxInfoEOrales.Controls.Add(Me.LabelEO1)
        Me.GroupBoxInfoEOrales.Location = New System.Drawing.Point(410, 277)
        Me.GroupBoxInfoEOrales.Name = "GroupBoxInfoEOrales"
        Me.GroupBoxInfoEOrales.Size = New System.Drawing.Size(369, 103)
        Me.GroupBoxInfoEOrales.TabIndex = 3
        Me.GroupBoxInfoEOrales.TabStop = False
        Me.GroupBoxInfoEOrales.Text = "Epreuves Orales Sélectionnées"
        '
        'LabelEO3
        '
        Me.LabelEO3.AutoSize = True
        Me.LabelEO3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEO3.Location = New System.Drawing.Point(186, 33)
        Me.LabelEO3.Name = "LabelEO3"
        Me.LabelEO3.Size = New System.Drawing.Size(44, 22)
        Me.LabelEO3.TabIndex = 2
        Me.LabelEO3.Text = "EO3"
        '
        'LabelEO2
        '
        Me.LabelEO2.AutoSize = True
        Me.LabelEO2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEO2.Location = New System.Drawing.Point(20, 63)
        Me.LabelEO2.Name = "LabelEO2"
        Me.LabelEO2.Size = New System.Drawing.Size(44, 22)
        Me.LabelEO2.TabIndex = 1
        Me.LabelEO2.Text = "EO2"
        '
        'LabelEO1
        '
        Me.LabelEO1.AutoSize = True
        Me.LabelEO1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEO1.Location = New System.Drawing.Point(20, 33)
        Me.LabelEO1.Name = "LabelEO1"
        Me.LabelEO1.Size = New System.Drawing.Size(44, 22)
        Me.LabelEO1.TabIndex = 0
        Me.LabelEO1.Text = "EO1"
        '
        'GroupBoxInfoEOF
        '
        Me.GroupBoxInfoEOF.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxInfoEOF.Controls.Add(Me.LabelEOF)
        Me.GroupBoxInfoEOF.Location = New System.Drawing.Point(410, 392)
        Me.GroupBoxInfoEOF.Name = "GroupBoxInfoEOF"
        Me.GroupBoxInfoEOF.Size = New System.Drawing.Size(369, 72)
        Me.GroupBoxInfoEOF.TabIndex = 4
        Me.GroupBoxInfoEOF.TabStop = False
        Me.GroupBoxInfoEOF.Text = "Epreuve Orale Facultative Sélectionnée"
        Me.GroupBoxInfoEOF.Visible = False
        '
        'LabelEOF
        '
        Me.LabelEOF.AutoSize = True
        Me.LabelEOF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelEOF.Location = New System.Drawing.Point(22, 36)
        Me.LabelEOF.Name = "LabelEOF"
        Me.LabelEOF.Size = New System.Drawing.Size(45, 22)
        Me.LabelEOF.TabIndex = 0
        Me.LabelEOF.Text = "EOF"
        '
        'ButtonSupp
        '
        Me.ButtonSupp.BackColor = System.Drawing.Color.Azure
        Me.ButtonSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupp.Location = New System.Drawing.Point(623, 497)
        Me.ButtonSupp.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSupp.Name = "ButtonSupp"
        Me.ButtonSupp.Size = New System.Drawing.Size(133, 68)
        Me.ButtonSupp.TabIndex = 8
        Me.ButtonSupp.Text = "Valider Suppression"
        Me.ButtonSupp.UseVisualStyleBackColor = False
        Me.ButtonSupp.Visible = False
        '
        'LabelInfoRegion
        '
        Me.LabelInfoRegion.AutoSize = True
        Me.LabelInfoRegion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfoRegion.Location = New System.Drawing.Point(196, 15)
        Me.LabelInfoRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfoRegion.Name = "LabelInfoRegion"
        Me.LabelInfoRegion.Size = New System.Drawing.Size(63, 22)
        Me.LabelInfoRegion.TabIndex = 24
        Me.LabelInfoRegion.Text = "Région"
        Me.LabelInfoRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = True
        Me.LabelRegion.BackColor = System.Drawing.Color.Cornsilk
        Me.LabelRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegion.Location = New System.Drawing.Point(7, 15)
        Me.LabelRegion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(181, 20)
        Me.LabelRegion.TabIndex = 23
        Me.LabelRegion.Text = "Région des épreuves  :"
        Me.LabelRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.LabelInfoRegion)
        Me.Panel1.Controls.Add(Me.LabelRegion)
        Me.Panel1.Location = New System.Drawing.Point(214, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 47)
        Me.Panel1.TabIndex = 0
        '
        'GroupBoxNum
        '
        Me.GroupBoxNum.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBoxNum.Controls.Add(Me.LabelInfoNum)
        Me.GroupBoxNum.Location = New System.Drawing.Point(52, 72)
        Me.GroupBoxNum.Name = "GroupBoxNum"
        Me.GroupBoxNum.Size = New System.Drawing.Size(112, 60)
        Me.GroupBoxNum.TabIndex = 5
        Me.GroupBoxNum.TabStop = False
        Me.GroupBoxNum.Text = "N°Candidat"
        '
        'LabelInfoNum
        '
        Me.LabelInfoNum.AutoSize = True
        Me.LabelInfoNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfoNum.Location = New System.Drawing.Point(30, 25)
        Me.LabelInfoNum.Name = "LabelInfoNum"
        Me.LabelInfoNum.Size = New System.Drawing.Size(38, 22)
        Me.LabelInfoNum.TabIndex = 0
        Me.LabelInfoNum.Text = "???"
        '
        'FormRecap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(814, 606)
        Me.Controls.Add(Me.GroupBoxNum)
        Me.Controls.Add(Me.ButtonSupp)
        Me.Controls.Add(Me.GroupBoxInfoEOF)
        Me.Controls.Add(Me.GroupBoxInfoEOrales)
        Me.Controls.Add(Me.GroupBoxInfoEEcrites)
        Me.Controls.Add(Me.GroupBoxInfoCandidat)
        Me.Controls.Add(Me.ButtonModif)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.LabelRecap)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRecap"
        Me.Text = "Récapitulatif"
        Me.GroupBoxInfoCandidat.ResumeLayout(False)
        Me.GroupBoxInfoCandidat.PerformLayout()
        Me.GroupBoxInfoEEcrites.ResumeLayout(False)
        Me.GroupBoxInfoEEcrites.PerformLayout()
        Me.GroupBoxInfoEOrales.ResumeLayout(False)
        Me.GroupBoxInfoEOrales.PerformLayout()
        Me.GroupBoxInfoEOF.ResumeLayout(False)
        Me.GroupBoxInfoEOF.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxNum.ResumeLayout(False)
        Me.GroupBoxNum.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelRecap As Label
    Friend WithEvents ButtonValider As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonModif As Button
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelCP As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelInfoNom As Label
    Friend WithEvents LabelInfoPrenom As Label
    Friend WithEvents LabelInfoAdresse As Label
    Friend WithEvents LabelInfoCP As Label
    Friend WithEvents LabelInfoVille As Label
    Friend WithEvents LabelInfoAge As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents GroupBoxInfoCandidat As GroupBox
    Friend WithEvents GroupBoxInfoEEcrites As GroupBox
    Friend WithEvents LabelEE4 As Label
    Friend WithEvents LabelEE3 As Label
    Friend WithEvents LabelEE2 As Label
    Friend WithEvents LabelEE1 As Label
    Friend WithEvents GroupBoxInfoEOrales As GroupBox
    Friend WithEvents LabelEO3 As Label
    Friend WithEvents LabelEO2 As Label
    Friend WithEvents LabelEO1 As Label
    Friend WithEvents GroupBoxInfoEOF As GroupBox
    Friend WithEvents LabelEOF As Label
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents LabelInfoRegion As Label
    Friend WithEvents LabelRegion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxNum As GroupBox
    Friend WithEvents LabelInfoNum As Label
End Class
