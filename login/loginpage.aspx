<%@ Page Title="" Language="C#" MasterPageFile="~/login/loginmaster.Master" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="WebApplication1.login.loginpage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <div>
        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td class="hdrTTL" align="center">
                    Login
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td valign="top" align="center">
                    <table border="0" cellpadding="4" cellspacing="0">
                        <tr>
                            <td>
                                User Name
                            </td>
                            <td>
                                <asp:TextBox ID="txtuseridname" runat="server" CssClass="box" Width="168px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                                    ControlToValidate="txtuseridname" ValidationGroup="login"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Password
                            </td>
                            <td>
                                <asp:TextBox ID="txtpassword" runat="server" CssClass="box" TextMode="Password" 
                                    Width="167px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                                    ControlToValidate="txtpassword" ValidationGroup="login"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                User Group
                            </td>
                            <td align="left">
                                <asp:RadioButtonList ID="RadioButton1" runat="server" RepeatDirection="Horizontal"
                                    Width="243px">
                                    <asp:ListItem Text="Admin" Value="A">
                                    </asp:ListItem>
                                    <asp:ListItem Text="User" Value="U">
                                    </asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td style="font-size: 12px;">
                                <%-- <a class="fancybox" id="linkforgot" href="#inline" style="text-decoration: none;">Forgot Password?</a>--%>
                                <%--<asp:HyperLink ID="linkforgot" class="fancybox" runat="server">Forgot Password?</asp:HyperLink>--%>
                                <asp:LinkButton ID="lnkUpdate" ForeColor="#0000ff" Font-Bold="true" Font-Underline="true"
                                    Font-Size="12px" runat="server" OnClick="lnkUpdate_Click">Forget Password?</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 10px; font-style: italic;" colspan="2">
                                Not registered yet? <a href="Register.aspx" style="text-decoration: none;">Click Here</a>
                                to register
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <asp:Button ID="lbtnlogin" runat="server" CssClass="btn" Text="Login" Height="23px"
                                    OnClick="lbtnlogin_Click" Width="77px" />
                                <%--<asp:LinkButton ID="lbtnlogin" runat="server" CssClass="btn" ValidationGroup="login"
                                        >Login</asp:LinkButton>--%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    <asp:Panel ID="Panel1" runat="server" CssClass="modalPanel" Style="display: none"
        Width="160%">
        <asp:Panel ID="Panel2" runat="server" Style="width: 130; cursor: move;">
            <table width="100%">
                <tr>
                    <td align="right">
                        <asp:Button ID="btnCancel" CssClass="button" runat="server" Text="[ X ]" />
                    </td>
                </tr>
                <tr>
                    <td class="hdrTTL">
                        Forgot Password
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="font-size: 12px;">
                        Please Enter your userid
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <table>
            <tr>
                <td>
                    <strong>UserID:-</strong>
                </td>
                <td>
                    <asp:TextBox ID="txtforgrtid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <div class="getplanbtn">
                        <asp:Button ID="lbtnforgetpass" OnClick="lbtnforgetpass_Click" runat="server" Text="Submit" />
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:ModalPopupExtender BackgroundCssClass="modalBg" DropShadow="true" ID="ModalPopupExtender1"
        PopupControlID="Panel1" runat="server" TargetControlID="lnkUpdate" PopupDragHandleControlID="Panel2"
        CancelControlID="btnCancel">
    </asp:ModalPopupExtender>
    <div class="clear">
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" runat="Server">
</asp:Content>

