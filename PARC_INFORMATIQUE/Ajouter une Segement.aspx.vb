Partial Class Ajouter_une_Segement
    Inherits System.Web.UI.Page
    Protected Sub Ajouter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Dim con As New notre_declaration
        Dim t As Data.DataTable = con.Selection("select * from segement")
        Dim vue As New Data.DataView(t)
        vue.RowFilter = "n_segement=" & "'" & Me.Nseg.Text & "'"
        If vue.Count = 0 Then
            Me.trouve.Text = ""
            con.Execute_Requete_Action("insert into segement values(@n,@nom)", New Object()() {New Object() {"@n", "@nom"}, New Object() {Me.Nseg.Text, Me.Nomseg.Text}}, 1)
            Me.trouve.Text = "Ajout s'effectuér avec Succés"
        Else
            Me.trouve.Text = "Cette Segement est déja existant"
        End If
    End Sub
    Protected Sub Nouveau_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nouveau.Click
        Me.Nseg.Text = ""
        Me.Nomseg.Text = ""
        Me.trouve.Text = ""
    End Sub

    
End Class
