﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frame.aspx.cs" Inherits="Teaching.Pages.frameTop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/power.css" />
    <link type="text/css" rel="stylesheet" href="~/Content/css/global.css" />

    <title>系统框架</title>
    <style type="text/css">
    </style>
    <script type="text/javascript">
        $(document).mousemove(function () {
            $("li").text()
        })
    </script>
</head>
<body style="background-color:#6989B7">
    <div style="width: 1200px; height: 620px; background-color: white; margin: -17px 0px -17px 75px;">
        <div id="top">
            <img src='<%=ResolveUrl("/Content/Images/teach_logo.jpg") %>' style="width: 1190px; height: 170px; margin: -4px 5px;" />
        </div>
        <div class="js user">
            <script type="text/javascript">
                var enabled = 0; today = new Date();
                var day; var date;
                if (today.getDay() == 0) day = "星期日"
                if (today.getDay() == 1) day = "星期一"
                if (today.getDay() == 2) day = "星期二"
                if (today.getDay() == 3) day = "星期三"
                if (today.getDay() == 4) day = "星期四"
                if (today.getDay() == 5) day = "星期五"
                if (today.getDay() == 6) day = "星期六"
                date = (today.getFullYear()) + "年" + (today.getMonth() + 1) + "月" + today.getDate() + "日 " + day;
                document.write("今天是&nbsp;" + date + "&nbsp;&nbsp;&nbsp;");
            </script>
            当前用户：张三&nbsp;&nbsp;&nbsp;<a href='<%=ResolveUrl("Login.aspx") %>'><input type="button" id="btnLogout" value="注销" class="logout" /></a>
            <a href='<%=ResolveUrl("Power/PassWordUpdate.aspx") %>' target="_right">
                <input type="button" id="btnpassword" value="修改密码" class="logout" /></a>
        </div>
        <%-- <div id="nav">
                    <ul>
                        <li>人员信息管理</li>
                        <li>教学文件管理</li>
                        <li>课程调度编排</li>
                        <li>学生成绩管理</li>
                        <li>实践教学管理</li>
                        <li>日常公文管理</li>
                        <li>教官规章制度</li>
                        <li>系统设置维护</li>
                    </ul>
                </div>--%>
        <div id="content">
            <div id="left">
                <div>
                    <ul id="menu">
                        <li>
                            <dl class="gallery">
                                <dt><a>人员信息维护</a></dt>
                                <dd><a href="BasicInfo/TeacherInfoMaintenance.aspx" title="教工信息维护" target="_right">教工信息维护</a></dd>
                                <dd><a href="BasicInfo/TeacherInfoSearch.aspx" title="教工信息查询" target="_right">教工信息查询</a></dd>
                                <dd><a href="BasicInfo/StudentInfoMaintenance.aspx" title="学生信息维护" target="_right">学生信息维护</a></dd>
                                <dd><a href="BasicInfo/StudentInfoSearch.aspx" title="学生信息查询" target="_right">学生信息查询</a></dd>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx" target="_right">教学文件管理</a></dt>
                                <dd><a href="help0201.aspx" title="人才培养方案" target="_right">人才培养方案</a></dd>
                                <dd><a href="help0202.aspx" title="教学大纲" target="_right">教学大纲</a></dd>
                                <dd><a href="help0203.aspx" title="考核大纲" target="_right">考核大纲</a></dd>
                                <dd><a href="help020103.aspx" title="实验大纲" target="_right">实验大纲</a></dd>
                                <dd><a href="help0204.aspx" title="教学日历" target="_right">教学日历</a></dd>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">课程调度编排</a></dt>
                                <dd><a href="help0301.aspx" title="教学设备管理总述操作方法">教学设备管理总述</a></dd>
                                <dd><a href="help0302.aspx" title="设置报废状态操作方法">设置报废状态</a></dd>
                                <dd><a href="help0303.aspx" title="新增设备记录操作方法">新增设备记录</a></dd>
                                <dd><a href="help0304.aspx" title="更改所属部门操作方法">更改所属部门</a></dd>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">学生成绩管理</a></dt>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">实践教学管理</a></dt>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">日常公文管理</a></dt>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">教管规章制度</a></dt>
                            </dl>
                        </li>
                        <li>
                            <dl class="gallery">
                                <dt><a href="main.aspx">系统维护设置</a></dt>
                                <dd><a href="Power/RoleList.aspx" title="角色维护" target="_right">权限维护</a></dd>
                                <dd><a href="help0302.aspx" title="学期维护" target="_right">学期维护</a></dd>
                                <dd><a href="help0303.aspx" title="数据备份" target="_right">数据备份</a></dd>
                                <dd><a href="Power/DataList.aspx" title="数据字典" target="_right">数据字典</a></dd>
                            </dl>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <iframe id="right" name="_right"></iframe>

        <div class="footer">
            <br />
            版权所有：哈尔滨学院软件学院　　地址： 哈尔滨市南岗区中兴大道109号<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;邮编： 150086　　哈公网监备： 230100101	
        </div>
    </div>
</body>
</html>
