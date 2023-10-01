<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertFile.aspx.vb" Inherits="GestionStudents.InsertFile" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div id="Div1" class="content_box" style="position:absolute; top: 342px; left: 515px;" runat="server">
        
        	<div style="float:left; background-color:Black" id="b" runat="server">
              <p>
        Intitulé :<br />
        <asp:TextBox ID="TxtIntitule" runat="server" Width="215px"></asp:TextBox>
        <br />
        <br />
        Credit :<br />
        <asp:TextBox ID="TxtCredit" runat="server" Width="215px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TxtCredit" ErrorMessage="Credit Obligatoire" ForeColor="Red" 
                      Visible="False"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enseignant :<br />
        <asp:DropDownList ID="DwEns" runat="server" Height="23px" Width="215px">
        </asp:DropDownList>
        <br />
        <br />
        Plan du cours :<br />
        <asp:FileUpload ID="FileMatiere" runat="server" />
        <br />
        <br />
        <asp:Button ID="BtnEnr" runat="server" Text="Enregistrer" Width="130px" 
                      CausesValidation="False" />
    </p>
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    
    </div> <!-- end of content -->

   
</asp:Content>


