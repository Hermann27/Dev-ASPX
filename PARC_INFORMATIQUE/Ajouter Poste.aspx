<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ajouter Poste.aspx.vb" Inherits="Ajouter_Poste" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ajouter un Poste</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div>
        
        <br />
        <asp:Literal ID="trouve" runat="server"></asp:Literal><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="N° Poste :" Width="109px" Font-Bold="True" ForeColor="#C00000"></asp:Label>&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="nposte" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Nom de Poste:" Width="110px" Font-Bold="True" ForeColor="#C00000"></asp:Label>&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
        &nbsp; &nbsp;<asp:TextBox ID="nomposte" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" Text="N°Salle :" Width="109px" Font-Bold="True" ForeColor="#C00000"></asp:Label>&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="nsalle" runat="server" Width="156px" AutoPostBack="True">
        </asp:DropDownList><br />
        <asp:Label ID="Label4" runat="server" Text="Type de Poste:" Width="109px" Font-Bold="True" ForeColor="#C00000"></asp:Label>&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="typeposte" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label6" runat="server" Text="Dernier Groupe de Chiffre IP :" Width="216px" Font-Bold="True" ForeColor="#C00000"></asp:Label>&nbsp;&nbsp;
        &nbsp;
        <asp:TextBox ID="ad" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label3" runat="server" Text="N°Segement :" Width="109px" Font-Bold="True" ForeColor="#C00000"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="nseg" runat="server" ReadOnly="True"></asp:TextBox><br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button
            ID="Enregistrer" runat="server" BackColor="PeachPuff" BorderColor="Yellow" Font-Bold="True"
            ForeColor="#C00000" Text="Enregistrer" />
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button ID="Nouveau" runat="server" BackColor="PeachPuff"
            BorderColor="Yellow" Font-Bold="True" ForeColor="#C00000" Text="Nouveau Logiciel" /><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
        <br />
        </div>
    </form>
</body>
</html>
