<%@ Page Title="" Language="C#" MasterPageFile="~/masterpagevisitor.master" AutoEventWireup="true" CodeFile="Addproducts.aspx.cs" Inherits="Pages_Addproducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h3>
        Add new Product</h3>
    <table class="productTable">
        <tr>
            <td style="width: 80px">
                <b>Movie Title: </b>
            </td>
            <td>
                <asp:TextBox ID="movieNametxt" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV1" runat="server" 
                    ControlToValidate="movieNametxt" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">
                <b>Ticket Quantity: </b>
            </td>
            <td>
                <asp:TextBox ID="amountMovietxt" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV2" runat="server" 
                    ControlToValidate="amountMovietxt" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">
                <b>Ticket-Price:</b>
            </td>
            <td>
                <asp:TextBox ID="totalPricetxt" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV3" runat="server" 
                    ControlToValidate="totalPricetxt" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 80px">
                <b>Movie Image:</b>
            </td>
            <td>
                <asp:DropDownList ID="ddlImage" runat="server" Width="300px">
                </asp:DropDownList>
                <br/>

                <asp:FileUpload ID="FileUpload1" runat="server" /> 
                <asp:Button ID="btnUploadImage" runat="server" Text="Upload Image" 
                    onclick="btnUploadImage_Click" CausesValidation="False" /> 
            </td>
            
        </tr>
    </table>
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />

</asp:Content>

