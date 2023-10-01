<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Identification.aspx.vb" Inherits="Identification" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Identification</title>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Height="107px" Width="720px">
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Compte :" ForeColor="#C00000"></asp:Label>
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="compte1" runat="server" Width="138px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="compte1"
            ErrorMessage="Entrez votre Compte"></asp:RequiredFieldValidator><asp:Literal ID="trouve" runat="server"></asp:Literal><br />
            <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Mot de passe : " ForeColor="#C00000"></asp:Label>
            &nbsp;&nbsp; &nbsp;<asp:TextBox ID="passe1" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="passe1"
            ErrorMessage="Entrez le mot de passe"></asp:RequiredFieldValidator><br />
        <asp:Button ID="Valider" runat="server" Text="Valider" Font-Bold="True" ForeColor="#C00000" BackColor="PeachPuff" BorderColor="Yellow" /></asp:Panel>
        <asp:Table ID="Table1" runat="server" BorderStyle="Groove" Height="1px" HorizontalAlign="Center"
            Visible="False" Width="659px">
            <asp:TableRow runat="server" BorderStyle="Groove" Font-Bold="False">
                <asp:TableCell runat="server" BorderStyle="Groove" Font-Bold="True" ForeColor="#C00000">
                    <asp:Label ID="Label1" runat="server" Text="Compte:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Groove">
                    <asp:TextBox ID="compte" runat="server" EnableViewState="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="compte"
                        ErrorMessage="Entrez le Compte "></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderStyle="Groove" Font-Bold="False">
                <asp:TableCell runat="server" BorderStyle="Groove" Font-Bold="True" ForeColor="#C00000">
                    <asp:Label ID="Label2" runat="server" Text="Mot de passe:"></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Groove">
                    <asp:TextBox ID="passe" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator100" runat="server" ControlToValidate="passe"
                        ErrorMessage="Entrez le mot de passe"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderStyle="Groove" Font-Bold="False">
                <asp:TableCell runat="server" BorderStyle="Groove" Font-Bold="True" ForeColor="#C00000">
                    <asp:Label ID="Label4" runat="server" Text="Confirmation : "></asp:Label>
                </asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Groove">
                    <asp:TextBox ID="confirme" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passe"
                        ControlToValidate="confirme" Display="Dynamic" ErrorMessage="Validez votre mot de passe"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="confirme"
                        Display="Dynamic" ErrorMessage="Entrez un mot de passe"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" Font-Bold="True">
                <asp:TableCell runat="server" Font-Bold="True" ForeColor="#C00000">
                    <asp:Button ID="OK" runat="server" Text="OK" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        </div>
    </form>
</body>
</html>
