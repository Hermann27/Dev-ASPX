<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ajouter une salle.aspx.vb" Inherits="AAjouter_une_salle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ajouter une Salle</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div>
        <table style="width: 492px">
            <tr>
                <td style="width: 81px">
                    <asp:Label ID="Label1" runat="server" Text="N°Salle : " Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td style="width: 234px">
                    <asp:TextBox ID="nsalle" runat="server" Width="139px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nsalle"
                        Display="Dynamic" ErrorMessage="Entrez le N°Salle"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 81px">
                    <asp:Label ID="Label2" runat="server" Text="Nom Salle :" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td style="width: 234px">
                    <asp:TextBox ID="nomsalle" runat="server" Width="141px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nomsalle"
                        ErrorMessage="Entrez Le Nom de Salle: "></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 81px">
                    <asp:Label ID="Label3" runat="server" Text="Segement :" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td style="width: 234px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="145px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1"
                        ErrorMessage="Choisissez le Segement"></asp:RequiredFieldValidator></td>
            </tr>
        </table>
    
    </div>
        &nbsp; &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Literal ID="trouve" runat="server"></asp:Literal><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Enregistrer" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Enregistrer cette Salle " />
        &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Nouveau" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Nouvelle Salle" />&nbsp;<br />
        &nbsp; &nbsp;<br />
        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
        <br />
        &nbsp;&nbsp;
    </form>
</body>
</html>
