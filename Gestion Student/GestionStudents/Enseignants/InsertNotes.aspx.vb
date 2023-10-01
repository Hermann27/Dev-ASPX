Public Class InsertNotes
    Inherits System.Web.UI.Page
    Dim DC As New DCDataContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim liste = DC.Notes.ToList
            Dim liste2 As New List(Of Object)
            Dim liste3 As New List(Of Integer)
            With liste3
                .Add(1)
                .Add(2)
                .Add(3)
            End With
            
            For Each elt In liste
                liste2.Add(New With {.Etudiant = elt.Etudiant.Personne.Nom & "  " & elt.Etudiant.Personne.Prenom, .Matiere = elt.Matiere.Intitule})
            Next
            GridView1.DataSource = liste2
            GridView1.DataBind()

            Dim drop As DropDownList = CType(GridView1.Rows(0).FindControl("DTrim"), DropDownList)
            drop.DataSource = liste3
            drop.DataBind()
        End If
    End Sub

   
End Class