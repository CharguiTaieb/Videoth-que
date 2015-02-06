Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.IO

'codeFilm,titre,anneeRealisation,genre,idRealis
Public Class Film
    Private _idfilm As Integer
    Private _titre As String
    Private _anneeRealisation As Date
    Private _genre As String
    Private _idRealis As Integer
    Private _nomimage As String



    Private _autorise As Boolean
    Public Event AjoutImpossible()
    Public Event suppImpossible()
    Public Property nomimage() As String


        Get
            Return _nomimage

        End Get
        Set(value As String)
            _nomimage = value

        End Set
    End Property


    Public Property idrealis() As Integer
        Get
            Return _idRealis

        End Get
        Set(ByVal value As Integer)
            _idRealis = value
        End Set
    End Property
    Public Property idfilm() As Integer
        Get
            Return _idfilm
        End Get
        Set(ByVal value As Integer)
            _idfilm = value
        End Set
    End Property
    Public Property titre() As String
        Get
            Return _titre
        End Get
        Set(ByVal value As String)
            _titre = value
        End Set
    End Property
    Public Property anneeRealisation() As Date
        Get
            Return _anneeRealisation
        End Get
        Set(ByVal value As Date)
            _anneeRealisation = value
        End Set
    End Property
    Public Property genre() As String
        Get
            Return _genre
        End Get
        Set(ByVal value As String)
            _genre = value
        End Set
    End Property

    Public Property Autorise() As Boolean
        Get
            Return _autorise
        End Get
        Set(ByVal value As Boolean)
            _autorise = value
        End Set
    End Property
    Public Function Ajoutfilm() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "FILM_tapi.ins"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_ANNEREALIS", OracleDbType.Date)).Value = _anneeRealisation
            cd.Parameters.Add(New OracleParameter("p_TITRE", OracleDbType.Varchar2)).Value = _titre
            cd.Parameters.Add(New OracleParameter("p_GENRE", OracleDbType.Varchar2)).Value = _genre
            cd.Parameters.Add(New OracleParameter("p_IDREALIS", OracleDbType.Int16)).Value = _idRealis
            cd.ExecuteNonQuery()
            addpic()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

    End Function
   
    Public Function suppfilm(ByVal n As Integer) As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "FILM_tapi.del"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_IDFILM", OracleDbType.Int16)).Value = n
            'p_ANNEREALIS ,p_TITRE ,p_GENRE ,p_IDREALIS,p_IDFILM 
            cd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
    End Function

  
    Public Function misajour() As Boolean
        Try
            Dim cd As New OracleCommand()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "FILM_tapi.upd"
            cd.CommandType = CommandType.StoredProcedure
            cd.Parameters.Add(New OracleParameter("p_ANNEREALIS", OracleDbType.Date)).Value = _anneeRealisation
            cd.Parameters.Add(New OracleParameter("p_TITRE", OracleDbType.Varchar2)).Value = _titre
            cd.Parameters.Add(New OracleParameter("p_GENRE", OracleDbType.Varchar2)).Value = _genre
            cd.Parameters.Add(New OracleParameter("p_IDREALIS", OracleDbType.Int16)).Value = _idRealis
            cd.Parameters.Add(New OracleParameter("p_IDFILM", OracleDbType.Int16)).Value = _idfilm


            'p_ANNEREALIS ,p_TITRE ,p_GENRE ,p_IDREALIS,p_IDFILM 
            cd.ExecuteNonQuery()
          
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
    End Function
    Public Function mispic() As Boolean
        Dim fls As FileStream
        fls = New FileStream(_nomimage, FileMode.Open, FileAccess.Read)
        'a byte array to read the image 
        Dim blob() As Byte = New Byte((fls.Length) - 1) {}
        fls.Read(blob, 0, System.Convert.ToInt32(fls.Length))
        fls.Close()
        Dim cd1 As New OracleCommand()
        cd1.Connection = UtilitaireBDO.cn
        cd1.CommandText = "PICFILM_tapi.upd"
        cd1.CommandType = CommandType.StoredProcedure
        cd1.Parameters.Add(New OracleParameter("p_PIC", OracleDbType.Blob)).Value = blob
        cd1.ExecuteNonQuery()
        Return True
    End Function
    Public Function addpic() As Boolean
        Try
            Dim fls As FileStream
            fls = New FileStream(_nomimage, FileMode.Open, FileAccess.Read)
            'a byte array to read the image 
            Dim blob() As Byte = New Byte((fls.Length) - 1) {}
            fls.Read(blob, 0, System.Convert.ToInt32(fls.Length))
            fls.Close()
            Dim cd1 As New OracleCommand()
            cd1.Connection = UtilitaireBDO.cn
            cd1.CommandText = "PICFILM_tapi.ins"
            cd1.CommandType = CommandType.StoredProcedure
            cd1.Parameters.Add(New OracleParameter("p_PIC", OracleDbType.Blob)).Value = blob
            cd1.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        
    End Function
End Class
