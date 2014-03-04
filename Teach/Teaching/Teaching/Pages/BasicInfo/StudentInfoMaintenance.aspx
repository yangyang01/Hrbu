<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoMaintenance.aspx.cs" Inherits="Teaching.Pages.BasicInfo.StudentInfoMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生信息列表</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content_title"><span>学生信息维护</span></div>
        <div>
            <div style="padding-left: 100px; font-size: 18px; height: 27px">
                姓名：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
                工号：<asp:TextBox runat="server" Width="100px" Height="25px"></asp:TextBox>
                <asp:Button runat="server" Text="查询" CssClass="button" />
                <%--</div>
            <div style="padding-left: 100px;">--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a onclick="openDialog('StudentInfoDetail.aspx')" href="#"
                    title="教师信息详情">
                    <asp:Button Text="添加" runat="server" CssClass="button" ID="AddInfo" /></a>
                <asp:Button runat="server" Text="批量数据信息导入" CssClass="button" Style="width: 125px;" ID="AddInfoList" />
            </div>
            <table class="table" border="0" style="padding-left: 100px; border-collapse: collapse; margin: 10px 100px;">
                <tr class="table_title">
                    <td style="width: 100px">工号</td>
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
                <asp:Repeater runat="server" ID="rptStudentInfoList">
                    <ItemTemplate>
                        <tr>
                           <td title="<%#Eval("StudentNo") %>"><%#Eval("StudentNo") %></td>
                            <td title="<%#Eval("Name") %>"><%#Eval("Name") %></td>
                            <td title="<%#Eval("Major") %>"><%#Eval("Major") %></td>
                            <td title="<%#Eval("Class") %>"><%#Eval("Class") %></td>
                            <td>
                                <a onclick="openDialog('StudentInfoDetail.aspx')" href="#"
                                    title="教师信息详情">
                                    <asp:Button Text="修改" runat="server" CssClass="button" /></a>
                                <asp:Button Text="删除" runat="server" CssClass="button" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr id="trPage" runat="server">
                    <td colspan='5'>
                        <div>
                            <uc1:PagerControl runat="server" ID="PagerControl" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

