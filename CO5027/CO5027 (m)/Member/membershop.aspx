<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPmember.master" AutoEventWireup="true" CodeFile="membershop.aspx.cs" Inherits="Member.MemberShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <asp:Button ID="btnOrder" runat="server" Text="Order!" BackColor="#00ff7f"
        onclick="Order" />
    
     
   <table id="table" class="contacttable">
        
        <tr>
            <td>
                <asp:Label ID="finished" runat="server" Text="Label" Visible="False" ForeColor="#008000"></asp:Label>
    <br />
    <asp:Button ID="confirm" runat="server" Text="Ok" Visible="False" Width="100px" 
        onclick="ConfirmaClick" />
    <asp:Button ID="cancel" runat="server" Text="Cancel" Visible="False" 
        Width="100px" onclick="Cancel" />
    <br />
    <br />
    <asp:Label ID="err" runat="server"></asp:Label>
    <asp:Panel ID="pnlProducts" runat="server">
    </asp:Panel>
    <br />
               </td> 
                </tr>
        </table>
</asp:Content>

