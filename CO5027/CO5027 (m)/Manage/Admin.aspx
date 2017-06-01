<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPadmin.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Manage_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <table class="contacttable">
        <tr>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MoviePeopleID" DataSourceID="sds" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="MoviePeopleID" HeaderText="MoviePeopleID" ReadOnly="True" SortExpression="MoviePeopleID" />
            <asp:BoundField DataField="LoginUsername" HeaderText="LoginUsername" SortExpression="LoginUsername" />
            <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserPasscode" HeaderText="UserPasscode" SortExpression="UserPasscode" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sds" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" SelectCommand="SELECT * FROM [TblMoviePeople]" DeleteCommand="DELETE FROM [TblMoviePeople] WHERE [MoviePeopleID] = @MoviePeopleID" InsertCommand="INSERT INTO [TblMoviePeople] ([MoviePeopleID], [LoginUsername], [UserEmail], [UserPasscode]) VALUES (@MoviePeopleID, @LoginUsername, @UserEmail, @UserPasscode)" UpdateCommand="UPDATE [TblMoviePeople] SET [LoginUsername] = @LoginUsername, [UserEmail] = @UserEmail, [UserPasscode] = @UserPasscode WHERE [MoviePeopleID] = @MoviePeopleID">
        <DeleteParameters>
            <asp:Parameter Name="MoviePeopleID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="MoviePeopleID" Type="String" />
            <asp:Parameter Name="LoginUsername" Type="String" />
            <asp:Parameter Name="UserEmail" Type="String" />
            <asp:Parameter Name="UserPasscode" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="LoginUsername" Type="String" />
            <asp:Parameter Name="UserEmail" Type="String" />
            <asp:Parameter Name="UserPasscode" Type="String" />
            <asp:Parameter Name="MoviePeopleID" Type="String" />
        </UpdateParameters>
            </asp:SqlDataSource>
    
        </tr>
    </table>
  
</asp:Content>

