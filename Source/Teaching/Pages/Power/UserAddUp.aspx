﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAddUp.aspx.cs" Inherits="Teaching.Pages.Power.UserAddUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <title>用户添加修改页面</title>
</head>
<body>
    <form id="form1" runat="server" target="_right">
        <div style="margin-top: 30px">
            <div style="height:35px">
                <span class="list">用户名：<asp:TextBox ID="txtUserNo" runat="server" CssClass="txt"></asp:TextBox></span>
                <span class="list">姓&nbsp;名：<asp:TextBox ID="txtUserName" runat="server" CssClass="txt"></asp:TextBox></span>
            </div>
            <div style="height:45px">
                <span class="list">密&nbsp;&nbsp;码：<asp:TextBox ID="txtPassword" runat="server" CssClass="txt"></asp:TextBox></span>
                <span class="list">角&nbsp;色：<asp:TextBox ID="txt" runat="server" CssClass="txt"></asp:TextBox></span>
            </div>
            <div style="margin-left:285px">
                <span>
                    <asp:Button runat="server" Text="提交" ClientIDMode="Static" CssClass="button" />
                    <asp:Button runat="server" Text="返回" ClientIDMode="Static" CssClass="button" OnClientClick="window.close();return false;" />
                </span>
            </div>
        </div>
    </form>
</body>
</html>