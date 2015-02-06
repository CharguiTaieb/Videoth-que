Imports System.Data
Imports Oracle.DataAccess.Client
Public Class client
    Public _idclient As Integer
    Public _cin As Integer
    Public _nomprenom As String
    Public _datenaissance As Date
    Public _adr As String

    Dim d As DataTable



    'IDCLIENT CIN NOM_PRENOM DATENAISSANCE ADRESSE


    Public Function ajoutclient() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "CLIENT_tapi.ins"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = _datenaissance
            cd.Parameters.Add(New OracleParameter("p_ADRESSE", OracleDbType.Varchar2)).Value = _adr
            cd.Parameters.Add(New OracleParameter("p_CIN", OracleDbType.Int64)).Value = _cin
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = _nomprenom
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
    End Function
    Public Function modifrealis() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "CLIENT_tapi.upd"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = _datenaissance
            cd.Parameters.Add(New OracleParameter("p_ADRESSE", OracleDbType.Varchar2)).Value = _adr
            cd.Parameters.Add(New OracleParameter("p_CIN", OracleDbType.Int16)).Value = _cin
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = _nomprenom
            cd.Parameters.Add(New OracleParameter("p_IDCLIENT ", OracleDbType.Int16)).Value = _idclient

            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
    Public Function suppclient() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "CLIENT_tapi.del"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_IDCLIENT", OracleDbType.Int16)).Value = _idclient
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function Cclient() As Integer
        Try
            Dim cd As New OracleCommand()
            Dim n As Integer
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "CLIENT_tapi.del"
            cd.CommandType = CommandType.TableDirect
            cd.Parameters.Add(New OracleParameter("p_IDCLIENT", OracleDbType.Int16)).Value = _idclient
            cd.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function afficheclient() As DataTable
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "V_CLIENT"
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
End Class
