<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="userlist.aspx.cs" Inherits="WebApplication1.Admin.userlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<table >
    <tr>
    <td colspan="2" align="center" class="hdrTTL">List Of Users
    </td>
    </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="20"
                    Width="563px" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True"
                    Height="142px">
                    <Columns>
                        <asp:TemplateField HeaderText="S.No">
                            <ItemTemplate>
                                <%# Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Users Name" DataField="r_fname" />
                         <asp:BoundField HeaderText="No. Of Files" DataField="tot" />
                        <asp:TemplateField HeaderText="View Detail">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("~/admin/userfile.aspx?R_Id={0}",
                    HttpUtility.UrlEncode(Eval("R_Id").ToString())) %>' Text="Details" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                        NextPageText="Next" PreviousPageText="Previous" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" Runat="Server">
</asp:Content>

