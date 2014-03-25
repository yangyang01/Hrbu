<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTrainCourseInfo.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AddTrainCourseInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/basicInfo.css" rel="stylesheet" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../../Content/js/Utility.js"></script>
    <title></title>

    <style>
        .ddl {
            width: 152px;
            height: 26px;
        }

        .i {
            font-size: 13px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $('#btnSubmit').click(function () {
                var flag = $('#ddlSemester').val() && $('#ddlGrade').val() && $('#txtCourseCode').val && $('#ddlMarjor').val && $('#txtSem').val() && $('#ddlEvaluation').val && $('#txtTeachPeriod').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvYear').css('display', $('#ddlYear').val() ? "none" : "");
                        $('#rfvSemester').css('display', $('#ddlSemester').val() ? "none" : "");
                        $('#rfvGrade').css('display', $('#ddlGrade').val() ? "none" : "");
                        $('#rfvCourseCode').css('display', $('#txtCourseCode').val() ? "none" : "");
                        $('#rfvMarjor').css('display', $('#ddlMarjor').val() ? "none" : "");
                        $('#rfvEvaluation').css('display', $('#ddlEvaluation').val() ? "none" : "");
                        $('#rfvTeachPeriod').css('display', $('#txtTeachPeriod').val() ? "none" : "");
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
                        <legend>人才培养方案课程添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">学年：</span> <span class="right">
                                    <asp:DropDownList ID="ddlYear" runat="server" CssClass="txt ddl" Style="margin-left: -10px;"></asp:DropDownList></span>
                                <span class="left a">年级：</span><span class="right" style="margin-left: 17px;">
                                    <asp:DropDownList ID="ddlGrade" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                <div>
                                    <span class="left">课程编码：</span> <span class="right">
                                        <asp:TextBox ID="txtCourseCode" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                    <span class="left a">专业方向：</span><span class="right">
                                        <asp:DropDownList ID="ddlMarjor" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                </div>
                                <div>
                                    <span class="left">开课学期：</span><span class="right">
                                        <asp:DropDownList ID="ddlSemester" runat="server" CssClass="txt ddl" Style="margin-left: -6px;"></asp:DropDownList></span>
                                    <span class="left a">考核方式：</span><span class="right">
                                        <asp:DropDownList runat="server" ID="ddlEvaluation" CssClass="txt ddl"></asp:DropDownList></span>
                                </div>
                                <div>
                                    <span class="left">实验学时：</span><span class="right"><asp:TextBox ID="txtTestPeriod" runat="server" CssClass="txt"></asp:TextBox></span>
                                    <span class="left a">授课学时：</span><span class="right" style="margin-left:22px"><asp:TextBox ID="txtTeachPeriod" runat="server" CssClass="txt"></asp:TextBox></span>
                                </div>
                                <div>
                                    <span class="left">实践周数：</span><span class="right"><asp:TextBox ID="txtPracticeWeeks" runat="server" CssClass="txt"></asp:TextBox></span>
                                </div>
                                <div>
                                    <span style="margin-left: 102px;">备注：<textarea id="txtaRemark" rows="5" cols="80" runat="server"></textarea></span>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                    <div style="padding-left: 590px; margin-top: 20px">
                        <asp:Button runat="server" ID="btnSubmit" Text="确认提交" CssClass="button" OnClick="ClickbtnSubmit" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
                    </div>
                    <div style="margin-left: -100px;">
                        <span id="rfvYear" class="errorTip i" style="display: none; color: red;">请选择学年！</span><br />
                        <span id="rfvSemester" class="errorTip i" style="display: none; color: red;">请选择开课学期！</span><br />
                        <span id="rfvGrade" class="errorTip i" style="display: none; color: red;">请选择年级！</span><br />
                        <span id="rfvCourseCode" class="errorTip i" style="display: none; color: red;">请输入课程编码！</span><br />
                        <span id="rfvMarjor" class="errorTip i" style="display: none; color: red;">请选择专业方向！</span><br />
                        <span id="rfvEvaluation" class="errorTip i" style="display: none; color: red;">请选择考核方式！</span><br />
                        <span id="rfvTeachPeriod" class="errorTip i" style="display: none; color: red;">请输入授课学时！</span>
                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
