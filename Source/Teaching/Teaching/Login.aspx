﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Teaching.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>教务管理平台登录</title>
    <meta http-equiv="X-UA-Compatible" content="IE=8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/login.css" />
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
</head>
<body style="background-color:#6989B7">

    <form id="form1" runat="server" class="login_form">
        <div style="width: 1000px; height: 620px; background-color: white; margin: -17px 0px 0px 170px;">
            <img src='<%=ResolveUrl("/Content/Images/teach_logo.jpg") %>' class="arrowhead_bg" />
            <div class="login_left_div">
                <div>
                    <span class="new">通知信息</span>
                    <span style="font-size: 10px;">更多>></span>
                </div>
                <div style="height: 1.5px; padding: 0px; background-color: #3B3B81; overflow: hidden;"></div>
                <div>
                    <ul>
                        <li><em></em>哈尔滨学院简介</li>
                        <li><em></em>哈尔滨学院简介</li>
                        <li><em></em>哈尔滨学院简介</li>
                    </ul>
                </div>
            </div>
            <div class="login_window">
                <span class="login_title">登录</span>
                <span class="login_txt">用户类型：
       <%--          <select data-parameter="Role">
                     <option value="">==请选择==</option>
                     <asp:Repeater ID="rptType" runat="server">
                         <ItemTemplate>
                             <option value="<%# Eval("enumValue") %>"><%#Eval("DisplayValue") %></option>
                         </ItemTemplate>
                     </asp:Repeater>
                 </select>--%>
                    <asp:DropDownList ID="ddlUsertype" runat="server" CssClass="type">
                        <asp:ListItem Text="==请选择==" Value="" Selected="true"></asp:ListItem>
                        <asp:ListItem Text="管理员" Value="1"></asp:ListItem>
                        <asp:ListItem Text="教管人员" Value="2"></asp:ListItem>
                        <asp:ListItem Text="教师" Value="3"></asp:ListItem>
                        <asp:ListItem Text="学生" Value="4"></asp:ListItem>
                    </asp:DropDownList></span>
                <span id="rfvRolename" class="errorTip" style="display: none; color: red;">请选择用户类型！</span>
                <span class="login_txt">用户名：<asp:TextBox ID="txtUsername" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvUsername" class="errorTip" style="display: none; color: red;">请输入用户名！</span>

                <span class="login_txt">密&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txtPassword" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox></span>
                <span id="rfvPassword" class="errorTip" style="display: none; color: red;">请输入密码！</span>

                <span class="login_txt">验证码：<asp:TextBox ID="txtVeriCode" runat="server" CssClass="code"></asp:TextBox>
                    <img id="CodeImg" onclick="ValiCode(this.id,'VerifyImageCode.ashx')" alt="验证码" />
                    <a onclick="ValiCode('CodeImg','VerifyImageCode.ashx')">看不清,换一张</a>
                </span>
                <span id="rfvVeriCode" class="errorTip" style="display: none; color: red; top: -40px;">请输入验证码！</span>

                <span class="login_bt">
                    <asp:Button ID="btLogin" runat="server" Text="登录" CssClass="btn" OnClick="Login_Button" /></span>
                <asp:Label ID="lblLoginMeg" ClientIDMode="Static" runat="server" CssClass="red errorTip" Visible="false" Style="top: -34px;"></asp:Label>
            </div>
            <div class="footer">
                <span>版权所有：哈尔滨学院软件学院　　地址： 哈尔滨市南岗区中兴大道109号<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;邮编： 150086　　哈公网监备： 230100101	
                </span>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        $(function () {
            ValiCode('CodeImg', 'VerifyImageCode.ashx');
            $('#btLogin').click(function () {
                var flag = $('#txtUsername').val() && $('#txtPassword').val() && $('#txtVeriCode').val() && $('#ddlUsertype').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvRolename').css('display', $('#ddlUsertype').val() ? "none" : "");
                        $('#rfvUsername').css('display', $('#txtUsername').val() ? "none" : "");
                        $('#rfvPassword').css('display', $('#txtPassword').val() ? "none" : "");
                        $('#rfvVeriCode').css('display', $('#txtVeriCode').val() ? "none" : "");
                    }
                    $('#lblLoginMeg').hide();
                    return !!flag;
                }
            })
        });

        function ValiCode(imgID, VerifyImagePage) {
            $("#" + imgID).attr('src', VerifyImagePage + '?random=' + Math.random());
        }

    </script>
</body>

</html>
