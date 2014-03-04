<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataAddUp.aspx.cs" Inherits="Teaching.Pages.Power.DataAddUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <title>数据字典添加修改页面</title>
</head>
<body>
    <form id="form1"  runat="server" target="_right">
        <div style="margin-top:10px">
            <span class="list">数据项：<asp:TextBox ID="txtDataName" runat="server" CssClass="txt"></asp:TextBox></span>
            <span>
                <asp:Button runat="server" Text="提交" ClientIDMode="Static" CssClass="button" OnClick="btSure_Click" />
                <asp:Button runat="server" Text="返回" ClientIDMode="Static" CssClass="button" OnClientClick="window.close();return false;" />
            </span>
        </div>
    </form>
</body>
</html>
