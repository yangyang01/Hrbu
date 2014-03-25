<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseAddUp.aspx.cs" Inherits="Teaching.Pages.TeachDocument.CourseAddUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <title>课程添加修改页面</title>
    <style>
        .p {
            width: 151px;
            margin-left: 2px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 30px">
            <div style="height: 35px; margin-left: 120px">
                <span class="list">课程编码：<asp:TextBox ID="txtCourseNo" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvCourseCode" class="errorTip" style="display: none; color: red;">请输入课程编码名！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list">课程名称：<asp:TextBox ID="txtCourseName" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvCourseName" class="errorTip" style="display: none; color: red;">请输入课程名称！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list">课程性质：<asp:DropDownList ID="ddlCourseProperty" runat="server" CssClass="txt p"></asp:DropDownList></span>
                <span id="rfvCourseProperty" class="errorTip" style="display: none; color: red;">请选择课程性质！</span>
            </div>
            <div style="height: 35px; margin-left: 105px">
                <span class="list" style="margin-left: 16px;">课程类别：<asp:DropDownList ID="ddlCourseType" runat="server" CssClass="txt p"></asp:DropDownList></span>
                <span id="rfvCourseType" class="errorTip" style="display: none; color: red; ">请选择课程类别！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list" style="margin-left: 33px;">学分：<asp:TextBox ID="txtCredit" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvCredit" class="errorTip" style="display: none; color: red;">请输入课程学分！</span>
            </div>
            <div style="height: 35px; margin-left: 120px">
                <span class="list" style="margin-left: 17px;">总学时：<asp:TextBox ID="txtPeriodTotal" runat="server" CssClass="txt"></asp:TextBox></span>
                <span id="rfvPeriodTotal" class="errorTip" style="display: none; color: red;">请输入课程总学时！</span>
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
                var flag = $('#txtCourseNo').val() && $('#txtCourseName').val() && $('#ddlCourseProperty').val() && $('#ddlCourseType').val && $('#txtCredit').val() && $('#txtPeriodTotal').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvCourseCode').css('display', $('#txtCourseNo').val() ? "none" : "");
                        $('#rfvCourseName').css('display', $('#txtCourseName').val() ? "none" : "");
                        $('#rfvCourseProperty').css('display', $('#ddlCourseProperty').val() ? "none" : "");
                        $('#rfvCourseType').css('display', $('#ddlCourseType').val() ? "none" : "");
                        $('#rfvCredit').css('display', $('#txtCredit').val() ? "none" : "");
                        $('#rfvPeriodTotal').css('display', $('#txtPeriodTotal').val() ? "none" : "");
                    }
                    return !!flag;
                }
            })
        });
    </script>
</body>
</html>
