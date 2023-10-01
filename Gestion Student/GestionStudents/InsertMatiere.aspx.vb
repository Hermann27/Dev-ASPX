Public Class InsertMatiere
    Inherits System.Web.UI.Page
    Dim DC As New DCDataContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim listeEns = DC.Enseignants.ToList
            Session("ListeEns") = listeEns
            Dim liste2 As New List(Of Object)
            For Each elt In listeEns
                liste2.Add(New With {.Id = elt.Id, .Nom = elt.Personne.Nom})
            Next
            DwEns.DataSource = liste2
            DwEns.DataTextField = "Nom"
            DwEns.DataBind()

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnr.Click

       

        Dim Ens As New Enseignant
        Ens = CType(Session("ListeEns"), List(Of Enseignant)).Item(DwEns.SelectedIndex)

        Dim Ens1 = New Enseignant() With {.Id = Ens.Id, .Id_Personne = Ens.Id_Personne, .Annee = Ens.Annee, .Id_Specialite = Ens.Id_Specialite}
        Dim mat As New Matiere() With {.Id_Enseignant = Ens1.Id, .Intitule = TxtIntitule.Text, .Credit = CInt(TxtCredit.Text), .Plan_cour = FileMatiere.FileBytes}
        DC.Matieres.InsertOnSubmit(mat)
        DC.SubmitChanges()
        If FileMatiere.FileName IsNot Nothing Then
            Dim ext = IO.Path.GetExtension(FileMatiere.FileName)
            Dim chemin As String = Server.MapPath("~\Tmp\" & TxtIntitule.Text & ext)
            FileMatiere.SaveAs(chemin)
            'ImgPhoto.ImageUrl = "Tmp/" & TxtEmail.Text & Extension
        End If
    End Sub
End Class