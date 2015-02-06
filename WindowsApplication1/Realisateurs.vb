Imports System.Data
Imports Oracle.DataAccess.Client

Public Class Realisateurs
    Dim real As New realisateur
    Dim d As DataTable



    Private Sub quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitter.Click
        Me.Close()
    End Sub

    Private Sub afficherealisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Dtgreal.DataSource = real.affichereaslisateur()
        Dtgreal.Refresh()
    End Sub

    Private Sub modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier.Click
        Try
            If Dtgreal.SelectedCells.Count > 0 Then
                MsgBox(Dtgreal.SelectedRows(0).Cells(0).Value)
                real.numreali = CInt(Dtgreal.SelectedRows(0).Cells(0).Value)
                real.nom_prenom = Dtgreal.SelectedRows(0).Cells(1).Value
                real.pays = Dtgreal.SelectedRows(0).Cells(2).Value
                real.dateNaissance = Dtgreal.SelectedRows(0).Cells(3).Value
                real.modifrealis()
                Dtgreal.Refresh()
            End If

        Catch ex As Exception
            MsgBox("te7cha" & ex.Message.ToString)
        End Try


    End Sub

    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        Dim n As Integer
        If Dtgreal.SelectedRows.Count > 0 Then
            MsgBox("ffffffffff")
            n = Dtgreal.SelectedRows(0).Cells(0).Value
            real.supprealis(n)
        End If

    End Sub

    Private Sub Ajout_Click(sender As System.Object, e As System.EventArgs) Handles Ajout.Click


        Try

            If Dtgreal.SelectedRows.Count > 0 Then
                real.nom_prenom = Dtgreal.SelectedRows(0).Cells(1).Value
                real.pays = Dtgreal.SelectedRows(0).Cells(2).Value
                real.dateNaissance = Dtgreal.SelectedRows(0).Cells(3).Value
                real.ajoutrealisateur()
                Dtgreal.Refresh()
            End If
        Catch ex As Exception
            MsgBox("te7cha" & ex.Message.ToString)
        End Try
    End Sub


End Class