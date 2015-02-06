<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutFilm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjoutFilm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBrealisa = New System.Windows.Forms.ComboBox()
        Me.genre = New System.Windows.Forms.ComboBox()
        Me.Daterealisation = New System.Windows.Forms.DateTimePicker()
        Me.nomfilm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.parcourir = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBacteur = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBacteur.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBrealisa)
        Me.GroupBox1.Controls.Add(Me.genre)
        Me.GroupBox1.Controls.Add(Me.Daterealisation)
        Me.GroupBox1.Controls.Add(Me.nomfilm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 139)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "info film"
        '
        'CBrealisa
        '
        Me.CBrealisa.FormattingEnabled = True
        Me.CBrealisa.Location = New System.Drawing.Point(144, 48)
        Me.CBrealisa.Name = "CBrealisa"
        Me.CBrealisa.Size = New System.Drawing.Size(200, 21)
        Me.CBrealisa.TabIndex = 54
        '
        'genre
        '
        Me.genre.FormattingEnabled = True
        Me.genre.Items.AddRange(New Object() {"HORREUR", "ROMANTIQUE", "DRAMA", "ACTION", "DANCE", "DOCUMENTAIRE"})
        Me.genre.Location = New System.Drawing.Point(144, 109)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(200, 21)
        Me.genre.TabIndex = 51
        '
        'Daterealisation
        '
        Me.Daterealisation.Location = New System.Drawing.Point(144, 80)
        Me.Daterealisation.Name = "Daterealisation"
        Me.Daterealisation.Size = New System.Drawing.Size(200, 20)
        Me.Daterealisation.TabIndex = 50
        '
        'nomfilm
        '
        Me.nomfilm.Location = New System.Drawing.Point(144, 15)
        Me.nomfilm.Name = "nomfilm"
        Me.nomfilm.Size = New System.Drawing.Size(200, 20)
        Me.nomfilm.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Genre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Année de création :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Realisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nom fillm :"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(103, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 45)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Ajout FILM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 193)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "image"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'parcourir
        '
        Me.parcourir.AutoSize = True
        Me.parcourir.Location = New System.Drawing.Point(325, 154)
        Me.parcourir.Name = "parcourir"
        Me.parcourir.Size = New System.Drawing.Size(41, 13)
        Me.parcourir.TabIndex = 3
        Me.parcourir.TabStop = True
        Me.parcourir.Text = "browse"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'GBacteur
        '
        Me.GBacteur.Controls.Add(Me.Button2)
        Me.GBacteur.Controls.Add(Me.CheckedListBox1)
        Me.GBacteur.Enabled = False
        Me.GBacteur.Location = New System.Drawing.Point(372, 12)
        Me.GBacteur.Name = "GBacteur"
        Me.GBacteur.Size = New System.Drawing.Size(276, 400)
        Me.GBacteur.TabIndex = 56
        Me.GBacteur.TabStop = False
        Me.GBacteur.Text = "ACTEURS :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 40)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "AJOUT ACTEURS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(6, 31)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(264, 319)
        Me.CheckedListBox1.TabIndex = 58
        '
        'AjoutFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(660, 435)
        Me.Controls.Add(Me.GBacteur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.parcourir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AjoutFilm"
        Me.Text = "AjoutFilm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBacteur.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents genre As System.Windows.Forms.ComboBox
    Friend WithEvents Daterealisation As System.Windows.Forms.DateTimePicker
    Friend WithEvents nomfilm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBrealisa As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents parcourir As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBacteur As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
