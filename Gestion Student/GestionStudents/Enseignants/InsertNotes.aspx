<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertNotes.aspx.vb" Inherits="GestionStudents.InsertNotes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <div class="content_box" style="position:absolute; top: 342px; left: 515px;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Etudiant" HeaderText="Etudiant" />
            <asp:BoundField DataField="Matiere" HeaderText="Matiere" />
            <asp:TemplateField HeaderText="Trimestre">
                <ItemTemplate><asp:DropDownList ID="DTrim" runat="server">
                </asp:DropDownList></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cc1">
            <ItemTemplate>
                <asp:TextBox ID="TxtCc1" runat="server"></asp:TextBox></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cc2">
                <ItemTemplate>
                    <asp:TextBox ID="TxtCc2" runat="server"></asp:TextBox></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Examen">
            <ItemTemplate>
                <asp:TextBox ID="TxtExam" runat="server"></asp:TextBox></ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    </div>
    
</asp:Content>


