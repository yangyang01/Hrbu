<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SyllabusDetail.aspx.cs" Inherits="Teaching.Pages.TeachDocument.SyllabusDetail" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a onclick="openDialog('SyllabusDetailAdd.aspx')" href="#"
                title="添加教学大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd" /></a>
            <table class="table">
                <tr class="table_title">
                    <td colspan="4">课程编码</td>
                    <td colspan="2"></td>
                    <td colspan="3">课程名称</td>
                    <td colspan="3"></td>
                </tr>
                <tr>
                    <td rowspan="2">序号</td>
                    <td rowspan="2">内容</td>
                    <td rowspan="2">教学目的</td>
                    <td rowspan="2">教学要求</td>
                    <td rowspan="2">内容提要</td>
                    <td rowspan="2">教学重点与难点问题</td>
                    <td rowspan="2">复习思考题</td>
                    <td colspan="4">学时安排</td>
                    <td rowspan="2">总计</td>
                </tr>
                <tr>
                    <td>理论课时</td>
                    <td>实验课时</td>
                    <td>习题课时</td>
                    <td>上机课时</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
