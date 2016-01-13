<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="userfile.aspx.cs" Inherits="WebApplication1.Admin.userfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="0" style="margin-left: 40px;
        font-size: 12px; height: 100%;">
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td class="hdrTTL" align="center">
                Base Upload Files
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                    OnPageIndexChanging="GridView1_PageIndexChanging" Width="554px">
                    <Columns>
                        <asp:TemplateField HeaderText="S.No">
                            <ItemTemplate>
                                <%# Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="File Name" DataField="UP_FileName" />
                        <asp:BoundField HeaderText="File Description" DataField="UP_Discription" />
                    </Columns>
                    <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                        NextPageText="Next" PreviousPageText="Previous" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="center">
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="hdrTTL" align="center">
                Advance Upload Files
            </td>
        </tr>
        <tr>
            <td valign="top">
                </br>
                <br />
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="554px"
                    AllowPaging="True" Height="142px" OnPageIndexChanging="GridView2_PageIndexChanging">
                    <Columns>
                        <asp:TemplateField HeaderText="S.No">
                            <ItemTemplate>
                                <%# Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="File Name" DataField="UP_FileName" />
                        <asp:BoundField HeaderText="File Description" DataField="UP_Discription" />
                    </Columns>
                    <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                        NextPageText="Next" PreviousPageText="Previous" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td valign="top">
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Literal ID="Literal1" runat="server" Visible="false"></asp:Literal>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" runat="Server">
</asp:Content>
