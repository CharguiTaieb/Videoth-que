Imports System.Data
Imports Oracle.DataAccess.Client
Imports System.IO

Public Class ModiFilm
    Dim f As New Film
    Dim d As DataTable
    Dim bytearrayin As Byte()
    Dim ms As MemoryStream
    Private Sub modif_Click(sender As System.Object, e As System.EventArgs) Handles modif.Click
        Try
            MsgBox(numfilm.Text & CInt(CBrealis.SelectedValue.ToString()) & genre.SelectedItem & Daterealisation.Text & nomfilm.Text)
            f.idfilm = numfilm.Text
            f.idrealis = CInt(CBrealis.SelectedValue.ToString())
            f.genre = genre.SelectedItem
            f.anneeRealisation = Daterealisation.Text
            f.titre = nomfilm.Text
            If f.misajour() = True Then
                MsgBox("Succès de mis à jour")
                If PictureBox1.Image Is Nothing Then
                    MsgBox("u must choose ur pic")
                Else
                    f.mispic()

                End If





            Else
                MsgBox("update failed")
            End If













            videotheque.load()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub quitter_Click(sender As System.Object, e As System.EventArgs) Handles quitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog
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

    Private Sub ModifFilm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Dim cd As New OracleCommand()
            Dim da As New OracleDataAdapter
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select IDPIC, pic from PICFILM where IDFILM=" & CInt(numfilm.Text)
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            If d.Rows.Count = 0 Then
                MsgBox("il n'y a pas d'image à affiché", MsgBoxStyle.Information)
            Else
                bytearrayin = d.Rows(0).Item(1)
                ms = New MemoryStream(bytearrayin)
                PictureBox1.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Reset_Click(sender As System.Object, e As System.EventArgs) Handles Reset.Click
        PictureBox1.Image = Image.FromStream(ms)
    End Sub
End Class