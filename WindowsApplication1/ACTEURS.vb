Imports System.Data
Imports Oracle.DataAccess.Client
Public Class ACTEURS
    Public numacteur As Integer
    Public NOM_PRENOM As String
    Public pays As String
    Public DATENAISSANCE As Date
    Public Function ajoutActeur() As Boolean


        MsgBox(CDate(DATENAISSANCE) & pays & NOM_PRENOM)

        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "ACTEUR_tapi.ins"
            cd.CommandType = CommandType.StoredProcedure


            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = DATENAISSANCE
            cd.Parameters.Add(New OracleParameter("p_PAYS", OracleDbType.Varchar2)).Value = pays
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = NOM_PRENOM
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try


    End Function
    Public Function modifacteur() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "ACTEUR_tapi.upd"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = DATENAISSANCE
            cd.Parameters.Add(New OracleParameter("p_PAYS", OracleDbType.Varchar2)).Value = pays
            cd.Parameters.Add(New OracleParameter("p_NUMACTEUR", OracleDbType.Int16)).Value = numacteur
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = NOM_PRENOM

            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
    '
    Public Function afficheacteur(ByRef d As DataTable) As DataTable
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "V_ACTEUR"
            cd.CommandType = CommandType.TableDirect
            Dim da As New OracleDataAdapter

            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)

            Return d


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Function

    Public Function suppacteur(ByVal n As Integer) As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "ACTEUR_tapi.del"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_NUMACTEUR", OracleDbType.Int16)).Value = n
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
End Class
