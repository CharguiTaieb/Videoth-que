<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModiFilm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModiFilm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBrealis = New System.Windows.Forms.ComboBox()
        Me.numfilm = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.genre = New System.Windows.Forms.ComboBox()
        Me.Daterealisation = New System.Windows.Forms.DateTimePicker()
        Me.nomfilm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.modif = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBrealis)
        Me.GroupBox1.Controls.Add(Me.numfilm)
        Me.GroupBox1.Controls.Add(Me.L)
        Me.GroupBox1.Controls.Add(Me.genre)
        Me.GroupBox1.Controls.Add(Me.Daterealisation)
        Me.GroupBox1.Controls.Add(Me.nomfilm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 190)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifier film"
        '
        'CBrealis
        '
        Me.CBrealis.FormattingEnabled = True
        Me.CBrealis.Location = New System.Drawing.Point(112, 98)
        Me.CBrealis.Name = "CBrealis"
        Me.CBrealis.Size = New System.Drawing.Size(200, 21)
        Me.CBrealis.TabIndex = 54
        '
        'numfilm
        '
        Me.numfilm.AutoSize = True
        Me.numfilm.Location = New System.Drawing.Point(131, 37)
        Me.numfilm.Name = "numfilm"
        Me.numfilm.Size = New System.Drawing.Size(0, 13)
        Me.numfilm.TabIndex = 53
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(14, 38)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(53, 13)
        Me.L.TabIndex = 52
        Me.L.Text = "Num film :"
        '
        'genre
        '
        Me.genre.FormattingEnabled = True
        Me.genre.Items.AddRange(New Object() {"HORREUR", "ROMANTIQUE", "DRAMA", "ACTION", "DANCE", "DOCUMENTAIRE"})
        Me.genre.Location = New System.Drawing.Point(112, 159)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(200, 21)
        Me.genre.TabIndex = 51
        '
        'Daterealisation
        '
        Me.Daterealisation.Location = New System.Drawing.Point(112, 130)
        Me.Daterealisation.Name = "Daterealisation"
        Me.Daterealisation.Size = New System.Drawing.Size(200, 20)
        Me.Daterealisation.TabIndex = 43
        '
        'nomfilm
        '
        Me.nomfilm.Location = New System.Drawing.Point(112, 65)
        Me.nomfilm.Name = "nomfilm"
        Me.nomfilm.Size = New System.Drawing.Size(200, 20)
        Me.nomfilm.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Genre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Année de création :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Realisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nom fillm :"
        '
        'modif
        '
        Me.modif.Image = CType(resources.GetObject("modif.Image"), System.Drawing.Image)
        Me.modif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modif.Location = New System.Drawing.Point(371, 363)
        Me.modif.Name = "modif"
        Me.modif.Size = New System.Drawing.Size(108, 30)
        Me.modif.TabIndex = 48
        Me.modif.Text = "Modifier"
        Me.modif.UseVisualStyleBackColor = True
        '
        'quitter
        '
        Me.quitter.Image = CType(resources.GetObject("quitter.Image"), System.Drawing.Image)
        Me.quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quitter.Location = New System.Drawing.Point(523, 363)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(108, 30)
        Me.quitter.TabIndex = 49
        Me.quitter.Text = "Annuler/Quitter"
        Me.quitter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 224)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(312, 169)
        Me.CheckedListBox1.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 273)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 54
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(616, 302)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(45, 23)
        Me.Reset.TabIndex = 55
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ModiFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 406)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quitter)
        Me.Controls.Add(Me.modif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModiFilm"
        Me.Text = "Modication du Film"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numfilm As System.Windows.Forms.Label
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents genre As System.Windows.Forms.ComboBox
    Friend WithEvents Daterealisation As System.Windows.Forms.DateTimePicker
    Friend WithEvents nomfilm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents modif As System.Windows.Forms.Button
    Friend WithEvents quitter As System.Windows.Forms.Button
    Friend WithEvents CBrealis As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Reset As System.Windows.Forms.Button
End Class
