Imports System.Data
Imports Oracle.DataAccess.Client
Imports System.IO

Public Class detailsfilm
    Public n As Integer
    Private Sub detailsfilm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Dim d As DataTable
            Dim cd As New OracleCommand()
            Dim bytearrayin As Byte()
            cd.Connection = UtilitaireBDO.cn
            cd.CommandText = "select TITRE,GENRE,ANNEREALIS,IDREALIS from   FILM where  IDFILM=" & n
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            Dim da As New OracleDataAdapter
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            nomfilm.Text = d.Rows(0).Item(0)
            genre.Text = d.Rows(0).Item(1)
            annecrea.Text = d.Rows(0).Item(2)


            cd.CommandText = "select NOM_PRENOM from REALISATEUR where IDREALIS=" & d.Rows(0).Item(3)
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            realisat.Text = d.Rows(0).Item(0)


            cd.CommandText = "select pic from PICFILM where IDFILM=" & n
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)

            If d.Rows.Count = 0 Then
                MsgBox("il n'y a pas d'image à affiché", MsgBoxStyle.Information)
            Else
                bytearrayin = d.Rows(0).Item(0)
                Dim ms As New MemoryStream(bytearrayin)
                filmPicture.Image = Image.FromStream(ms)

            End If
            cd.CommandText = "select distinct (AC.NOM_PRENOM) as NOM_PRENOM from FILM F,ACTER A,ACTEUR AC  where   A.IDFILM=F.IDFILM and AC.NUMACTEUR=A.NUMACTEUR  and  F.IDFILM =" & n
            cd.CommandType = CommandType.Text
            cd.ExecuteNonQuery()
            da = New OracleDataAdapter(cd)
            d = New DataTable
            da.Fill(d)
            acteur.DataSource = d
            acteur.DisplayMember = "NOM_PRENOM"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub rech_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles rech.LinkClicked
        If IsConnectionAvailable() = True Then
            Dim webAddress As String = "https://www.google.com/search?q=" & nomfilm.Text & " " & realisat.Text
            Process.Start(webAddress)
        Else
            MessageBox.Show("You etes deconnectés de l'internet!")
        End If
        
    End Sub







    Public Function IsConnectionAvailable() As Boolean
        ' Returns True if connection is available
        ' Replace www.yoursite.com with a site that
        ' is guaranteed to be online - perhaps your
        ' corporate site, or microsoft.com
        Dim objUrl As New System.Uri("https://www.google.com/")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            objResp.Close()
            objWebReq = Nothing
            Return False
        End Try

        's how you might use this function in your application:

    End Function

End Class