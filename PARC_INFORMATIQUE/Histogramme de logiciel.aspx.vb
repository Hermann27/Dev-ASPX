Imports CrystalDecisions.CrystalReports.Engine

Partial Class Histogramme_de_logiciel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oRpt As New ReportDocument
        oRpt.Load(Server.MapPath("Histograme.rpt"))
        Me.CrystalReportViewer1.ReportSource = oRpt
        Me.CrystalReportViewer1.DataBind()
    End Sub

    Protected Sub télécharger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles télécharger.Click
        Dim oRpt As New ReportDocument
        oRpt.Load(Server.MapPath("Histograme.rpt"))
        oRpt.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.WordForWindows, Me.Response, True, "diagramme")
    End Sub
End Class
