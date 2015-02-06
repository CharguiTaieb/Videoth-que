Imports System.Data
Imports Oracle.DataAccess.Client

Public Class realisateur

    Dim _numrealis As Integer
    Dim d As DataTable
    Dim _nom_prenom As String
    Dim _pays As String
    Dim _dateNaissance As Date
    Public Event ajoutimpossible()
    Public Event suppimpossible()
    Public Event modifimposible()
    Public Property numreali() As Integer
        Get
            Return _numrealis
        End Get
        Set(ByVal value As Integer)
            _numrealis = value
        End Set
    End Property
    Public Property nom_prenom() As String
        Get
            Return _nom_prenom
        End Get
        Set(ByVal value As String)
            _nom_prenom = value
        End Set
    End Property
    Public Property pays() As String
        Get
            Return _pays
        End Get
        Set(ByVal value As String)
            _pays = value
        End Set
    End Property
    Public Property dateNaissance() As Date
        Get
            Return _dateNaissance
        End Get
        Set(ByVal value As Date)
            _dateNaissance = value
        End Set
    End Property
    Public Function affichereaslisateur() As DataTable
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "V_REALISATEUR"
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

    Public Function ajoutrealisateur() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "REALISATEUR_tapi.ins"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = _dateNaissance
            cd.Parameters.Add(New OracleParameter("p_PAYS", OracleDbType.Varchar2)).Value = _pays
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = _nom_prenom
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
            cd.CommandText = "REALISATEUR_tapi.upd"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_DATENAISSANCE", OracleDbType.Date)).Value = _dateNaissance
            cd.Parameters.Add(New OracleParameter("p_PAYS", OracleDbType.Varchar2)).Value = _pays
            cd.Parameters.Add(New OracleParameter("p_NOM_PRENOM", OracleDbType.Varchar2)).Value = _nom_prenom
            cd.Parameters.Add(New OracleParameter("p_IDREALIS", OracleDbType.Int16)).Value = _numrealis
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
    Public Function supprealis(ByVal n As Integer) As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "REALISATEUR_tapi.del"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_IDREALIS", OracleDbType.Int16)).Value = n
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
End Class
