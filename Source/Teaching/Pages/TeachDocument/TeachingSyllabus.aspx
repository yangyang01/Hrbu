<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeachingSyllabus.aspx.cs" Inherits="Teaching.Pages.TeachDocument.TeachingSyllabus" %>

<%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <title></title>
    <style type="text/css">
        table {
            width: 960px;
        }

        .btnadd {
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="content_title"><span>教学大纲</span></div>
            <a onclick="openDialog('TeachingSyllabusAdd.aspx')" href="#"
                title="添加教学大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd button" /></a>
            <table class="table">
                <tr class="table_title">

                    <td>课程编码</td>
                    <td>课程名称</td>
                    <td>学分</td>
                    <td>总学时</td>
                    <td>课程性质</td>
                    <td>教学目的</td>
                    <td>教学任务</td>
                    <td>教学内容</td>
                    <td>教学原则</td>
                    <td>教学方法</td>
                    <td>先修课程</td>
                    <td>教材</td>
                    <td>参考书</td>
                    <td>操作</td>
                </tr>
                <asp:Repeater runat="server" ID="rptTeachingList">
                    <ItemTemplate>
                        <tr>
                            <td title="<%#Eval("TeachingSyllabusBasic.CourseCode") %>"><%#Eval("TeachingSyllabusBasic.CourseCode") %></td>
                            <td><%#Eval("CourseName") %></td>
                            <td><%#Eval("Credit") %></td>
                            <td><%#Eval("PeriodTotal") %></td>
                            <td><%#Eval("CoursePropertyCn") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.TeachAim") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.TeachTask") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.TeachContent") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.TeachPrinciple") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.TeachMethod") %></td>
                            <td><%#Eval("PrerequisiteCourseCn") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.Textbook") %></td>
                            <td><%#Eval("TeachingSyllabusBasic.ReferenceBook") %></td>
                            <td><a onclick="openDialog('SyllabusDetail.aspx?BasicId=<%#Eval("TeachingSyllabusBasic.id") %>&BasicCode=<%#Eval("TeachingSyllabusBasic.CourseCode") %>&CourseName=<%#Eval("CourseName") %>')" href="#"
                                title="大纲详情">
                                <asp:Button runat="server" Text="详情" CssClass="button" /></a></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='14' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr id="trPage" class="page_list" runat="server">
                    <td colspan='14'>
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
