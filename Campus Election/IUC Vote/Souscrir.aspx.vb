Public Partial Class WebForm3
    Inherits System.Web.UI.Page
    Dim dc As New DCDataContext()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim listMatri = dc.Etudiants.ToList
            DDList1.DataSource = listMatri
            DDList1.DataValueField = "Matricule"
            DDList1.DataTextField = "Nom"
            DDList1.DataBind()

            Dim listElect = dc.Elections.ToList
            DDList2.DataSource = listElect
            DDList2.DataValueField = "Code"
            DDList2.DataTextField = "Type"
            DDList2.DataBind()
        End If
    End Sub

    Private Sub BtnEnre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEnre.Click
        Dim Extension As String = Nothing
        If FilePhoto.FileName IsNot Nothing Then
            Extension = IO.Path.GetExtension(FilePhoto.FileName)
            Dim chemin As String = Server.MapPath("~\Tmp\" & DDList1.SelectedValue & Extension)
            FilePhoto.SaveAs(chemin)
            ImgPhoto.ImageUrl = "Tmp/" & DDList1.SelectedValue & Extension
        End If
        Dim cand As New Candidature()
        cand.Matricule = DDList1.SelectedValue
        cand.Code_Election = CInt(DDList2.SelectedValue)
        cand.PhotoProfil = FilePhoto.FileBytes
        cand.Extension = Extension
        dc.Candidatures.InsertOnSubmit(cand)
        dc.SubmitChanges()
    End Sub
End Class