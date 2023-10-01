Public Class Filiere03
    Inherits System.Web.UI.Page

    Dim DC As New DCDataContext
    Dim listeFil As List(Of Filiere) = DC.Filieres.ToList
    Dim listeSpe As List(Of Specialite) = DC.Specialites.ToList

    Private Sub Filiere03_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Gdv.DataSource = listeFil
            Gdv.DataBind()
            affich()
        End If
    End Sub

    Private Sub Gdv_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gdv.SelectedIndexChanged
        Dim query = From el In listeSpe Where el.Filiere.Id = el.Id_Filiere Select el
        rbspe.DataSource = listeSpe
        rbspe.DataTextField = "Nom"
        rbspe.DataBind()
        MVFiliere.ActiveViewIndex = 1
    End Sub


    Private Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Dim listE As List(Of Etudiant) = DC.Etudiants.ToList
        Dim query1 = From elt1 In listE Where elt1.Specialite.Id = elt1.Id_Specialite _
                     And elt1.Specialite.Nom = rbspe.SelectedValue Select elt1
        If query1.Count = 0 Then
            MsgBox("any students")
        Else
            
            MVFiliere.ActiveViewIndex = 2
        End If
    End Sub

    Sub affich()
        If Not IsPostBack Then
            Dim liste As New List(Of Object)
            For Each elt As Etudiant In DC.Etudiants.ToList
                liste.Add(New With {.Matricule = elt.Personne.Matricule, .Nom = elt.Personne.Nom, .Prenom = elt.Personne.Prenom, .Situation_Matrimoniale = elt.Personne.Situation_Matrimoniale, .Date_Naissance = elt.Personne.Date_Naissance, .Sexe = elt.Personne.Sexe, .Email = elt.Personne.Email, _
                                    .Profession = elt.Personne.Profession, .Niveau = elt.Niveau, .Annee = elt.Annee, .Specialite = elt.Specialite.Nom})
            Next

            Gdv1.DataSource = liste
            Gdv1.DataBind()

        End If
    End Sub
End Class