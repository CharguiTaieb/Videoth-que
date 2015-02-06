Imports System.Data
Imports Oracle.DataAccess.Client
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Public Class AjoutFilm
    Dim f As New Film
    Dim real As New realisateur
    Dim d As DataTable
    Dim OpenFileDialog As New OpenFileDialog
        
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim khra As String
        Try
            If nomfilm.Text.ToString = "" Then
                MessageBox.Show("veuillez saisir le nom du film")
            ElseIf CBrealisa.Text.ToString = "" Then
                MessageBox.Show("veuillez choisir le realisateur")
            ElseIf Daterealisation.Text.ToString = "" Then
                MsgBox("veuillez choisir le date SVP", MsgBoxStyle.Exclamation)
            ElseIf genre.Text.ToString = "" Then
                MsgBox("veuillez saisir le genre du film", MsgBoxStyle.Exclamation)
            Else
                khra = nomfilm.Text & CBrealisa.SelectedValue.ToString() & Daterealisation.Text & genre.Text.ToString
                MsgBox(khra)
                f.titre = nomfilm.Text
                f.idrealis = CInt(CBrealisa.SelectedValue.ToString())
                f.anneeRealisation = Daterealisation.Text
                f.genre = genre.Text.ToString
                f.nomimage = Label1.Text
                If f.Ajoutfilm() = True Then
                    MsgBox("Ajout avec Succès")
                    GBacteur.Enabled = True
                    Me.ControlBox = False
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = False
                    Button1.Enabled = False
                    MsgBox("veillez ajouter les acteurs de ce fimls", MsgBoxStyle.Exclamation)

                Else
                    MsgBox("ajout non effectuer")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub


    Private Sub AjoutFilm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            CBrealisa.DataSource = real.affichereaslisateur()
            CBrealisa.DisplayMember = "nom_prenom"
            CBrealisa.ValueMember = "IDREALIS"
            Dim n As Integer
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select	  NOM_PRENOM, NUMACTEUR from	 ACTEUR"
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            Dim da As New OracleDataAdapter
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            Me.CheckedListBox1.DataSource = d
           
            Me.CheckedListBox1.DisplayMember = "NOM_PRENOM"
            Me.CheckedListBox1.ValueMember = "NUMACTEUR"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
        

    End Sub

    Private Sub quitter_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        videotheque.CBliste.Refresh()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles parcourir.LinkClicked
        Try
            With OpenFileDialog
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2
                If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                    Label1.Text = OpenFileDialog.FileName
                    Dim bm As New Bitmap(Label1.Text)
                    PictureBox1.Image = bm
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try


    End Sub

 
  
    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Try


        Dim cd As New OracleCommand()
        cd.Connection = UtilitaireBDO.cn
        cd.CommandText = "select IDFILM from film where titre= '" & nomfilm.Text & "'"
        cd.CommandType = CommandType.Text
        cd.ExecuteNonQuery()
        Dim da As New OracleDataAdapter
        da = New OracleDataAdapter(cd)
        d = New DataTable
        da.Fill(d)
        Dim n As Integer
        n = CInt(d.Rows(0).Item(0).ToString)
        MsgBox(n)

        If CInt(Me.CheckedListBox1.CheckedItems.Count.ToString) = 0 Then
            MsgBox("veuillez selectionnez les acteurs des films")
        Else
            Dim b As Integer
            Dim c As Integer
            c = 0
            b = CInt(Me.CheckedListBox1.CheckedItems.Count.ToString)
           
            Do While c < b
                cd.CommandText = "ACTER_tapi.ins"
                cd.CommandType = CommandType.StoredProcedure
                MsgBox("numfilm " & n & ", num acteur " & CInt(CheckedListBox1.CheckedIndices.Item(c).ToString) + 1)
                cd.Parameters.Add(New OracleParameter("p_IDFILM", OracleDbType.Int32)).Value = n
                cd.Parameters.Add(New OracleParameter("p_NUMACTEUR", OracleDbType.Int32)).Value = (CInt(CheckedListBox1.CheckedIndices.Item(c).ToString) + 1)
                cd.ExecuteNonQuery()
                cd.Parameters.Clear()
                c = c + 1
            Loop
            MsgBox("acteurs ajouter")
            Me.ControlBox = True
        End If

    End Sub
End Class