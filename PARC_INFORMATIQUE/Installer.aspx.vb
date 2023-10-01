
Partial Class Installer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select n_poste from poste")
            Dim i As Integer
            For i = 0 To t.Rows.Count - 1
                Me.poste.Items.Add(t.Rows(i).Item(0))
            Next

            Dim t1 As Data.DataTable = c.Selection("select * from logiciel")
            Session("Logiciel") = t1
            For i = 0 To t1.Rows.Count - 1
                Me.log.Items.Add(t1.Rows(i).Item(0))
            Next
            Me.log.SelectedIndex = 0
        End If
    End Sub

    Protected Sub installe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles installe.Click
        Dim c As New notre_declaration
        Dim t As Data.DataTable = c.Selection("select * from installer where n_poste='" & Me.poste.SelectedItem.Text & "'" & "and  n_log='" & Me.log.SelectedItem.Text & "'")
        If t.Rows.Count = 0 Then
            trouve.Text = ""
            c.Execute_Requete_Action("insert into installer values(@poste,@log,@date)", New Object()() {New Object() {"@poste", "@log", "@date"}, New Object() {Me.poste.SelectedItem.Text, Me.log.SelectedItem.Text, Me.dte.Text}}, 1)

        Else
            trouve.Text = "Cette Logiciel est déja Installer dans cette Poste"
        End If
    End Sub

    Protected Sub poste_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles poste.SelectedIndexChanged
        trouve.Text = ""
    End Sub

    Protected Sub log_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles log.SelectedIndexChanged
        trouve.Text = ""
        Dim vue As New Data.DataView(Session("Logiciel"))
        vue.RowFilter = "n_log='" & Me.log.SelectedItem.Text & "'"
        Me.nom.Text = vue.Item(0).Item(1)
        Me.version.Text = vue.Item(0).Item(3)
        Me.type.Text = vue.Item(0).Item(4)
    End Sub

   
End Class
