<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataAddUp.aspx.cs" Inherits="Teaching.Pages.Power.DataAddUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <title>数据字典添加修改页面</title>
</head>
<body>
    <form id="form1"  runat="server">
        <div style="margin-top:10px">
            <span class="list">数据项：<asp:TextBox ID="txtDataName" runat="server" CssClass="txt"></asp:TextBox></span>
            <span>
                <asp:Button runat="server" ID="btnSbmit" Text="提交" CssClass="button" OnClick="btClickSubmit"/>
                <asp:Button runat="server" UseSubmitBehavior="false" ID="btnReturn" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
            </span>
        </div>
    </form>
</body>
</html>
