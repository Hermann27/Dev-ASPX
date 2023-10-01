<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Filiere03.aspx.vb" Inherits="GestionStudents.Filiere03" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div class="content_box" 
    style="position:absolute; top: 493px; left: 476px; height: 178px;">
        
        <asp:MultiView ID="MVFiliere" runat="server" ActiveViewIndex="0">

           <asp:View ID="Viewlist" runat="server">
               <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True" Font-Italic="True">Les filieres
               </asp:Label>               <br />
                <br />
                <br />
               <asp:GridView ID="Gdv" runat="server" AutoGenerateColumns="False">
                   <Columns>
                       <asp:BoundField DataField="Nom" HeaderText="Nom" />
                       <asp:CommandField SelectText="Ses Spécialités" ShowSelectButton="True" />
                   </Columns>
               </asp:GridView>
            </asp:View> 

            <asp:View ID="View1" runat="server">
                <asp:RadioButtonList ID="rbspe" runat="server">
                </asp:RadioButtonList>
                <asp:LinkButton ID="LinkButton1" runat="server">liste des etudiants</asp:LinkButton>
                </asp:View> 
                
                <asp:View ID="View2" runat="server">
                <asp:GridView ID="Gdv1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                    <asp:BoundField DataField="Matricule" HeaderText="Matricule" />
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prenom" />
                    <asp:BoundField DataField="Date_Naissance" HeaderText="Date de Naissance" />
                    <asp:BoundField DataField="Sexe" HeaderText="Sexe" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Niveau" HeaderText="Niveau" />
                    <asp:BoundField DataField="Annee" HeaderText="Année" />
                </Columns>
                    
                </asp:GridView>
            </asp:View> 

            </asp:MultiView> 
    </div> <!-- end of content -->
</asp:Content>


