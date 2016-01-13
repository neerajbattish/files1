<%@ Page Title="" Language="C#" MasterPageFile="~/login/loginmaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.login.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <div align="right" class="getplanbtn">
        <a href="loginpage.aspx" style="text-decoration: none;">Login</a></div>
    <table border="0" align="center" cellpadding="0" cellspacing="0" style="height: 471px;
        width: 721px;">
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="2" align="center">
                Sign Up
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style17">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style10">
                Name
            </td>
            <td class="style6">
                <asp:TextBox ID="txtusername" runat="server" CssClass="box" Width="252px" TabIndex="1"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                User Group
            </td>
            <td align="left">
                <asp:RadioButtonList ID="RadioButton1" runat="server" 
                    RepeatDirection="Horizontal" Width="243px">
                    <asp:ListItem Text="Admin" Value="A">
                    </asp:ListItem>
                    <asp:ListItem Text="User" Value="U">
                    </asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style10">
                UserID
            </td>
            <td class="style6">
                <asp:TextBox ID="txtuseridname" runat="server" CssClass="box" Width="252px" OnTextChanged="txtuseridname_TextChanged"
                    AutoPostBack="True" TabIndex="4"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        runat="server" ErrorMessage="*" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Password
            </td>
            <td class="style4">
                <asp:TextBox ID="txtpassword" runat="server" CssClass="box" Width="251px" TextMode="Password"
                    TabIndex="5"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                    ControlToValidate="txtpassword"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                        ID="RegExp1" runat="server" Style="color: red;" ErrorMessage="Must be between 6 to 10 characters"
                        ControlToValidate="txtpassword" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{6,10}$" />
            </td>
        </tr>
        <tr>
            <td class="style12">
                Re-Password
            </td>
            <td class="style4">
                <asp:TextBox ID="txtrepasswrd" runat="server" CssClass="box" Width="251px" TextMode="Password"
                    TabIndex="6"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                    ControlToValidate="txtrepasswrd"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="Cv1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtrepasswrd"
                    ErrorMessage="Password not Matched" Style="color: #FF0000"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style13">
                Email Address
            </td>
            <td class="style2">
                <asp:TextBox ID="txtemail" runat="server" CssClass="box" Width="290px" AutoPostBack="True"
                    TabIndex="7"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                    ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtemail">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;
            </td>
            <td style="font-size: 10px; font-style: italic;">
                <asp:CheckBox ID="CheckBox1" Checked="true" runat="server" />
                Clicking tick the box, I am agreeing to the Terms of Service and Privacy Policy
            </td>
        </tr>
        <tr>
            <td class="style1">
            </td>
            <td>
                <div class="loginbtn">
                    <asp:LinkButton ID="lbsignup" runat="server" CssClass="getplanbtn" OnClick="lbsignup_Click"
                        TabIndex="8">Create My Account</asp:LinkButton>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style9">
            </td>
            <td>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" runat="Server">
</asp:Content>