Partial Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim DC As New DCDataContext()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim liste = DC.Candidatures.ToList
        
        Session("ListeCandidat") = liste
        If Not IsPostBack Then
            Dim t = From l In liste _
                Where l.Code_Election = 3 _
                Select l
            Dim liste2 As New List(Of Object)
            For Each elt In t
                Dim n = elt
                Dim u = From h In DC.Votes.ToList _
                      Where h.Code_Candidat = n.Code And h.Matricule = n.Etudiant.Matricule And h.CodeElection = n.Code_Election _
                      Select h.Nombre
                liste2.Add(New With {.Code = elt.Code, .Matricule = elt.Etudiant.Matricule, .Nom = elt.Etudiant.Nom, .Code_Election = elt.Election.Type, .PhotoProfil = elt.PhotoProfil, .Extension = elt.Extension, .Sondages = u.FirstOrDefault & " " & "Voix"})

            Next

            GridView1.DataSource = liste2
            GridView1.DataBind()
        End If
    End Sub
    Function image(ByVal matricule As String, ByVal extension As String) As String
        Return "~\Tmp\" & matricule & extension
    End Function

    Private Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim vot As New Vote()
                Select e.CommandName
            Case "Voter"
                Dim elt = From t In CType(Session("ListeCandidat"), List(Of Candidature)) _
                        Where t.Code = e.CommandArgument.ToString _
                        Select t

                Dim liste = DC.Votes.ToList
                Dim h = From k In liste _
                        Where k.Code_Candidat = elt.First.Code And k.Matricule = elt.First.Matricule And k.CodeElection = elt.First.Code_Election Select k

                If h.Count = 1 Then
                    Dim d As Vote = DC.Votes.Single(Function(f) f.Code = h.FirstOrDefault.Code)

                    d.Matricule = elt.First.Matricule
                    d.Code_Candidat = elt.First.Code
                    d.CodeElection = elt.First.Code_Election
                    d.Nombre = d.Nombre + 1
                    DC.SubmitChanges()
                Else
                    vot.Matricule = elt.First.Matricule
                    vot.Code_Candidat = elt.First.Code
                    vot.CodeElection = elt.First.Code_Election
                    vot.Nombre = 1
                    DC.Votes.InsertOnSubmit(vot)
                    DC.SubmitChanges()
                End If
        End Select
    End Sub
End Class