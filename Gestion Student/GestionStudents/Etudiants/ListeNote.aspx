<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListeNote.aspx.vb" Inherits="GestionStudents.ListeNote" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div class="content_box" style="position:absolute; top: 342px; left: 515px;">
        
        	
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                 EditIndex="0">
                <Columns>
                
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Prenom" HeaderText="Prenom" />
                    <asp:TemplateField HeaderText="Trimestre">
                        <ItemTemplate><asp:DropDownList runat="server" id="DwTrim">
                        </asp:DropDownList></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cc1">
                    <ItemTemplate><asp:TextBox runat="server" id="TxtCc1">
                        </asp:TextBox></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cc2">
                    <ItemTemplate><asp:TextBox runat="server" id="TxtCc2">
                        </asp:TextBox></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Examen">
                    <ItemTemplate><asp:TextBox runat="server" id="Examen">
                        </asp:TextBox></ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Enregistrer" Width="124px" />
        	
    </div> <!-- end of content -->
</asp:Content>


