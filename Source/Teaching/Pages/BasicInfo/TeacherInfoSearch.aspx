<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInfoSearch.aspx.cs" Inherits="Teaching.Pages.BasicInfo.TeacherInfoSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>教工信息页面</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <%--<link type="text/css" rel="stylesheet" href="~/Content/css/basicInfo.css" />--%>
    <script src="../../Content/js/Utility.js"></script>
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>

</head>
<body style="background-color: #FAFBFC;">
    <form id="form1" runat="server">
        <div class="content_title"><span>教工信息查询</span></div>
        <div style="padding-left: 100px; font-size: 18px; height: 27px; margin-bottom: -14px;">
            姓名：<asp:TextBox ID="searchName" runat="server" Width="100px" Height="25px"></asp:TextBox>
            工号：<asp:TextBox ID="searchNo" runat="server" Width="100px" Height="25px"></asp:TextBox>
            <asp:Button runat="server" ID="SearchId" Text="查询" CssClass="button" />
            <asp:Button runat="server" ID="SearchAll" Text="查询所有" CssClass="button" />
        </div>
        <%--<div style="padding-top: 20px;border-bottom:1px solid black;width:500px;padding-left:500px">--%>

        <%--</div>--%>
        <div style="padding-top: 20px;">
            <table class="table" border="1" style="border-bottom-color: gray; text-align: center; margin-left: 100px; border-collapse: collapse" id="TeacherInfoListTable">
                <tr class="table_title">
                    <td style="width: 150px">工号</td>
                    <td style="width: 150px">姓名</td>
                    <td style="width: 150px">学院</td>
                    <td style="width: 150px">专业</td>
                    <td style="width: 250px">操作</td>
                </tr>
                <asp:PlaceHolder ID="phNoData" runat="server" Visible="false">
                    <tr>
                        <td colspan='5' style="text-align: left;">当前查询条件没有数据！
                        </td>
                    </tr>
                </asp:PlaceHolder>
                <asp:Repeater runat="server" ID="rptTeacherList">
                    <ItemTemplate>
                        <tr>
                            <td title="<%#Eval("TeacherBasicInfo.EmpNo") %>"><%#Eval("TeacherBasicInfo.EmpNo")%></td>
                            <td title="<%#Eval("TeacherBasicInfo.Name") %>"><%#Eval("TeacherBasicInfo.Name")%></td>
                            <td title="<%#Eval("CollageName") %>"><%#Eval("CollageName")%></td>
                            <td title="<%#Eval("MajorName") %>"><%#Eval("MajorName")%></td>
                            <td>
                                <a onclick="openDialog('TeacherInfoDetail.aspx?TeacherId=<%#Eval("TeacherBasicInfo.Id") %>&Status=View')" href="#"
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
