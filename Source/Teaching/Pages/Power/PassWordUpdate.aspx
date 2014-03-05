<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PassWordUpdate.aspx.cs" Inherits="Teaching.Pages.Power.PassWordUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>修改密码页面</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <style type="text/css">
        span {
            height: 27px;
            padding-top: 10px;
            display: inline-block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" target="_right">
        <div style="padding-left: 100px">
            <div>
                &nbsp;&nbsp;<span>原密码：<asp:TextBox runat="server" TextMode="Password" ID="txtOldPass"></asp:TextBox></span><br />
                &nbsp;&nbsp;<span>新密码：<asp:TextBox runat="server" TextMode="Password" ID="txtNewPass"></asp:TextBox></span><br />
                <span>确认密码：<asp:TextBox runat="server" TextMode="Password" ID="txtConfirmPass"></asp:TextBox></span><br />
            </div>
            <div style="padding: 10px 50px">
                <asp:Button runat="server" Text="确认" CssClass="button" OnClick="Confirm_Button" />&nbsp;
            <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
            </div>
            <asp:Label ID="lblErrorMeg" ClientIDMode="Static" runat="server" CssClass="errorTip" Visible="false" Style="top: -34px;margin-left: 70px;color:red"></asp:Label>

        </div>
    </form>
</body>
</html>
