Public Class Ajouter_Poste
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim con As New notre_declaration
            Dim i As Integer
            Dim t1 As Data.DataTable = con.Selection("select * from salle")
            Session("tsale") = t1
            For i = 0 To t1.Rows.Count - 1
                Me.nsalle.Items.Add(t1.Rows(i).Item(0))
            Next
            Me.nsalle.SelectedIndex = 0
        End If
    End Sub
    Protected Sub Enregistrer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Enregistrer.Click
        Dim con As New notre_declaration
        Dim t As Data.DataTable = con.Selection("select * from poste")
        Dim vue As New Data.DataView(t)
        vue.RowFilter = "n_poste=" & "'" & nposte.Text & "'"
        If vue.Count = 0 Then
            vue = New Data.DataView(t)
            vue.Sort = "n_segement,ad,n_salle"
            Dim objet() As Object = {Me.nseg.Text, Me.ad.Text, Me.nsalle.SelectedItem.Text}
            Dim pos As Integer = vue.Find(objet)
            If pos < 0 Then
                Me.trouve.Text = ""
                con.Execute_Requete_Action("insert into poste values(@poste,@nom,@segemnt,@ad,@type,@salle)", New Object()() {New Object() {"@poste", "@nom", "@segemnt", "@ad", "@type", "@salle"}, New Object() {Me.nposte.Text, Me.nomposte.Text, Me.nseg.Text, Me.ad.Text, Me.typeposte.Text, Me.nsalle.SelectedItem.Text}}, 1)
                Me.trouve.Text = "Ajout s'effectuér avec Succés"
            Else
                Me.trouve.Text = "il existe dans cette Salle : " & Me.nsalle.SelectedItem.Text & "Déja Cette Adresse IP : " & Me.nseg.Text & "." & Me.ad.Text
            End If
        Else
            Me.trouve.Text = "Cette poste est déja existe"
        End If
    End Sub
    Protected Sub Nouveau_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nouveau.Load
        Me.nposte.Text = ""
        Me.nomposte.Text = ""
        Me.ad.Text = ""
        Me.typeposte.Text = ""
        Me.trouve.Text = ""
    End Sub
    Protected Sub nsalle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nsalle.SelectedIndexChanged
        Dim vue As New Data.DataView(Session("tsale"))
        vue.Sort = "n_salle"
        Dim pos As Integer = vue.Find(Me.nsalle.SelectedItem.Text)
        Me.nseg.Text = vue.Item(pos).Item(2)
    End Sub

    Protected Sub Nouveau_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nouveau.Click
        Me.nposte.Text = ""
        Me.nomposte.Text = ""
        Me.nseg.Text = ""
        Me.ad.Text = ""
        Me.typeposte.Text = ""
    End Sub
End Class
