Public Class clients
    Dim c As New client
    Dim d As DataTable

    Private Sub Ajout_Click(sender As System.Object, e As System.EventArgs) Handles Ajout.Click
        Try
            'IDCLIENT CIN NOM_PRENOM DATENAISSANCE ADRESSE
            If dtgclient.SelectedRows.Count > 0 Then


                MsgBox(dtgclient.SelectedRows(0).Cells(1).Value & dtgclient.SelectedRows(0).Cells(2).Value & dtgclient.SelectedRows(0).Cells(3).Value & dtgclient.SelectedRows(0).Cells(4).Value)
                c._cin = dtgclient.SelectedRows(0).Cells(1).Value
                c._nomprenom = dtgclient.SelectedRows(0).Cells(2).Value
                c._datenaissance = dtgclient.SelectedRows(0).Cells(3).Value
                c._adr = dtgclient.SelectedRows(0).Cells(4).Value
                If c.ajoutclient() = True Then
                    MsgBox("insertion valide")
                Else
                    MsgBox("insert Echouer ")

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)



        End Try
    End Sub

    Private Sub clients_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtgclient.DataSource = c.afficheclient
        dtgclient.Refresh()
        dtgclient.Columns(0).ReadOnly = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

    End Sub

    Private Sub modifier_Click(sender As System.Object, e As System.EventArgs) Handles modifier.Click
        Try
            If dtgclient.SelectedRows.Count > 0 Then

                '    MsgBox(dtgaffichereal.SelectedRows(0).Cells(0).Value)
                c._idclient = dtgclient.SelectedRows(0).Cells(0).Value
                c._cin = dtgclient.SelectedRows(0).Cells(1).Value
                c._nomprenom = dtgclient.SelectedRows(0).Cells(2).Value
                c._datenaissance = dtgclient.SelectedRows(0).Cells(3).Value
                c._adr = dtgclient.SelectedRows(0).Cells(4).Value
                c.modifrealis()

                dtgclient.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)



        End Try
    End Sub

    Private Sub supprimer_Click(sender As System.Object, e As System.EventArgs) Handles supprimer.Click
        Try
            MsgBox(CInt(dtgclient.SelectedRows(0).Cells(0).Value))
            c._idclient = CInt(dtgclient.SelectedRows(0).Cells(0).Value)
            If c.suppclient = True Then
                MsgBox("Suppression reussie")
            Else
                MsgBox("delete failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

   
End Class