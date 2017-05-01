<%@ Page Title="" Language="C#" MasterPageFile="~/masterpagevisitor.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PagesVisitor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="wrapper1">
       <h2> Welcome to Movies & Co <br/>
        Buying Tickets, Redefined.</h2>
    </div>
            <div class="space"></div>
    <h3>Now Showing</h3>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="MovieName" DataValueField="MovieName" Visible="false">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" SelectCommand="SELECT [MovieName], [AmountMovie], [TotalPrice], [MovieImage] FROM [TblMovies]"></asp:SqlDataSource>
         <asp:Label ID="movielabel" runat="server"></asp:Label>
        



</asp:Content>

