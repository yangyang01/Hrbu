<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Teaching.Pages.Power.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>
    <script src="../../Content/js/Utility.js"></script>
    <title>用户列表</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content_title"><span>用户管理</span></div>
        <div style="padding-left: 100px">
            <div style="font-size: 18px; height: 27px; margin: 8px">
                用户名：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
                姓名：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
                <asp:Button runat="server" Text="查询" CssClass="button" />
                <a onclick="openDialog('UserAddUp.aspx',500,400) " href="#"
                    title="权限信息详情">
                    <asp:Button Text="添加" runat="server" CssClass="button" />
                </a>
            </div>
            <table class="table" style="border-collapse: collapse">
                <tr class="table_title">
                    <td style="width: 200px">用户名</td>
                    <td style="width: 200px">姓名</td>
                    <td style="width: 200px">用户类型</td>
                    <td style="width: 200px">操&nbsp;作</td>
                </tr>
                <asp:Repeater ID="rptUserList" runat="server" OnItemCommand="repPend_ItemCommand">
                    <ItemTemplate>
                        <tr>
                             <asp:HiddenField ID="hfUserID" runat="server" Value='<%#Eval("User.Id") %>'
                                        ClientIDMode="Static" />
                            <td title="<%# Eval("User.UserNo") %>"><%# Eval("User.UserNo") %></td>
                            <td title="<%# Eval("User.UserName") %>"><%# Eval("User.UserName") %></td>
                            <td title="<%# Eval("RoleName") %>"><%# Eval("RoleName") %></td>
                            <td>
                                <a onclick="openDialog('UserAddUp.aspx?Id=<%#Eval("User.Id") %>',500,400) " href="#"
                                    title="权限信息详情">
                                    <asp:Button Text="修改" runat="server" CssClass="button" /></a>
                                <asp:Button ID="lbtnDetele" Text="删除" runat="server" CssClass="button"  CommandName="Delete"
                                    OnClientClick="if(confirm('是否删除记录？')==false)return false;"></asp:Button>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='8' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr class="page_list">
                    <td colspan='4'>
                        <div class="page_list_menu">
                            <uc1:PagerControl runat="server" ID="PagerControl" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
