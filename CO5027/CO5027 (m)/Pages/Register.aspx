<%@ Page Title="" Language="C#" MasterPageFile="~/MasterP1.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table class="contacttable">
        <tr>
            <td style="font-weight: 700">Name: </td>
            <td>
                <asp:TextBox ID="nametxt" runat="server" Width="40%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your Username" ControlToValidate="nametxt" ForeColor="OrangeRed"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-weight: 700">Password: </td>
            <td>
                <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password" Width="40%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your Password" ControlToValidate="passwordtxt" ForeColor="OrangeRed"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-weight: 700">Confirm Password: </td>
            <td>
                <asp:TextBox ID="passwordcfrm" runat="server" TextMode="Password" Width="40%"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="passwordtxt" ControlToValidate="passwordcfrm" ErrorMessage="Passwords must match" Font-Bold="True" ForeColor="OrangeRed"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="font-weight: 700">E-mail: </td>
            <td>
                <asp:TextBox ID="emailtxt" runat="server" Width="40%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please an existing Email Address" ControlToValidate="emailtxt" ForeColor="OrangeRed"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <br/>
                <asp:Button ID="btnRegister" runat="server" Text="Register" 
                    onclick="btnRegister_Click" />
                <br />
                
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

