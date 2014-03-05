<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Teaching.Pages.Power.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>
    <script src="../../Content/js/Utility.js"></script>
    <title>角色列表</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content_title"><span>用户管理</span></div>
        <div style="padding-left: 100px">
            <div style="margin-bottom:4px">
                <a onclick="openDialog('UserAddUpdate.aspx') " href="#"
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
                <asp:Repeater ID="rptUserList" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td title="<%# Eval("UserNo") %>"><%# Eval("UserNo") %></td>
                            <td title="<%# Eval("UserName") %>"><%# Eval("UserName") %></td>
                            <td title="<%# Eval("RoleId") %>"><%# Eval("RoleId") %></td>
                            <td>
                                <a onclick="openDialog('UserAddUpdate.aspx?Id=<%#Eval("Id")%>') " href="#"
                                    title="权限信息详情">
                                    <asp:Button Text="修改" runat="server" CssClass="button" /></a>
                                <asp:Button Text="删除" runat="server" CssClass="button" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
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
