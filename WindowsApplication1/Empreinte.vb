Imports System.Data
Imports Oracle.DataAccess.Client

Public Class Empreinte

    Public IDemprreinte As Integer
    Public _IDclient As Integer
    Public _numexemplaire As Integer
    Public _datelocation As Date
    Public _dateretour As Date


    Public Function Ajoutlocation() As Boolean
        Try

            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "EMPREINTE_tapi.ins"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATEEMPREINTE", OracleDbType.Date)).Value = _datelocation
            cd.Parameters.Add(New OracleParameter("p_IDXEMPLAIR", OracleDbType.Int32)).Value = _numexemplaire
            cd.Parameters.Add(New OracleParameter("p_DATERETOUR", OracleDbType.Date)).Value = _dateretour
            cd.Parameters.Add(New OracleParameter("p_IDCLIENT", OracleDbType.Varchar2)).Value = _IDclient
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
    End Function


    Public Function modifempreinte() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "EMPREINTE_tapi.upd"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATEEMPREINTE", OracleDbType.Date)).Value = _datelocation
            cd.Parameters.Add(New OracleParameter("p_IDXEMPLAIR", OracleDbType.Int32)).Value = _numexemplaire
            cd.Parameters.Add(New OracleParameter("  p_IDPREINTE", OracleDbType.Int32)).Value = IDemprreinte
            cd.Parameters.Add(New OracleParameter("p_DATERETOUR", OracleDbType.Date)).Value = _dateretour
            cd.Parameters.Add(New OracleParameter("p_IDCLIENT", OracleDbType.Varchar2)).Value = _IDclient
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try





    End Function

End Class
