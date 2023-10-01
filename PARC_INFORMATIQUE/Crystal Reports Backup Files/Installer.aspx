<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Installer.aspx.vb" Inherits="Installer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Installer</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="N° Poste :" Width="125px" ForeColor="#C00000"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;<asp:DropDownList ID="poste"
            runat="server" Width="155px">
        </asp:DropDownList>&nbsp;
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="N°Logiciel :" Width="126px" ForeColor="#C00000"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;<asp:DropDownList ID="log" runat="server"
            AutoPostBack="True" Width="154px">
        </asp:DropDownList><br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Nom Logiciel" ForeColor="#C00000" Width="126px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="nom" runat="server" ReadOnly="True" Width="149px"></asp:TextBox>
        <asp:Literal ID="trouve" runat="server"></asp:Literal><br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Version   :" ForeColor="#C00000" Width="127px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="version" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Type Logiciel :" ForeColor="#C00000" Width="128px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="type" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Date Instalation :"
            Width="127px" ForeColor="#C00000"></asp:Label>
        &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="dte" runat="server" Width="150px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="dte"
            ErrorMessage="Entrez une date valide" Operator="DataTypeCheck" Type="Date" Display="Dynamic"></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="dte"
            Display="Dynamic" ErrorMessage="Entrez une Date "></asp:RequiredFieldValidator><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button
            ID="installe" runat="server" Text="Installer" Font-Bold="True" ForeColor="#C00000" BackColor="PeachPuff" BorderColor="Yellow" />
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        </div>
    </form>
</body>
</html>
