<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Histogramme de logiciel.aspx.vb" Inherits="Histogramme_de_logiciel" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Histogramme de Logiciel</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" BackColor="#FFC080" Font-Bold="True" Font-Italic="True"
            Font-Underline="True" ForeColor="#C00000" Text="Les Logiciels le Plus Populaires"
            Width="372px"></asp:Label><br />
        <br />
        <asp:LinkButton ID="télécharger" runat="server">Télécharger cette Etat</asp:LinkButton><br />
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True"
            DisplayGroupTree="False" DisplayToolbar="False" EnableDatabaseLogonPrompt="False"
            EnableParameterPrompt="False" Height="50px" ShowAllPageIds="True" SkinID="1"
            Width="350px" />
        &nbsp;<br />
        &nbsp;
    
    </div>
    </form>
</body>
</html>
