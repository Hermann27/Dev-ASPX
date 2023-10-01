<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Evaluation.aspx.vb" Inherits="GestionStudents.Evaluation1" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div id="DivEval" class="content_box" style="position:absolute; top: 342px; left: 515px;" runat="server">
        
        	<div style="float:left; background-color:Black" id="b" runat="server">
        Vos Impressions :<br />
        <asp:TextBox ID="TxtTexte" runat="server" Width="240px" Height="120px" 
                      TextMode="MultiLine"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TxtCredit" ErrorMessage="Credit Obligatoire" ForeColor="Red" 
                      Visible="False"></asp:RequiredFieldValidator>
        <br />
        <br />
        Enseignant :<br />
        <asp:DropDownList ID="DwEns" runat="server" Height="21px" Width="240px">
        </asp:DropDownList>
                  <br />
                  <br />
                  Mention :<br />
                  <asp:DropDownList ID="DwMention" runat="server" Height="16px" Width="239px">
                  </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnEnr" runat="server" Text="Enregistrer" Width="130px" 
                      CausesValidation="False" />
    </p>
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    
    </div> <!-- end of content -->
</asp:Content>


