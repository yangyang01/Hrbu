<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuDetail.aspx.cs" Inherits="Teaching.Pages.Power.LimitDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>菜单管理页面</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <style type="text/css">
        .box {
            padding-left: 100px;
            text-align: left;
            border: hidden;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom: 10px">
            角色名：<asp:Label ID="lbRoleName" runat="server"></asp:Label>
        </div>
        <div>
            <table class="table" style="border-collapse: collapse;">
                <tr class="table_title">
                    <td style="width: 300px;">一级菜单</td>
                    <td style="width: 300px;">二级菜单</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="Power" Text="系统设置维护" runat="server" /></td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box" ID="power_sub">
                            <asp:ListItem Text="权限维护" Value="1"></asp:ListItem>
                            <asp:ListItem Text="用户管理" Value="2"></asp:ListItem>
                            <asp:ListItem Text="数据备份" Value="3"></asp:ListItem>
                            <asp:ListItem Text="数据字典" Value="4"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="BasicInfo" Text="人员信息管理" runat="server" /></td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box" ID="basicinfo_sub">
                            <asp:ListItem Text="教工信息维护" Value="1"></asp:ListItem>
                            <asp:ListItem Text="教工信息查询" Value="2"></asp:ListItem>
                            <asp:ListItem Text="学生信息维护" Value="3"></asp:ListItem>
                            <asp:ListItem Text="学生信息查询" Value="4"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="TeachFile" Text="教学文件管理" runat="server" />教学文件管理</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box" ID="teachfile_sub">
                            <asp:ListItem Text="培养方案" Value="1"></asp:ListItem>
                            <asp:ListItem Text="教学大纲" Value="2"></asp:ListItem>
                            <asp:ListItem Text="考核大纲" Value="3"></asp:ListItem>
                            <asp:ListItem Text="实验大纲" Value="4"></asp:ListItem>
                            <asp:ListItem Text="教学日历" Value="5"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="CourseSchedule" Text="课程调度编排" runat="server" />课程调度编排</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box" ID="courceSchedule_sub">
                            <asp:ListItem Text="教学设备管理总述" Value="1"></asp:ListItem>
                            <asp:ListItem Text="设置报废状态" Value="2"></asp:ListItem>
                            <asp:ListItem Text="新增设备记录" Value="3"></asp:ListItem>
                            <asp:ListItem Text="实验大纲" Value="4"></asp:ListItem>
                            <asp:ListItem Text="更改所属部门" Value="5"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox runat="server" Text="学生成绩管理" ID="chbStudentsMg"/>学生成绩管理</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box" >
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox runat="server" Text="实践教学管理" ID="chbPracticeMg" />实践教学管理</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox runat="server" Text="日常公文管理" ID="chbReportsMg" />日常公文管理</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox runat="server" Text="教官规章制度" ID="chbRulesMg" />教官规章制度</td>
                    <td>
                        <asp:CheckBoxList runat="server" CssClass="box">
                        </asp:CheckBoxList>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding-left: 460px;">
            <asp:Button runat="server" Text="保存" CssClass="button" OnClick="btnSave_Click" ID="btnSave" />
            <asp:Button runat="server" Text="返回" CssClass="button" />
        </div>
    </form>
</body>
</html>
