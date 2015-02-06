<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class videotheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(videotheque))
        Me.LOCATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.REALISATEURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIlmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listefilm = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActeurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExemplaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nbrexemplaire = New System.Windows.Forms.TextBox()
        Me.typexemplaire = New System.Windows.Forms.ListBox()
        Me.bsupp = New System.Windows.Forms.Button()
        Me.bmodif = New System.Windows.Forms.Button()
        Me.bdetails = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CBliste = New System.Windows.Forms.ComboBox()
        Me.rechhh = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LOCATIONToolStripMenuItem
        '
        Me.LOCATIONToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LOCATIONToolStripMenuItem.Image = CType(resources.GetObject("LOCATIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LOCATIONToolStripMenuItem.Name = "LOCATIONToolStripMenuItem"
        Me.LOCATIONToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.LOCATIONToolStripMenuItem.Text = "Empreinte"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-443, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'REALISATEURToolStripMenuItem
        '
        Me.REALISATEURToolStripMenuItem.Image = CType(resources.GetObject("REALISATEURToolStripMenuItem.Image"), System.Drawing.Image)
        Me.REALISATEURToolStripMenuItem.Name = "REALISATEURToolStripMenuItem"
        Me.REALISATEURToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.REALISATEURToolStripMenuItem.Text = "REALISATEUR"
        '
        'FIlmToolStripMenuItem
        '
        Me.FIlmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem})
        Me.FIlmToolStripMenuItem.Image = CType(resources.GetObject("FIlmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FIlmToolStripMenuItem.Name = "FIlmToolStripMenuItem"
        Me.FIlmToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FIlmToolStripMenuItem.Text = "FILM"
        '
        'AjoutToolStripMenuItem
        '
        Me.AjoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AjoutToolStripMenuItem.Image = CType(resources.GetObject("AjoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjoutToolStripMenuItem.Name = "AjoutToolStripMenuItem"
        Me.AjoutToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AjoutToolStripMenuItem.Text = "Ajout"
        '
        'listefilm
        '
        Me.listefilm.FormattingEnabled = True
        Me.listefilm.ItemHeight = 14
        Me.listefilm.Location = New System.Drawing.Point(6, 19)
        Me.listefilm.Name = "listefilm"
        Me.listefilm.Size = New System.Drawing.Size(313, 256)
        Me.listefilm.TabIndex = 29
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIlmToolStripMenuItem, Me.LOCATIONToolStripMenuItem, Me.REALISATEURToolStripMenuItem, Me.ActeurToolStripMenuItem, Me.ClientToolStripMenuItem, Me.ExemplaireToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActeurToolStripMenuItem
        '
        Me.ActeurToolStripMenuItem.Name = "ActeurToolStripMenuItem"
        Me.ActeurToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ActeurToolStripMenuItem.Text = "acteur"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ExemplaireToolStripMenuItem
        '
        Me.ExemplaireToolStripMenuItem.Name = "ExemplaireToolStripMenuItem"
        Me.ExemplaireToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ExemplaireToolStripMenuItem.Text = "Exemplaire"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(254, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 264)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nbrexemplaire)
        Me.GroupBox1.Controls.Add(Me.typexemplaire)
        Me.GroupBox1.Controls.Add(Me.bsupp)
        Me.GroupBox1.Controls.Add(Me.bmodif)
        Me.GroupBox1.Controls.Add(Me.bdetails)
        Me.GroupBox1.Controls.Add(Me.listefilm)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 292)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filmes"
        '
        'nbrexemplaire
        '
        Me.nbrexemplaire.Enabled = False
        Me.nbrexemplaire.Location = New System.Drawing.Point(474, 36)
        Me.nbrexemplaire.Name = "nbrexemplaire"
        Me.nbrexemplaire.Size = New System.Drawing.Size(117, 22)
        Me.nbrexemplaire.TabIndex = 37
        '
        'typexemplaire
        '
        Me.typexemplaire.FormattingEnabled = True
        Me.typexemplaire.ItemHeight = 14
        Me.typexemplaire.Location = New System.Drawing.Point(474, 119)
        Me.typexemplaire.Name = "typexemplaire"
        Me.typexemplaire.Size = New System.Drawing.Size(117, 130)
        Me.typexemplaire.TabIndex = 36
        '
        'bsupp
        '
        Me.bsupp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bsupp.Location = New System.Drawing.Point(361, 195)
        Me.bsupp.Name = "bsupp"
        Me.bsupp.Size = New System.Drawing.Size(90, 23)
        Me.bsupp.TabIndex = 35
        Me.bsupp.Text = "Supprimer"
        Me.bsupp.UseVisualStyleBackColor = True
        '
        'bmodif
        '
        Me.bmodif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bmodif.Location = New System.Drawing.Point(361, 119)
        Me.bmodif.Name = "bmodif"
        Me.bmodif.Size = New System.Drawing.Size(90, 23)
        Me.bmodif.TabIndex = 34
        Me.bmodif.Text = "Modifier"
        Me.bmodif.UseVisualStyleBackColor = True
        '
        'bdetails
        '
        Me.bdetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bdetails.Location = New System.Drawing.Point(361, 63)
        Me.bdetails.Name = "bdetails"
        Me.bdetails.Size = New System.Drawing.Size(90, 23)
        Me.bdetails.TabIndex = 33
        Me.bdetails.Text = "Affiche détaile"
        Me.bdetails.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.CBliste)
        Me.GroupBox2.Controls.Add(Me.rechhh)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 40)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chercher"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(484, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Cherche"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CBliste
        '
        Me.CBliste.FormattingEnabled = True
        Me.CBliste.Items.AddRange(New Object() {"Film", "Realisateur", "Acteur", "Genre"})
        Me.CBliste.Location = New System.Drawing.Point(330, 13)
        Me.CBliste.Name = "CBliste"
        Me.CBliste.Size = New System.Drawing.Size(121, 21)
        Me.CBliste.TabIndex = 1
        '
        'rechhh
        '
        Me.rechhh.Location = New System.Drawing.Point(6, 14)
        Me.rechhh.Name = "rechhh"
        Me.rechhh.Size = New System.Drawing.Size(305, 20)
        Me.rechhh.TabIndex = 0
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(40, 375)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(532, 150)
        Me.DGV1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nbre d'exemplaire :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 14)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Type d'exemplaire:"
        '
        'videotheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(616, 529)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "videotheque"
        Me.Text = "Videothéque"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LOCATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents REALISATEURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FIlmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents listefilm As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bsupp As System.Windows.Forms.Button
    Friend WithEvents bmodif As System.Windows.Forms.Button
    Friend WithEvents bdetails As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CBliste As System.Windows.Forms.ComboBox
    Friend WithEvents rechhh As System.Windows.Forms.TextBox
    Friend WithEvents ActeurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents nbrexemplaire As System.Windows.Forms.TextBox
    Friend WithEvents typexemplaire As System.Windows.Forms.ListBox
    Friend WithEvents ExemplaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
