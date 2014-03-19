<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainingProgram.aspx.cs" Inherits="Teaching.Pages.TeachDocument.TrainingProgram" %>

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
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="content_title"><span>人才培养方案</span></div>

            <div style="margin-left: 10px;">
                学年学期：<asp:DropDownList runat="server"></asp:DropDownList>&nbsp;年级：<asp:DropDownList runat="server"></asp:DropDownList><asp:Button Text="检索" runat="server" />
                <span style="margin-left: 570px">
                    <a onclick="openDialog('AddTrainAim.aspx')" href="#"
                    title="添加目标"><asp:Button Text="添加目标" runat="server" /></a><a onclick="openDialog('AddTrainCourseInfo.aspx')" href="#"
                    title="添加信息"><asp:Button Text="添加信息" runat="server" /></a></span>
            </div>
            <table>
                <tr>
                    <td colspan="2" style="width: 100px">培养目标</td>
                    <td class="txtarea_td"></td>
                </tr>
                <tr>
                    <td colspan="2">规格要求</td>
                    <td class="txtarea_td"></td>
                </tr>
                <tr>
                    <td colspan="2">学制学位</td>
                    <td class="txtarea_td"></td>
                </tr>
                <tr>
                    <td rowspan="3" style="width: 100px">课程体系<br />
                        与设置</td>
                    <td style="width: 100px">通识教育<br />
                        课程平台</td>
                    <td class="txtarea_td"></td>
                </tr>
                <tr>
                    <td>学科专业<br />
                        课程平台</td>
                    <td class="txtarea_td"></td>
                </tr>
                <tr>
                    <td>实践<br />
                        课程平台</td>
                    <td class="txtarea_td"></td>
                </tr>
            </table>
            <br />
            <table class="table">
                <tr class="table_title">
                    <td>学年学期</td>
                    <td>课程性质</td>
                    <td>课程类别</td>
                    <td>专业方向</td>
                    <td>课程编码</td>
                    <td>课程名称</td>
                    <td>学分</td>
                    <td>总学时</td>
                    <td>理论学时</td>
                    <td>实验学时</td>
                    <td>实践周数</td>
                    <td>开课学期</td>
                    <td>考核方式</td>
                    <td>备注</td>
                </tr>
                <tr>
                    <td>2010-2011第一学期</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
