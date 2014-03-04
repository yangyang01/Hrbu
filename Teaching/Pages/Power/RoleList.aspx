<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleList.aspx.cs" Inherits="Teaching.Pages.Power.RoleList" %>

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
        <div class="content_title"><span>权限维护</span></div>
        <div style="padding-left: 100px">
            <table class="table" style="border-collapse: collapse">
                <tr class="table_title">
                    <td style="width: 200px">角色名称</td>
                    <td style="width: 200px">描述</td>
                    <td style="width: 200px">操作选项</td>
                </tr>
                <asp:Repeater ID="rptRoleList" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td title="<%# Eval("roleName") %>"><%# Eval("roleName") %></td>
                            <td title="<%# Eval("describe") %>"><%# Eval("describe") %></td>
                            <td>
                                <a onclick="openDialog('MenuDetail.aspx?Id=<%#Eval("Id")%>') " href="#"
                                    title="权限信息详情">
                                    <asp:Button Text="权限修改" runat="server" CssClass="button" /></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr class="page_list">
                    <td colspan='3'>
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
