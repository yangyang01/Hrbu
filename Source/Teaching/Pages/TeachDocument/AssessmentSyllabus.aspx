<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssessmentSyllabus.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AssessmentSyllabus" %>

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
            <div class="content_title"><span>考核大纲</span></div>
            <a onclick="openDialog('AssessmentSyllabusAdd.aspx')" href="#"
                title="添加考核大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd" /></a>
            <table class="table">
                <tr class="table_title">
                    <td>课程<br />
                        编码</td>
                    <td>课程<br />
                        名称</td>
                    <td>考核<br />
                        目的</td>
                    <td>课程<br />
                        学习的基础</td>
                    <td>考核的<br />
                        内容范围</td>
                    <td>考核<br />
                        方法</td>
                    <td>期末<br />
                        考核形式</td>
                    <td>期末考核对<br />
                        试题的要求</td>
                    <td>主、客观<br />
                        试题的比例</td>
                    <td>题型<br />
                        比例</td>
                    <td>难度<br />
                        等级</td>
                    <td>考核<br />
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
                    <td><a onclick="openDialog('AssessmentDetail.aspx')" href="#"
                        title="大纲详情">
                        <asp:Button runat="server" Text="详细" /></a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
