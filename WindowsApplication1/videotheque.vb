Imports System.Data
Imports Oracle.DataAccess.Client


Public Class videotheque
    Public Event affichagelisteimpossible()


    Dim numcher As Integer
    Dim d As DataTable
    Dim real As New realisateur
    Dim f As New Film

    Private Sub REALISATEURToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles REALISATEURToolStripMenuItem.Click

        Realisateurs.Show()
    End Sub

    Private Sub NouvelleLocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub videotheque_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        load()
    End Sub
    Public Sub load()
        Try
            UtilitaireBDO.connecter("Data Source=OraclePlt;User Id=dooms;Password=14021989;")
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "V_FILM"
            cd.CommandType = CommandType.TableDirect
            Dim da As New OracleDataAdapter
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            listefilm.DataSource = d
            listefilm.DisplayMember = "titre"
            listefilm.ValueMember = "idfilm"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub AjoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AjoutToolStripMenuItem.Click
        AjoutFilm.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        numcher = CBliste.SelectedIndex
        Dim rech As String
        Dim tab As String


        If numcher = -1 Then
            MsgBox("vous devez selectionner un theme de recherche")
        ElseIf numcher = 0 Then

            rech = rechhh.Text
            tab = CBliste.SelectedItem

        ElseIf numcher = 1 Then
            rech = rechhh.Text
            tab = CBliste.SelectedItem
        ElseIf numcher = 2 Then
            rech = rechhh.Text
            tab = CBliste.SelectedItem
        ElseIf numcher = 3 Then
            rech = rechhh.Text
            tab = CBliste.SelectedItem
        End If

        If numcher = -1 Then
            MsgBox("vous devez selectionner un theme de recherche")
        Else
            Try
                Dim ggg As String
                Dim cd As New OracleCommand()
                cd.Connection = UtilitaireBDO.cn
                cd.CommandText = "PK_SEARCH.open_join_cursor1"
                cd.CommandType = CommandType.StoredProcedure
                tab = UCase(tab)
                rech = UCase(rech)
                cd.Parameters.Add(New OracleParameter("tab", OracleDbType.Varchar2)).Value = tab
                cd.Parameters.Add(New OracleParameter("rech", OracleDbType.Varchar2)).Value = rech
                cd.Parameters.Add(New OracleParameter("io_cursor", OracleDbType.RefCursor)).Direction = ParameterDirection.InputOutput
                Dim da As New OracleDataAdapter
                da = New OracleDataAdapter(cd)
                d = New DataTable
                da.Fill(d)
                DGV1.DataSource = d
                DGV1.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub ActeurToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActeurToolStripMenuItem.Click
        acteur.Show()
    End Sub



    Private Sub bsupp_Click(sender As System.Object, e As System.EventArgs) Handles bsupp.Click
        Try
            MsgBox(CInt(listefilm.SelectedValue.ToString))


            If f.suppfilm(CInt(listefilm.SelectedValue.ToString)) = True Then
                MsgBox("Suppression reussie")
            Else
                MsgBox("delete failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

    Private Sub bmodif_Click(sender As System.Object, e As System.EventArgs) Handles bmodif.Click
        '  Try
        d = listefilm.DataSource
        '    MsgBox(listefilm.SelectedValue & ":::::" & d.Rows(listefilm.SelectedIndex).Item(0) & "::::::" & d.Rows(listefilm.SelectedIndex).Item(3))

        ModiFilm.numfilm.Text = d.Rows(listefilm.SelectedIndex).Item(0)
        ModiFilm.nomfilm.Text = d.Rows(listefilm.SelectedIndex).Item(1)
        ModiFilm.Daterealisation.Text = d.Rows(listefilm.SelectedIndex).Item(2)
        ModiFilm.genre.Text = d.Rows(listefilm.SelectedIndex).Item(4)
        ModiFilm.CBrealis.DataSource = real.affichereaslisateur()
        ModiFilm.CBrealis.DisplayMember = "nom_prenom"
        ModiFilm.CBrealis.ValueMember = "IDREALIS"
        ' MsgBox(d.Rows(listefilm.SelectedIndex).Item(3))
        ModiFilm.CBrealis.SelectedValue = CInt(d.Rows(listefilm.SelectedIndex).Item(3))

        ModiFilm.Show()



        Dim cd As New OracleCommand()
        cd.Connection = UtilitaireBDO.cn
        cd.CommandText = "select  NOM_PRENOM, NUMACTEUR from	 ACTEUR"
        cd.CommandType = CommandType.Text
        cd.ExecuteNonQuery()
        Dim da As New OracleDataAdapter
        da = New OracleDataAdapter(cd)
        d = New DataTable
        da.Fill(d)
        ModiFilm.CheckedListBox1.DataSource = d
        ModiFilm.CheckedListBox1.DisplayMember = "NOM_PRENOM"
        ModiFilm.CheckedListBox1.ValueMember = "NUMACTEUR"



        cd.CommandText = "select ACTER.NUMACTEUR  from  FILM FILM,  ACTER ACTER where FILM.IDFILM= ACTER.IDFILM and FILM.IDFILM=" & ModiFilm.numfilm.Text
        cd.CommandType = CommandType.Text
        cd.ExecuteNonQuery()
        da = New OracleDataAdapter(cd)
        d = New DataTable
        da.Fill(d)
        If d.Rows.Count > 0 Then
            Dim n, b As Integer
            n = d.Rows.Count
            b = 0
            Do While b < n

                ModiFilm.CheckedListBox1.SetItemChecked(CInt(d.Rows(b).Item(0)) - 1, True)


                b = b + 1
            Loop

        End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString)
        'End Try


    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientToolStripMenuItem.Click
        clients.Show()
    End Sub

    Private Sub bdetails_Click(sender As System.Object, e As System.EventArgs) Handles bdetails.Click
        detailsfilm.n = listefilm.SelectedValue
        detailsfilm.Show()
    End Sub
    Private Sub listefilm_Click(sender As Object, e As System.EventArgs) Handles listefilm.Click
        '  MsgBox(listefilm.SelectedValue.ToString)
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select count(E.IDXEMPLAIRE) as IDXEMPLAIRE from	 EXEMPLAIRE E where 	 E.IDFILM =" & listefilm.SelectedValue.ToString
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            Dim da As New OracleDataAdapter
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            If d.Rows.Count > 0 Then
                nbrexemplaire.Text = d.Rows(0).Item(0).ToString

            End If

            cd.CommandText = "select distinct (E.TYPESUPP) from EXEMPLAIRE E where E.IDFILM =" & listefilm.SelectedValue.ToString
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            typexemplaire.DataSource = d
            typexemplaire.DisplayMember = "TYPESUPP"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try

    End Sub




    Private Sub LOCATIONToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOCATIONToolStripMenuItem.Click
        EmpreinteFilm.Show()
        EmpreinteFilm.CBfilm.DataSource = listefilm.DataSource
        EmpreinteFilm.CBfilm.DisplayMember = "titre"
        EmpreinteFilm.CBfilm.ValueMember = "idfilm"
    End Sub

    Private Sub ExemplaireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExemplaireToolStripMenuItem.Click
        Exemplaire.Show()
        Exemplaire.lfexem.DataSource = listefilm.DataSource
        Exemplaire.lfexem.DisplayMember = "titre"
        Exemplaire.lfexem.ValueMember = "idfilm"
    End Sub
End Class
