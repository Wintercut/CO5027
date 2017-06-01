<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPadmin.master" AutoEventWireup="true" CodeFile="Movie.aspx.cs" Inherits="Manage_Movie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="MovieID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="MovieID" HeaderText="MovieID" ReadOnly="True" SortExpression="MovieID" />
            <asp:BoundField DataField="MovieName" HeaderText="MovieName" SortExpression="MovieName" />
            <asp:BoundField DataField="AmountMovie" HeaderText="AmountMovie" SortExpression="AmountMovie" />
            <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
            <asp:BoundField DataField="MovieImage" HeaderText="MovieImage" SortExpression="MovieImage" />
            <asp:BoundField DataField="MovieText" HeaderText="MovieText" SortExpression="MovieText" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" DeleteCommand="DELETE FROM [TblMovies] WHERE [MovieID] = @MovieID" InsertCommand="INSERT INTO [TblMovies] ([MovieID], [MovieName], [AmountMovie], [TotalPrice], [MovieImage], [MovieText]) VALUES (@MovieID, @MovieName, @AmountMovie, @TotalPrice, @MovieImage, @MovieText)" SelectCommand="SELECT * FROM [TblMovies]" UpdateCommand="UPDATE [TblMovies] SET [MovieName] = @MovieName, [AmountMovie] = @AmountMovie, [TotalPrice] = @TotalPrice, [MovieImage] = @MovieImage, [MovieText] = @MovieText WHERE [MovieID] = @MovieID">
        <DeleteParameters>
            <asp:Parameter Name="MovieID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="MovieID" Type="String" />
            <asp:Parameter Name="MovieName" Type="String" />
            <asp:Parameter Name="AmountMovie" Type="String" />
            <asp:Parameter Name="TotalPrice" Type="Double" />
            <asp:Parameter Name="MovieImage" Type="String" />
            <asp:Parameter Name="MovieText" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="MovieName" Type="String" />
            <asp:Parameter Name="AmountMovie" Type="String" />
            <asp:Parameter Name="TotalPrice" Type="Double" />
            <asp:Parameter Name="MovieImage" Type="String" />
            <asp:Parameter Name="MovieText" Type="String" />
            <asp:Parameter Name="MovieID" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

