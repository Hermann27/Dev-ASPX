<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Master.aspx.vb" Inherits="IUC_Vote.WebForm4" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
       <h2>
       <br /><br />
       <h1><center>Candidature</center></h1><br />
            <br /><asp:GridView ID="GridView1" runat="server" 
               AutoGenerateColumns="False" Width="685px"
    Height="50px" CellPadding="4" BorderColor="Blue" ForeColor="#333333" 
           GridLines="None">
        
        <Columns>
        
            <asp:BoundField DataField="Code" HeaderText="No. " Visible="False" />
            <asp:BoundField DataField="Matricule" HeaderText="Nom" Visible="False" />
            <asp:BoundField DataField="Code_Election" HeaderText="Election" />
            <asp:TemplateField HeaderText="Profile">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%#image(Eval("Matricule"),Eval("Extension")) %>' Height="100px" Width="100px"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Extension" HeaderText="Extension" Visible="False" />
            <asp:BoundField DataField="Nom" HeaderText="Nom" />
            
             <asp:TemplateField>
                    <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Voter" CommandArgument='<%#Eval("Code")%>' CausesValidation="False"> 
                        Voter</asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
             </asp:TemplateField>
            <asp:BoundField DataField="Sondages" HeaderText="Sondages" />
        </Columns>
        
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <EmptyDataTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" />
           </EmptyDataTemplate>
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    </h2> 
  
</asp:Content>
