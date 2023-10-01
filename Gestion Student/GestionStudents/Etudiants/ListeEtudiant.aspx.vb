Public Class ListeEtudiant
    Inherits System.Web.UI.Page

    Dim DC As New DCDataContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim liste As New List(Of Object)
            For Each elt As Etudiant In DC.Etudiants.ToList
                liste.Add(New With {.Matricule = elt.Personne.Matricule, .Nom = elt.Personne.Nom, .Prenom = elt.Personne.Prenom, .Situation_Matrimoniale = elt.Personne.Situation_Matrimoniale, .Date_Naissance = elt.Personne.Date_Naissance, .Sexe = elt.Personne.Sexe, .Email = elt.Personne.Email, _
                                    .Profession = elt.Personne.Profession, .Niveau = elt.Niveau, .Annee = elt.Annee, .Specialite = elt.Specialite.Nom})
            Next

            GridView1.DataSource = liste
            GridView1.DataBind()

        End If
    End Sub


End Class