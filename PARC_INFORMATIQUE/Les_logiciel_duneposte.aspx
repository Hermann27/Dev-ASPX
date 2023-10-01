<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Les_logiciel_duneposte.aspx.vb" Inherits="Les_logiciel_duneposte" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> Les Logiciel Installer dans les postes</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#C00000" Text=" Numéro de Poste :"></asp:Label>
        <asp:DropDownList ID="numero" runat="server" AutoPostBack="True" Width="153px">
        </asp:DropDownList><br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Nom de Poste  :"
            Width="124px"></asp:Label>
        <asp:TextBox ID="nom" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Segement    : "
            Width="125px"></asp:Label>
        <asp:TextBox ID="seg" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Adresse Ip :"
            Width="124px"></asp:Label>
        <asp:TextBox ID="ip" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Type de Poste :"
            Width="123px"></asp:Label>
        <asp:TextBox ID="type" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#C00000" Text="N ° Salle :"
            Width="122px"></asp:Label>
        <asp:TextBox ID="nsalle" runat="server" ReadOnly="True"></asp:TextBox><br />
        <br />
        <asp:Label ID="trouve" runat="server" BackColor="#FFE0C0" Font-Bold="True" Font-Italic="True"
            Font-Underline="True" ForeColor="#FF8000" Text="Les Logiciel Installer dans cette Postes Sont : "
            Width="380px"></asp:Label><br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999"
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"
            Width="692px" Height="3px">
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#DCDCDC" />
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
