Partial Class Poste
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Request.Params("log") Is Nothing Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select poste.nom_p as [Nom de Poste],n_segement+'.'+ad as [Adresse IP],type_p as [Type de Poste],n_salle as [N° salle],substring(convert(varchar,date_ins),0,14)as [Date Instalation] from poste inner join installer on poste.n_poste=installer.n_poste and n_log=" & Request.Params("log"))
            If t.Rows.Count = 0 Then
                Me.Label1.Text = "!!!!Aucun  Poste  Installe ce Logiciel " & Request.Params("log") & "!!!!"
            Else
                Me.GridView1.DataSource = t
                Me.GridView1.DataBind()
                Me.Label1.Text = "Les Poste Qui Installe Le Logiciel " & Request.Params("log")
            End If
        End If
    End Sub
End Class
