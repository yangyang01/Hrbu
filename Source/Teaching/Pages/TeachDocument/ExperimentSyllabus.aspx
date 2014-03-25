<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExperimentSyllabus.aspx.cs" Inherits="Teaching.Pages.TeachDocument.ExperimentSyllabus" %>

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
            <div class="content_title"><span>实验大纲</span></div>
            <a onclick="openDialog('ExperimentSyllabusAdd.aspx')" href="#"
                title="添加教学大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd button" /></a>
            <table class="table">
                <tr class="table_title">
                    <td>课程<br />
                        编码</td>
                    <td>课程<br />
                        名称</td>
                    <td>学分</td>
                    <td>总学时</td>
                    <td>课程<br />
                        性质</td>
                    <td>教学<br />
                        目的</td>
                    <td>教学<br />
                        任务</td>
                    <td>教学<br />
                        内容</td>
                    <td>教学<br />
                        原则和方法</td>
                    <td>先修<br />
                        课程</td>
                    <td>考核<br />
                        方式</td>
                    <td>教材</td>
                    <td>参考书</td>
                    <td>实验<br />
                        详情</td>
                </tr>
                <tr>
                    <td>003121</td>
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
                    <td><a onclick="openDialog('ExperimentDetail.aspx')" href="#"
                        title="大纲详情">
                        <asp:Button runat="server" Text="详细" CssClass="button" /></a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
