<%@ Page Title="" Language="C#" MasterPageFile="~/MasterP1.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages.PagesLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
         <table class="contacttable">
        <tr>
            <td>Login:</td>
            <td>
                <asp:TextBox ID="logintxt" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your Username" ControlToValidate="logintxt" ForeColor="OrangeRed"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><b>Password: </b></td>
            <td>
                <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your Password" ControlToValidate="passwordtxt" ForeColor="OrangeRed"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                Don't have an account yet? Register <a href="Register.aspx">Here</a></p>
            </td>
            <td>
                <p>
               <asp:Button ID="loginbtn" runat="server" Text="Login" 
                    onclick="btnLogin_Click" /><br/>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                <br /></p>
            </td>
        </tr>

             </table>

   
</asp:Content>

