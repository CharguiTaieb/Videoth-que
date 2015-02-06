<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailsfilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detailsfilm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.annecrea = New System.Windows.Forms.Label()
        Me.genre = New System.Windows.Forms.Label()
        Me.realisat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomfilm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.filmPicture = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.acteur = New System.Windows.Forms.ComboBox()
        Me.rech = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.filmPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.annecrea)
        Me.GroupBox1.Controls.Add(Me.genre)
        Me.GroupBox1.Controls.Add(Me.realisat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nomfilm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'annecrea
        '
        Me.annecrea.AutoSize = True
        Me.annecrea.Location = New System.Drawing.Point(391, 16)
        Me.annecrea.Name = "annecrea"
        Me.annecrea.Size = New System.Drawing.Size(39, 13)
        Me.annecrea.TabIndex = 54
        Me.annecrea.Text = "Label8"
        '
        'genre
        '
        Me.genre.AutoSize = True
        Me.genre.Location = New System.Drawing.Point(334, 61)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(39, 13)
        Me.genre.TabIndex = 53
        Me.genre.Text = "Label7"
        '
        'realisat
        '
        Me.realisat.AutoSize = True
        Me.realisat.Location = New System.Drawing.Point(89, 61)
        Me.realisat.Name = "realisat"
        Me.realisat.Size = New System.Drawing.Size(39, 13)
        Me.realisat.TabIndex = 52
        Me.realisat.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Genre :"
        '
        'nomfilm
        '
        Me.nomfilm.AutoSize = True
        Me.nomfilm.Location = New System.Drawing.Point(89, 16)
        Me.nomfilm.Name = "nomfilm"
        Me.nomfilm.Size = New System.Drawing.Size(39, 13)
        Me.nomfilm.TabIndex = 0
        Me.nomfilm.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Année de création :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Realisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nom fillm :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.filmPicture)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "image"
        '
        'filmPicture
        '
        Me.filmPicture.Location = New System.Drawing.Point(13, 20)
        Me.filmPicture.Name = "filmPicture"
        Me.filmPicture.Size = New System.Drawing.Size(299, 224)
        Me.filmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.filmPicture.TabIndex = 0
        Me.filmPicture.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(337, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Acteurs :"
        '
        'acteur
        '
        Me.acteur.FormattingEnabled = True
        Me.acteur.Location = New System.Drawing.Point(339, 151)
        Me.acteur.Name = "acteur"
        Me.acteur.Size = New System.Drawing.Size(175, 21)
        Me.acteur.TabIndex = 56
        '
        'rech
        '
        Me.rech.AutoSize = True
        Me.rech.Location = New System.Drawing.Point(484, 337)
        Me.rech.Name = "rech"
        Me.rech.Size = New System.Drawing.Size(30, 13)
        Me.rech.TabIndex = 2
        Me.rech.TabStop = True
        Me.rech.Text = "more"
        '
        'detailsfilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 362)
        Me.Controls.Add(Me.acteur)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rech)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "detailsfilm"
        Me.Text = "Détails Film"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.filmPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nomfilm As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents annecrea As System.Windows.Forms.Label
    Friend WithEvents genre As System.Windows.Forms.Label
    Friend WithEvents realisat As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filmPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents acteur As System.Windows.Forms.ComboBox
    Friend WithEvents rech As System.Windows.Forms.LinkLabel
End Class
