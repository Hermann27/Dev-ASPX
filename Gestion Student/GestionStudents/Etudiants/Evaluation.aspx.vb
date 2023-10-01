Public Class Evaluation1
    Inherits System.Web.UI.Page
    Dim DC As New DCDataContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim liste1 = DC.Enseignants.ToList
            Dim liste2 As New List(Of Object)

            For Each elt In liste1
                liste2.Add(New With {.Nom = elt.Personne.Nom & "  " & elt.Personne.Prenom})
            Next

            DwEns.DataSource = liste2
            DwEns.DataTextField = "Nom"
            DwEns.DataBind()
            liste2 = New List(Of Object)
            With liste2
                .Add("Assez Bien")
                .Add("Mediocre")
                .Add("Excellent")
                .Add("Null")
                .Add("Passable")
            End With
            DwMention.DataSource = liste2
            DwMention.DataBind()
        End If
    End Sub

End Class