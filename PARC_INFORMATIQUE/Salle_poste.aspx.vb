
Partial Class Salle_poste
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select * from salle")
            Session("table_salle") = t
            Dim i As Integer
            For i = 0 To t.Rows.Count - 1
                Me.salle.Items.Add(t.Rows(i).Item(0))
            Next
        End If
    End Sub

    Protected Sub salle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salle.SelectedIndexChanged
        Dim vue As New Data.DataView(Session("table_salle"))
        vue.RowFilter = "n_salle='" & Me.salle.SelectedItem.Text & "'"
        If vue.Count > 0 Then
            Me.nom.Text = vue(0).Item(1)
            Me.seg.Text = vue(0).Item(2)
            Me.nb.Text = vue(0).Item(3)
        End If
        Dim c As New notre_declaration
        Dim t As Data.DataTable = c.Selection("select n_poste as [Numéro de poste], nom_p as [Nom du Poste],n_segement as [Numéro de Segement],  n_segement+'.'+ad as [Adresse IP],type_p as [Type de Poste] from poste where n_salle='" & Me.salle.SelectedItem.Text & "'")
        Me.GridView1.DataSource = t
        Me.GridView1.DataBind()
    End Sub
End Class
