Imports Microsoft.VisualBasic
Public Class notre_declaration
    Dim con As New System.Data.SqlClient.SqlConnection("data source=(local);integrated security=true;initial catalog=Parc_Informatique")
    Dim com As System.Data.SqlClient.SqlCommand
    Public Sub Execute_Requete_Action(ByVal requete As String, ByVal t()() As Object, ByVal cas As Byte)
        Dim i As Integer
        If con.State = Data.ConnectionState.Closed Then
            con.Open()
        End If

        com = New System.Data.SqlClient.SqlCommand(requete, con)
        If (Not t Is Nothing And cas = 1) Then
            com.CommandType = Data.CommandType.Text
            Dim par() As Object = t(0)
            Dim val() As Object = t(1)
            For i = 0 To par.Length - 1
                With com.Parameters
                    .Add(New System.Data.SqlClient.SqlParameter(par(i).ToString, val(i)))
                End With
            Next
        ElseIf (Not t Is Nothing And cas = 2) Then
            com.CommandType = Data.CommandType.StoredProcedure
            Dim par() As Object = t(0)
            Dim val() As Object = t(1)
            For i = 0 To par.Length - 1
                With com.Parameters
                    .Add(New System.Data.SqlClient.SqlParameter(par(i).ToString, val(i)))
                End With
            Next
        End If
        com.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function Selection(ByVal requette As String) As Data.DataTable
        If Me.con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        com = New System.Data.SqlClient.SqlCommand(requette, con)
        Dim ad As New System.Data.SqlClient.SqlDataAdapter(com)
        Dim d As New Data.DataSet
        ad.Fill(d)
        Selection = d.Tables(0)
    End Function

End Class
