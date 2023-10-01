<%@ Page Language="vb" MasterPageFile="~/Site1.Master"  AutoEventWireup="false" CodeBehind="Etudiant.aspx.vb" Inherits="IUC_Vote.Etudiant1" %>



<asp:content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">Vote - 
    Etudiant</asp:content>

<asp:content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="templatemo_middle_column">
            	<h2>Enregistrement Etudiant</h2>
            	
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                <p> Matricule :
                    <br />
                    <asp:TextBox ID="TxtMatricule" runat="server" Width="305px"></asp:TextBox>
                   
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="TxtMatricule" Display="Dynamic" 
                        ErrorMessage="Entrez votre matricule"></asp:RequiredFieldValidator>
                   
                    <br />
                    Nom :<br />
                    <asp:TextBox ID="TxtNom" runat="server" Width="305px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TxtNom" ErrorMessage="Entrez votre Nom" 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />
                    Prenom :<br />
                    <asp:TextBox ID="TxtPrenom" runat="server" Width="307px"></asp:TextBox>
                       <br />
                    Filiere :<br />
                    <asp:TextBox ID="TxtFiliere" runat="server" Width="307px"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="Entrez votre Filiere" ControlToValidate="TxtFiliere" 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />
                    Specialité :                     <br />
                    <asp:TextBox ID="TxtSpecialite" runat="server" Width="307px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="TxtSpecialite" Display="Dynamic" 
                        ErrorMessage="Entrez votre Specialite"></asp:RequiredFieldValidator>
                    <br />
                     Niveau:<br />
                    <asp:TextBox  ID="Niveau" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="Niveau" Display="Dynamic" ErrorMessage="Entrez votre Niveau"></asp:RequiredFieldValidator>
                    <br />
                        
                        Sexe:<br />
                    <asp:TextBox  ID="Sexe" runat="server" />
                    &nbsp;
                   
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnEnregistrer" runat="server" Height="32px" 
                        Text="Enregistrer" />
                </p>
              
          </div>
         
</asp:content>