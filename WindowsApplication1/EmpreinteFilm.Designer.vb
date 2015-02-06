<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpreinteFilm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpreinteFilm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTGempreinte = New System.Windows.Forms.DataGridView()
        Me.Supprime = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.modifierr = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBfilm = New System.Windows.Forms.ComboBox()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.CBexemplaire = New System.Windows.Forms.ComboBox()
        Me.dateretour = New System.Windows.Forms.DateTimePicker()
        Me.dateprinte = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGempreinte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTGempreinte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empreintes"
        '
        'DTGempreinte
        '
        Me.DTGempreinte.AllowUserToAddRows = False
        Me.DTGempreinte.AllowUserToDeleteRows = False
        Me.DTGempreinte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGempreinte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Supprime, Me.modifierr})
        Me.DTGempreinte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTGempreinte.Location = New System.Drawing.Point(3, 16)
        Me.DTGempreinte.Name = "DTGempreinte"
        Me.DTGempreinte.ReadOnly = True
        Me.DTGempreinte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGempreinte.Size = New System.Drawing.Size(813, 149)
        Me.DTGempreinte.TabIndex = 0
        '
        'Supprime
        '
        Me.Supprime.HeaderText = "Suppression"
        Me.Supprime.Name = "Supprime"
        Me.Supprime.ReadOnly = True
        '
        'modifierr
        '
        Me.modifierr.HeaderText = "Modification"
        Me.modifierr.Name = "modifierr"
        Me.modifierr.ReadOnly = True
        Me.modifierr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.modifierr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBfilm)
        Me.GroupBox2.Controls.Add(Me.Modifier)
        Me.GroupBox2.Controls.Add(Me.Ajouter)
        Me.GroupBox2.Controls.Add(Me.CBexemplaire)
        Me.GroupBox2.Controls.Add(Me.dateretour)
        Me.GroupBox2.Controls.Add(Me.dateprinte)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(946, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "c"
        '
        'CBfilm
        '
        Me.CBfilm.FormattingEnabled = True
        Me.CBfilm.Location = New System.Drawing.Point(92, 127)
        Me.CBfilm.Name = "CBfilm"
        Me.CBfilm.Size = New System.Drawing.Size(121, 21)
        Me.CBfilm.TabIndex = 19
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(682, 116)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(75, 23)
        Me.Modifier.TabIndex = 18
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'Ajouter
        '
        Me.Ajouter.Location = New System.Drawing.Point(682, 41)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(75, 23)
        Me.Ajouter.TabIndex = 17
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = True
        '
        'CBexemplaire
        '
        Me.CBexemplaire.FormattingEnabled = True
        Me.CBexemplaire.Location = New System.Drawing.Point(452, 145)
        Me.CBexemplaire.Name = "CBexemplaire"
        Me.CBexemplaire.Size = New System.Drawing.Size(142, 21)
        Me.CBexemplaire.TabIndex = 16
        '
        'dateretour
        '
        Me.dateretour.Location = New System.Drawing.Point(394, 90)
        Me.dateretour.Name = "dateretour"
        Me.dateretour.Size = New System.Drawing.Size(200, 20)
        Me.dateretour.TabIndex = 15
        '
        'dateprinte
        '
        Me.dateprinte.Location = New System.Drawing.Point(356, 36)
        Me.dateprinte.Name = "dateprinte"
        Me.dateprinte.Size = New System.Drawing.Size(200, 20)
        Me.dateprinte.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Exemplaire disponible/Allouer :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date Retour :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date Empreinte :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nom Film :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOM Client  :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CIN   :"
        '
        'EmpreinteFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(836, 397)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmpreinteFilm"
        Me.Text = "EmpreinteFilm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DTGempreinte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTGempreinte As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dateprinte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dateretour As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBfilm As System.Windows.Forms.ComboBox
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents CBexemplaire As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Supprime As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents modifierr As System.Windows.Forms.DataGridViewButtonColumn
End Class
