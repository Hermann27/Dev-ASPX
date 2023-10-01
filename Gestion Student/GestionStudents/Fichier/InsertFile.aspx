<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertFile.aspx.vb" Inherits="GestionStudents.InsertFile1" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div id="DivEval" class="content_box" style="position:absolute; top: 342px; left: 515px;" runat="server">
        
        	<div style="float:left; background-color:Black" id="b" runat="server">
                Nom :<br />
                <asp:TextBox ID="TxtNom" runat="server" Width="219px"></asp:TextBox>
                <br />
                <br />
                Niveau :<br />
                <asp:TextBox ID="TxtNiveau" runat="server" Width="219px"></asp:TextBox>
                <br />
                <br />
                Année :<br />
                <asp:TextBox ID="TxtAnnee" runat="server" Width="219px"></asp:TextBox>
                <br />
                <br />
                Epreuve :<br />
                <asp:FileUpload ID="FileEpreuve" runat="server" Height="21px" Width="219px" />
                <br />
                <br />
                Corrigé :<br />
                <asp:FileUpload ID="FileCorrige" runat="server" />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TxtCredit" ErrorMessage="Credit Obligatoire" ForeColor="Red" 
                      Visible="False"></asp:RequiredFieldValidator>
        <br />
        <br />
                Spécialité :<br />
        <asp:DropDownList ID="DwSpecialite" runat="server" Height="16px" Width="219px">
        </asp:DropDownList>
                  <br />
        <br />
        <br />
        <asp:Button ID="BtnEnr" runat="server" Text="Enregistrer" Width="130px" 
                      CausesValidation="False" />
    </p>
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    
    </div> <!-- end of content -->
</asp:Content>


