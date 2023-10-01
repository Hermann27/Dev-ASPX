Partial Class Les_logiciel_duneposte
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select * from poste")
            Session("table_poste") = t
            Dim i As Integer
            For i = 0 To t.Rows.Count - 1
                Me.numero.Items.Add(t.Rows(i).Item(0))
            Next


        End If
    End Sub
    Protected Sub numero_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numero.SelectedIndexChanged
        Dim vue As New Data.DataView(Session("table_poste"))
        vue.RowFilter = "n_poste='" & Me.numero.SelectedItem.Text & "'"
        If vue.Count > 0 Then
            Me.nom.Text = vue(0).Item(1)
            Me.seg.Text = vue(0).Item(2)
            Me.ip.Text = vue(0).Item(2) & "." & vue(0).Item(3)
            Me.type.Text = vue(0).Item(4)
            Me.nsalle.Text = vue(0).Item(5)
        End If
        Dim c As New notre_declaration
        Dim t As Data.DataTable = c.Selection("select installer.N_log as [Numéro de Logiciel],nom_l as [Nom de Logiciel],SUBSTRING(convert(varchar,Date_ach),1,12) as [Date Achat] ,version ,type_l as [Type de Logiciel],SUBSTRING(convert(varchar,Date_ins),1,12) as [Date Instalation] from logiciel inner join installer on logiciel.N_log=installer.N_log and n_poste='" & Me.numero.SelectedItem.Text & "'")
        If t.Rows.Count > 0 Then
            Me.trouve.Text = "Les Logiciel Installer dans cette Postes Sont : "
            Me.GridView1.Visible = True
            Me.GridView1.DataSource = t
            Me.GridView1.DataBind()
        Else
            Me.GridView1.Visible = False
            Me.trouve.Text = "!!!!Aucun Logiciel Installer dans cet Poste!!!!"
        End If
    End Sub
End Class
