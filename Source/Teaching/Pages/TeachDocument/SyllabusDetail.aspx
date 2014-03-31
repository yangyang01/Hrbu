<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SyllabusDetail.aspx.cs" Inherits="Teaching.Pages.TeachDocument.SyllabusDetail" %>

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
        .traintxtarea {
            border: none;
        }

        .txtarea_td {
            width: 585px;
            height: 50px;
        }

        table {
            width: 960px;
        }

        .btnadd {
            margin-left: 10px;
        }

        .t1 {
            height: 45px;
            color: #3459AD;
        }

        .t2 {
            height: 30px;
            color: #3459AD;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a onclick="openDialog('SyllabusDetailAdd.aspx?BasicCode=<%=BasicCode%>')" href="#"
                title="添加教学大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd button" /></a>
            <table class="table">
                <tr class="table_title">
                    <td colspan="4" class="t1">课程编码</td>
                    <td colspan="1" style="background-color:#E7E7E7"><%=BasicCode%></td>
                    <td colspan="3" class="t1">课程名称</td>
                    <td colspan="4" style="background-color:#E7E7E7"><%=CourseName%></td>
                </tr>
                <tr class="table_title">
                    <td rowspan="2" class="t2">序号</td>
                    <td rowspan="2" class="t2">标题</td>
                    <td rowspan="2" class="t2">教学目的</td>
                    <td rowspan="2" class="t2">教学要求</td>
                    <td rowspan="2" class="t2">内容提要</td>
                    <td rowspan="2" class="t2">教学重点与难点问题</td>
                    <td rowspan="2" class="t2">复习思考题</td>
                    <td colspan="4" class="t2">学时安排</td>
                    <td rowspan="2" class="t2">总计</td>
                </tr>
                <tr class="table_title">
                    <td class="t2">理论课时</td>
                    <td class="t2">实验课时</td>
                    <td class="t2">习题课时</td>
                    <td class="t2">上机课时</td>
                </tr>
                <asp:Repeater runat="server" ID="rptSyllabusDetailList">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("TeachingSyllabusDetail.SerialNo")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.Title")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.TeachingAims")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.TeachRequirement")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.Synopsis")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.TeachKeyPoint")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.LessonReview")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.TheoreticalLessons")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.ExperimentLessons")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.ExerciseLessons")%></td>
                            <td><%#Eval("TeachingSyllabusDetail.ComputerLessons")%></td>
                            <td><%#Eval("Total") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='12' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr id="trPage" class="page_list" runat="server">
                    <td colspan='12'>
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
