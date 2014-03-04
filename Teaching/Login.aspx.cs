using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teachings.Utility;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.BusinessView.Model.Power;
using StructureMap;
using Hrbu.Teaching.WebUI;
using System.Web.Security;

namespace Teaching
{
    public partial class Login : BasePage
    {
        public ILogin login { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Button(object sender, EventArgs e)
        {
            LoginCheck(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtVeriCode.Text.Trim());
        }
        /// <summary>
        /// 验证用户名和密码是否正确
        /// </summary>
        private void LoginCheck(string No, string Pass, string verifyCode)
        {
            // 用户名，密码,类型,验证码错误
            if (!string.IsNullOrWhiteSpace(No) && !string.IsNullOrWhiteSpace(Pass) && !string.IsNullOrWhiteSpace(verifyCode))
            {
                var userInfo = login.GetUserByNoAndPass(No, Pass);
                if (!userInfo)
                {
                    ShowLoginMeg("用户名或密码错误！");
                    return;
                }
                var typeInfo = login.GetRoleByNo(No);
                if (!typeInfo)
                {
                    ShowLoginMeg("该用户与用户类型不相符！");
                    return;
                }
                var userinfo = login.GetUserInfoById(1);

                var serverVerifyCode = Session["VerifyCode"].NullToString();
                if (!verifyCode.EqualsOrdinalIgnoreCase(serverVerifyCode))
                {
                    ShowLoginMeg("验证码输入错误！");
                    return;
                }
                //用户名，密码，类型，验证码正确
                if (userInfo && typeInfo && verifyCode.EqualsOrdinalIgnoreCase(serverVerifyCode))
                {
                    //记录用户信息 生成票据

                    var user = login.GetUserInfoByNo(No);
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(user.UserNo, false, 2000);
                    string formCookieValue = FormsAuthentication.Encrypt(ticket);
                    HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, formCookieValue);
                    httpCookie.HttpOnly = true;
                    HttpContext.Current.Response.Cookies.Add(httpCookie);

                    Response.Redirect("Pages/frame.aspx");
                }
            }

        }

        private void ShowLoginMeg(string loginMeg)
        {
            this.lblLoginMeg.Visible = true;
            this.lblLoginMeg.Text = loginMeg;
        }
    }
}