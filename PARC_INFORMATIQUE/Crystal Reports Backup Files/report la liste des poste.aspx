<%@ Page Language="VB" AutoEventWireup="false" CodeFile="report la liste des poste.aspx.vb" Inherits="report_la_liste_des_poste" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Etat La Liste des Poste</title>
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
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#C04000" Text="Numéro de Salle : "></asp:Label>
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="119px">
        </asp:DropDownList><br />
        <br />
        <asp:Button ID="enreg" runat="server" Font-Bold="True" ForeColor="#C04000" Text="Enregistrer cette Etat sous forme excel" /><br />
        <br />
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ClientTarget="Uplevel" DisplayGroupTree="False" EnableDatabaseLogonPrompt="False" EnableDrillDown="False" EnableParameterPrompt="False" HasCrystalLogo="False" HasDrillUpButton="False" HasExportButton="False" HasSearchButton="False" HasViewList="False" HasZoomFactorList="False" Height="50px" Width="350px" />
        <br />
        &nbsp;</div>
    </form>
</body>
</html>
