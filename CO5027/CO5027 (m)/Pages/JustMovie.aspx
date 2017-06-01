<%@ Page Title="" Language="C#" MasterPageFile="~/MasterP1.master" AutoEventWireup="true" CodeFile="JustMovie.aspx.cs" Inherits="Pages.JustMovie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h2> Welcome to Movies & Co <br/>
        Buying Tickets, Redefined.</h2>
   
   
            <div class="space"></div>
    <h3>Now Showing</h3>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="MovieName" DataValueField="MovieName" Visible="false">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:database %>" SelectCommand="SELECT [MovieName], [AmountMovie], [TotalPrice], [MovieImage] FROM [TblTblMovies]"></asp:SqlDataSource>
         <asp:Label ID="movielabel" runat="server"></asp:Label>
        

</asp:Content>

