<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultNotes.aspx.vb" Inherits="GestionStudents.ConsultNotes" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div class="content_box" style="position:absolute; top: 342px; left: 515px;">
        
        <asp:MultiView ID="MVMatiere" runat="server" ActiveViewIndex="0">
 
           <asp:View ID="Viewlist" runat="server">
               <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True" Font-Italic="True">Liste 
              des Matieres </asp:Label>               <br />
                <br />
                <br />
             <asp:GridView ID="Gdv" runat="server" AutoGenerateColumns="False" 
                CellPadding="3" Width="449px" 
                  BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" 
                  BorderStyle="None" CellSpacing="2">
                 <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <Columns>
                    <asp:BoundField DataField="Intitule" HeaderText="Intitule" />
            
                    <asp:BoundField DataField="Credit" HeaderText="Crédit" />
                    <asp:BoundField DataField="Plan_Cour" HeaderText="Plan du Cour" />
                    <asp:BoundField  HeaderText="Enseignant" DataField="Id_Enseignant" />
                    <asp:CommandField SelectText="Selectionner" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <PagerStyle ForeColor="#8C4510" 
                     HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" ForeColor="White" 
                     HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        
           </asp:View>

           <asp:View ID="View1" runat="server">

             <center><asp:GridView ID="GDV1" runat="server" AutoGenerateColumns="False" 
                     CellPadding="4" ForeColor="#333333" GridLines="None" Width="90%" 
                 >
                 <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Matricule" HeaderText="Matricule" />
                    <asp:BoundField DataField="Nom" HeaderText="Nom" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Prenom" HeaderText="Prenom" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Cc1" HeaderText="Cc1" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Cc2" HeaderText="Cc2" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Exam" HeaderText="Examen" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Trimestre" HeaderText="Trimestre" >
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                </Columns>
                 <EditRowStyle BackColor="#2461BF" />
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#507CD1" BorderColor="Red" Font-Bold="True" 
                     ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#EFF3FB" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor="#F5F7FB" />
                 <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                 <SortedDescendingCellStyle BackColor="#E9EBEF" />
                 <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView></center>

        	</asp:View> 

            

            </asp:MultiView> 
    </div> <!-- end of content -->
</asp:Content>


