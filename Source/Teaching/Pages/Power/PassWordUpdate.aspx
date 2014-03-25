<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PassWordUpdate.aspx.cs" Inherits="Teaching.Pages.Power.PassWordUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>修改密码页面</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
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
            <div class="e">
                &nbsp;&nbsp;<span class="login_txt">原密码：<asp:TextBox TextMode="Password" ID="txtOldPass" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvPassword" class="errorTipPass" style="display: none; color: red;">请输入原密码！</span>
            </div>
            <div class="e">
                &nbsp;&nbsp;<span class="login_txt">新密码：<asp:TextBox ID="txtNewPass" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></span>
                <span id="rfvNewPassword" class="errorTipPass" style="display: none; color: red;">请输入新密码！</span>
            </div>
            <div class="e">
                <span class="login_txt">确认密码：<asp:TextBox ID="txtConfirmPass" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></span>
                <span id="rfvNewPasswordConfirm" class="errorTipPass" style="display: none; color: red;">请确认输入新密码！</span>
            </div>
            <div style="padding: 10px 79px">
                <asp:Button runat="server" ID="btLogin" Text="确认" CssClass="button" OnClick="Confirm_Button" />&nbsp;
            <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
            </div>

            <asp:Label ID="lblErrorMeg" ClientIDMode="Static" runat="server" CssClass="errorTip" Visible="false" Style="top: -44px; margin-left: 80px; color: red"></asp:Label>
        </div>
    </form>
    <script type="text/javascript">
        $(function () {
            $('#btLogin').click(function () {
                var flag = $('#txtOldPass').val() && $('#txtNewPass').val() && $('#txtConfirmPass').val();
                if (!flag) {
                    if (!flag) {
                        $('#rfvPassword').css('display', $('#txtOldPass').val() ? "none" : "");
                        $('#rfvNewPassword').css('display', $('#txtNewPass').val() ? "none" : "");
                        $('#rfvNewPasswordConfirm').css('display', $('#txtConfirmPass').val() ? "none" : "");
                    }
                    return !!flag;
                }
            })
        });
    </script>
</body>
</html>
