<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainingProgram.aspx.cs" Inherits="Teaching.Pages.TeachDocument.TrainingProgram" %>

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

        .search_bn {
            margin: -1px 5px 0px 5px;
        }

        .ddl {
            width: 90px;
            height: 26px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="content_title"><span>人才培养方案</span></div>

            <div style="margin-left: 10px;">
                学年：<asp:DropDownList runat="server" ID="ddlYear" CssClass="txt ddl"></asp:DropDownList>&nbsp;
                学期：<asp:DropDownList runat="server" ID="ddlSemester" CssClass="txt ddl"></asp:DropDownList>&nbsp;
                年级：<asp:DropDownList ID="ddlGrade" runat="server" CssClass="txt ddl"></asp:DropDownList><asp:Button Text="检索" runat="server" CssClass="button search_bn" />
                <span style="margin-left: 270px">
                    <a onclick="openDialog('AddTrainAim.aspx')" href="#"
                        title="添加目标">
                        <asp:Button Text="添加目标" runat="server" CssClass="button search_bn" /></a>
                    <a onclick="openDialog('AddTrainCourseInfo.aspx')" href="#"
                        title="添加信息">
                        <asp:Button Text="添加信息" runat="server" CssClass="button search_bn" /></a></span>
            </div>
            <table class="table">
                <tr class="table_title">
                    <td rowspan="2">年级</td>
                    <td rowspan="2">培养目标</td>
                    <td rowspan="2">规格要求</td>
                    <td rowspan="2">学制学位</td>
                    <td colspan="3">课程体系与设置</td>
                </tr>
                <tr class="table_title">
                    <td>通识教育<br />
                        课程平台</td>
                    <td>学科专业<br />
                        课程平台</td>
                    <td>实践<br />
                        课程平台</td>
                </tr>
                 <asp:Repeater ID="rptTrainAim" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td title="<%#Eval("Grade") %>"><%#Eval("Grade") %></td>
                            <td><%#Eval("TrainAim") %></td>
                            <td><%#Eval("SpecificationRequirements") %></td>
                            <td><%#Eval("LearningDegree") %></td>
                            <td><%#Eval("TeachingPlatform") %></td>
                            <td><%#Eval("ProfessionalPlatform") %></td>
                            <td><%#Eval("PracticalPlatform") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='7' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr class="page_list" id="trPage" runat="server">
                    <td colspan='7'>
                        <div class="page_list_menu">
                            <uc1:PagerControl runat="server" ID="PagerControl1" />
                        </div>
                    </td>
                </tr>
            </table>
            <br />
            <table class="table">
                <tr class="table_title">
                    <td>学年</td>
                    <td>开课学期</td>
                    <td>课程编码</td>
                    <td>课程名称</td>
                    <td>课程性质</td>
                    <td>课程类别</td>
                    <td>专业方向</td>
                    <td>学分</td>
                    <td>总学时</td>
                    <td>理论学时</td>
                    <td>实验学时</td>
                    <td>实践周数</td>
                    <td>考核方式</td>
                    <td>备注</td>
                </tr>
                <asp:Repeater ID="rptTrainCourse" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td ><%#Eval("SchoolYear") %></td>  
                            <td><%#Eval("SchoolSemester") %></td>
                            <td><%#Eval("TrainingProgramInfo.CourseCode") %></td>
                            <td><%#Eval("CourseName") %></td>
                            <td><%#Eval("CoursePropertyCn") %></td>
                            <td><%#Eval("CourseTypeCn") %></td>
                            <td><%#Eval("ProfessionalEmphasis") %></td>
                            <td><%#Eval("Credit") %></td>
                            <td><%#Eval("PeriodTotal") %></td>
                            <td><%#Eval("TrainingProgramInfo.TeachingPeriod") %></td>
                            <td><%#Eval("TrainingProgramInfo.ExperimentPeriod") %></td>
                            <td><%#Eval("TrainingProgramInfo.PracticeWeeks") %></td>
                            <td><%#Eval("EvaluationMode") %></td>
                            <td><%#Eval("TrainingProgramInfo.Remark") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:PlaceHolder ID="phNoData1" runat="server" Visible="false">
                    <tr>
                        <td colspan='14' style="text-align: left;">当前查询条件没有数据！
                </td>
                    </tr>
                </asp:PlaceHolder>
                <tr class="page_list" id="trPage1" runat="server">
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
