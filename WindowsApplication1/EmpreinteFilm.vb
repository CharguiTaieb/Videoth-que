Imports System.Data
Imports Oracle.DataAccess.Client
Imports System.Text
Imports System.Windows.Forms

Public Class EmpreinteFilm
    Dim d As DataTable
    Public dtp As DateTimePicker
    Dim da As New OracleDataAdapter
    Dim cd As New OracleCommand()
    Dim em As New Empreinte




    Public Sub load_reload()
        cd = New OracleCommand()
        cd.Connection = UtilitaireBDO.cn
        cd.CommandText = "select EM.IDPREINTE ,C.CIN ,C.NOM_PRENOM ,EM.IDXEMPLAIRE ,EM.DATEEMPREINTE ,EM.DATERETOUR  from	 CLIENT C,EMPREINTE EM where   EM.IDCLIENT=C.IDCLIENT"
        cd.CommandType = CommandType.Text
        cd.ExecuteNonQuery()

        da = New OracleDataAdapter(cd)
        d = New DataTable
        da.Fill(d)
        DTGempreinte.DataSource = d
    End Sub


    Private Sub EmpreinteFilm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        load_reload()
    End Sub

    Private Sub CBfilm_Click(sender As Object, e As System.EventArgs) Handles CBfilm.Click
        Try
            cd = New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select E.IDXEMPLAIRE,E.TYPESUPP from EXEMPLAIRE E where E.IDXEMPLAIRE NOT IN (SELECT EM.IDXEMPLAIRE FROM EMPREINTE EM)  and E.IDFILM =" & CBfilm.SelectedValue.ToString

            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            CBexemplaire.DataSource = d
            CBexemplaire.DisplayMember = "TYPESUPP"
            CBexemplaire.ValueMember = "IDXEMPLAIRE"

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

  


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            cd = New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select	 IDCLIENT,	CIN,NOM_PRENOM from client where cin =" & TextBox1.Text
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            If d.Rows.Count Then
                TextBox2.Text = d.Rows(0).Item(2).ToString
                Label6.Text = d.Rows(0).Item(0).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Ajouter_Click(sender As System.Object, e As System.EventArgs) Handles Ajouter.Click
        Try
            em._IDclient = Label6.Text
            em._datelocation = dateprinte.Text
            em._dateretour = dateretour.Text
            em._numexemplaire = CBexemplaire.SelectedValue
            If em.Ajoutlocation = True Then
                MsgBox("empreinte ajouter")



                load_reload()
                DTGempreinte.Refresh()

            Else
                MsgBox("empreinte non ajouter")

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

    End Sub













    Private Sub DTGempreinte_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGempreinte.CellClick
        Try
            Dim answer As Integer
            Dim c As Integer
            'MsgBox(DTGempreinte.CurrentCell.ColumnIndex)
            If ((DTGempreinte.Focused) And (DTGempreinte.CurrentCell.ColumnIndex = 0)) Then
                cd = New OracleCommand()
                cd.Connection = UtilitaireBDO.cn
                c = DTGempreinte.CurrentCell.RowIndex
                DTGempreinte.Rows(c).Selected = True
                answer = MsgBox("voulez vous vraimet le supprimer " & DTGempreinte.SelectedRows(0).Cells(1).Value, MsgBoxStyle.YesNoCancel, "Confirmation")

                If answer = 6 Then
                    cd.CommandText = "delete from EMPREINTE E where E.IDPREINTE =" & DTGempreinte.SelectedRows(0).Cells(2).Value
                    cd.CommandType = CommandType.Text
                    cd.ExecuteNonQuery()
                    load_reload()
                    DTGempreinte.Refresh()
                End If
            End If






            If ((DTGempreinte.Focused) And (DTGempreinte.CurrentCell.ColumnIndex = 1)) Then

                'MsgBox("that's update touch")
                ' CBexemplaire.SelectedItem = DTGempreinte.SelectedRows(0).Cells(5).Value
                dateprinte.Text = DTGempreinte.SelectedRows(0).Cells(6).Value
                dateretour.Text = DTGempreinte.SelectedRows(0).Cells(7).Value
                ' select	 IDXEMPLAIRE, TYPESUPP,	 F.IDFILM ,F.TITRE  from	 EXEMPLAIRE,	 FILM F where   EXEMPLAIRE.IDFILM=F.IDFILM 
                cd.CommandText = "select E.IDXEMPLAIRE,E.TYPESUPP ,e.idfilm from EXEMPLAIRE E where e.idfilm  IN (SELECT e.idfilm  FROM EXEMPLAIRE E where E.IDXEMPLAIRE=" & DTGempreinte.SelectedRows(0).Cells(5).Value & ") "
                cd.CommandType = CommandType.Text
                cd.ExecuteNonQuery()
                da = New OracleDataAdapter(cd)
                d = New DataTable
                da.Fill(d)
                CBexemplaire.DataSource = d
                CBexemplaire.DisplayMember = "TYPESUPP"
                CBexemplaire.ValueMember = "IDXEMPLAIRE"
                CBfilm.SelectedValue = CInt(d.Rows(0).Item(2).ToString())
                cd.CommandText = "select CIN, NOM_PRENOM, IDCLIENT  from CLIENT where CIN =" & DTGempreinte.SelectedRows(0).Cells(3).Value
                cd.CommandType = CommandType.Text
                cd.ExecuteNonQuery()
                da = New OracleDataAdapter(cd)
                d = New DataTable
                da.Fill(d)
                If d.Rows.Count > 0 Then
                    ' MsgBox(d.Rows(0).Item(0).ToString & d.Rows(0).Item(1).ToString & d.Rows(0).Item(2).ToString)
                    TextBox1.Text = d.Rows(0).Item(0).ToString
                    TextBox2.Text = d.Rows(0).Item(1).ToString
                    Label6.Text = d.Rows(0).Item(2).ToString

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Modifier_Click(sender As System.Object, e As System.EventArgs) Handles Modifier.Click
        Try
            em._IDclient = Label6.Text
            em._datelocation = dateprinte.Text
            em._dateretour = dateretour.Text
            em._numexemplaire = CBexemplaire.SelectedValue
            em.IDemprreinte = DTGempreinte.SelectedRows(0).Cells(2).Value
            If em.modifempreinte = True Then
                MsgBox("Empreinte modifier  ")
                load_reload()
                DTGempreinte.Refresh()

            Else
                MsgBox("Empreinte non modifier ")

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub
End Class