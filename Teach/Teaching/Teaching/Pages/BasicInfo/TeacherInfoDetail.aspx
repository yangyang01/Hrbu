<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInfoDetail.aspx.cs" Inherits="Teaching.Pages.BasicInfo.TeacherInfoDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>教师信息详情</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/basicInfo.css" />
    <style type="text/css">
        .info {
            margin-top: 110px;
        }
    </style>
    <script type="text/javascript">
        $(function () {
            $("button:#resetButton").bind("click", function (e) {
                $(this).find('input:text').val('');
            });
        })
    </script>
</head>
<body style="background-color: #FAFBFC;">
    <form id="form1" runat="server" target="_right">
        <div>
            <ul style="display: inline-block; list-style-type: none; margin-left: 100px">
                <li class="title">
                    <fieldset>
                        <legend>教工基本信息</legend>
                        <div class="left">
                            <span class="person_pic">
                                <asp:Image class="personal_img" ID="imgPhote" runat="server" onerror="this.src='/Content/Images/personal.jpg'" />
                            </span>
                            <span style="margin-left: 200px;">
                                <asp:FileUpload ID="FileUpload1" runat="server" /></span>
                        </div>
                        <div class="info">
                            <div>
                                <span class="left">工号：</span> <span class="right">
                                    <asp:TextBox ID="txtEmpNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">姓名：</span><span class="right"><asp:TextBox ID="txtEmpName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>

                            <div>
                                <span class="left">性别：</span><span class="right"><asp:TextBox ID="txtsex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">专业技术职务：</span><span class="right"><asp:TextBox ID="txtPost" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left" style="width: 120px;">主讲课程:</span><span class="right">1<asp:TextBox ID="txtCourseOne" runat="server" CssClass="txt course"></asp:TextBox></span>
                                <span class="left"></span><span class="right" style="margin-left: 116px;">2<asp:TextBox ID="txtCourseTwo" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left" style="width: 120px;"></span><span class="right">3<asp:TextBox ID="txtCoursethree" runat="server" CssClass="txt course"></asp:TextBox></span>
                                <span class="left"></span><span class="right" style="margin-left: 116px;">4<asp:TextBox ID="txtCourseFour" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">最高学历学位：</span><span class="right"><asp:TextBox ID="txtHighBackground" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">毕业学校：</span><span class="right"><asp:TextBox ID="txtFinishSchool" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">联系电话：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">E-mail：</span><span class="right"><asp:TextBox ID="txtMail" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left" style="display: block; margin-top: 6px;">个人简介：</span>
                                <textarea rows="5" cols="80" style="margin-left: 156px;" id="txtCurriculumVitae" runat="server"></textarea>
                            </div>
                        </div>
                    </fieldset>
                    <asp:PlaceHolder runat="server">
                        <div style="padding-left: 590px; margin-top: 20px">
                            <asp:Button runat="server" Text="确认提交" CssClass="button" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" ID="resetButton" />&nbsp;
                            <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
                        </div>
                    </asp:PlaceHolder>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
