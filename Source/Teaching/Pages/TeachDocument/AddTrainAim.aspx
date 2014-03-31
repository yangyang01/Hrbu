<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTrainAim.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AddTrainAim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/basicInfo.css" rel="stylesheet" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>
    <title></title>
    <style type="text/css">
        .txtarea_td {
            width: 585px;
        }

        table {
            width: 960px;
        }

        .ddl {
            width: 90px;
            height: 26px;
        }

        .search_bn {
            margin: -1px 5px 0px 5px;
        }

        .i {
            font-size: 13px;
        }

        td {
            font-size: 14px;
            color: black;
        }
        .r {
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $('#btnSubmit').click(function () {
                var flag = $('#ddlSemester').val() && $('#ddlGrade').val() && $('#txtaAim').val && $('#txtaRequirements').val
                    && $('#txtaLearningDegree').val() && $('#txtaPlatform').val && $('#txtaProfessional').val && $('#txtaPractical').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvYear').css('display', $('#ddlYear').val() ? "none" : "");
                        $('#rfvSemester').css('display', $('#ddlSemester').val() ? "none" : "");
                        $('#rfvGrade').css('display', $('#ddlGrade').val() ? "none" : "");
                        $('#rfvAim').css('display', $('#txtaAim').val() ? "none" : "");
                        $('#rfvRequirements').css('display', $('#txtaRequirements').val() ? "none" : "");
                        $('#rfvLearningDegree').css('display', $('#txtaLearningDegree').val() ? "none" : "");
                        $('#rfvPlatform').css('display', $('#txtaPlatform').val() ? "none" : "");
                        $('#rfvProfessional').css('display', $('#txtaProfessional').val() ? "none" : "");
                        $('#rfvPractical').css('display', $('#txtaPractical').val() ? "none" : "");
                    }
                    return !!flag;
                }
            })
        });
    </script>
    <form id="form1" runat="server">
        <div style="margin-left:-60px">
            <ul style="display: inline-block; list-style-type: none; margin-left: 100px">
                <li class="title">
                    <fieldset>
                        <legend>人才培养方案目标添加</legend>
                        <span style="margin-left: 8px;">学年：<asp:DropDownList runat="server" ID="ddlYear" CssClass="txt ddl"></asp:DropDownList>&nbsp;
                学期：<asp:DropDownList runat="server" ID="ddlSemester" CssClass="txt ddl"></asp:DropDownList>&nbsp;
                年级：<asp:DropDownList ID="ddlGrade" runat="server" CssClass="txt ddl"></asp:DropDownList>
                        </span>
                        <table>
                            <tr>
                                <td class="tit" colspan="2" style="width: 100px">培养目标</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaAim" rows="3" cols="70" runat="server" class="r"></textarea></td>
                            </tr>
                            <tr>
                                <td class="tit" colspan="2">规格要求</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaRequirements" rows="3" cols="70" runat="server" class="r"></textarea></td>
                            </tr>
                            <tr>
                                <td class="tit" colspan="2">学制学位</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaLearningDegree" rows="3" cols="70" runat="server" class="r"></textarea></td>
                            </tr>
                            <tr>
                                <td rowspan="3" style="width: 100px">课程体系<br />
                                    与设置</td>
                                <td class="tit" style="width: 100px">通识教育<br />
                                    课程平台</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaPlatform" rows="3" cols="70" runat="server" class="r"></textarea ></td>
                            </tr>
                            <tr>
                                <td class="tit">学科专业<br />
                                    课程平台</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaProfessional" rows="3" cols="70" runat="server" class="r"></textarea></td>
                            </tr>
                            <tr>
                                <td class="tit">实践<br />
                                    课程平台</td>
                                <td class="txtarea_td">
                                    <textarea id="txtaPractical" rows="3" cols="70" runat="server" class="r"></textarea></td>
                            </tr>
                        </table>
                    </fieldset>
                </li>
            </ul>
            <div style="padding-left: 800px; margin-top: 20px">
                <asp:Button runat="server" ID="btnSubmit" Text="确认提交" CssClass="button" OnClick="ClickbtnSubmit" />
                <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />
            </div>
            <div style="margin-left: 20px;">
                <span id="rfvYear" class="errorTip i" style="display: none; color: red;">请选择学年！</span><br />
                <span id="rfvSemester" class="errorTip i" style="display: none; color: red;">请选择学期！</span><br />
                <span id="rfvGrade" class="errorTip i" style="display: none; color: red;">请选择年级！</span><br />
                <span id="rfvAim" class="errorTip i" style="display: none; color: red;">请输入培养目标！</span><br />
                <span id="rfvRequirements" class="errorTip i" style="display: none; color: red;">请输入规格要求！</span><br />
                <span id="rfvLearningDegree" class="errorTip i" style="display: none; color: red;">请输入学制学位！</span><br />
                <span id="rfvPlatform" class="errorTip i" style="display: none; color: red;">请输入通识教育课程平台！</span><br />
                <span id="rfvProfessional" class="errorTip i" style="display: none; color: red;">请输入学科专业课程平台！</span><br />
                <span id="rfvPractical" class="errorTip i" style="display: none; color: red;">请输入实践课程平台！</span>
            </div>
        </div>
    </form>
</body>
</html>
