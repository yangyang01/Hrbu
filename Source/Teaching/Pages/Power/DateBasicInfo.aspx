<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateBasicInfo.aspx.cs" Inherits="Teaching.Pages.Power.DateBasicInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <title>数据信息</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a onclick="openDialog('DataAddUp.aspx?DicId=<%=Id%>',400,200)" href="#"
                title="添加数据详情" style="margin-left: 50px;">
                <asp:Button Text="添加" runat="server" CssClass="button" />
            </a>
            <table class="table" style="margin-left: 50px">
                <tr class="table_title">
                    <td style="width: 200px">数据</td>
                    <td style="width: 200px">操作</td>
                </tr>
                <asp:Repeater runat="server" ID="rptDataDicList" OnItemCommand="repPend_ItemCommand">
                    <ItemTemplate>
                        <tr>
                                <asp:HiddenField runat="server" ID="hfDataDicInfoID" Value='<%# Eval("Id") %>'  ClientIDMode="Static" />
                            <td title="<%#Eval("InfoName") %>"><%#Eval("InfoName") %></td>
                            <td>
                                <a onclick="openDialog('DataAddUp.aspx?DicId=<%#Eval("DataDicId") %>&Id=<%#Eval("Id") %>',400,200)" href="#"
                                    title="添加数据详情">
                                    <asp:Button Text="修改" runat="server" CssClass="button"/>
                                </a>
                                <asp:Button ID="lbtnDetele" Text="删除" runat="server" CssClass="button" CommandName="Delete"
                                    OnClientClick="if(confirm('是否删除记录？')==false)return false;" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
