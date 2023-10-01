<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Souscrir.aspx.vb" Inherits="IUC_Vote.WebForm3" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="templatemo_middle_column">
            	
            	<br /><br />
       <h1><center>Enregistrement Candidat</center></h1><br /><br />
                <p> Matricule :<br />
                        <asp:DropDownList ID="DDList1" runat="server" Font-Size="Smaller" Height="20px" 
                            Width="150px">
                        </asp:DropDownList>
                    <br />
                   
                    <br />
                    Election :<br />
                        <asp:DropDownList ID="DDList2" runat="server" Font-Size="Smaller" Height="20px" 
                            Width="150px">
                        </asp:DropDownList>
                    <br />
                    Photo :<br />
                    <asp:FileUpload ID="FilePhoto" runat="server" />
                    &nbsp;
                    <asp:Image ID="ImgPhoto" runat="server" Height="90px" ImageAlign="AbsMiddle" 
                        Width="150px" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="BtnEnre" runat="server" Text="Save" Width="64px" 
                        Height="32px" />
                
          </div>

</asp:Content>
