<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exemplaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exemplaire))
        Me.lfexem = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTGexempl = New System.Windows.Forms.DataGridView()
        Me.Suppression = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nbreexem = New System.Windows.Forms.TextBox()
        Me.CBtypesupport = New System.Windows.Forms.ComboBox()
        Me.Ajout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGexempl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lfexem
        '
        Me.lfexem.FormattingEnabled = True
        Me.lfexem.Location = New System.Drawing.Point(13, 15)
        Me.lfexem.Name = "lfexem"
        Me.lfexem.Size = New System.Drawing.Size(225, 277)
        Me.lfexem.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTGexempl)
        Me.GroupBox1.Location = New System.Drawing.Point(257, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 212)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les Exemplaires :"
        '
        'DTGexempl
        '
        Me.DTGexempl.AllowUserToAddRows = False
        Me.DTGexempl.AllowUserToDeleteRows = False
        Me.DTGexempl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGexempl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Suppression})
        Me.DTGexempl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTGexempl.Location = New System.Drawing.Point(3, 16)
        Me.DTGexempl.Name = "DTGexempl"
        Me.DTGexempl.ReadOnly = True
        Me.DTGexempl.Size = New System.Drawing.Size(428, 193)
        Me.DTGexempl.TabIndex = 0
        '
        'Suppression
        '
        Me.Suppression.HeaderText = "Suppression"
        Me.Suppression.Name = "Suppression"
        Me.Suppression.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nbreexem)
        Me.GroupBox2.Controls.Add(Me.CBtypesupport)
        Me.GroupBox2.Controls.Add(Me.Ajout)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 55)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "A ajouté :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Type :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre :"
        '
        'nbreexem
        '
        Me.nbreexem.Location = New System.Drawing.Point(75, 22)
        Me.nbreexem.Name = "nbreexem"
        Me.nbreexem.Size = New System.Drawing.Size(43, 20)
        Me.nbreexem.TabIndex = 9
        '
        'CBtypesupport
        '
        Me.CBtypesupport.FormattingEnabled = True
        Me.CBtypesupport.Items.AddRange(New Object() {"CD", "DVD", "DVD 2couche", "BLU-RAY", "VCD", "CASETTE"})
        Me.CBtypesupport.Location = New System.Drawing.Point(187, 18)
        Me.CBtypesupport.Name = "CBtypesupport"
        Me.CBtypesupport.Size = New System.Drawing.Size(121, 21)
        Me.CBtypesupport.TabIndex = 8
        '
        'Ajout
        '
        Me.Ajout.Location = New System.Drawing.Point(314, 18)
        Me.Ajout.Name = "Ajout"
        Me.Ajout.Size = New System.Drawing.Size(99, 23)
        Me.Ajout.TabIndex = 7
        Me.Ajout.Text = "AjoutExemplaire"
        Me.Ajout.UseVisualStyleBackColor = True
        '
        'Exemplaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(696, 307)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lfexem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Exemplaire"
        Me.Text = "Exemplaire"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DTGexempl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lfexem As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTGexempl As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nbreexem As System.Windows.Forms.TextBox
    Friend WithEvents CBtypesupport As System.Windows.Forms.ComboBox
    Friend WithEvents Ajout As System.Windows.Forms.Button
    Friend WithEvents Suppression As System.Windows.Forms.DataGridViewButtonColumn
End Class
