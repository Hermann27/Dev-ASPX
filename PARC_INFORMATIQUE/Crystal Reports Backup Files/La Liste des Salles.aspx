<%@ Page Language="VB" AutoEventWireup="false" CodeFile="La Liste des Salles.aspx.vb" Inherits="La_Liste_des_Logiciels" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>La Liste des Logiciels</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" BackColor="#FFE0C0" Font-Bold="True" Font-Underline="True"
            ForeColor="#FF8000" Text="La Listes des Salles Dans Le Parc Informatique " Width="361px"></asp:Label>
            <br/>
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
            BorderWidth="2px" CellPadding="2" ForeColor="Black" GridLines="Both" RepeatColumns="3" Width="742px">
            <FooterStyle BackColor="Tan" />
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text='<%# Databinder.Eval(Container.DataItem, "N_Salle") %>' BackColor="#FFC080" Width="159px"></asp:Label><br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nom de Salle :" Width="159px"></asp:Label>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#C04000" Text='<%# Databinder.Eval(Container.DataItem, "Nom_s") %>'></asp:Label><br />
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Numéro de Segement :"
                    Width="158px"></asp:Label>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#C04000" Text='<%# Databinder.Eval(Container.DataItem, "N_Segement") %>'></asp:Label><br />
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Nombre du Poste :" Width="157px"></asp:Label>
                <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#C04000" Text='<%# Databinder.Eval(Container.DataItem, "nb_poste") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList></div>
    </form>
</body>
</html>
