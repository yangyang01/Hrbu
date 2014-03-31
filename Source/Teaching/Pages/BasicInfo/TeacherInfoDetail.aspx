<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInfoDetail.aspx.cs" Inherits="Teaching.Pages.BasicInfo.TeacherInfoDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>教师信息详情</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/basicInfo.css" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <style type="text/css">
        .info {
            margin-top: 110px;
        }

        .ddl {
            width: 155px;
            height: 34px;
        }
    </style>
    <%--<script type="text/javascript">
        $(function () {
            $("button:#resetButton").bind("click", function (e) {
                $(this).find('input:text').val('');
            });
        })
    </script>--%>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $('#btnSubmit').click(function () {
                var flag = $('#txtEmpNo').val() && $('#txtsex').val() && $('#ddlPATP').val && $('#ddlCollage').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvTearchNo').css('display', $('#txtEmpNo').val() ? "none" : "");
                        $('#rfvSex').css('display', $('#txtsex').val() ? "none" : "");
                        $('#rfvPATP').css('display', $('#ddlPATP').val() ? "none" : "");
                        $('#rfvCollage').css('display', $('#ddlCollage').val() ? "none" : "");
                    }
                    return !!flag;
                }
            })
        });
    </script>
    <form id="form1" runat="server">
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
                                <span class="left">*工号：</span> <span class="right">
                                    <asp:TextBox ID="txtEmpNo" runat="server" CssClass="txt" Style="margin-left: -11px;"></asp:TextBox></span>
                                <span class="left a">专业技术职务：</span><span class="right"><asp:DropDownList ID="ddlPATP" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                            </div>

                            <div>
                                <span class="left">*性别：</span><span class="right"><asp:TextBox ID="txtsex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">毕业学校：</span><span class="right"><asp:TextBox ID="txtFinishSchool" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">*学院：</span><span class="right"><asp:DropDownList ID="ddlCollage" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                <span class="left a">专业：</span><span class="right"><asp:DropDownList ID="ddlMajor" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                            </div>
                            <div>
                                <span class="left" style="width: 120px;">主讲课程:</span><span class="right">1<asp:DropDownList ID="ddlCourse1" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                <span class="left"></span><span class="right" style="margin-left: 116px;">2<asp:DropDownList ID="ddlCourse2" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                            </div>
                            <div>
                                <span class="left" style="width: 120px;"></span><span class="right">3<asp:DropDownList ID="ddlCourse3" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                <span class="left"></span><span class="right" style="margin-left: 116px;">4<asp:DropDownList ID="ddlCourse4" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                            </div>
                            <div>
                                <span class="left">最高学历学位：</span><span class="right"><asp:TextBox ID="txtHighBackground" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">E-mail：</span><span class="right"><asp:TextBox ID="txtMail" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">联系电话：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left" style="display: block; margin-top: 6px;">个人简介：</span>
                                <textarea rows="5" cols="80" style="margin-left: 156px;border-radius: 5px" id="txtCurriculumVitae" runat="server"></textarea>
                            </div>
                        </div>
                    </fieldset>
                    <asp:PlaceHolder runat="server">
                        <div style="padding-left: 590px; margin-top: 20px">
                            <asp:Button runat="server" ID="btnSubmit" Text="确认提交" CssClass="button" OnClick="ClickbtnSubmit" Visible="false" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" ID="btnReset" Visible="false" />&nbsp;
                            <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
                        </div>
                    </asp:PlaceHolder>
                    <div style="margin-left: -100px;">
                        <span id="rfvTearchNo" class="errorTip" style="display: none; color: red;">请输入学号！</span><br />
                        <span id="rfvPATP" class="errorTip" style="display: none; color: red;">请选择专业技术职务！</span><br />
                        <span id="rfvSex" class="errorTip" style="display: none; color: red;">请输入性别！</span><br />
                        <span id="rfvCollage" class="errorTip" style="display: none; color: red;">请选择学院！</span>
                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
