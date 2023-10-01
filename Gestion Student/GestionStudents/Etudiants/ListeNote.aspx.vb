Public Class ListeNote
    Inherits System.Web.UI.Page

    Dim DC As New DCDataContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Accroche()

        End If
    End Sub
    Sub Accroche()

        Dim liste As New List(Of Object)
        For Each elt As Note In DC.Notes.ToList
            liste.Add(New With {.Nom = elt.Etudiant.Personne.Nom, _
                                .Prenom = elt.Etudiant.Personne.Prenom, _
                                .Cc1 = elt.CC1, .Trimestre = elt.Trimestre, _
                                .Cc2 = elt.CC2, _
                                .Examen = elt.Exam})
        Next
        GridView1.DataSource = liste
        GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        MsgBox(CType(GridView1.Rows(0).FindControl("TxtCc1"), TextBox).Text)
    End Sub
End Class