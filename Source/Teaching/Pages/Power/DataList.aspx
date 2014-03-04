<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="Teaching.Pages.Power.Datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>

    <title>数据字典列表</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content_title"><span>数据字典</span></div>
        <div style="padding-left: 100px;">
            <span style="margin-left: 100px;">
                <asp:Button Text="添加" runat="server" CssClass="button" OnClick="NewData" CommandName="New" />
            </span>
            <table class="table" style="border-collapse: collapse; margin: 10px 100px;">
                <tr class="table_title">
                    <td style="width: 200px">查看</td>
                    <td style="width: 200px">数据名</td>
                </tr>
                <asp:Repeater ID="rptDateList" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <a onclick="showModuleDialog('DateBasicInfo.aspx?Id=<%#Eval("id") %>')" href="#"
                                    title="数据信息详情">
                                    <asp:Button Text="详情" runat="server" CssClass="button" /></a>
                            </td>
                            <td title="<%# Eval("DataName") %>"><%# Eval("DataName") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr class="page_list">
                    <td colspan='2'>
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
