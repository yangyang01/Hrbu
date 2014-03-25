<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseInfoList.aspx.cs" Inherits="Teaching.Pages.TeachDocument.CourseInfoList" %>

<%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <title>用户列表</title>
    <style>
        .b {
            margin-top: -1px;
        }

        .a {
            margin-left: 225px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="content_title"><span>课程管理</span></div>
        <div style="padding-left: 100px">
            <div style="font-size: 18px; height: 27px; margin: 8px">
                课程编码：<asp:TextBox ID="txtSearchNo" runat="server" Width="100px" Height="25px"></asp:TextBox>
                课程名称：<asp:TextBox ID="txtSearchName" runat="server" Width="100px" Height="25px"></asp:TextBox>
                <asp:Button runat="server" Text="查询" CssClass="button b" OnClick="SearchQuery" />
                <a onclick="openDialog('CourseAddUp.aspx',600,500) " href="#"
                    title="权限信息详情">
                    <asp:Button Text="添加" runat="server" CssClass="button a b" />
                </a>
            </div>
            <table class="table" style="border-collapse: collapse">
                <tr class="table_title">
                    <td style="width: 150px">课程编码</td>
                    <td style="width: 150px">课程名称</td>
                    <td style="width: 150px">课程性质</td>
                    <td style="width: 150px">课程类别</td>
                    <td style="width: 100px">学&nbsp;分</td>
                    <td style="width: 100px">总学时</td>
                    <td style="width: 200px">操&nbsp;作</td>
                </tr>
                <asp:Repeater ID="rptCourseInfoList" runat="server" OnItemCommand="repPend_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <asp:HiddenField ID="hfCourseID" runat="server" Value='<%#Eval("CourseInfo.Id") %>'
                                ClientIDMode="Static" />
                            <td title="<%# Eval("CourseInfo.CourseCode") %>"><%# Eval("CourseInfo.CourseCode") %></td>
                            <td title="<%# Eval("CourseInfo.CourseName") %>"><%# Eval("CourseInfo.CourseName") %></td>
                            <td title="<%# Eval("CoursePropertyCn") %>"><%# Eval("CoursePropertyCn") %></td>
                            <td title="<%# Eval("CourseTypeCn") %>"><%# Eval("CourseTypeCn") %></td>
                            <td title="<%# Eval("CourseInfo.Credit") %>"><%# Eval("CourseInfo.Credit") %></td>
                            <td title="<%# Eval("CourseInfo.PeriodTotal") %>"><%# Eval("CourseInfo.PeriodTotal") %></td>
                            <td>
                                <a onclick="openDialog('CourseAddUp.aspx?Id=<%#Eval("CourseInfo.Id") %>',500,400) " href="#"
                                    title="权限信息详情">
                                    <asp:Button Text="修改" runat="server" CssClass="button" /></a>
                                <asp:Button ID="lbtnDetele" Text="删除" runat="server" CssClass="button" CommandName="Delete"
                                    OnClientClick="if(confirm('是否删除记录？')==false)return false;"></asp:Button>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='7' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr id="trPage" class="page_list" runat="server">
                    <td colspan='7'>
                        <div class="page_list_menu">
                            <uc1:PagerControl runat="server" ID="PagerControl" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

