<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListeEtudiant.aspx.vb" Inherits="GestionStudents.ListeEtudiant"  MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div class="content_box" style="position:absolute; top: 413px; left: 323px;">
        
        	<asp:MultiView ID="MVMatiere" runat="server" ActiveViewIndex="0">
          <asp:View ID="Viewlist" runat="server">

             <center ><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prenom" />
                    <asp:BoundField DataField="Date_Naissance" HeaderText="Date de Naissance" />
                    <asp:BoundField DataField="Sexe" HeaderText="Sexe" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Niveau" HeaderText="Niveau" />
                    <asp:BoundField DataField="Annee" HeaderText="Année" />
                </Columns>
            </asp:GridView></center>
        </asp:View> 

          <asp:View ID="View2" runat="server">
          </asp:View> 
        </asp:MultiView> 
        	
    </div> <!-- end of content -->
</asp:Content>


