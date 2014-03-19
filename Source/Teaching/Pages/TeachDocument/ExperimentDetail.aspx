<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExperimentDetail.aspx.cs" Inherits="Teaching.Pages.TeachDocument.ExperimentDetail" %>

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
            <a onclick="openDialog('ExperimentDetailAdd.aspx')" href="#"
                title="添加实验大纲">
                <asp:Button runat="server" ID="btnAddSyllabus" Text="添加" CssClass="btnadd" /></a>
            <table class="table">
                <tr class="title_sty">
                    <td colspan="2">课程编码</td>
                    <td colspan="3"></td>
                    <td colspan="2">课程名称</td>
                    <td colspan="2"></td>
                </tr>
                <tr>
                    <td>实验编号</td>
                    <td>实验内容</td>
                    <td>实验学时</td>

                    <td>实验类型</td>

                    <td>实验教学目的</td>
                    <td>实验教学要求</td>
                    <td>实验原理</td>

                    <td>实验步骤</td>
                    <td>实验主要仪器设备及材料</td>

                </tr>
                <tr>
                    <td>0111</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>电路板</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
