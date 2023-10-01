Partial Public Class Etudiant1
    Inherits System.Web.UI.Page
    Dim dc As New DCDataContext()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub BtnEnregistrer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnregistrer.Click
        Dim etd As New Etudiant()
        etd.Matricule = TxtMatricule.Text
        etd.Nom = TxtNom.Text
        etd.Prenom = TxtPrenom.Text
        etd.Filiere = TxtFiliere.Text
        etd.Specialite = TxtFiliere.Text

        etd.Niveau = CInt(Niveau.Text)
        etd.Sexe = Sexe.Text
        dc.Etudiants.InsertOnSubmit(etd)
        dc.SubmitChanges()
    End Sub
End Class