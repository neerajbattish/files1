﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="fileway.aspx.cs" Inherits="WebApplication1.fileway" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:Panel ID="Panel1" Width="100%"  runat="server">
        <table align="center" >
            <tr>
                <td style="width: 726px">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="hdrTTL" style="width: 726px" align="center">
                    Upload</td>
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
                            <td valign="top">
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Button ID="Btnenhance" runat="server" CssClass="btn" Text="Enhanced way" 
                                    Width="136px" Height="31px" onclick="Btnenhance_Click1"  />
                            </td>
                            <td align="center">
                                <asp:Button ID="btnbase" runat="server" CssClass="btn" Text="Base Way" Width="150px"
                                    Height="31px" onclick="btnbase_Click"  />
                            </td>
                            <td align="center">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
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
            <tr>
                <td align="center">
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server"></asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" Runat="Server"></asp:Content>