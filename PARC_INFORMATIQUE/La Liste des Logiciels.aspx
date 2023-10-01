<%@ Page Language="VB" AutoEventWireup="false" CodeFile="La Liste des Logiciels.aspx.vb" Inherits="La_Liste_des_Logiciels" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>La Liste des Logiciels</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
					<table bgcolor="#ffcc66" style="COLOR:#cc0000; font-size:medium" border="1">
						<tr>
							<td width="220px">
								<a href ='Poste.aspx?log=<%#DataBinder.Eval(Container.Dataitem,"n_log")%>'>
									<%#DataBinder.Eval(Container.Dataitem,"n_log") %>
								</a>
								<br>
                                <asp:Label ID="Label3" runat="server" Text="Nom du Logiciel :"></asp:Label>		<%#DataBinder.Eval(Container.Dataitem,"Nom_L")%>
								<br>
							<asp:Label ID="Label1" runat="server" Text="Version :"></asp:Label>	<%#DataBinder.Eval(Container.Dataitem,"version")%><br>
                            <asp:Label ID="Label2" runat="server" Text="Date Achat :"></asp:Label>   	<%#DataBinder.Eval(Container.DataItem, "date_ach", "{0:d}")%></td>
                            <td width="190px" align="center">
                            <%#DataBinder.Eval(Container.Dataitem,"type_l")%>
                            </td>
						</tr>
					</table>
				</ItemTemplate>
				 <AlternatingItemTemplate>
					<table bgcolor="#ffff66"style="COLOR:#cc0000; font-size:medium">
						<tr>
							<td width="220px">
								<a href ='Poste.aspx?log=<%#DataBinder.Eval(Container.Dataitem,"n_log")%>'>
									<%#DataBinder.Eval(Container.Dataitem,"n_log") %>
								</a>
								<br>
                                <asp:Label ID="Label4" runat="server" Text="Nom du Logiciel :"></asp:Label>	<%#DataBinder.Eval(Container.Dataitem,"Nom_L")%>
								<br>
							<asp:Label ID="Label1" runat="server" Text="Version :"></asp:Label>	<%#DataBinder.Eval(Container.Dataitem,"version")%><br>
                            <asp:Label ID="Label2" runat="server" Text="Date Achat :"></asp:Label>   	<%#DataBinder.Eval(Container.DataItem, "date_ach", "{0:d}")%></td>
                            <td width="190px" align="center">
                            <%#DataBinder.Eval(Container.Dataitem,"type_l")%>
                            </td>
						</tr>
					</table>
				</AlternatingItemTemplate>
				
				<HeaderTemplate>
					<table bgcolor="white" style="font-size:larger;color:Lime; background-color:Black" border="1">
						<tr>
							<td width="220px">Infos_Logiciel</td>
							<td width="190px">Type du Logiciel</td>
						</tr>
					</table>
				</HeaderTemplate>
	<SeparatorTemplate>
                                <hr style="color:Gray; width:430px; height :1px; position:absolute;left:8px;" />			
       </SeparatorTemplate> 
         
            </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
