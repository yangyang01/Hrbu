<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAddUp.aspx.cs" Inherits="Teaching.Pages.Power.UserAddUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <title>用户添加修改页面</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 30px">
            <div style="height: 35px; margin-left: 120px">
                <span class="list">用户名：<asp:TextBox ID="txtUserNo" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvUserNo" class="errorTip" style="display: none; color: red;">请输入用户名！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list">姓&nbsp;&nbsp;名：<asp:TextBox ID="txtUserName" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvUserName" class="errorTip" style="display: none; color: red;">请输入用户姓名！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list">密&nbsp;&nbsp;码：<asp:TextBox ID="txtPassword" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvPassword" class="errorTip" style="display: none; color: red;">请输入密码！</span>
            </div>
            <div style="height: 35px; margin-left: 105px">
                <span class="list">用户类型：<asp:DropDownList ID="ddlRoleName" runat="server" CssClass="txt"></asp:DropDownList></span>
                <span id="rfvRolename" class="errorTip" style="display: none; color: red;margin-left: 47px;">请选择用户类型！</span>
            </div>
            <div style="margin-left: 180px">
                <span>
                    <asp:Button runat="server" ID="btSubmit" Text="提交" ClientIDMode="Static" CssClass="button" OnClick="ClickbtnSure" />
                    <asp:Button runat="server" Text="返回" ClientIDMode="Static" CssClass="button" OnClientClick="window.close();return false;" />
                </span>
            </div>
        </div>
    </form>
     <script type="text/javascript">
         $(function () {
             $('#btSubmit').click(function () {
                 var flag = $('#txtUserNo').val() && $('#txtUserName').val() && $('#txtPassword').val() && $('#ddlRoleName').val;
                 if (!flag) {
                     if (!flag) {
                         $('#rfvUserNo').css('display', $('#txtUserNo').val() ? "none" : "");
                         $('#rfvRolename').css('display', $('#ddlRoleName').val() ? "none" : "");
                         $('#rfvUserName').css('display', $('#txtUserName').val() ? "none" : "");
                         $('#rfvPassword').css('display', $('#txtPassword').val() ? "none" : "");
                     }
                     return !!flag;
                 }
             })
         });
    </script>
</body>
</html>
