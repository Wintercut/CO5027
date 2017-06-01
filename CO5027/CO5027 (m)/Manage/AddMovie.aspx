<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPadmin.master" AutoEventWireup="true" CodeFile="AddMovie.aspx.cs" Inherits="Manage.ManageAddMovie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
        Add new Product</h3>
    <table class="contacttable">
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
                <asp:DropDownList ID="dropdownimageslist" runat="server" Width="300px">
                </asp:DropDownList>
                <br />
                <br/>

                <asp:FileUpload ID="FileUpload1" runat="server" /> 
                <asp:Button ID="btnUploadImage" runat="server" Text="Upload Image" 
                    onclick="UploadsImageClick" CausesValidation="False" /> 
            </td>
            
        </tr>
        <tr>
            <td style="width: 80px">
                Movie Description:
            </td>
            <td>
                <asp:TextBox ID="movietxt" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="movietxt" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Font-Size="Larger" Text="Save" onclick="Save" />
                
            </td>
            <td>
                <asp:Label ID="result" runat="server" Text=""></asp:Label>
    
            </td>
        </tr>
    </table>

</asp:Content>

