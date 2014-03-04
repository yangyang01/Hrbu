<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleAddUpdate.aspx.cs" Inherits="Teaching.Pages.Power.RoleAddUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <style type="text/css">
        .txt {
            height: 27px;
            border: 2px solid gray;
        }

        span {
            margin-left: 20px;
        }

        .list {
            display: inline-block;
        }
    </style>
    <title>修改添加角色页面</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="list">角色信息：<asp:TextBox ID="txtRoleName" runat="server" CssClass="txt"></asp:TextBox></span>
            <span class="list">描述信息：<asp:TextBox ID="txtDescribe" runat="server" CssClass="txt"></asp:TextBox></span>

            <span>
                <asp:Button runat="server" Text="提交" CssClass="button" />
                <asp:Button runat="server" Text="返回" CssClass="button" />
            </span>
        </div>
        <asp:PlaceHolder ID="phIsCode" runat="server">
            <table class="table" style="width: 680px; margin: 20px;border-collapse:collapse">
                <tr class="table_title">
                    <td>用户名
                    </td>
                    <td>用户姓名
                    </td>
                    <td>操&nbsp;&nbsp;作
                    </td>
                </tr>
                <tr>
                    <td>10031216</td>
                    <td>刘洋</td>
                    <td>
                        <asp:Button runat="server" Text="删除" CssClass="button" /></td>
                </tr>
            </table>
            <span class="list">&nbsp;&nbsp;用户名：<asp:TextBox ID="txtUserNo" runat="server" CssClass="txt"></asp:TextBox></span><br />
            <span class="list">用户姓名：<asp:TextBox ID="txtUserName" runat="server" CssClass="txt"></asp:TextBox></span>&nbsp;&nbsp;&nbsp;<asp:Button runat="server" Text="添加" CssClass="button" />
        </asp:PlaceHolder>
    </form>
</body>
</html>
