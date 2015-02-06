Imports System.Data
Imports Oracle.DataAccess.Client
Public Class Exemplaire
    Dim d As DataTable
    Dim da As New OracleDataAdapter
    Dim cd As New OracleCommand()
    Private Sub Exemplaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
    Public Sub loadexem()
        Try
            cd = New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select E.IDXEMPLAIRE,E.TYPESUPP from EXEMPLAIRE E where E.IDFILM =" & lfexem.SelectedValue.ToString
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            DTGexempl.DataSource = d
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub lfexem_Click(sender As Object, e As System.EventArgs) Handles lfexem.Click
        loadexem()
    End Sub

    Private Sub Ajout_Click(sender As System.Object, e As System.EventArgs) Handles Ajout.Click

        Dim b, n As Integer
        b = 0
        n = CInt(nbreexem.Text)
        lfexem.Enabled = False

        While b < n
            cd = New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = " INSERT  INTO EXEMPLAIRE    (IDFILM ,TYPESUPP ) VALUES(  " & lfexem.SelectedValue.ToString & ",'" & CBtypesupport.SelectedItem.ToString & " ')"
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            b += 1
        End While

        lfexem.Enabled = True


        loadexem()
        DTGexempl.Refresh()

    End Sub

    Private Sub DTGexempl_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGexempl.CellClick
        Try

            Dim c As Integer
            'MsgBox(DTGexempl.CurrentCell.ColumnIndex)
            If ((DTGexempl.Focused) And (DTGexempl.CurrentCell.ColumnIndex = 0)) Then
                cd = New OracleCommand()
                cd.Connection = UtilitaireBDO.cn
                c = DTGexempl.CurrentCell.RowIndex
                DTGexempl.Rows(c).Selected = True
                MsgBox(DTGexempl.SelectedRows(0).Cells(1).Value)
                cd.CommandText = "delete from EXEMPLAIRE E where E.IDXEMPLAIRE =" & DTGexempl.SelectedRows(0).Cells(1).Value
                cd.CommandType = CommandType.Text
                cd.ExecuteNonQuery()
                loadexem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

 
End Class