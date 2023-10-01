Public Partial Class Site1
    Inherits System.Web.UI.MasterPage
    Dim dc As New DCDataContext

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("et") IsNot Nothing Then

            Dim lis As List(Of Etudiant) = dc.Etudiants.ToList
            Dim obj As New Etudiant()
            Dim Link = From elt In lis _
                       Where elt.Matricule = Session("et") _
                       Select elt

            obj.Nom = Link.FirstOrDefault.Nom
            obj.Prenom = Link.FirstOrDefault.Prenom
            Loghere.InnerHtml = "Bienvenu !" & " " & obj.Prenom & " " & obj.Nom
            login_form.Visible = False
            BtnDecon.Visible = True
        Else
            Loghere.InnerHtml = "Authentifiez-Vous !"
            login_form.Visible = True
            BtnDecon.Visible = False

        End If

       


    End Sub
    Private Sub Login_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Login.ServerClick
        Try
            Dim lis As List(Of Etudiant) = dc.Etudiants.ToList
            Dim Link = From elt In lis _
                       Where elt.Nom = username.Value And elt.Matricule = password.Value _
                       Select elt
            Dim lst2 As List(Of Administrateur) = dc.Administrateurs.ToList
            'Dim obj As Etudiant = _
            'dc.Etudiants.Where(Function(f) f.Nom = _
            '                       username.Value And f.Matricule = password.Value).FirstOrDefault

            If Session("et") = Nothing Then

                If Link.Count = 0 Then
                    Lb.Text = "Nom ou Matricule Incorecte"
                    Lb.Visible = True
                Else
                    Lb.Text = "Conexion reussite!!!"
                    Lb.Visible = True
                    Session("et") = Link.FirstOrDefault.Matricule
                    Dim link2 = From elt In lst2 _
                       Where elt.IdEtud = Session("et") _
                       Select elt
                    If link2.Count <> 0 Then

                        Session("ad") = link2.FirstOrDefault.IdEtud
                    End If
                    If Session("ad") IsNot Nothing Then
                        Response.Redirect("Default.aspx")
                    Else
                        Response.Redirect("Default.aspx")
                    End If

                    Exit Sub
                End If
            Else

                MsgBox("Utilisateur déjà connecté")
            End If

        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Sub BtnDecon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDecon.Click
        Session.Remove("et")
        Session.Remove("ad")
        'Page_Load(sender, e)

        Response.Redirect("Contact.aspx")
    End Sub

End Class