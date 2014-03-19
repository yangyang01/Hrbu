<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoDetail.aspx.cs" Inherits="Teaching.Pages.BasicInfo.StudentInfoDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生详细信息</title>
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/basicInfo.css" />
    <style type="text/css">
        .info {
            margin-top: 110px;
        }

        .ddl {
            width: 155px;
            height: 26px;
        }
    </style>
</head>
<body style="background-color: #FAFBFC;">
    <form id="form1" runat="server" target="_right">
        <div>
            <ul style="display: inline-block; list-style-type: none; margin-left: 100px">
                <li class="title">
                    <%-- 专业、班级、学号、姓名、性别、联系电话、E-mail、家庭通信地址、邮政编码、联系人（父母之一）、联系人电话等。 --%>
                    <fieldset>
                        <legend>学生基本信息</legend>
                        <div class="left">
                            <span class="person_pic">
                                <asp:Image class="personal_img" ID="imgPhote" runat="server" onerror="this.src='/Content/Images/personal.jpg'" />
                            </span>
                            <span style="margin-left: 200px">
                                <asp:FileUpload ID="FileUpload1" runat="server" /></span>
                        </div>
                        <div class="info">
                            <div>
                                <span class="left">学号：</span> <span class="right">
                                    <asp:TextBox ID="txtStuNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">姓名：</span><span class="right"><asp:TextBox ID="txtStuName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">性别：</span><span class="right"><asp:TextBox ID="txtSex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">联系电话：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">专业：</span><span class="right"><asp:DropDownList ID="ddlMajor" runat="server" CssClass="txt ddl"></asp:DropDownList></span>
                                <span class="left a">班级：</span><span class="right"><asp:TextBox ID="txtClass" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">邮政编码</span><span class="right"><asp:TextBox ID="txtZipCode" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">家庭通讯地址：</span><span class="right"><asp:TextBox ID="txtAddress" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">联系人：</span><span class="right"><asp:TextBox ID="txtContacts" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">联系人电话：</span><span class="right"><asp:TextBox ID="txtContTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">E-mail：</span><span class="right"><asp:TextBox ID="txtMail" runat="server" CssClass="txt"></asp:TextBox></span>

                            </div>
                        </div>
                    </fieldset>
                    <div style="padding-left: 590px; margin-top: 20px">
                        <asp:Button runat="server" ID="btnSubmit" Text="确认提交" CssClass="button" OnClick="ClickbtnSubmit" Visible="false" />&nbsp;
                         <asp:Button runat="server" ID="btnReset" Text="清除重置" CssClass="button" Visible="false" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />

                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
