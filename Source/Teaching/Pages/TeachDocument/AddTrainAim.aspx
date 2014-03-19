<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTrainAim.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AddTrainAim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .txtarea_td {
            width: 585px;
        }

        table {
            width: 960px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:80px;">
            <span style="margin-left: 8px;">学年学期：<asp:DropDownList runat="server"></asp:DropDownList>&nbsp;年级：<asp:DropDownList runat="server"></asp:DropDownList><asp:Button Text="检索" runat="server" /></span>
            <table>
                <tr>
                    <td colspan="2" style="width: 100px">培养目标</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
                <tr>
                    <td colspan="2">规格要求</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
                <tr>
                    <td colspan="2">学制学位</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
                <tr>
                    <td rowspan="3" style="width: 100px">课程体系<br />
                        与设置</td>
                    <td style="width: 100px">通识教育<br />
                        课程平台</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
                <tr>
                    <td>学科专业<br />
                        课程平台</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
                <tr>
                    <td>实践<br />
                        课程平台</td>
                    <td class="txtarea_td">
                        <textarea rows="3" cols="70"></textarea></td>
                </tr>
            </table>
            <div style="padding-left: 727px; margin-top: 20px">
                <asp:Button runat="server" Text="确认提交" CssClass="button" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />

            </div>
        </div>
    </form>
</body>
</html>
