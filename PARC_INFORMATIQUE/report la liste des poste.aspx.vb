Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Partial Class report_la_liste_des_poste
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim c As New notre_declaration
            Dim t As Data.DataTable = c.Selection("select n_salle from salle where n_salle in(select n_salle from poste)")
            For i As Integer = 0 To t.Rows.Count - 1
                Me.DropDownList1.Items.Add(t.Rows(i).Item(0))
            Next
            charger_etat("1")
        End If
    End Sub
    Sub charger_etat(ByVal k As String)
        Dim orpt As New ReportDocument
        orpt.Load(Server.MapPath("La Liste des Postes.rpt"))
        orpt.SetParameterValue(0, k)
        Me.CrystalReportViewer1.ReportSource = orpt
        Session("rapport") = orpt
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        charger_etat(Me.DropDownList1.SelectedItem.Text)
    End Sub

    Protected Sub enreg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enreg.Click
        If Not Directory.Exists(Server.MapPath("Temp/")) Then
            Directory.CreateDirectory(Server.MapPath("Temp/"))
        End If
        CType(Session("rapport"), ReportDocument).ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, Server.MapPath("Temp/" & " les poste du salle " & Me.DropDownList1.SelectedItem.Text & ".xls"))
        Me.CrystalReportViewer1.ReportSource = Session("rapport")
    End Sub
End Class
