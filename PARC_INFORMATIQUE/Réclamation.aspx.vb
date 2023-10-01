Imports System.Net

Partial Class Réclamation
    Inherits System.Web.UI.Page

    Protected Sub Envoyer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Envoyer.Click
        Dim adrresip As String = Request.ServerVariables("remote_addr")
        Dim nommachine As String = Request.ServerVariables(5)
        Dim c As New notre_declaration
        If Me.sujet.Text <> "" Then
            c.Execute_Requete_Action("insert into réclamation(adresseip,nommachine,sujet) values(@adresse,@nom,@sujet)", New Object()() {New Object() {"@adresse", "@nom", "@sujet"}, New Object() {adrresip, nommachine, Me.sujet.Text}}, 1)
        Else
            Me.votre_probleme.Text = "Ecrivez le Sujet de votre Réclamation"
        End If


    End Sub

   
End Class
