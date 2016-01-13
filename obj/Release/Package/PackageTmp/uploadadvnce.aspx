<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="uploadadvnce.aspx.cs" Inherits="WebApplication1.uploadadvnce" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">

<style type="text/css">
        .button
        {
            border: solid 1px #c0c0c0;
            background-color: #eeeeee;
            font-family: verdana;
            font-size: 11px;
        }
        
        .modalBg
        {
            background-color: #cccccc;
            filter: alpha(opacity=80);
            opacity: 0.8;
        }
        
        .modalPanel
        {
            background-color: #ffffff;
            border-width: 3px;
            border-style: solid;
            border-color: Gray;
            padding: 3px;
            width: 320px;
        }
    </style>
    <div class="clear">
    </div>
    <div id="midcont">
        <div id="rightbx">
            <table width="800" border="0" cellspacing="0" cellpadding="0" style="margin-left: 40px;">
                <tr>
                    <td style="width: 726px">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td  style="width: 726px" align="center">
                      <h1 style="text-align: left">Upload Files</h1>  
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td valign="top" style="width: 726px" align="center">
                        <table width="582" border="0" cellpadding="4" cellspacing="0">
                            <tr>
                                <td valign="top" style="width: 132px">
                                    Upload File
                                </td>
                                <td width="362" valign="top">
                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="box" Width="284px" TabIndex="1" />
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="width: 132px">
                                    File Name
                                </td>
                                <td width="362" valign="top">
                                    <asp:TextBox ID="txtfilename" runat="server" CssClass="box" Width="168px" TabIndex="2"
                                        autocomplete="off"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                                        ControlToValidate="txtfilename"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <%--<tr>
                                <td style="width: 132px; height: 35px;">
                                    File Type
                                </td>
                                <td style="height: 35px">
                                    &nbsp;<asp:DropDownList ID="cmbfiletype" runat="server" Height="16px" Width="165px" TabIndex="3">
                                    </asp:DropDownList>
                                </td>
                            </tr>--%>
                           <%-- <tr>
                                <td valign="top" style="width: 132px">
                                    Unique Signature</td>
                                <td width="362" valign="top">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="box" Width="168px" TabIndex="2"
                                        autocomplete="off"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                        ControlToValidate="txtfilename"></asp:RequiredFieldValidator>
                                </td>
                            </tr>--%>
                            <tr>
                                <td style="width: 132px">
                                    File Discription
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdiscptn" runat="server" CssClass="box" Height="54px" TextMode="MultiLine"
                                        Width="296px" TabIndex="4"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    Comment
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcommnt" runat="server" CssClass="box" Height="51px" TextMode="MultiLine"
                                        Width="294px" TabIndex="5"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Button ID="btnkey" runat="server" CssClass="btn" Text="Upload" Width="122px"
                                        Height="25px"  TabIndex="6" onclick="btnkey_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    &nbsp;
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    &nbsp;
                                </td>
                                <td>
                                    <div class="loginbtn">
                                        </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 132px">
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Literal ID="LTRPRIKEY" runat="server" Visible="False"></asp:Literal>
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
    </div>
   
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" Runat="Server">
</asp:Content>

