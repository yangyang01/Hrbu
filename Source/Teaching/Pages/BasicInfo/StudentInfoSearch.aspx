<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoSearch.aspx.cs" Inherits="Teaching.Pages.BasicInfo.StudentInfoSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生信息页面</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/basicInfo.css" />
    <script src="../../Content/js/Utility.js"></script>
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>
</head>
<body style="background-color: #FAFBFC;">
    <form id="form1" runat="server">
        <div class="content_title"><span>学生信息查询</span></div>
        <div style="padding-left: 100px; font-size: 18px; height: 27px">
            姓名：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
            学号：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
            <asp:Button runat="server" Text="查询" CssClass="button" />
            <asp:Button runat="server" Text="查询所有" CssClass="button" />
        </div>
        <div style="padding-top: 20px;">
            <table class="table" border="0" style="padding-left: 100px; border-collapse: collapse; margin-left: 100px;">
                <tr class="table_title">
                    <td style="width: 100px">学号</td>
                    <td style="width: 100px">姓名</td>
                    <td style="width: 150px">专业</td>
                    <td style="width: 150px">班级</td>
                    <td style="width: 250px">操作</td>
                </tr>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='5' style="text-align: left;">当前查询条件没有数据！
                        </td>
                    </tr>
                </asp:PlaceHolder>
                <asp:Repeater runat="server" ID="rptStudentList">
                    <ItemTemplate>
                        <tr>
                            <td title="<%#Eval("StudentNo") %>"><%#Eval("StudentNo") %></td>
                            <td title="<%#Eval("Name") %>"><%#Eval("Name") %></td>
                            <td title="<%#Eval("Major") %>"><%#Eval("Major") %></td>
                            <td title="<%#Eval("Class") %>"><%#Eval("Class") %></td>
                            <td>
                                <a onclick="openDialog('StudentInfoDetail.aspx?StudentId=<%#Eval("Id") %>')" href="#"
                                    title="教师信息详情">
                                    <asp:Button Text="详情" runat="server" CssClass="button" /></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr class="page_list" id="trPage" runat="server">
                    <td colspan='5'>
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
