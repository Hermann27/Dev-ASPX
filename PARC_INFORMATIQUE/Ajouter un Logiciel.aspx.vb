
Partial Class Ajouter_un_Logiciel
    Inherits System.Web.UI.Page

    Protected Sub Ajouter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Dim con As New notre_declaration
        Dim t As Data.DataTable = con.Selection("select * from logiciel")
        Dim vue As New Data.DataView(t)
        vue.RowFilter = "N_Log=" & "'" & Me.nlog.Text & "'"
        If vue.Count = 0 Then
            Me.trouve.Text = ""
            con.Execute_Requete_Action("insert into logiciel values(@log,@nom,@date,@version,@type)", New Object()() {New Object() {"@log", "@nom", "@date", "@version", "@type"}, New Object() {Me.nlog.Text, Me.nomlog.Text, Me.datachat.Text, Me.version.Text, Me.typelog.Text}}, 1)
            Me.trouve.Text = "Ajout s'effectuér avec Succés"
        Else
            Me.trouve.Text = "Cette logiciel est déja existant tapez un autre N°Logiciel"
        End If
    End Sub

    Protected Sub Nouveau_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nouveau.Click
        Me.trouve.Text = ""
        Me.typelog.Text = ""
        Me.nlog.Text = ""
        Me.nomlog.Text = ""
        Me.version.Text = ""
        Me.datachat.Text = ""
    End Sub

   
End Class
