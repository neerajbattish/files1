<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Searchfile.aspx.cs" Inherits="WebApplication1.Searchfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 203px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="Server">
    <table width="100%">
        <tr>
            <td colspan="2">
            </td>
            
        </tr>
        <tr>
            <td colspan="2" align="center">
            <asp:Label ID="lblhead" runat="server" Text="Searching" 
                    style="font-size: x-large; font-weight: 700; font-style: italic; font-family: 'Courier New'; color: #0000FF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr align="center">
            <td align="right" class="style1">
                Enter Word
            </td>
            <td align="left">
                <asp:TextBox ID="txtserch" runat="server" Width="254px"></asp:TextBox>
            </td>
        </tr>
        <tr align="center">
            <td colspan="2">
                <asp:Button ID="btnserch" runat="server" Text="Search" OnClick="btnserch_Click" Width="164px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <br />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:GridView ID="grdjob" runat="server" AutoGenerateColumns="False" PageSize="20"
                    Height="142px" Width="535px">
                    <Columns>
                        <asp:TemplateField HeaderText="S.No">
                            <ItemTemplate>
                                <%# Container.DataItemIndex +1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="File Name">
                            <ItemTemplate>
                                <asp:Label ID="lbljobty" runat="server" Text='<%# Eval("UP_FileName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="File Description">
                            <ItemTemplate>
                                <asp:Label ID="lbldecp" runat="server" Text='<%# Eval("UP_Discription") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
        <td>
        <br />
        </td>
        </tr>
        <tr>
        <td>
       
        <asp:TextBox ID="richTextBox1" runat="server" lines="String[] Array" 
                Visible="False"></asp:TextBox>
            <asp:CheckBox ID="CheckBox1" runat="server" Visible="False" />
        </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="AfterBody" runat="Server">
</asp:Content>

