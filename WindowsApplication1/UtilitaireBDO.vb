Imports System.Data
Imports Oracle.DataAccess.Client
Public Class UtilitaireBDO
    Public Shared cn As OracleConnection
    Public Shared Sub connecter(ByVal n As String)
        On Error GoTo E
        cn = New OracleConnection()
        cn.ConnectionString = n
        cn.Open()
E:
        If Err.Number <> 0 Then
            MsgBox("Erreur de connexion  " & Err.Description, MsgBoxStyle.Critical, "Ouverture de la connexion")
        Else
            MsgBox("Connexion reussie", MsgBoxStyle.Information, "Ouverture de la connexion")
        End If
    End Sub
End Class


