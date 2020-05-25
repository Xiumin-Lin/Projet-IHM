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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.ListBoxID = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ListBoxPrenom = New System.Windows.Forms.ListBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ListBoxRegion = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelBilanMatiere
        '
        Me.LabelBilanMatiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!)
        Me.LabelBilanMatiere.Location = New System.Drawing.Point(11, 9)
        Me.LabelBilanMatiere.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBilanMatiere.Name = "LabelBilanMatiere"
        Me.LabelBilanMatiere.Size = New System.Drawing.Size(732, 68)
        Me.LabelBilanMatiere.TabIndex = 5
        Me.LabelBilanMatiere.Text = "Bilan des inscription par matière"
        Me.LabelBilanMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.2!)
        Me.Label1.Location = New System.Drawing.Point(13, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matière : ???"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelID.Location = New System.Drawing.Point(204, 139)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(28, 20)
        Me.LabelID.TabIndex = 7
        Me.LabelID.Text = "N°"
        '
        'ListBoxID
        '
        Me.ListBoxID.FormattingEnabled = True
        Me.ListBoxID.ItemHeight = 20
        Me.ListBoxID.Location = New System.Drawing.Point(208, 172)
        Me.ListBoxID.Name = "ListBoxID"
        Me.ListBoxID.Size = New System.Drawing.Size(58, 224)
        Me.ListBoxID.TabIndex = 8
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 20
        Me.ListBoxNom.Location = New System.Drawing.Point(272, 172)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(150, 224)
        Me.ListBoxNom.TabIndex = 10
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelNom.Location = New System.Drawing.Point(268, 139)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(44, 20)
        Me.LabelNom.TabIndex = 9
        Me.LabelNom.Text = "Nom"
        '
        'ListBoxPrenom
        '
        Me.ListBoxPrenom.FormattingEnabled = True
        Me.ListBoxPrenom.ItemHeight = 20
        Me.ListBoxPrenom.Location = New System.Drawing.Point(428, 172)
        Me.ListBoxPrenom.Name = "ListBoxPrenom"
        Me.ListBoxPrenom.Size = New System.Drawing.Size(154, 224)
        Me.ListBoxPrenom.TabIndex = 12
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.LabelPrenom.Location = New System.Drawing.Point(424, 139)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(67, 20)
        Me.LabelPrenom.TabIndex = 11
        Me.LabelPrenom.Text = "Prénom"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(602, 172)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(54, 224)
        Me.ListBox2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(598, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ecrit ?"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(662, 172)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(51, 224)
        Me.ListBox3.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(664, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Oral ?"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(301, 418)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(152, 46)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Fermer"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ListBoxRegion
        '
        Me.ListBoxRegion.FormattingEnabled = True
        Me.ListBoxRegion.ItemHeight = 20
        Me.ListBoxRegion.Location = New System.Drawing.Point(44, 172)
        Me.ListBoxRegion.Name = "ListBoxRegion"
        Me.ListBoxRegion.Size = New System.Drawing.Size(143, 224)
        Me.ListBoxRegion.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(40, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Région"
        '
        'FormBilanMatiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 479)
        Me.Controls.Add(Me.ListBoxRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBoxPrenom)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ListBoxID)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelBilanMatiere)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBilanMatiere"
        Me.Text = "Bilan Matière"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelBilanMatiere As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents ListBoxID As ListBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents ListBoxPrenom As ListBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ListBoxRegion As ListBox
    Friend WithEvents Label2 As Label
End Class
