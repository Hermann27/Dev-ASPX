<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Ajouter un Logiciel.aspx.vb" Inherits="Ajouter_un_Logiciel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ajouter un Logiciel </title>
</head>
<body bgcolor="#ffffff" alink="#ff3300">
    <form id="form1" runat="server">
    <div>
        <table style="position:absolute ;top:65px;left:0px;width:597px; height: 160px;">
            <tr>
                <td style="width: 210px">
                    <asp:Label ID="Label1" runat="server" Text="N° Logiciel :" Width="199px" Font-Bold="True" ForeColor="#C00000"></asp:Label></td>
                <td>
                    <asp:TextBox ID="nlog" runat="server" Width="140px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nlog"
                        Display="Dynamic" ErrorMessage="Entrez le N° de Logiciel "></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="nlog"
                        Display="Dynamic" ErrorMessage="Entrez Un Nombre" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator></td>
               
            </tr>
            <tr>
                <td style="width: 210px; height: 26px;">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nom Logiciel :" ForeColor="#C00000"></asp:Label></td>
                <td style="height: 26px">
                    <asp:TextBox ID="nomlog" runat="server" Width="143px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nomlog"
                        Display="Dynamic" ErrorMessage="Entrez le Nom de Logiciel"></asp:RequiredFieldValidator></td>
                
            </tr>
            <tr>
                <td style="width: 210px">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Date Achat :" ForeColor="#C00000"></asp:Label></td>
                <td>
                    <asp:TextBox ID="datachat" runat="server" Width="143px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="datachat"
                        Display="Dynamic" ErrorMessage="Saisair Date Achat"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="datachat"
                        Display="Dynamic" ErrorMessage="Entrez une Date Valide" Operator="DataTypeCheck"
                        Type="Date"></asp:CompareValidator></td>
                
            </tr>
            <tr>
                <td style="width: 210px">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Version :" ForeColor="#C00000"></asp:Label></td>
                <td>
                    <asp:TextBox ID="version" runat="server" Width="145px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="version"
                        Display="Dynamic" ErrorMessage="Entrez la Version"></asp:RequiredFieldValidator></td>
                
            </tr>
            <tr>
                <td style="width: 210px; height: 26px;">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Type Logiciel :" ForeColor="#C00000"></asp:Label></td>
                <td style="height: 26px">
                    <asp:TextBox ID="typelog" runat="server" Font-Bold="False" Width="145px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="typelog"
                        Display="Dynamic" ErrorMessage="Entrez le Type de Logiciel"></asp:RequiredFieldValidator></td>
                
            </tr>
        </table>
    
    </div>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Literal ID="trouve" runat="server"></asp:Literal><br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Ajouter" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Enregistrer" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Nouveau" runat="server" BackColor="PeachPuff" BorderColor="Yellow"
            Font-Bold="True" ForeColor="#C00000" Text="Nouveau Logiciel" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
