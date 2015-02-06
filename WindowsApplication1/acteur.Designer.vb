<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acteur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acteur))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTGACTEUR = New System.Windows.Forms.DataGridView()
        Me.Ajout = New System.Windows.Forms.Button()
        Me.dtgaffichereal = New System.Windows.Forms.DataGridView()
        Me.quitter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DTGACTEUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgaffichereal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTGACTEUR)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 359)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'DTGACTEUR
        '
        Me.DTGACTEUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGACTEUR.Location = New System.Drawing.Point(10, 19)
        Me.DTGACTEUR.Name = "DTGACTEUR"
        Me.DTGACTEUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGACTEUR.Size = New System.Drawing.Size(482, 334)
        Me.DTGACTEUR.TabIndex = 9
        '
        'Ajout
        '
        Me.Ajout.Location = New System.Drawing.Point(13, 29)
        Me.Ajout.Name = "Ajout"
        Me.Ajout.Size = New System.Drawing.Size(136, 51)
        Me.Ajout.TabIndex = 11
        Me.Ajout.Text = "Ajout"
        Me.Ajout.UseVisualStyleBackColor = True
        '
        'dtgaffichereal
        '
        Me.dtgaffichereal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgaffichereal.Location = New System.Drawing.Point(10, 19)
        Me.dtgaffichereal.Name = "dtgaffichereal"
        Me.dtgaffichereal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgaffichereal.Size = New System.Drawing.Size(468, 320)
        Me.dtgaffichereal.TabIndex = 9
        '
        'quitter
        '
        Me.quitter.Image = CType(resources.GetObject("quitter.Image"), System.Drawing.Image)
        Me.quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quitter.Location = New System.Drawing.Point(13, 243)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(136, 51)
        Me.quitter.TabIndex = 10
        Me.quitter.Text = "Quitter"
        Me.quitter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtgaffichereal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 359)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ajout)
        Me.GroupBox2.Controls.Add(Me.quitter)
        Me.GroupBox2.Controls.Add(Me.supprimer)
        Me.GroupBox2.Controls.Add(Me.modifier)
        Me.GroupBox2.Location = New System.Drawing.Point(516, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 359)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services :"
        '
        'supprimer
        '
        Me.supprimer.Image = CType(resources.GetObject("supprimer.Image"), System.Drawing.Image)
        Me.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.supprimer.Location = New System.Drawing.Point(13, 171)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(136, 51)
        Me.supprimer.TabIndex = 9
        Me.supprimer.Text = "Supprimer"
        Me.supprimer.UseVisualStyleBackColor = True
        '
        'modifier
        '
        Me.modifier.Image = CType(resources.GetObject("modifier.Image"), System.Drawing.Image)
        Me.modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modifier.Location = New System.Drawing.Point(13, 95)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(136, 51)
        Me.modifier.TabIndex = 8
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = True
        '
        'acteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(688, 378)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "acteur"
        Me.Text = "Acteurs"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DTGACTEUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgaffichereal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTGACTEUR As System.Windows.Forms.DataGridView
    Friend WithEvents Ajout As System.Windows.Forms.Button
    Friend WithEvents dtgaffichereal As System.Windows.Forms.DataGridView
    Friend WithEvents quitter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents supprimer As System.Windows.Forms.Button
    Friend WithEvents modifier As System.Windows.Forms.Button
End Class
