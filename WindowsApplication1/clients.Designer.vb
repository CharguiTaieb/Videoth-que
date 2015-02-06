<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clients))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ajout = New System.Windows.Forms.Button()
        Me.quitter = New System.Windows.Forms.Button()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.modifier = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtgclient = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Ajout)
        Me.GroupBox2.Controls.Add(Me.quitter)
        Me.GroupBox2.Controls.Add(Me.supprimer)
        Me.GroupBox2.Controls.Add(Me.modifier)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 303)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services :"
        '
        'Ajout
        '
        Me.Ajout.Location = New System.Drawing.Point(13, 19)
        Me.Ajout.Name = "Ajout"
        Me.Ajout.Size = New System.Drawing.Size(136, 51)
        Me.Ajout.TabIndex = 11
        Me.Ajout.Text = "Ajout"
        Me.Ajout.UseVisualStyleBackColor = True
        '
        'quitter
        '
        Me.quitter.Image = CType(resources.GetObject("quitter.Image"), System.Drawing.Image)
        Me.quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quitter.Location = New System.Drawing.Point(13, 226)
        Me.quitter.Name = "quitter"
        Me.quitter.Size = New System.Drawing.Size(136, 51)
        Me.quitter.TabIndex = 10
        Me.quitter.Text = "Quitter"
        Me.quitter.UseVisualStyleBackColor = True
        '
        'supprimer
        '
        Me.supprimer.Image = CType(resources.GetObject("supprimer.Image"), System.Drawing.Image)
        Me.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.supprimer.Location = New System.Drawing.Point(13, 156)
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
        Me.modifier.Location = New System.Drawing.Point(13, 86)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(136, 51)
        Me.modifier.TabIndex = 8
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtgclient)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 303)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'dtgclient
        '
        Me.dtgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgclient.Location = New System.Drawing.Point(10, 19)
        Me.dtgclient.Name = "dtgclient"
        Me.dtgclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgclient.Size = New System.Drawing.Size(468, 275)
        Me.dtgclient.TabIndex = 9
        '
        'clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(666, 328)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "clients"
        Me.Text = "clients"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtgclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Ajout As System.Windows.Forms.Button
    Friend WithEvents quitter As System.Windows.Forms.Button
    Friend WithEvents supprimer As System.Windows.Forms.Button
    Friend WithEvents modifier As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgclient As System.Windows.Forms.DataGridView
End Class
