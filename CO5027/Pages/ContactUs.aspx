<%@ Page Title="" Language="C#" MasterPageFile="~/masterpagevisitor.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Pages_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="lblMsg" runat="server"></asp:Label>


            

<table id="table" class="contacttable">

     <tr>
            <td colspan="2">

                <h3>Contact Us</h3>
                
            </td>

        </tr>
        <tr>
            <td>
                <span id="namelabel" style="font-weight:bold;">Email:</span>
            </td>
            <td>
                <asp:textbox ID="theboxname" runat="server"  Width="260px"></asp:textbox><br />
                <asp:RequiredFieldValidator ID="rfv2" runat="server" ErrorMessage="Please enter an existing email addess" ControlToValidate="theboxname" ValidationExpression="\w+(\w+)*@\w+(\w+)*\.\w+(\w+)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <span id="subjectlabel" style="font-weight:bold;">Subject:</span><br />
            </td>
            <td>
                <asp:dropdownlist id="thesubjectbox" runat="server" Width="265px">
                    <asp:ListItem text="Pick a subject" value="-1"></asp:ListItem>
	                <asp:listitem text="Asking questions" value="Asking questions"></asp:listitem>
	                <asp:listitem text="Customer support ticket" value="Customer support ticket"></asp:listitem>
	                <asp:listitem text="Other" value="Other"></asp:listitem>
                </asp:dropdownlist>
                <asp:RequiredFieldValidator ID="rfv3" InitialValue="-1" runat="server" ErrorMessage="Please state your subject" ControlToValidate="thesubjectbox" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </tr>
<tr>
        <td>
            <span id="ctl00_ContentPlaceHolder1_Label4" style="font-weight:bold;">Message:</span>
        </td>
        <td>
            <asp:textbox ID="mailbody" runat="server" Rows="2" Columns="30" Height="200px" Width="260px"></asp:textbox>
            <asp:RequiredFieldValidator ID="rfv4" runat="server" ErrorMessage="Please tell us your request" ControlToValidate="mailbody" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <br />
           <asp:button ID="btnsave" runat="server" text="Submit" OnClick="sendmessagebtn" OnClientClick="" />
            <input type="reset" name="Reset" value="reset." /><br />
            Want to know where we are? Click <a href="map.aspx">Here</a>
            <br />           
       </td>
        <td>

        </td>
    </tr>

    </table>

      <div id="map" ></div>
    <script>
      var map;
      function initMap() {
        map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 4.868742, lng: 114.850850 },
          zoom: 8
        });
        var marker = new google.maps.Marker({
            position: { lat: 4.868742, lng: 114.850850 },
            map: map,
            title: 'We are here!'
        });
    }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCu8JXsOjlXgVyqLZCxsfiuC7GYT4t2aYw&callback=initMap" async defer></script>
</asp:Content>

