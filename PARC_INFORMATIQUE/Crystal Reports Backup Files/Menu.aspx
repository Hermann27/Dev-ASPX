<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Menu.aspx.vb" Inherits="Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Page sans titre</title>
</head>
<body bgcolor="#cc0000">
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        &nbsp;
        <asp:Menu ID="Menu1" runat="server" BackColor="#CC0000" DynamicHorizontalOffset="2"
            Font-Names="Arial" Font-Size="8pt" ForeColor="Khaki" Height="1px" StaticSubMenuIndent="10px"
            Width="1px" Font-Bold="True" Font-Overline="False" Font-Underline="False" Font-Italic="True">
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuStyle BackColor="#FF8000" />
            <StaticSelectedStyle BackColor="PapayaWhip" ForeColor="#FF8080" />
            <DynamicSelectedStyle BackColor="#FF8000" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <Items>
                <asp:MenuItem Text="Fichier" Value="Fichier">
                    <asp:MenuItem NavigateUrl="~/Ajouter une Segement.aspx" Target="f1" Text="Segement"
                        Value="Segement"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Ajouter une salle.aspx" Target="f1" Text="Salle" Value="Salle">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Ajouter Poste.aspx" Target="f1" Text="Poste" Value="Poste">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Ajouter un Logiciel.aspx" Target="f1" Text="Logiciel"
                        Value="Logiciel"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Installer.aspx" Target="f1" Text="Installer" Value="Installer">
                    </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Consultation" Value="Consultation">
                    <asp:MenuItem NavigateUrl="~/Salle_poste.aspx" Target="f1" Text="Les Postes d'une Salle"
                        Value="Les Postes d'une Salle"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Les_logiciel_duneposte.aspx" Target="f1" Text="Les Logiciels Install&#233;s dans une Poste"
                        Value="Les Logiciels Install&#233;s dans une Poste"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/La Liste des Logiciels.aspx" Target="f1" Text="La Liste des Logiciels"
                        Value="La Liste des Logiciels"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/La Liste des Salles.aspx" Target="f1" Text="La Liste des Salles"
                        Value="La Liste des Salles"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Etat" Value="Etat">
                    <asp:MenuItem NavigateUrl="~/Histogramme de logiciel.aspx" Target="f1" Text="Histogramme des Logiciels les plus Utilis&#233;s"
                        Value="Les Logiciels les plus Utilis&#233;s"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/report la liste des poste.aspx" Target="f1" Text="La Liste des Postes"
                        Value="La Liste des Postes"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Panne" Value="Panne">
                    <asp:MenuItem NavigateUrl="~/R&#233;clamation.aspx" Target="f1" Text="Effectuer une R&#233;clamation"
                        Value="Reclamation"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
        </asp:Menu>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
