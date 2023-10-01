Public Class Site
    Inherits System.Web.UI.MasterPage
    Dim DC As New DCDataContext
    
    Private Sub BtnCon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCon.Click
        'Response.Redirect("Etudiants/ListeNote.aspx")
        Dim liste As List(Of Personne) = DC.Personnes.ToList
        Dim query = From elt In liste Where elt.Matricule = TextBox1.Text And elt.Password = TxtPass.Text _
        And elt.Profession = "Etudiant" Select elt

        If query.Count = 0 Then

        Else

            MultiView1.ActiveViewIndex = 1
            Response.Redirect("ConsultNotes.aspx")
        End If
        Dim query1 = From elt In liste Where elt.Matricule = TextBox1.Text And elt.Password = TxtPass.Text _
        And elt.Profession = "Enseignant" Select elt

        If query.Count = 0 Then

        Else

            MultiView1.ActiveViewIndex = 2
            Response.Redirect("ConsultNotes.aspx")
        End If


    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fs.Visible = True
        Image1.ImageUrl = "personal.png"
    End Sub

    Private Sub BtnDec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDec.Click
        Session.Remove("Personne")
    End Sub
End Class