<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Salle_poste.aspx.vb" Inherits="Salle_poste" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Poste_Salle</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Salle : "
            Width="124px"></asp:Label>
        <asp:DropDownList ID="salle" runat="server" AutoPostBack="True" Width="154px">
        </asp:DropDownList><br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Nom de Salle : "
            Width="124px"></asp:Label>
        <asp:TextBox ID="nom" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#C00000" Text="Segement : "
            Width="125px"></asp:Label>
        <asp:TextBox ID="seg" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#C00000" Text="NB poste   :"
            Width="126px"></asp:Label>
        <asp:TextBox ID="nb" runat="server" ReadOnly="True"></asp:TextBox><br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="566px">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
