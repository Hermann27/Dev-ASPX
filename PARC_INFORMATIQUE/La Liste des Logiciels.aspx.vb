Partial Class La_Liste_des_Logiciels
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select * from logiciel")
            Me.Repeater1.DataSource = t
            Me.Repeater1.DataBind()
        End If
    End Sub
End Class
