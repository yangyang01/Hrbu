<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInfoMaintenance.aspx.cs" Inherits="Teaching.Pages.BasicInfo.TeacherInfoMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>教工信息列表</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <script src="../../Content/js/Utility.js"></script>
    <%@ Register Src="~/UserControls/PagerControl.ascx" TagPrefix="uc1" TagName="PagerControl" %>

</head>
<body>
    <form id="form1" runat="server" target="_right">
        <div class="content_title"><span>教工信息维护</span></div>
        <div>
            <div style="padding-left: 100px; font-size: 18px; height: 27px">
                姓名：<asp:TextBox runat="server" Width="100px" Height="25px" ID="txtSearchName"></asp:TextBox>
                工号：<asp:TextBox runat="server" Width="100px" Height="25px" ID="txtSearchNo"></asp:TextBox>
                <asp:Button runat="server" Text="查询" CssClass="button" />
                <%--<div>
            <div style="margin-left: 100px">--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a onclick="openDialog('TeacherInfoDetail.aspx')" href="#"
                    title="教师信息详情">
                    <asp:Button Text="添加" runat="server" CssClass="button" /></a>
                <asp:Button runat="server" Text="批量数据信息导入" CssClass="button" Style="width: 125px;" />
            </div>
            <table class="table" border="1" style="border-bottom-color: gray; text-align: center; margin: 10px 100px; border-collapse: collapse;" id="TeacherInfoListTable">
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
                <asp:Repeater runat="server" ID="rptTeacherList" OnItemCommand="repPend_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <asp:HiddenField ID="hfTeacherInfoID" runat="server" Value='<%#Eval("TeacherBasicInfo.Id") %>'
                                ClientIDMode="Static" />
                            <td title="<%#Eval("TeacherBasicInfo.EmpNo") %>"><%#Eval("TeacherBasicInfo.EmpNo")%></td>
                            <td title="<%#Eval("TeacherBasicInfo.Name") %>"><%#Eval("TeacherBasicInfo.Name")%></td>
                            <td title="<%#Eval("CollageName") %>"><%#Eval("CollageName")%></td>
                            <td title="<%#Eval("MajorName") %>"><%#Eval("MajorName")%></td>
                            <td>
                                <a onclick="openDialog('TeacherInfoDetail.aspx?TeacherId=<%#Eval("TeacherBasicInfo.id") %>')" href="#"
                                    title="修改学生信息">
                                    <asp:Button Text="修改" runat="server" CssClass="button" /></a>
                                <asp:Button ID="lbtnDetele" Text="删除" runat="server" CssClass="button" CommandName="Delete"
                                    OnClientClick="if(confirm('是否删除记录？')==false)return false;"></asp:Button>
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
