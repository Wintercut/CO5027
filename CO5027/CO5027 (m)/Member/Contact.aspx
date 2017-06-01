<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPmember.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Member.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblMsg" runat="server"></asp:Label>

<table id="table" class="contacttable">

     <tr>
            <td colspan="1" style="width: 146px">

                <h3>Contact form</h3> 
                
            </td>

        </tr>
    <tr>
        <td style="width: 146px"> 
                <span id="namelabel1" style="font-weight:bold;">Name:</span>
        
        </td>
        <td>
            <asp:textbox ID="thenamebox" runat="server"  Width="260px"></asp:textbox><br />
            <asp:RequiredFieldValidator ID="RFD4" runat="server" ErrorMessage="Please enter a Name" ControlToValidate="thenamebox" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr>
            <td style="width: 146px">
                <span id="namelabel" style="font-weight:bold;">Email:</span>
            </td>
            <td>
                <asp:textbox ID="SmsTextBox" runat="server"  Width="260px"></asp:textbox><br />
                <asp:RequiredFieldValidator ID="rfv2" runat="server" ErrorMessage="Please enter an existing SmsTextBox addess" ControlToValidate="SmsTextBox" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REV1" runat="server" ErrorMessage="Incorrect Email Format" ControlToValidate="SmsTextBox" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"> </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                <span id="subjectlabel" style="font-weight:bold;">Subject:</span><br />
            </td>
            <td>
                <asp:dropdownlist id="thesubjectbox" runat="server" Width="265px">
                    <asp:ListItem text="------pick a subject-----" value="-1"></asp:ListItem>
	                <asp:listitem text="Asking questions" value="Asking questions"></asp:listitem>
	                <asp:listitem text="Customer support ticket" value="Customer support ticket"></asp:listitem>
	                <asp:listitem text="Other" value="Other"></asp:listitem>
                    
                </asp:dropdownlist>
                <asp:RequiredFieldValidator ID="rfv3" InitialValue="-1" runat="server" ErrorMessage="Please state your subject" ControlToValidate="thesubjectbox" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </tr>
<tr>
        <td style="width: 146px">
            <span id="ctl00_ContentPlaceHolder1_Label4" style="font-weight:bold;">Message:</span>
        </td>
        <td>
            <asp:textbox ID="information" runat="server" Rows="2" Columns="30" Height="200px" Width="260px"></asp:textbox>
            <asp:RequiredFieldValidator ID="rfv4" runat="server" ErrorMessage="Please tell us your request" ControlToValidate="information" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>

    </tr>
    <tr>
        <td style="width: 146px">
            <br />
           

            <br />        
       </td>
        <td>
          <asp:button ID="btnsave" runat="server" text="Submit" OnClick="Uploademailmessg" OnClientClick="" />
            <input type="reset" name="Reset" value="reset." /><br /><p>
                
                
        </td>
    </tr>

    </table>

      
</asp:Content>

