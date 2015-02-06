Imports System.Data
Imports Oracle.DataAccess.Client
Public Class acteur
    Dim ACT As New ACTEURS
    Dim d As DataTable
    Private Sub quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitter.Click
        Me.Close()
    End Sub

    Private Sub afficherealisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            ACT.afficheacteur(d)
            DTGACTEUR.DataSource = d
            DTGACTEUR.Refresh()
            DTGACTEUR.Columns(0).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

    End Sub

    Private Sub modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier.Click

        Try
            If DTGACTEUR.SelectedCells.Count > 0 Then
                MsgBox(DTGACTEUR.SelectedRows(0).Cells(0).Value)
                ACT.numacteur = CInt(DTGACTEUR.SelectedRows(0).Cells(0).Value)
                ACT.NOM_PRENOM = DTGACTEUR.SelectedRows(0).Cells(1).Value
                ACT.pays = DTGACTEUR.SelectedRows(0).Cells(2).Value
                ACT.DATENAISSANCE = DTGACTEUR.SelectedRows(0).Cells(3).Value

                If ACT.modifacteur() = True Then
                    MsgBox("modification Faite", MsgBoxStyle.Information)
                Else
                    MsgBox("modification Echouer", MsgBoxStyle.Information)
                End If
                DTGACTEUR.Refresh()

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        Dim n As Integer
        If DTGACTEUR.SelectedRows.Count > 0 Then
            n = DTGACTEUR.SelectedRows(0).Cells(0).Value

            If ACT.suppacteur(n) = True Then
                MsgBox("Suppression reussite", MsgBoxStyle.Information)
            Else
                MsgBox("Suppression echouer", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub Ajout_Click(sender As System.Object, e As System.EventArgs) Handles Ajout.Click
        Try

            If DTGACTEUR.SelectedRows.Count > 0 Then
                ACT.NOM_PRENOM = DTGACTEUR.SelectedRows(0).Cells(1).Value
                ACT.pays = DTGACTEUR.SelectedRows(0).Cells(2).Value
                ACT.DATENAISSANCE = DTGACTEUR.SelectedRows(0).Cells(3).Value
                If ACT.ajoutActeur() = True Then
                    MsgBox("ajout avec success")
                Else
                    MsgBox("ajout échouer ")
                End If
                DTGACTEUR.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class