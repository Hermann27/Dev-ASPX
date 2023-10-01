Imports System.Web.Security
Partial Class Identification
    Inherits System.Web.UI.Page
    Protected Sub Valider_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Valider.Click
        Dim c As New notre_declaration
        Dim t As Data.DataTable = c.Selection("select * from utilisateur where compte='" & Me.compte1.Text & "' and passe='" & Me.passe1.Text & "'")
        If t.Rows.Count = 0 Then
            Me.trouve.Text = "Ce Compte Introuvable "
            Me.Table1.Visible = True
            Panel1.Visible = False
        Else
            FormsAuthentication.RedirectFromLoginPage(Me.compte1.Text, False)
        End If
    End Sub
    Protected Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ch_compte As String = Me.compte.Text
        Dim ch_passe As String = Me.passe.Text
        Dim c As New notre_declaration
        Dim t As Data.DataTable = c.Selection("select * from utilisateur where compte='" & ch_compte & "'")
        If t.Rows.Count = 0 Then
            Me.trouve.Text = ""
            c.Execute_Requete_Action("insert into utilisateur values(@compte,@mot)", New Object()() {New Object() {"@compte", "@mot"}, New Object() {ch_compte, ch_passe}}, 1)
            Me.trouve.Text = "Compte Créez"
            FormsAuthentication.RedirectFromLoginPage(Me.compte.Text, False)
        Else
            Me.trouve.Text = "Ce Compte est déja existe Entrez une autre Compte"
        End If
    End Sub
End Class
