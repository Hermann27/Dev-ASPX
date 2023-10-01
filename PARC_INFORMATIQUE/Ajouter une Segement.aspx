<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ajouter une Segement.aspx.vb" Inherits="Ajouter_une_Segement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ajouter une Segement</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div>
        <table border="0" style="position:absolute;left:7px;top:20px;width:577px; height: 86px" frame="above" title="Ajouter un Segement :">
            <tr>
                <td style="width: 147px">
                    <asp:Label ID="Label1" runat="server" Text="N°Segement :" Width="134px" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td>
                    <asp:TextBox ID="Nseg" runat="server"></asp:TextBox>&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Nseg"
                        Display="Dynamic" ErrorMessage="Cette champs n'admet les valeur null"></asp:RequiredFieldValidator>&nbsp;</td>
                
            </tr>
            <tr>
                <td style="width: 147px; height: 40px">
                    <asp:Label ID="Label2" runat="server" Text="Nom Segement :" Width="136px" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td style="height: 40px">
                    <asp:TextBox ID="Nomseg" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Nomseg"
                        Display="Dynamic" ErrorMessage="Entrez le Nom de Segement"></asp:RequiredFieldValidator></td>
                
            </tr>
            
        </table>
        &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Ajouter" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Ajouter" />
        <asp:Button ID="Nouveau" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Nouvelle Segement" />
        <br />
        <br />
        <asp:Literal ID="trouve" runat="server" ></asp:Literal><br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
   
    </div>
    </form>
</body>
</html>
