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
                姓名：<asp:TextBox runat="server" Width="100px" Height="25px" ID="txtSearchName"></asp:TextBox>
                学号：<asp:TextBox runat="server" Width="100px" Height="25px" ID="txtSearchNo"></asp:TextBox>
                <asp:Button runat="server" Text="查询" CssClass="button" />
                <%--</div>
            <div style="padding-left: 100px;">--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a onclick="openDialog('StudentInfoDetail.aspx')" href="#"
                    title="添加学生信息">
                    <asp:Button Text="添加" runat="server" CssClass="button" ID="btnAddInfo" Visible="false" /></a>
                <asp:Button runat="server" Text="批量数据信息导入" CssClass="button" Style="width: 125px;" ID="btnAddInfoList" Visible="false" />
            </div>
            <table class="table" border="0" style="padding-left: 100px; border-collapse: collapse; margin: 10px 100px;">
                <tr class="table_title">
                    <td style="width: 150px">学号</td>
                    <td style="width: 150px">姓名</td>
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
                <asp:Repeater runat="server" ID="rptStudentInfoList" OnItemCommand="repPend_ItemCommand">
                    <ItemTemplate>
                        <tr>
                             <asp:HiddenField ID="hfStudentInfoID" runat="server" Value='<%#Eval("StudentBasicInfo.Id") %>'
                                ClientIDMode="Static" />
                            <td title="<%#Eval("StudentBasicInfo.StudentNo") %>"><%#Eval("StudentBasicInfo.StudentNo") %></td>
                            <td title="<%#Eval("StudentBasicInfo.Name") %>"><%#Eval("StudentBasicInfo.Name") %></td>
                            <td title="<%#Eval("MajorName") %>"><%#Eval("MajorName") %></td>
                            <td title="<%#Eval("StudentBasicInfo.Class") %>"><%#Eval("StudentBasicInfo.Class") %></td>
                            <td>
                                <a onclick="openDialog('StudentInfoDetail.aspx?StudentId=<%#Eval("StudentBasicInfo.id") %>')" href="#"
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

