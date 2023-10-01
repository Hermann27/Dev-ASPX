Partial Class AAjouter_une_salle
    Inherits System.Web.UI.Page
    Protected Sub Enregistrer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Enregistrer.Click
        Dim con As New notre_declaration
        Dim t As Data.DataTable = con.Selection("select * from salle")
        Dim vue As New Data.DataView(t)
        vue.RowFilter = "n_salle=" & "'" & Me.nsalle.Text & "'"
        If vue.Count = 0 Then
            con.Execute_Requete_Action("insert into salle(N_Salle,Nom_S,N_Segement) values(@salle,@nom,@segemnt)", New Object()() {New Object() {"@salle", "@nom", "@segemnt"}, New Object() {Me.nsalle.Text, Me.nomsalle.Text, Me.DropDownList1.SelectedItem.Text}}, 1)
            Me.trouve.Text = "Ajout s'effectuér avec Succés"
        Else
            Me.trouve.Text = "Impossible d'Ajouter cette Salle Car est Deja existe une Salle qui a ce Numéro"
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim con As New notre_declaration
            Dim t As Data.DataTable = con.Selection("select N_segement from segement")
            Dim i As Integer
            For i = 0 To t.Rows.Count - 1
                Me.DropDownList1.Items.Add(t.Rows(i).Item(0))
            Next
        End If
    End Sub
    Protected Sub nouveau_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nouveau.Click
        Me.trouve.Text = ""
        Me.nsalle.Text = ""
        Me.nomsalle.Text = ""
    End Sub

   
End Class
