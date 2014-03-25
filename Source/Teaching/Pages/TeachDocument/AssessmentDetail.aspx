<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssessmentDetail.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AssessmentDetail" %>

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

        .title_sty {
            background-color: #728AC0;
            color: white;
        }

        .btnadd {
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a onclick="openDialog('AssessmentDetailAdd.aspx')" href="#"
                title="添加教学大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd button" /></a>
            <table class="table">
                <tr class="title_sty">
                    <td>课程编码</td>
                    <td colspan="2"></td>
                    <td>课程名称</td>
                    <td colspan="2"></td>
                </tr>
                <tr>
                    <td rowspan="2">章数</td>
                    <td rowspan="2">知识点</td>
                    <td colspan="3">考核目标</td>

                    <td rowspan="2">样题</td>
                </tr>
                <tr>
                    <td>识记</td>
                    <td>理解</td>
                    <td>运用</td>
                </tr>
                <tr>
                    <td>第一章</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>下载</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
